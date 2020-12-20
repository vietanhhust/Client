namespace ClientManager.Forms
{
    partial class LockForm
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
            this.lbClientId = new System.Windows.Forms.Label();
            this.lbDisconnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClientId
            // 
            this.lbClientId.BackColor = System.Drawing.Color.Transparent;
            this.lbClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientId.ForeColor = System.Drawing.Color.Red;
            this.lbClientId.Location = new System.Drawing.Point(12, 9);
            this.lbClientId.Name = "lbClientId";
            this.lbClientId.Size = new System.Drawing.Size(287, 90);
            this.lbClientId.TabIndex = 0;
            this.lbClientId.Text = "Máy Test";
            // 
            // lbDisconnect
            // 
            this.lbDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.lbDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisconnect.ForeColor = System.Drawing.Color.Red;
            this.lbDisconnect.Location = new System.Drawing.Point(247, 9);
            this.lbDisconnect.Name = "lbDisconnect";
            this.lbDisconnect.Size = new System.Drawing.Size(358, 90);
            this.lbDisconnect.TabIndex = 1;
            this.lbDisconnect.Text = "Mất kết nối";
            this.lbDisconnect.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ClientManager.Properties.Resources.LockScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.lbDisconnect);
            this.Controls.Add(this.lbClientId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LockForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LockForm_FormClosing);
            this.DoubleClick += new System.EventHandler(this.LockForm_DoubleClick);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LockForm_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showLoginForm);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbClientId;
        public System.Windows.Forms.Label lbDisconnect;
    }
}