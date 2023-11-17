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
    public partial class AdminCategories : Form
    {
        public AdminCategories()
        {
            InitializeComponent();

            this.categoryTree.AfterSelect += this.treeView1_AfterSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.categoryImageUploader.Filter = "Изображения (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png|Все файлы (*.*)|*.*";

            if (this.categoryImageUploader.ShowDialog() == DialogResult.OK) {
                // Получаем путь к выбранному файлу
                string selectedImagePath = this.categoryImageUploader.FileName;
                string fileName = this.saveCategoryImage(selectedImagePath);

                // Отображаем изображение в PictureBox
                this.categoryImage.Image = Image.FromFile(Path.Combine(Application.StartupPath, "uploads", fileName));
                this.categoryImage.Tag = fileName;
            }
        }

        private void AdminCategories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataset.shop_categories". При необходимости она может быть перемещена или удалена.
            this.shop_categoriesTableAdapter.Fill(this.mainDataset.shop_categories);

            this.UpdateCategoriesLists();

        }

        private void UpdateCategoriesLists() {
            this.shop_categoriesTableAdapter.Fill(this.mainDataset.shop_categories);

            this.LoadTreeView(this.categoryTree);
            this.LoadTreeView(this.categoriesListTree);

            this.ExpandAllNodes(this.categoriesListTree.Nodes);
        }

        private void LoadTreeView(TreeView tree)
        {
            // Очистка TreeView
            tree.Nodes.Clear();

            // Загрузка корневых элементов
            DataRow[] rootNodes = this.mainDataset.shop_categories.Select("parent_id IS NULL");

            foreach (DataRow rootNode in rootNodes)
            {
                TreeNode node = new TreeNode(rootNode["name"].ToString());
                node.Tag = rootNode["id"]; // Сохраняем ID в Tag для последующего использования
                tree.Nodes.Add(node);

                // Рекурсивное добавление дочерних узлов
                this.AddChildNodes(node);
            }
        }

        private void AddChildNodes(TreeNode parentNode)
        {
            // Находим дочерние элементы для текущего узла
            int parentID = Convert.ToInt32(parentNode.Tag);
            DataRow[] childNodes = this.mainDataset.shop_categories.Select($"parent_id = {parentID}");

            // Добавляем дочерние узлы
            foreach (DataRow childNode in childNodes)
            {
                string uploadsFolderPath = Path.Combine(Application.StartupPath, "uploads");

                TreeNode node = new TreeNode(childNode["name"].ToString());
                node.Tag = childNode["id"]; // Сохраняем ID в Tag для последующего использования

                parentNode.Nodes.Add(node);

                // Рекурсивное добавление дочерних узлов
                this.AddChildNodes(node);
            }
        }

        private void ExpandAllNodes(TreeNodeCollection nodes) {
            foreach (TreeNode node in nodes) {
                // Развернуть текущий узел
                node.Expand();

                // Рекурсивно развернуть все дочерние узлы
                ExpandAllNodes(node.Nodes);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shopcategoriesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private bool validateForm() {
            string name = this.categoryName.Text;

            if (string.IsNullOrWhiteSpace(name)) {
                MessageBox.Show("Пожалуйста, введите название категории.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private string GenerateRandomFileName() {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            Random random = new Random();

            return new string(Enumerable.Repeat(chars, 11)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());
        }

        private string saveCategoryImage(string selectedImagePath) {
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

        private void button2_Click(object sender, EventArgs e) {
            if (this.validateForm()) {
                string name = this.categoryName.Text;
                string description = this.categoryDesc.Text;
                string imagePath = (this.categoryImage.Tag != null) ? this.categoryImage.Tag.ToString() : "";
                int parentId = (this.categoryTree.SelectedNode != null) ? Convert.ToInt32(this.categoryTree.SelectedNode.Tag) : -1;

                if (this.categoryId.Text.ToString() == "") {
                    DataRow newRow = this.mainDataset.shop_categories.NewRow();

                    newRow["name"] = name;
                    newRow["description"] = description;
                    newRow["image"] = imagePath;

                    if (parentId != -1)
                    {
                        newRow["parent_id"] = parentId;
                    }

                    this.mainDataset.shop_categories.Rows.Add(newRow);
                    this.shop_categoriesTableAdapter.Update(this.mainDataset.shop_categories);
                }
                else {
                    int category_id = Convert.ToInt32(this.categoryId.Text);
                    DataRow[] rowsToUpdate = this.mainDataset.shop_categories.Select($"id = {category_id}");

                    if (rowsToUpdate.Length > 0) {
                        rowsToUpdate[0]["name"] = name;
                        rowsToUpdate[0]["description"] = description;
                        rowsToUpdate[0]["image"] = imagePath;

                        if (parentId != -1) {
                            rowsToUpdate[0]["parent_id"] = parentId;
                        }

                        this.shop_categoriesTableAdapter.Update(this.mainDataset.shop_categories);
                    }
                    else
                    {
                        MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка");
                    }
                }

                this.UpdateCategoriesLists();
                this.clearEditForm();
            }
        }

        private void DeleteRow(int rowID) {
            // Найти строку в DataTable, которую нужно удалить
            DataRow[] rowsToDelete = this.mainDataset.shop_categories.Select($"ID = {rowID}");

            if (rowsToDelete.Length > 0)
            {
                // Удалить строку из DataTable
                rowsToDelete[0].Delete();

                // Вызвать метод Update у TableAdapter для удаления строки из базы данных
                this.shop_categoriesTableAdapter.Update(this.mainDataset.shop_categories);
            }
            else
            {
                MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e) {
            int selectedId = Convert.ToInt32(this.categoriesListTree.SelectedNode.Tag);

            this.DeleteRow(selectedId);
            this.UpdateCategoriesLists();
            this.clearEditForm();
        }

        private TreeNode FindNodeById(TreeNodeCollection nodes, int nodeId) {
            foreach (TreeNode node in nodes) {
                if ((int)node.Tag == nodeId) {
                    return node;
                }

                TreeNode foundNode = FindNodeById(node.Nodes, nodeId);
                if (foundNode != null) {
                    return foundNode;
                }
            }

            return null;
        }

        private void SelectNodeById(TreeView tree, int nodeId){
            TreeNode nodeToSelect = FindNodeById(tree.Nodes, nodeId);

            if (nodeToSelect != null) {
                tree.SelectedNode = nodeToSelect;
                tree.Focus(); 
            } else {
                MessageBox.Show($"Узел с ID {nodeId} не найден.", "Предупреждение");
            }
        }

        private void fillEditForm(int rowID) {
            DataRow[] rowsToUpdate = this.mainDataset.shop_categories.Select($"ID = {rowID}");

            if (rowsToUpdate.Length > 0) {
                DataRow rowData = rowsToUpdate[0];
                int id = rowID;
                string name = rowData["name"].ToString();
                string description = rowData["description"].ToString();
                string imagePath = rowData["image"].ToString();

                this.categoryId.Text = id.ToString();
                this.categoryName.Text = name;
                this.categoryDesc.Text = description;


                if (imagePath != "") {
                    this.categoryImage.Image = Image.FromFile(Path.Combine(Application.StartupPath, "uploads", imagePath));
                    this.categoryImage.Tag = imagePath;
                } else {
                    this.categoryImage.Image = null;
                    this.categoryImage.Tag = "";
                }

                if (rowData["parent_id"].ToString() != "") {
                    int parentId = Convert.ToInt32(rowData["parent_id"]);

                    this.SelectNodeById(this.categoryTree, parentId);
                }
            } else {
                MessageBox.Show("Строка с указанным ID не найдена.", "Ошибка");
            }
        }

        private void clearEditForm() {
            this.categoryName.Text = "";
            this.categoryDesc.Text = "";
            this.categoryId.Text = "";
            this.categoryImage.Image = null;
            this.categoryImage.Tag = "";
        }

        private void editButton_Click(object sender, EventArgs e) {
            if (this.categoriesListTree.SelectedNode != null) {
                int selectedId = Convert.ToInt32(this.categoriesListTree.SelectedNode.Tag);

                this.clearEditForm();
                this.fillEditForm(selectedId);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.clearEditForm();
        }

        private void categoriesListTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
