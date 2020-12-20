namespace ClientManager.Forms
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lbAccountName = new System.Windows.Forms.Label();
            this.lbClientId = new System.Windows.Forms.Label();
            this.lbTotalTime = new System.Windows.Forms.Label();
            this.lbelapsedTime = new System.Windows.Forms.Label();
            this.lbRemainTime = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.txtRemainTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChangePass = new System.Windows.Forms.Label();
            this.lbChat = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.btnLockClient = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAccountName
            // 
            this.lbAccountName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbAccountName.ForeColor = System.Drawing.Color.White;
            this.lbAccountName.Location = new System.Drawing.Point(-1, 0);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbAccountName.Size = new System.Drawing.Size(275, 34);
            this.lbAccountName.TabIndex = 0;
            this.lbAccountName.Text = "User: ";
            this.lbAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbClientId
            // 
            this.lbClientId.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbClientId.ForeColor = System.Drawing.Color.White;
            this.lbClientId.Location = new System.Drawing.Point(180, 6);
            this.lbClientId.Name = "lbClientId";
            this.lbClientId.Size = new System.Drawing.Size(54, 23);
            this.lbClientId.TabIndex = 1;
            this.lbClientId.Text = "Máy ";
            this.lbClientId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalTime
            // 
            this.lbTotalTime.Location = new System.Drawing.Point(13, 16);
            this.lbTotalTime.Name = "lbTotalTime";
            this.lbTotalTime.Size = new System.Drawing.Size(88, 23);
            this.lbTotalTime.TabIndex = 2;
            this.lbTotalTime.Text = "Tổng thời gian: ";
            this.lbTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbelapsedTime
            // 
            this.lbelapsedTime.Location = new System.Drawing.Point(12, 46);
            this.lbelapsedTime.Name = "lbelapsedTime";
            this.lbelapsedTime.Size = new System.Drawing.Size(104, 23);
            this.lbelapsedTime.TabIndex = 3;
            this.lbelapsedTime.Text = "Thời gian sử dụng: ";
            this.lbelapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRemainTime
            // 
            this.lbRemainTime.Location = new System.Drawing.Point(12, 80);
            this.lbRemainTime.Name = "lbRemainTime";
            this.lbRemainTime.Size = new System.Drawing.Size(88, 21);
            this.lbRemainTime.TabIndex = 4;
            this.lbRemainTime.Text = "Thời gian còn lại: ";
            this.lbRemainTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Enabled = false;
            this.txtTotalTime.ForeColor = System.Drawing.Color.Red;
            this.txtTotalTime.Location = new System.Drawing.Point(126, 18);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Size = new System.Drawing.Size(71, 20);
            this.txtTotalTime.TabIndex = 5;
            this.txtTotalTime.Text = "30:18";
            this.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.Enabled = false;
            this.txtElapsedTime.ForeColor = System.Drawing.Color.Red;
            this.txtElapsedTime.Location = new System.Drawing.Point(126, 48);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.Size = new System.Drawing.Size(71, 20);
            this.txtElapsedTime.TabIndex = 6;
            this.txtElapsedTime.Text = "01:28";
            this.txtElapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemainTime
            // 
            this.txtRemainTime.Enabled = false;
            this.txtRemainTime.ForeColor = System.Drawing.Color.Red;
            this.txtRemainTime.Location = new System.Drawing.Point(126, 80);
            this.txtRemainTime.Name = "txtRemainTime";
            this.txtRemainTime.Size = new System.Drawing.Size(71, 20);
            this.txtRemainTime.TabIndex = 7;
            this.txtRemainTime.Text = "00:12";
            this.txtRemainTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtElapsedTime);
            this.panel1.Controls.Add(this.txtRemainTime);
            this.panel1.Controls.Add(this.lbTotalTime);
            this.panel1.Controls.Add(this.lbelapsedTime);
            this.panel1.Controls.Add(this.txtTotalTime);
            this.panel1.Controls.Add(this.lbRemainTime);
            this.panel1.Location = new System.Drawing.Point(6, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 119);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbChangePass);
            this.panel2.Controls.Add(this.lbChat);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnHide);
            this.panel2.Controls.Add(this.btnOrderFood);
            this.panel2.Controls.Add(this.btnLockClient);
            this.panel2.Controls.Add(this.btnChangePass);
            this.panel2.Controls.Add(this.btnChat);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(6, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 318);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(107, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ẩn menu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(14, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dịch vụ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(105, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Khóa máy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(17, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Đăng xuất";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChangePass
            // 
            this.lbChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbChangePass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbChangePass.Location = new System.Drawing.Point(101, 70);
            this.lbChangePass.Name = "lbChangePass";
            this.lbChangePass.Size = new System.Drawing.Size(87, 23);
            this.lbChangePass.TabIndex = 16;
            this.lbChangePass.Text = "Đổi mật khẩu";
            this.lbChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbChat
            // 
            this.lbChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbChat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbChat.Location = new System.Drawing.Point(29, 69);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(51, 23);
            this.lbChat.TabIndex = 15;
            this.lbChat.Text = "Nhắn tin";
            this.lbChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::ClientManager.Properties.Resources.logoutIcon;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(21, 112);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(65, 55);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackgroundImage = global::ClientManager.Properties.Resources.xIcon;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.Transparent;
            this.btnHide.Location = new System.Drawing.Point(113, 213);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(65, 55);
            this.btnHide.TabIndex = 14;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.BackgroundImage = global::ClientManager.Properties.Resources.listIcon;
            this.btnOrderFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderFood.ForeColor = System.Drawing.Color.Transparent;
            this.btnOrderFood.Location = new System.Drawing.Point(23, 212);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(65, 55);
            this.btnOrderFood.TabIndex = 11;
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.BtnOrderFood_Click);
            // 
            // btnLockClient
            // 
            this.btnLockClient.BackgroundImage = global::ClientManager.Properties.Resources.lockIcon;
            this.btnLockClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockClient.ForeColor = System.Drawing.Color.Transparent;
            this.btnLockClient.Location = new System.Drawing.Point(111, 111);
            this.btnLockClient.Name = "btnLockClient";
            this.btnLockClient.Size = new System.Drawing.Size(65, 55);
            this.btnLockClient.TabIndex = 12;
            this.btnLockClient.UseVisualStyleBackColor = true;
            this.btnLockClient.Click += new System.EventHandler(this.BtnLockClient_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackgroundImage = global::ClientManager.Properties.Resources.keyIcon;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.ForeColor = System.Drawing.Color.Transparent;
            this.btnChangePass.Location = new System.Drawing.Point(110, 12);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(65, 55);
            this.btnChangePass.TabIndex = 10;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackgroundImage = global::ClientManager.Properties.Resources.chatIcon;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.ForeColor = System.Drawing.Color.Transparent;
            this.btnChat.Location = new System.Drawing.Point(23, 12);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(65, 55);
            this.btnChat.TabIndex = 9;
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.BtnChat_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Hiện, ẩn";
            this.notifyIcon.BalloonTipTitle = "Ẩn, hiện";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Tag = "zzz";
            this.notifyIcon.Text = "Ẩn, hiện menu";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // timerCount
            // 
            this.timerCount.Interval = 180000;
            this.timerCount.Tick += new System.EventHandler(this.TimerCount_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(219, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbClientId);
            this.Controls.Add(this.lbAccountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbAccountName;
        public System.Windows.Forms.Label lbClientId;
        public System.Windows.Forms.Label lbTotalTime;
        public System.Windows.Forms.Label lbelapsedTime;
        public System.Windows.Forms.Label lbRemainTime;
        public System.Windows.Forms.TextBox txtTotalTime;
        public System.Windows.Forms.TextBox txtElapsedTime;
        public System.Windows.Forms.TextBox txtRemainTime;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnChat;
        public System.Windows.Forms.Button btnChangePass;
        public System.Windows.Forms.Button btnOrderFood;
        public System.Windows.Forms.Button btnLockClient;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Button btnHide;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbChat;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbChangePass;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.Timer timerCount;
    }
}