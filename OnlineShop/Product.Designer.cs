namespace OnlineShop
{
    partial class Product
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
            this.mainDataset1 = new OnlineShop.mainDataset();
            this.shop_categoriesTableAdapter1 = new OnlineShop.mainDatasetTableAdapters.shop_categoriesTableAdapter();
            this.shop_productsTableAdapter1 = new OnlineShop.mainDatasetTableAdapters.shop_productsTableAdapter();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productCategory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productDesc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shop_ratingTableAdapter1 = new OnlineShop.mainDatasetTableAdapters.shop_ratingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // productImage
            // 
            this.productImage.BackgroundImage = global::OnlineShop.Properties.Resources.logo;
            this.productImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Location = new System.Drawing.Point(12, 12);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(345, 311);
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName.Location = new System.Drawing.Point(373, 15);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(156, 20);
            this.productName.TabIndex = 1;
            this.productName.Text = "Название товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(374, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена:";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productPrice.Location = new System.Drawing.Point(451, 46);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(57, 15);
            this.productPrice.TabIndex = 3;
            this.productPrice.Text = "2000 тг";
            this.productPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // productCategory
            // 
            this.productCategory.AutoSize = true;
            this.productCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategory.Location = new System.Drawing.Point(451, 69);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(148, 15);
            this.productCategory.TabIndex = 5;
            this.productCategory.Text = "Акустические гитары";
            this.productCategory.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(374, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Категория: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // productDesc
            // 
            this.productDesc.AutoSize = true;
            this.productDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDesc.Location = new System.Drawing.Point(453, 116);
            this.productDesc.Name = "productDesc";
            this.productDesc.Size = new System.Drawing.Size(76, 15);
            this.productDesc.TabIndex = 7;
            this.productDesc.Text = "Описание:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(374, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Оценка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(374, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Описание:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(454, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(377, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оставить заявки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 0;
            // 
            // shop_ratingTableAdapter1
            // 
            this.shop_ratingTableAdapter1.ClearBeforeFill = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDesc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productImage);
            this.Name = "Product";
            this.Text = "Просмотр товара - Acoustic Music Shop";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mainDataset mainDataset1;
        private mainDatasetTableAdapters.shop_categoriesTableAdapter shop_categoriesTableAdapter1;
        private mainDatasetTableAdapters.shop_productsTableAdapter shop_productsTableAdapter1;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label productDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private mainDatasetTableAdapters.shop_ratingTableAdapter shop_ratingTableAdapter1;
    }
}