using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reactive;
using ClientManager.Model.StaticModel;
using ClientManager.Services;
using Newtonsoft.Json;

namespace ClientManager.Forms
{
    public partial class LockForm : Form
    {
        
        public LockForm()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.InitializeComponent();
            this.GraphicInitialize();
            StaticModels.LoginFormSubject.Subscribe(data =>
            {
                Console.WriteLine("Subject subscribe");
                this.AfterLogin(); 
            });
            // Phần code tiếp theo của hàm này sẽ implement tính giờ để tự động tắt
        }
        
        // Khởi tạo hiển thị ban đầu 
        private void GraphicInitialize()
        {
            this.TopMost = true;
            this.lbClientId.Text = "Máy " + StaticModels.ClientId;
            this.lbDisconnect.Hide(); 
        }

        // Khi click hoặc chạm màn hình 
        private void showLoginForm(object sender, EventArgs e)
        {
            this.ShowLoginForm();    
        }

        // Bấm phím bất kì khi focus form lock thì hiện ra form đăng nhập
        private void LockForm_KeyUp(object sender, KeyEventArgs e)
        {
            this.ShowLoginForm(); 
        }

        // Show Login form 
        // Nếu là Trạng thái khóa tạm máy trạm thì 
        private void ShowLoginForm()
        {
            StaticModels.LoginForm.lbInfo.Hide(); 
            if (!StaticModels.isLockWithAccount)
            {
                if (StaticModels.LoginForm.Visible)
                {
                    StaticModels.LoginForm.Invoke((Action)(() => {
                        StaticModels.LoginForm.TopLevel = true;
                        StaticModels.LoginForm.TopMost = true;
                    }), null);
                    return;
                }
                else
                {
                    StaticModels.LoginForm.txtPassword.Text = "";
                    StaticModels.LoginForm.txtUserName.Text = "";
                    StaticModels.LoginForm.TopLevel = true;
                    StaticModels.LoginForm.TopMost = true;
                    StaticModels.LoginForm.Show(); 
                }
            }
            else
            {
                if (StaticModels.TemporaryLockForm.Visible)
                {
                    StaticModels.TemporaryLockForm.TopLevel = true;
                    StaticModels.TemporaryLockForm.TopMost = true;
                    return;
                }
                else
                {
                    StaticModels.TemporaryLockForm.Show();
                    StaticModels.TemporaryLockForm.TopLevel = true;
                    StaticModels.TemporaryLockForm.TopMost = true;
                    return;
                }
            }
        }

        private void LockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; 
        }

        private void LockForm_DoubleClick(object sender, EventArgs e)
        {
            this.ShowLoginForm(); 
        }

        // Sau khi nhận được tín hiệu Login thành công. 
        private void AfterLogin()
        {
            this.lbDisconnect.Hide();
            StaticModels.MenuForm.Show();
            float totalMinuteInitialize = ((float)StaticModels.CurrentAccount.Balance.Value / (float)StaticModels.GroupClient.Price) * (float)60;
            Invoke((Action)(() => {
                StaticModels.MenuForm.txtTotalTime.Text = StaticInitializeService.MinuteToDate(totalMinuteInitialize);
                StaticModels.MenuForm.txtElapsedTime.Text = "00:00";
                StaticModels.MenuForm.txtRemainTime.Text = StaticModels.MenuForm.txtTotalTime.Text;

                // Hiển thị tên và số máy. 
                StaticModels.MenuForm.lbClientId.Text = "Máy " + StaticModels.ClientId;
                StaticModels.MenuForm.lbAccountName.Text = StaticModels.CurrentAccount.AccountName;

            }), null);



            this.Hide();
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
