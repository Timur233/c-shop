namespace OnlineShop
{
    partial class AdminCategories
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryImage = new System.Windows.Forms.PictureBox();
            this.categoryTree = new System.Windows.Forms.TreeView();
            this.shopcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataset = new OnlineShop.mainDataset();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoryImageButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryDesc = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryImageUploader = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shop_categoriesTableAdapter = new OnlineShop.mainDatasetTableAdapters.shop_categoriesTableAdapter();
            this.categoriesListTree = new System.Windows.Forms.TreeView();
            this.editButton = new System.Windows.Forms.Button();
            this.categoryListGroup = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.categoryId = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopcategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset)).BeginInit();
            this.categoryListGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.categoryId);
            this.groupBox1.Controls.Add(this.categoryImage);
            this.groupBox1.Controls.Add(this.categoryTree);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.categoryImageButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.categoryDesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.categoryName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 510);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование категорий";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // categoryImage
            // 
            this.categoryImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryImage.Location = new System.Drawing.Point(9, 349);
            this.categoryImage.Name = "categoryImage";
            this.categoryImage.Size = new System.Drawing.Size(134, 97);
            this.categoryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoryImage.TabIndex = 9;
            this.categoryImage.TabStop = false;
            // 
            // categoryTree
            // 
            this.categoryTree.CausesValidation = false;
            this.categoryTree.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.shopcategoriesBindingSource, "parent_id", true));
            this.categoryTree.FullRowSelect = true;
            this.categoryTree.HideSelection = false;
            this.categoryTree.HotTracking = true;
            this.categoryTree.Location = new System.Drawing.Point(9, 94);
            this.categoryTree.Name = "categoryTree";
            this.categoryTree.ShowNodeToolTips = true;
            this.categoryTree.Size = new System.Drawing.Size(220, 90);
            this.categoryTree.TabIndex = 3;
            this.categoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // shopcategoriesBindingSource
            // 
            this.shopcategoriesBindingSource.DataMember = "shop_categories";
            this.shopcategoriesBindingSource.DataSource = this.mainDataset;
            this.shopcategoriesBindingSource.CurrentChanged += new System.EventHandler(this.shopcategoriesBindingSource_CurrentChanged);
            // 
            // mainDataset
            // 
            this.mainDataset.DataSetName = "mainDataset";
            this.mainDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(9, 476);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryImageButton
            // 
            this.categoryImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryImageButton.Location = new System.Drawing.Point(149, 349);
            this.categoryImageButton.Name = "categoryImageButton";
            this.categoryImageButton.Size = new System.Drawing.Size(52, 97);
            this.categoryImageButton.TabIndex = 7;
            this.categoryImageButton.Text = "Выбор файла";
            this.categoryImageButton.UseVisualStyleBackColor = true;
            this.categoryImageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Изображение категории";
            // 
            // categoryDesc
            // 
            this.categoryDesc.Location = new System.Drawing.Point(9, 217);
            this.categoryDesc.Name = "categoryDesc";
            this.categoryDesc.Size = new System.Drawing.Size(220, 97);
            this.categoryDesc.TabIndex = 5;
            this.categoryDesc.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание категории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Родительская категория";
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(9, 42);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(140, 20);
            this.categoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название категории";
            // 
            // categoryImageUploader
            // 
            this.categoryImageUploader.FileName = "categoryImageUploader";
            // 
            // shop_categoriesTableAdapter
            // 
            this.shop_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesListTree
            // 
            this.categoriesListTree.HideSelection = false;
            this.categoriesListTree.Location = new System.Drawing.Point(6, 48);
            this.categoriesListTree.Name = "categoriesListTree";
            this.categoriesListTree.ShowPlusMinus = false;
            this.categoriesListTree.Size = new System.Drawing.Size(595, 451);
            this.categoriesListTree.TabIndex = 2;
            this.categoriesListTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.categoriesListTree_AfterSelect);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(87, 19);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(99, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // categoryListGroup
            // 
            this.categoryListGroup.Controls.Add(this.createButton);
            this.categoryListGroup.Controls.Add(this.deleteButton);
            this.categoryListGroup.Controls.Add(this.categoriesListTree);
            this.categoryListGroup.Controls.Add(this.editButton);
            this.categoryListGroup.Location = new System.Drawing.Point(259, 12);
            this.categoryListGroup.Name = "categoryListGroup";
            this.categoryListGroup.Size = new System.Drawing.Size(607, 510);
            this.categoryListGroup.TabIndex = 4;
            this.categoryListGroup.TabStop = false;
            this.categoryListGroup.Text = "Список категорй";
            // 
            // deleteButton
            // 
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(192, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(76, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // categoryId
            // 
            this.categoryId.Location = new System.Drawing.Point(155, 42);
            this.categoryId.Name = "categoryId";
            this.categoryId.Size = new System.Drawing.Size(74, 20);
            this.categoryId.TabIndex = 5;
            this.categoryId.Visible = false;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(6, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // AdminCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 534);
            this.Controls.Add(this.categoryListGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminCategories";
            this.Text = "Редактирование категорий - Acoustic Music Shop";
            this.Load += new System.EventHandler(this.AdminCategories_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopcategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataset)).EndInit();
            this.categoryListGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox categoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button categoryImageButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox categoryDesc;
        private System.Windows.Forms.OpenFileDialog categoryImageUploader;
        private System.Windows.Forms.Button saveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private mainDataset mainDataset;
        private System.Windows.Forms.BindingSource shopcategoriesBindingSource;
        private mainDatasetTableAdapters.shop_categoriesTableAdapter shop_categoriesTableAdapter;
        protected System.Windows.Forms.TreeView categoryTree;
        private System.Windows.Forms.PictureBox categoryImage;
        private System.Windows.Forms.TreeView categoriesListTree;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox categoryListGroup;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox categoryId;
        private System.Windows.Forms.Button createButton;
    }
}

