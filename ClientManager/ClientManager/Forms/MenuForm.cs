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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.GraphicInitialize(); 
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
            using(ApiService apiService = new ApiService())
            {
                var logoutResult = apiService.postEntity<LoginModel>(EnpointUrl.LogoutEnpoint + StaticModels.ClientId,
                    new LoginModel()
                    {
                        Password = "",
                        Username = StaticModels.CurrentAccount.AccountName
                    });
                if(logoutResult != null)
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
                    MessageBox.Show("Mất kết nối đến máy chủ");
                }
            }
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
    }
}
