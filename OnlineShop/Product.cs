using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Product : Form
    {
        public int productId;

        public Product(int productId)
        {
            InitializeComponent();

            this.shop_productsTableAdapter1.Fill(this.mainDataset1.shop_products);
            this.shop_categoriesTableAdapter1.Fill(this.mainDataset1.shop_categories);

            this.productId = productId;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            DataRow[] rowsToUpdate = this.mainDataset1.shop_products.Select($"ID = {this.productId}");

            if (rowsToUpdate.Length > 0)
            {
                DataRow rowData = rowsToUpdate[0];
                int id = this.productId;
                string name = rowData["name"].ToString();
                string description = rowData["description"].ToString();
                string price = rowData["price"].ToString();
                // string category = rowData["category_name"].ToString();
                string imagePath = rowData["image"].ToString();

                if (imagePath != "") {
                    this.productImage.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "uploads", imagePath));
                }
                
                this.productName.Text = name;
                this.productDesc.Text = description;
                this.productPrice.Text = price;
                // this.productCategory.Text = category;
            }
            else
            {
                MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rating = this.comboBox1.SelectedIndex + 1;

            DataRow newRow = this.mainDataset1.shop_rating.NewRow();

            newRow["product_id"] = Convert.ToInt32(this.productId);
            newRow["rating"] = rating;

            this.mainDataset1.shop_rating.Rows.Add(newRow);
            this.shop_ratingTableAdapter1.Update(this.mainDataset1.shop_rating);

            MessageBox.Show("Ваша оценка принята");
        }
    }
}
