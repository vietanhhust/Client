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
    public partial class ChatForm : Form
    {
        int i = 0; 
        public ChatForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("[Admin]: " + "Test");
            this.lstChatLine.Items.Add(item);
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
            ListViewItem item = new ListViewItem("[User]: " + this.txtChat.Text);
            this.lstChatLine.Items.Add(item);
            this.txtChat.Text = "";
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }
    }
}
