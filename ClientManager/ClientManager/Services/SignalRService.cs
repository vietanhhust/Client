using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System.Configuration;
using ClientManager.Model.StaticModel;
using System.Windows.Forms;
using System.Threading;

namespace ClientManager.Services
{
    class SignalRService
    {
        // Nên gọi sau khi StaticInitializeService.cs
        static public void CreateHubConnection()
        {
            StaticModels.HubConnection = null;
            StaticModels.HubConnection = new HubConnectionBuilder().WithUrl(EnpointUrl.ClientHubEndpoint, option =>
            {
                option.Headers.Add("Client-Id", StaticModels.ClientId.ToString());
                option.Headers.Add("User-Id", StaticModels.CurrentAccount.Id.ToString());
            }).WithAutomaticReconnect().Build();

            // Đăng kí nhận tin nhắn của server.
            StaticModels.HubConnection.On<string>("serverReply", ServerReply);


            // Nhập sự kiện thay đổi categoryItem của server
            StaticModels.HubConnection.On("categoryChange", () => {
                if (StaticModels.CategoryOrderForm.Visible)
                {
                    StaticInitializeService.GetCategoryAndItem();
                    StaticModels.CategoryOrderForm.Invoke((Action)(() => {
                        StaticModels.CategoryOrderForm.Hide(); 
                    }));
                }
            });

            // Nhận tín hiệu nạp hoặc trừ tiền của tài khoản từ server, nhận số tiền mới, tính lại thời gian. 
            StaticModels.HubConnection.On<int>("balanceChange", (int newBalance) =>
            {
                // Số tiền mới.
                StaticModels.CurrentAccount.Balance = newBalance;
                StaticModels.TotalTime = (float)newBalance / (float)StaticModels.GroupClient.Price * 60f; 
                // Tính lại thời gian. 
                StaticModels.MenuForm.Invoke((Action)(() => {
                    StaticModels.MenuForm.txtTotalTime.Text = StaticInitializeService.MinuteToDate(StaticModels.TotalTime);
                    StaticModels.MenuForm.txtElapsedTime.Text = StaticInitializeService.MinuteToDate(StaticModels.ElapsedTime);
                    var used = StaticModels.TotalTime - StaticModels.ElapsedTime;
                    StaticModels.MenuForm.txtRemainTime.Text = StaticInitializeService.MinuteToDate(used);
                }));
            });

            StaticModels.HubConnection.StartAsync();
        }


        // XỬ lý tin nhắn từ server
        public static Action<string> ServerReply = (string mess) =>
        {
            if (!StaticModels.ChatForm.Visible)
            {
                StaticModels.ChatForm.Invoke((Action)(() =>
                {
                    StaticModels.ChatForm.Show();
                    ListViewItem item = new ListViewItem("[Admin]: " + mess);
                    StaticModels.ChatForm.lstChatLine.Items.Add(item);
                }));
            }
            else
            {
                StaticModels.ChatForm.Invoke((Action)(() =>
                {
                    ListViewItem item = new ListViewItem("[Admin]: " + mess);
                    StaticModels.ChatForm.lstChatLine.Items.Add(item);
                }));
            }
        };

        // Xử lý nạp tiền. 

        public static Action<float> ServerAddBalace = (float balance) =>
        {
            StaticModels.TotalTime += balance;
            StaticModels.MenuForm.txtTotalTime.Text = StaticInitializeService.MinuteToDate(StaticModels.TotalTime);
            var remain = StaticModels.TotalTime - StaticModels.ElapsedTime;
        };
    }
}
