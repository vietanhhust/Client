namespace ClientManager.Forms
{
    partial class CategoryOrderForm
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
            this.pnListCategoryItem = new System.Windows.Forms.Panel();
            this.pnDatagridView = new System.Windows.Forms.Panel();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.CategoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnButtonChooseCategory = new System.Windows.Forms.Panel();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.pnDatagridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pnListCategoryItem
            // 
            this.pnListCategoryItem.Location = new System.Drawing.Point(12, 49);
            this.pnListCategoryItem.Name = "pnListCategoryItem";
            this.pnListCategoryItem.Size = new System.Drawing.Size(675, 178);
            this.pnListCategoryItem.TabIndex = 0;
            // 
            // pnDatagridView
            // 
            this.pnDatagridView.Controls.Add(this.dataGridViewOrder);
            this.pnDatagridView.Location = new System.Drawing.Point(12, 233);
            this.pnDatagridView.Name = "pnDatagridView";
            this.pnDatagridView.Size = new System.Drawing.Size(675, 215);
            this.pnDatagridView.TabIndex = 1;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToOrderColumns = true;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryItem,
            this.Price,
            this.Amount});
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.Size = new System.Drawing.Size(669, 209);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // CategoryItem
            // 
            this.CategoryItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryItem.HeaderText = "Sản phẩm";
            this.CategoryItem.Name = "CategoryItem";
            this.CategoryItem.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số lượng";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // pnButtonChooseCategory
            // 
            this.pnButtonChooseCategory.Location = new System.Drawing.Point(12, 7);
            this.pnButtonChooseCategory.Name = "pnButtonChooseCategory";
            this.pnButtonChooseCategory.Size = new System.Drawing.Size(675, 36);
            this.pnButtonChooseCategory.TabIndex = 2;
            // 
            // lbTongTien
            // 
            this.lbTongTien.Location = new System.Drawing.Point(10, 457);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(60, 35);
            this.lbTongTien.TabIndex = 3;
            this.lbTongTien.Text = "Tổng tiền:";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(68, 457);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(106, 35);
            this.lbTotalPrice.TabIndex = 4;
            this.lbTotalPrice.Text = "45,000 đ";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(491, 457);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(92, 35);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Gọi dịch vụ";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(592, 457);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(92, 35);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "Hủy";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CategoryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 501);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.pnButtonChooseCategory);
            this.Controls.Add(this.pnDatagridView);
            this.Controls.Add(this.pnListCategoryItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryOrderForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gọi dịch vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.CategoryOrderForm_Load);
            this.VisibleChanged += new System.EventHandler(this.CategoryOrderForm_VisibleChanged);
            this.pnDatagridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnListCategoryItem;
        private System.Windows.Forms.Panel pnDatagridView;
        private System.Windows.Forms.Panel pnButtonChooseCategory;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}