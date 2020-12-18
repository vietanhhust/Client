namespace ClientManager.Forms
{
    partial class ChangePasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbOldPass = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbComfirmPass = new System.Windows.Forms.Label();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtComfirmPass = new System.Windows.Forms.TextBox();
            this.lbChangePassInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOldPass
            // 
            this.lbOldPass.BackColor = System.Drawing.Color.Transparent;
            this.lbOldPass.Location = new System.Drawing.Point(16, 53);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(73, 23);
            this.lbOldPass.TabIndex = 0;
            this.lbOldPass.Text = "Mật khẩu cũ";
            // 
            // lbNewPass
            // 
            this.lbNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lbNewPass.Location = new System.Drawing.Point(16, 91);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(73, 23);
            this.lbNewPass.TabIndex = 1;
            this.lbNewPass.Text = "Mật khẩu mới";
            // 
            // lbComfirmPass
            // 
            this.lbComfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lbComfirmPass.Location = new System.Drawing.Point(16, 130);
            this.lbComfirmPass.Name = "lbComfirmPass";
            this.lbComfirmPass.Size = new System.Drawing.Size(73, 20);
            this.lbComfirmPass.TabIndex = 2;
            this.lbComfirmPass.Text = "Mật khẩu mới";
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTitle.Enabled = false;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTitle.Location = new System.Drawing.Point(-3, -1);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTitle.Size = new System.Drawing.Size(410, 36);
            this.btnTitle.TabIndex = 3;
            this.btnTitle.Text = "Đổi mật khẩu";
            this.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTitle.UseVisualStyleBackColor = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChangePass.Location = new System.Drawing.Point(190, 172);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(94, 34);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(295, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(109, 50);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(256, 20);
            this.txtOldPass.TabIndex = 6;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.TextChanged += new System.EventHandler(this.TxtOldPass_TextChanged);
            this.txtOldPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterToSubmit);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(109, 89);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(256, 20);
            this.txtNewPass.TabIndex = 7;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterToSubmit);
            // 
            // txtComfirmPass
            // 
            this.txtComfirmPass.Location = new System.Drawing.Point(109, 125);
            this.txtComfirmPass.Name = "txtComfirmPass";
            this.txtComfirmPass.Size = new System.Drawing.Size(256, 20);
            this.txtComfirmPass.TabIndex = 8;
            this.txtComfirmPass.UseSystemPasswordChar = true;
            this.txtComfirmPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EnterToSubmit);
            // 
            // lbChangePassInfo
            // 
            this.lbChangePassInfo.ForeColor = System.Drawing.Color.Red;
            this.lbChangePassInfo.Location = new System.Drawing.Point(108, 152);
            this.lbChangePassInfo.Name = "lbChangePassInfo";
            this.lbChangePassInfo.Size = new System.Drawing.Size(257, 13);
            this.lbChangePassInfo.TabIndex = 9;
            this.lbChangePassInfo.Text = "Tài khoản đăng nhập hoặc mật khẩu không đúng";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 222);
            this.Controls.Add(this.lbChangePassInfo);
            this.Controls.Add(this.txtComfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.lbComfirmPass);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.lbOldPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePasswordForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.ChangePasswordForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbOldPass;
        public System.Windows.Forms.Label lbNewPass;
        public System.Windows.Forms.Label lbComfirmPass;
        public System.Windows.Forms.Button btnTitle;
        public System.Windows.Forms.Button btnChangePass;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtOldPass;
        public System.Windows.Forms.TextBox txtNewPass;
        public System.Windows.Forms.TextBox txtComfirmPass;
        private System.Windows.Forms.Label lbChangePassInfo;
    }
}