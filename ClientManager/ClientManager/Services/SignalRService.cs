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
               StaticModels.HubConnection = new HubConnectionBuilder().WithUrl(EnpointUrl.ClientHubEndpoint, option => {
                    option.Headers.Add("Client-Id", StaticModels.ClientId.ToString());
                    option.Headers.Add("User-Id", StaticModels.CurrentAccount.Id.ToString());
               }).WithAutomaticReconnect().Build();

               // Đăng kí nhận tin nhắn của server.
               StaticModels.HubConnection.On<string>("serverReply", ServerReply);
               StaticModels.HubConnection.StartAsync();
        }


        // XỬ lý tin nhắn từ server
        public static Action<string> ServerReply = (string mess) => {
            if (!StaticModels.ChatForm.Visible)
            {
                StaticModels.ChatForm.Invoke((Action)(() => {
                    StaticModels.ChatForm.Show();
                    ListViewItem item = new ListViewItem("[Admin]: " + mess);
                    StaticModels.ChatForm.lstChatLine.Items.Add(item);
                }));
            }
            else
            {
                StaticModels.ChatForm.Invoke((Action)(() => {
                    ListViewItem item = new ListViewItem("[Admin]: " + mess);
                    StaticModels.ChatForm.lstChatLine.Items.Add(item);
                }));
            }
        };
    }
}
