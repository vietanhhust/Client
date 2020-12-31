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

namespace ClientManager.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        
        private async void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }

        // Reset lại form
        private void ChangePasswordForm_VisibleChanged(object sender, EventArgs e)
        {
            this.txtOldPass.Text = "";
            this.txtNewPass.Text = "";
            this.txtComfirmPass.Text = "";
            this.lbChangePassInfo.ForeColor = Color.Red;
            this.lbChangePassInfo.Hide(); 
        }

        // Bấm nút đổi mật khẩu
        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            this.PasswordValidate(); 
        }

        // Phím tắt Enter
        private void EnterToSubmit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.PasswordValidate(); 
            }
        }

        // Validate Password
        private bool PasswordValidate()
        {
            // Kiểm tra mật khẩu cũ có giống không
            if (PasswordService.PasswordHash(this.txtOldPass.Text)
                != StaticModels.CurrentAccount.Password)
            {
                this.lbChangePassInfo.Text = "Nhập mật khẩu cũng không đúng";
                this.lbChangePassInfo.Show();
                return false;
            }

            // Kiểm tra mật khẩu mới có đúng không
            if (!PasswordService.PasswordCheck(this.txtComfirmPass.Text, this.txtNewPass.Text))
            {
                this.lbChangePassInfo.Text = "Mật khẩu mới không giống mật khẩu cũ";
                this.lbChangePassInfo.Show();
                return false;
            }

            // Nếu qua được thì đổi mật khẩu, và đăng xuất. 
            using (ApiService apiService = new ApiService())
            {
                var changePasswordResult = apiService.putEntity<LoginModel>(EnpointUrl.ChangePasswordEndpoint
                    + StaticModels.CurrentAccount.Id, new LoginModel()
                    {
                        Username = StaticModels.CurrentAccount.AccountName,
                        Password = this.txtComfirmPass.Text
                    });
                if (changePasswordResult != null)
                {
                    if (changePasswordResult.IsSuccessStatusCode)
                    {
                        StaticModels.CurrentAccount.Password = PasswordService.PasswordHash(this.txtNewPass.Text);
                        this.lbChangePassInfo.Text = "Đổi mật khẩu thành công";
                        this.lbChangePassInfo.ForeColor = Color.Green;
                        this.lbChangePassInfo.Show();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    this.lbChangePassInfo.Text = "Lỗi kết nối";
                    return false;
                }
            }
        }

        private void TxtOldPass_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
