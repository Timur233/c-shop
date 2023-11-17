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
using System.Data.SqlTypes;

namespace OnlineShop
{
    public partial class AdminProducts : Form
    {
        public AdminProducts()
        {
            InitializeComponent();
        }

        private void AdminProducts_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowTemplate.Height = 50;

            this.FillTables();
            this.FillProductsTable();

            this.dataGridView1.CellPainting += this.dataGridView_CellPainting;
            this.UpdateCategoriesLists();
        }

        private void FillTables()
        {
            this.shop_productsTableAdapter1.Fill(this.mainDataset1.shop_products);
            this.shop_categoriesTableAdapter1.Fill(this.mainDataset1.shop_categories);

            this.dataGridView1.DataSource = this.mainDataset1.shop_products;
        }

        private void FillProductsTable() {
            this.dataGridView1.Columns.Remove("category_id");

            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["name"].Width = 200;
            this.dataGridView1.Columns["name"].HeaderText = "Название товара";

            // this.dataGridView1.Columns["category_name"].HeaderText = "Категория";
            this.dataGridView1.Columns["name"].Width = 150;
            // this.dataGridView1.Columns["category_name"].DisplayIndex = 1;

            this.dataGridView1.Columns["description"].HeaderText = "Описание товара";
            this.dataGridView1.Columns["description"].Width = 200;

            this.dataGridView1.Columns["price"].HeaderText = "Цена";
            this.dataGridView1.Columns["image"].HeaderText = "Изображение";
        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Проверка, что текущая ячейка относится к столбцу "ImageURL"
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "image")
                {
                    // Проверка, что текущая ячейка содержит данные и является ячейкой данных (не заголовком)
                    if (e.Value != null && e.RowIndex < this.dataGridView1.RowCount - 1)
                    {
                        // Получение URL изображения
                        string imageURL = "uploads/" + e.Value as string;

                        // Проверка, что URL не является null
                        if (!string.IsNullOrEmpty(imageURL))
                        {
                            // Создание объекта изображения
                            try
                            {
                                // Тут может быть логика загрузки изображения по URL
                                using (PictureBox pictureBox = new PictureBox())
                                {
                                    pictureBox.Load(imageURL);

                                    // Вычисление координат и размеров для вписывания изображения в ячейку
                                    int cellWidth = e.CellBounds.Width - 2;
                                    int cellHeight = e.CellBounds.Height - 2;

                                    int imageWidth = pictureBox.Image.Width;
                                    int imageHeight = pictureBox.Image.Height;

                                    int newWidth, newHeight;
                                    if (imageWidth > imageHeight)
                                    {
                                        newWidth = cellWidth;
                                        newHeight = (int)((double)cellWidth / imageWidth * imageHeight);
                                    }
                                    else
                                    {
                                        newHeight = cellHeight;
                                        newWidth = (int)((double)cellHeight / imageHeight * imageWidth);
                                    }

                                    int x = e.CellBounds.Left + (cellWidth - newWidth) / 2 + 1;
                                    int y = e.CellBounds.Top + (cellHeight - newHeight) / 2 + 1;

                                    // Рисование изображения в ячейке
                                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                                    e.Graphics.DrawImage(pictureBox.Image, new Rectangle(x, y, newWidth, newHeight));
                                    e.Handled = true;

                                    // Изменение цвета текста в ячейке
                                    e.Graphics.DrawString("", e.CellStyle.Font, Brushes.White, e.CellBounds.Left + 1, e.CellBounds.Top + 1);
                                }
                            }
                            catch (Exception ex)
                            {
                                // Обработка ошибок загрузки изображения
                                Console.WriteLine($"Ошибка загрузки изображения: {ex.Message}");
                            }
                        }
                    }
                }
            }
        }

        // TREE
        private void UpdateCategoriesLists()
        {
            this.shop_categoriesTableAdapter1.Fill(this.mainDataset1.shop_categories);

            this.LoadTreeView(this.productCategory);
        }

        private void LoadTreeView(TreeView tree)
        {
            tree.Nodes.Clear();
            
            DataRow[] rootNodes = this.mainDataset1.shop_categories.Select("parent_id IS NULL");

            foreach (DataRow rootNode in rootNodes)
            {
                TreeNode node = new TreeNode(rootNode["name"].ToString());
                node.Tag = rootNode["id"];
                tree.Nodes.Add(node);
                
                this.AddChildNodes(node);
            }
        }

        private void AddChildNodes(TreeNode parentNode)
        {
            int parentID = Convert.ToInt32(parentNode.Tag);
            DataRow[] childNodes = this.mainDataset1.shop_categories.Select($"parent_id = {parentID}");
            
            foreach (DataRow childNode in childNodes)
            {
                string uploadsFolderPath = Path.Combine(Application.StartupPath, "uploads");

                TreeNode node = new TreeNode(childNode["name"].ToString());
                node.Tag = childNode["id"]; 

                parentNode.Nodes.Add(node);
                
                this.AddChildNodes(node);
            }
        }

        private void ExpandAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Expand();
                ExpandAllNodes(node.Nodes);
            }
        }

        private TreeNode FindNodeById(TreeNodeCollection nodes, int nodeId)
        {
            foreach (TreeNode node in nodes)
            {
                if ((int)node.Tag == nodeId)
                {
                    return node;
                }

                TreeNode foundNode = FindNodeById(node.Nodes, nodeId);
                if (foundNode != null)
                {
                    return foundNode;
                }
            }

            return null;
        }

        private void SelectNodeById(TreeView tree, int nodeId)
        {
            TreeNode nodeToSelect = FindNodeById(tree.Nodes, nodeId);

            if (nodeToSelect != null)
            {
                tree.SelectedNode = nodeToSelect;
                tree.Focus();
            }
            else
            {
                MessageBox.Show($"Узел с ID {nodeId} не найден.", "Предупреждение");
            }
        }

        //EDIT FORM
        private void clearEditForm()
        {
            this.productName.Text = "";
            this.productDesc.Text = "";
            this.productId.Text = "";
            this.productPrice.Text = "";
            this.productImage.Image = null;
            this.productImage.Tag = "";
        }

        private bool validateForm()
        {
            string name = this.productName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Пожалуйста, введите название категории.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private string GenerateRandomFileName()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();

            return new string(Enumerable.Repeat(chars, 11)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());
        }

        private string saveProductImage(string selectedImagePath)
        {
            string uploadsFolderPath = Path.Combine(Application.StartupPath, "uploads");

            if (!Directory.Exists(uploadsFolderPath))
            {
                Directory.CreateDirectory(uploadsFolderPath);
            }

            string randomName = this.GenerateRandomFileName() + Path.GetExtension(selectedImagePath);
            string destinationPath = Path.Combine(uploadsFolderPath, randomName);

            File.Copy(selectedImagePath, destinationPath, true);

            return randomName;
        }

        private void productImageButton_Click(object sender, EventArgs e)
        {
            this.productImageUploader.Filter = "Изображения (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png|Все файлы (*.*)|*.*";

            if (this.productImageUploader.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = this.productImageUploader.FileName;
                string fileName = this.saveProductImage(selectedImagePath);
                
                this.productImage.Image = Image.FromFile(Path.Combine(Application.StartupPath, "uploads", fileName));
                this.productImage.Tag = fileName;
            }
        }

        private void fillEditForm(int rowID)
        {
            DataRow[] rowsToUpdate = this.mainDataset1.shop_products.Select($"ID = {rowID}");

            if (rowsToUpdate.Length > 0)
            {
                DataRow rowData = rowsToUpdate[0];
                int id = rowID;
                string name = rowData["name"].ToString();
                string description = rowData["description"].ToString();
                string price = rowData["price"].ToString();
                string imagePath = rowData["image"].ToString();

                this.productId.Text = id.ToString();
                this.productName.Text = name;
                this.productDesc.Text = description;
                this.productPrice.Text = price;


                if (imagePath != "")
                {
                    this.productImage.Image = Image.FromFile(Path.Combine(Application.StartupPath, "uploads", imagePath));
                    this.productImage.Tag = imagePath;
                }
                else
                {
                    this.productImage.Image = null;
                    this.productImage.Tag = "";
                }

                if (rowData["category_id"].ToString() != "")
                {
                    int categoryId = Convert.ToInt32(rowData["category_id"]);

                    this.SelectNodeById(this.productCategory, categoryId);
                }
            }
            else
            {
                MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка");
            }
        }

        private void DeleteRow(int rowID)
        {
            DataRow[] rowsToDelete = this.mainDataset1.shop_products.Select($"ID = {rowID}");

            if (rowsToDelete.Length > 0)
            {
                rowsToDelete[0].Delete();

                this.shop_productsTableAdapter1.Update(this.mainDataset1.shop_products);
            }
            else
            {
                MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.validateForm())
            {
                string name = this.productName.Text;
                string description = this.productDesc.Text;
                string imagePath = (this.productImage.Tag != null) ? this.productImage.Tag.ToString() : "";
                int price = Convert.ToInt32((this.productPrice.Text != "") ? this.productPrice.Text : "0");
                int categoryId = Convert.ToInt32(this.productCategory.SelectedNode.Tag);

                if (this.productId.Text.ToString() == "")
                {
                    DataRow newRow = this.mainDataset1.shop_products.NewRow();

                    newRow["category_id"] = categoryId;
                    newRow["name"] = name;
                    newRow["description"] = description;
                    newRow["price"] = price;
                    newRow["image"] = imagePath;

                    this.mainDataset1.shop_products.Rows.Add(newRow);
                    this.shop_productsTableAdapter1.Update(this.mainDataset1.shop_products);
                }
                else
                {
                    int product_id = Convert.ToInt32(this.productId.Text);
                    DataRow[] rowsToUpdate = this.mainDataset1.shop_products.Select($"id = {product_id}");

                    if (rowsToUpdate.Length > 0)
                    {
                        rowsToUpdate[0]["category_id"] = categoryId;
                        rowsToUpdate[0]["name"] = name;
                        rowsToUpdate[0]["description"] = description;
                        rowsToUpdate[0]["price"] = price;
                        rowsToUpdate[0]["image"] = imagePath;

                        this.shop_productsTableAdapter1.Update(this.mainDataset1.shop_products);
                    }
                    else
                    {
                        MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка");
                    }
                }

                this.UpdateCategoriesLists();
                this.FillTables();
                this.clearEditForm();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.SelectedRows[0];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                this.clearEditForm();
                this.fillEditForm(selectedId);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.SelectedRows[0];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                this.clearEditForm();
                this.DeleteRow(selectedId);
                this.UpdateCategoriesLists();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.clearEditForm();
        }
    }
}
