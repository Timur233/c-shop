namespace OnlineShop
{
    partial class Catalog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainDataset1 = new OnlineShop.mainDataset();
            this.shop_categoriesTableAdapter1 = new OnlineShop.mainDatasetTableAdapters.shop_categoriesTableAdapter();
            this.shop_productsTableAdapter1 = new OnlineShop.mainDatasetTableAdapters.shop_productsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productCategory = new System.Windows.Forms.TreeView();
            this.productSortLabel = new System.Windows.Forms.Label();
            this.productSort = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mainDataset1
            // 
            this.mainDataset1.DataSetName = "mainDataset";
            this.mainDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shop_categoriesTableAdapter1
            // 
            this.shop_categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // shop_productsTableAdapter1
            // 
            this.shop_productsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(638, 508);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.productSort);
            this.groupBox2.Controls.Add(this.productSortLabel);
            this.groupBox2.Controls.Add(this.productCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 533);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фильтр";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Категория";
            // 
            // productCategory
            // 
            this.productCategory.CausesValidation = false;
            this.productCategory.FullRowSelect = true;
            this.productCategory.HideSelection = false;
            this.productCategory.HotTracking = true;
            this.productCategory.Location = new System.Drawing.Point(9, 44);
            this.productCategory.Name = "productCategory";
            this.productCategory.ShowNodeToolTips = true;
            this.productCategory.Size = new System.Drawing.Size(200, 156);
            this.productCategory.TabIndex = 6;
            this.productCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.productCategory_AfterSelect);
            this.productCategory.Click += new System.EventHandler(this.productCategory_Click);
            // 
            // productSortLabel
            // 
            this.productSortLabel.AutoSize = true;
            this.productSortLabel.Location = new System.Drawing.Point(6, 218);
            this.productSortLabel.Name = "productSortLabel";
            this.productSortLabel.Size = new System.Drawing.Size(67, 13);
            this.productSortLabel.TabIndex = 7;
            this.productSortLabel.Text = "Сортировка";
            // 
            // productSort
            // 
            this.productSort.FormattingEnabled = true;
            this.productSort.Items.AddRange(new object[] {
            "По возрастанию цены",
            "По убыванию цены"});
            this.productSort.Location = new System.Drawing.Point(9, 238);
            this.productSort.Name = "productSort";
            this.productSort.Size = new System.Drawing.Size(200, 21);
            this.productSort.TabIndex = 1;
            this.productSort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отчистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Catalog";
            this.Text = "Каталог товаров- Acoustic Music Shop";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private mainDataset mainDataset1;
        private mainDatasetTableAdapters.shop_categoriesTableAdapter shop_categoriesTableAdapter1;
        private mainDatasetTableAdapters.shop_productsTableAdapter shop_productsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TreeView productCategory;
        private System.Windows.Forms.ComboBox productSort;
        private System.Windows.Forms.Label productSortLabel;
        private System.Windows.Forms.Button button1;
    }
}