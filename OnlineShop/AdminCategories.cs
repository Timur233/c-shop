using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            this.treeView1.AfterSelect += this.treeView1_AfterSelect;
            Console.WriteLine($"Selected Node Tag:");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminCategories_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataset.shop_categories". При необходимости она может быть перемещена или удалена.
            this.shop_categoriesTableAdapter.Fill(this.mainDataset.shop_categories);

            this.LoadTreeView();
        }

        private void LoadTreeView()
        {
            // Очистка TreeView
            this.treeView1.Nodes.Clear();

            // Загрузка корневых элементов
            DataRow[] rootNodes = this.mainDataset.shop_categories.Select("parent_id IS NULL");

            foreach (DataRow rootNode in rootNodes)
            {
                TreeNode node = new TreeNode(rootNode["name"].ToString());
                node.Tag = rootNode["id"]; // Сохраняем ID в Tag для последующего использования
                this.treeView1.Nodes.Add(node);

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
                TreeNode node = new TreeNode(childNode["name"].ToString());
                node.Tag = childNode["id"]; // Сохраняем ID в Tag для последующего использования
                parentNode.Nodes.Add(node);

                // Рекурсивное добавление дочерних узлов
                this.AddChildNodes(node);
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
            // Получаем выделенный узел
            TreeNode selectedNode = e.Node;

            // Выводим информацию о выделенном узле в консоль
            Console.WriteLine($"Selected Node Text: {selectedNode.Text}");

            // Если используется Tag для хранения данных, выведем его тоже
            if (selectedNode.Tag != null)
            {
                Console.WriteLine($"Selected Node Tag: {selectedNode.Tag}");
            }
        }
    }
}
