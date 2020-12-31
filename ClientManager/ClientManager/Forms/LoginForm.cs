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
    public partial class LoginForm : Form
    {
        // Mỗi instance của login Form sẽ có một subject.
        public Subject<bool> subject = new Subject<bool>(); 
        public LoginForm()
        {
            this.InitializeComponent();
            this.GraphicInitialize();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        // Khởi tạo những giao diện ban đầu
        private void GraphicInitialize()
        {
            this.lbInfo.Visible = false; 
        }

        // Gửi tài khoản đi
        private async void SubmitAccount(object sender, KeyEventArgs e)
        {
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
            using (ApiService apiService = new ApiService())
            {
                var result = apiService.postEntity<LoginModel>(EnpointUrl.AccountLogin + "/" + StaticModels.ClientId, new LoginModel
                {
                    Password = this.txtPassword.Text,
                    Username = this.txtUserName.Text
                });

                if(result != null)
                {
                    if (result.IsSuccessStatusCode)
                    {
                        // Lưu người đăng nhập hiện tại
                        StaticModels.CurrentAccount =
                            JsonConvert.DeserializeObject<Account>(
                                result.Content.ReadAsStringAsync().Result);
                        StaticModels.isConnect = true; 

                        // Thông báo cho form ngoài là đăng nhập thành công. 
                        StaticModels.LoginFormSubject.OnNext(true);
                        this.Hide();
                    }
                    else
                    {
                        this.lbInfo.Text = StaticUtility.Convert<ErrorModel>(
                            result.Content.ReadAsStringAsync().Result).Messege;
                        this.lbInfo.Show();
                    }
                }
                else
                {
                    Invoke((Action)(() => {
                        StaticModels.isConnect = false;
                        StaticModels.LockForm.lbDisconnect.Show();
                    }));
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            this.txtPassword.Text = "";
            this.txtUserName.Text = "";
            this.lbInfo.Text = "";
        }
    }
}
