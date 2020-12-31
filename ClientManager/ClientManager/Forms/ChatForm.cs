using ClientManager.Model.StaticModel;
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
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        // Bấm nút gửi chat tới server
        private void Button1_Click(object sender, EventArgs e)
        {
            this.SendChat(); 
        }

        private async void KeyUpEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // SendChat
                this.SendChat(); 
            }
        }

        private void SendChat()
        {
            if(this.txtChat.Text=="" || this.txtChat.Text is null)
            { return; }
            else
            {
                ListViewItem item = new ListViewItem($"[{StaticModels.CurrentAccount.AccountName}]: " + this.txtChat.Text);
                this.lstChatLine.Items.Add(item);
                StaticModels.HubConnection.InvokeAsync("sendToAdmin", this.txtChat.Text, StaticModels.CurrentAccount.AccountName);
                this.txtChat.Text = "";
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }
    }
}
