namespace OnlineShop
{
    partial class AdminProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainDataset1 = new OnlineShop.mainDataset();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shop_productsTableAdapter1 = new OnlineShop.mainDatasetTableAdapters.shop_productsTableAdapter();
            this.shop_categoriesTableAdapter1 = new OnlineShop.mainDatasetTableAdapters.shop_categoriesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.productImageButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productCategory = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productId = new System.Windows.Forms.TextBox();
            this.productImageUploader = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainDataset1
            // 
            this.mainDataset1.DataSetName = "mainDataset";
            this.mainDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // shop_productsTableAdapter1
            // 
            this.shop_productsTableAdapter1.ClearBeforeFill = true;
            // 
            // shop_categoriesTableAdapter1
            // 
            this.shop_categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 542);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список товаров";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(196, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(76, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(87, 19);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(103, 23);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.productImage);
            this.groupBox2.Controls.Add(this.productImageButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.productPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.productDesc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.productCategory);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.productName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 542);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование товара";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 507);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productImage
            // 
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Location = new System.Drawing.Point(9, 397);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(127, 97);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 12;
            this.productImage.TabStop = false;
            // 
            // productImageButton
            // 
            this.productImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productImageButton.Location = new System.Drawing.Point(142, 397);
            this.productImageButton.Name = "productImageButton";
            this.productImageButton.Size = new System.Drawing.Size(52, 97);
            this.productImageButton.TabIndex = 11;
            this.productImageButton.Text = "Выбор файла";
            this.productImageButton.UseVisualStyleBackColor = true;
            this.productImageButton.Click += new System.EventHandler(this.productImageButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Изображение";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(9, 337);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(113, 20);
            this.productPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена";
            // 
            // productDesc
            // 
            this.productDesc.Location = new System.Drawing.Point(9, 212);
            this.productDesc.Name = "productDesc";
            this.productDesc.Size = new System.Drawing.Size(185, 96);
            this.productDesc.TabIndex = 1;
            this.productDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание товара";
            // 
            // productCategory
            // 
            this.productCategory.CausesValidation = false;
            this.productCategory.FullRowSelect = true;
            this.productCategory.HideSelection = false;
            this.productCategory.HotTracking = true;
            this.productCategory.Location = new System.Drawing.Point(9, 90);
            this.productCategory.Name = "productCategory";
            this.productCategory.ShowNodeToolTips = true;
            this.productCategory.Size = new System.Drawing.Size(185, 90);
            this.productCategory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория товра";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(9, 38);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(113, 20);
            this.productName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // productId
            // 
            this.productId.Location = new System.Drawing.Point(140, 50);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(66, 20);
            this.productId.TabIndex = 4;
            // 
            // productImageUploader
            // 
            this.productImageUploader.FileName = "productImageUploader";
            // 
            // AdminProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 566);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminProducts";
            this.Text = "Редактирование товары - Acoustic Music Shop";
            this.Load += new System.EventHandler(this.AdminProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mainDataset mainDataset1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mainDatasetTableAdapters.shop_productsTableAdapter shop_productsTableAdapter1;
        private mainDatasetTableAdapters.shop_categoriesTableAdapter shop_categoriesTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productId;
        protected System.Windows.Forms.TreeView productCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox productDesc;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Button productImageButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.OpenFileDialog productImageUploader;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
    }
}