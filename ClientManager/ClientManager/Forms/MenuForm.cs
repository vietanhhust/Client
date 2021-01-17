using ClientManager.Model.StaticModel;
using ClientManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.SignalR; 

namespace ClientManager.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            
            InitializeComponent();
            this.GraphicInitialize();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        // Khởi tạo hiển thị ban đầu. 
        private void GraphicInitialize()
        {
            this.StartPosition = FormStartPosition.Manual;
            Screen myScreen = Screen.FromControl(this);
            this.Location = new Point(myScreen.WorkingArea.Width - this.Width, 0);

            this.notifyIcon.ContextMenuStrip = new ContextMenuStrip(); 
           
            this.notifyIcon.ContextMenuStrip.Items.Add("Ẩn/Hiện", null, this.NotifiIconClick);
            this.notifyIcon.DoubleClick += MenuForm_Click;
        }

        private void MenuForm_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Visible = false;
            }
            else { this.Visible = true; }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //NotifiIcon click 
        private void NotifiIconClick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }

        // Logout mọi thứ. 
        private async void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Logout(); 
        }

        // hàm logout 
        private void Logout()
        {
            using (ApiService apiService = new ApiService())
            {
                var logoutResult = apiService.postEntity<LoginModel>(EnpointUrl.LogoutEnpoint + StaticModels.ClientId,
                    new LoginModel()
                    {
                        Password = "",
                        Username = StaticModels.CurrentAccount.AccountName
                    });
                if (logoutResult != null)
                {
                    this.Invoke((Action)(() =>
                    {
                        if (!StaticModels.LockForm.Visible)
                        {
                            StaticModels.LockForm.TopMost = true;
                            StaticModels.LockForm.lbDisconnect.Hide();
                            StaticModels.LockForm.Show();
                        }
                    }));
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Mất kết nối đến máy chủ");
                }
            }
            StaticModels.HubConnection.StopAsync();
        }
        
        // Đổi mật khẩu của tài khoản hiện thời. 
        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            if (!StaticModels.ChangePasswordForm.Visible)
            {
                StaticModels.ChangePasswordForm.Show();
            }
        }

        // Nút khóa máy, đổi trạng thái khóa với Tài khoản. 
        // StaticModels.isLockWithAccount = true, vì dùng chung với màn Lock Form nên cần trạng thái này để phân biệt login form
        private void BtnLockClient_Click(object sender, EventArgs e)
        {
            StaticModels.isLockWithAccount = true;
            StaticModels.LockForm.Show();
            StaticModels.TemporaryLockForm.Show();
            StaticModels.TemporaryLockForm.TopMost = true; 
            this.Hide();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        // Show form dịch vụ
        private void BtnOrderFood_Click(object sender, EventArgs e)
        {
            if (StaticModels.isConnect)
            {
                if (StaticModels.CategoryOrderForm.Visible)
                {
                    return;
                }
                else
                {
                    StaticModels.CategoryOrderForm.Show();
                }
            }
            else
            {
                return;
            }
        }

        // Nhắn tin
        private void BtnChat_Click(object sender, EventArgs e)
        {
            if (!StaticModels.ChatForm.Visible)
            {
                StaticModels.ChatForm.Show(); 
            }
        }

        private void TimerCount_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("trừ tiền");
            StaticModels.ElapsedTime += 1;
            Invoke((Action)(() =>
            {
                this.txtElapsedTime.Text = StaticInitializeService.MinuteToDate(StaticModels.ElapsedTime);
                var used = StaticModels.TotalTime - StaticModels.ElapsedTime;
                if(used < 0)
                {
                    this.timerCount.Enabled = false;
                    this.Logout(); 
                    this.Hide(); 
                }
                this.txtRemainTime.Text = StaticInitializeService.MinuteToDate(used);

                try
                {
                    if(StaticModels.HubConnection.State== HubConnectionState.Connected)
                    {
                        StaticModels.HubConnection.InvokeAsync("bill");
                    }
                    else
                    {
                    }
                }
                catch
                {
                    //Console.Write("Lỗi phát từ hàm đồng hồ");
                }
            }));

        }
    }
}
