using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.GraphicsInitialize(); 
        }

        // Khởi tạo đồ họa
        public void GraphicsInitialize()
        {
            // Dành cho title button 
            this.btnTitle.FlatStyle = FlatStyle.Flat;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.ForeColor = Color.White;
            this.btnTitle.Enabled = false;
            this.btnTitle.UseCompatibleTextRendering = true;
        }
    }
}
