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
    public partial class CategoryOrderForm : Form
    {
        public CategoryOrderForm()
        {
            InitializeComponent();
        }

        // Bắt sự kiện hiện lên.
        private void CategoryOrderForm_VisibleChanged(object sender, EventArgs e)
        {

        }

        // Xử lý sự kiện tắt form
        private void CategoryOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide(); 
        }

        // Thoát form
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {

        }

        private void CategoryOrderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
