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
    public partial class Catalog : Form
    {
        private DataView dataView;

        public Catalog()
        {
            InitializeComponent();

            this.FillTables();
            this.FillProductsTable();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            this.UpdateCategoriesLists();
        }

        private void FillTables()
        {
            this.shop_productsTableAdapter1.FillBy(this.mainDataset1.shop_products);
            this.shop_categoriesTableAdapter1.Fill(this.mainDataset1.shop_categories);

            this.dataGridView1.DataSource = this.mainDataset1.shop_products;
        }

        private void FillProductsTable()
        {
            this.dataGridView1.Columns["id"].Visible = false;
            this.dataGridView1.Columns["category_id"].Visible = false;
            this.dataGridView1.Columns["image"].Visible = false;

            this.dataGridView1.Columns["name"].Width = 200;
            this.dataGridView1.Columns["name"].HeaderText = "Название товара";

            this.dataGridView1.Columns["category_name"].HeaderText = "Категория";
            this.dataGridView1.Columns["name"].Width = 180;
            this.dataGridView1.Columns["category_name"].DisplayIndex = 1;

            this.dataGridView1.Columns["description"].HeaderText = "Описание товара";
            this.dataGridView1.Columns["description"].Width = 200;

            this.dataGridView1.Columns["price"].HeaderText = "Цена";
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
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void queryBuilder(string query, string type) {
            if (this.dataView == null) {
                this.dataView = new DataView(this.mainDataset1.shop_products);
            }

            if (type == "sort") {
                this.dataView.Sort = query;
            }

            if (type == "filter") {
                this.dataView.RowFilter = query;
            }

            this.dataGridView1.DataSource = dataView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.productSort.SelectedIndex;

            if (selectedIndex == 0) {
                this.queryBuilder("price ASC", "sort");
            }

            if (selectedIndex == 1) {
                this.queryBuilder("price DESC", "sort");
            }

            this.dataGridView1.DataSource = dataView;
        }

        private void productCategory_Click(object sender, EventArgs e)
        {
        }

        private void productCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (productCategory.SelectedNode != null)
            {
                int category_id = Convert.ToInt32(productCategory.SelectedNode.Tag);

                this.queryBuilder($"category_id = '{category_id}'", "filter");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productCategory.SelectedNode = null;
            this.productSort.SelectedItem = null;

            this.queryBuilder("", "sort");
            this.queryBuilder("", "filter");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Console.WriteLine(this.dataGridView1.SelectedRows.Count);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.SelectedRows[0];
                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                Product modal = new Product(selectedId);
                DialogResult result = modal.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    /*
                    this.dataView = null;
                    this.shop_productsTableAdapter1.FillBy(this.mainDataset1.shop_products);
                    this.FillProductsTable();
                    this.queryBuilder("", "sort");
                    */
                }

            }
        }
    }
}
