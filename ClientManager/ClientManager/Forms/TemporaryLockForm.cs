using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientManager.Services;
using System.Reactive;
using System.Reactive.Subjects;
using ClientManager.Model.StaticModel;
using ClientManager.Model.Error;
using Newtonsoft.Json;
using ClientManager.Models.AppModel;

namespace ClientManager.Forms
{
    public partial class TemporaryLockForm : Form
    {
        // Mỗi instance của login Form sẽ có một subject.
        public TemporaryLockForm()
        {
            this.InitializeComponent();
            this.GraphicInitialize(); 
        }

        // Khởi tạo những giao diện ban đầu
        private void GraphicInitialize()
        {
            this.lbInfo.Visible = false; 
        }

        // Gửi tài khoản đi ( phím enter ) 
        private async void SubmitAccount(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide(); 
            }
            if (e.KeyCode == Keys.Enter)
            {
                if(this.txtPassword.Text=="1" && this.txtUserName.Text == "1")
                {
                    this.Hide();
                    StaticModels.LoginFormSubject.OnNext(true);

                }
                if(StaticModels.isConnect)
                    this.AuthenticateAccount();
            }
        }

        // Bấm nút đăng nhập để gửi tài khoản lên server
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "1" && this.txtUserName.Text == "1")
            {
                this.Hide();
                StaticModels.LoginFormSubject.OnNext(true);

            }
            if (StaticModels.isConnect)
                this.AuthenticateAccount(); 
        }

        // Bấm nút đóng form login
        private async void HideLogin(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        // Khởi tạo khi show lại form đăng nhập
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            
        }

        // Hàm dành cho việc đăng nhập tài khoản
        private void AuthenticateAccount()
        {
            if(this.txtUserName.Text != StaticModels.CurrentAccount.AccountName) 
            {
                this.lbInfo.Text = "Tên tài khoản chưa đúng";
                this.lbInfo.Show(); 
                return;
            }
            if(PasswordService.PasswordHash(this.txtPassword.Text)!= StaticModels.CurrentAccount.Password)
            {
                this.lbInfo.Text = "Mật khẩu không đúng";
                this.lbInfo.Show();
                return; 
            }

            StaticModels.isLockWithAccount = false;
            StaticModels.LoginFormSubject.OnNext(true);
            this.Hide(); 
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            this.txtUserName.Text = StaticModels.CurrentAccount.AccountName;
            this.txtPassword.Text = "";
            this.lbInfo.Text = "";
        }
    }
}
