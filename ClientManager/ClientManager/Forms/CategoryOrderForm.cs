using ClientManager.Model.StaticModel;
using ClientManager.Models.AppModel;
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
        // Biến tổng tiền
        int totalCost = 0; 
        List<CategoryItem> ListCategoryItems = new List<CategoryItem>(); 
        List<Button> ListCategoryButtons = new List<Button>(); 
        public CategoryOrderForm()
        {
            InitializeComponent();
            //this.GraphicInitialize();
        }

        // Bắt sự kiện hiện lên.
        private void CategoryOrderForm_VisibleChanged(object sender, EventArgs e)
        {
            this.GraphicInitialize(); 

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

        // Khởi tạo giao diện ban đầu
        private void GraphicInitialize()
        {
            this.lbTotalPrice.Text = this.totalCost.ToString() + " đ";
            this.CategoryButtonInitialize();

            //var x = dataGridViewOrder.Rows.Cast<DataGridViewRow>().ToList()[0];
            //dataGridViewOrder.Rows.Remove(x);
        }

        // Hàm này khởi tạo nút bấm chọn category
        public void CategoryButtonInitialize()
        {
            this.pnButtonChooseCategory.Controls.Clear();
            this.pnListCategoryItem.Controls.Clear(); 
            this.dataGridViewOrder.Rows.Clear(); 
            var locX = 0;
            if(StaticModels.ListCategory != null)
            {
                StaticModels.ListCategory.ForEach(item =>
                {
                    var button = new Button()
                    {
                        Text = item.CategoryName,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.White,
                        ForeColor = Color.Black,
                        Height = 35,
                        Name = item.Id.ToString(),
                        MinimumSize = new Size(100, 40),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    this.pnButtonChooseCategory.Controls.Add(button);
                    button.FlatAppearance.BorderSize = 0;
                    button.Location = new Point(locX, 2);
                    button.FlatStyle = FlatStyle.Flat;
                    button.Click += CategoryChoose;
                    button.Show();
                    this.ListCategoryButtons.Add(button);
                    locX = locX + 100;
                });
            }
               
        }

        // Khi chọn loại danh mục
        private void CategoryChoose(object sender, EventArgs e)
        {
            this.ListCategoryButtons.ForEach(item =>
            {
                item.ForeColor = Color.Black;
                item.BackColor = Color.White; 
            });

            var button = sender as Button;
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(18, 140, 201);

            var id = int.Parse(button.Name);
            
            // Bắt đầu hiển thị những item mà có category là như thế kia
            this.CategoryItemInitialize(id); 

        }

        // Hàm này chọn loại danh mục tương ứng
        public void CategoryItemChoose(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            var id = int.Parse(button.Name);
            var categoryItem = StaticModels.ListCategoryItem.Where(x => x.Id == id).FirstOrDefault();
            var rows = this.dataGridViewOrder.Rows.Cast<DataGridViewRow>().ToList(); 
            var rowExist = rows.Where(x => (x.Cells[0].Value as string) == id.ToString()).FirstOrDefault();

            // Nếu là chuột trái, thì thực hiện thêm/ tăng danh sách
            // Nếu là chuột phải, thì thực hiện giảm/ xóa khỏi danh sách
            if (e.Button == MouseButtons.Left)
            {
                if(rowExist is null)
                {
                    this.dataGridViewOrder.Rows.Add(new object[] { 
                        id.ToString(), categoryItem.CategoryItemName.ToString(), 
                        categoryItem.UnitPrice, "1"
                    });
                    // Tăng giá tiền. 
                    this.totalCost += categoryItem.UnitPrice;
                    this.lbTotalPrice.Text = this.totalCost.ToString() + " đ";
                }
                else
                {
                    rowExist.Cells[3].Value = (int.Parse(rowExist.Cells[3].Value as string) + 1).ToString();
                    this.totalCost += categoryItem.UnitPrice;
                    this.lbTotalPrice.Text = this.totalCost.ToString() + " đ";
                }
            }
            else
            {
                if(rowExist is null)
                {
                    return;
                }
                else
                {
                    if(int.Parse(rowExist.Cells[3].Value as string) > 1)
                    {
                        rowExist.Cells[3].Value = (int.Parse(rowExist.Cells[3].Value as string) - 1).ToString();
                        this.totalCost -= categoryItem.UnitPrice;
                        this.lbTotalPrice.Text = this.totalCost.ToString() + " đ";
                    }
                    else
                    {
                        this.dataGridViewOrder.Rows.Remove(rowExist);
                        this.totalCost -= categoryItem.UnitPrice;
                        this.lbTotalPrice.Text = this.totalCost.ToString() + " đ";
                    }
                }
            }
            
        }

        // Hàm này để vẽ lên các nút chọn danh mục. 
        public void CategoryItemInitialize(int categoryId)
        {
            this.pnListCategoryItem.Controls.Clear();
            var listCategoryItem = StaticModels.ListCategoryItem.
                Where(item => item.CategoryId == categoryId).ToList();
            

            var locationX = 0;
            var locationY = 0;
            var count = 0;
            listCategoryItem.ForEach(item =>
            {
                // Tạo khay
                Panel panel = new Panel()
                {
                    Width = 159,
                    Height = 70,
                    Name = item.Id.ToString()
                };
                this.pnListCategoryItem.Controls.Add(panel);
                panel.Location = new Point(locationX, locationY);

                // Button chứa ảnh của đồ an
                Button button = new Button()
                {
                    Width = 62,
                    Height = 70,
                    FlatStyle = FlatStyle.Flat,
                    Name = item.Id.ToString()
                };
                panel.Controls.Add(button);
                button.FlatAppearance.BorderSize = 0;
                button.Location = new Point(0, 0);
                button.BackgroundImage = new Bitmap(item.Image, new Size(62, 70));
                button.MouseUp += this.CategoryItemChoose;

                // Label tên
                Label categoryName = new Label()
                {
                    Text = item.CategoryItemName,
                    BackColor = Color.Transparent,
                    AutoSize = false,
                    Width = 89,
                    Height = 43,

                };
                panel.Controls.Add(categoryName);
                categoryName.Location = new Point(70, 24);

                // Label giá
                Label categoryPrice = new Label()
                {
                    Text = item.UnitPrice.ToString() + " đ",
                    Width = 83,
                    Height = 20,
                };
                categoryPrice.Font = new Font(categoryPrice.Font, FontStyle.Bold);
                panel.Controls.Add(categoryPrice);
                categoryPrice.Location = new Point(73, 5);
                locationX += 162;
                count++;
                if ((count % 4) == 0 && count> 3)
                {
                    locationY += 75;
                    locationX = 0;
                }
            });


        }


        public class CategoryOrderList
        {
            public string Id { get; set; }
            public string Amount { get; set; }
            public string Price { get; set; }
            public string CategoryItemName { get; set; }
        }

        
    }
}
