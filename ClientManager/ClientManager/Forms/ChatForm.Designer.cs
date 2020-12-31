namespace ClientManager.Forms
{
    partial class ChatForm
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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.lstChatLine = new System.Windows.Forms.ListView();
            this.admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSendChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(12, 296);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(409, 38);
            this.txtChat.TabIndex = 0;
            this.txtChat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEnter);
            // 
            // lstChatLine
            // 
            this.lstChatLine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.admin});
            this.lstChatLine.HideSelection = false;
            this.lstChatLine.Location = new System.Drawing.Point(12, 12);
            this.lstChatLine.Name = "lstChatLine";
            this.lstChatLine.Size = new System.Drawing.Size(455, 268);
            this.lstChatLine.TabIndex = 1;
            this.lstChatLine.UseCompatibleStateImageBehavior = false;
            this.lstChatLine.View = System.Windows.Forms.View.Details;
            // 
            // admin
            // 
            this.admin.Text = global::ClientManager.Properties.Settings.Default.zzzz;
            this.admin.Width = 448;
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(428, 296);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(40, 38);
            this.btnSendChat.TabIndex = 2;
            this.btnSendChat.Text = "Gửi";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 346);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.lstChatLine);
            this.Controls.Add(this.txtChat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatForm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtChat;
        public System.Windows.Forms.ListView lstChatLine;
        public System.Windows.Forms.ColumnHeader admin;
        public System.Windows.Forms.Button btnSendChat;
    }
}