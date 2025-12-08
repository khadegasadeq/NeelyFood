using System.Drawing;

namespace NeelyFood.Forms
{
    partial class FrmMenuItems
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuItems));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSelectCategoryImage = new System.Windows.Forms.Button();
            this.picBoxCategory = new System.Windows.Forms.PictureBox();
            this.btnNavigateToItems = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryImage = new System.Windows.Forms.Label();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNavigateToCategories = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbAvailability = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.picBoxItem = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblImagePreview = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.tabPageItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCategories);
            this.tabControlMain.Controls.Add(this.tabPageItems);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlMain.RightToLeftLayout = true;
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(850, 650);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.BackColor = System.Drawing.Color.Black;
            this.tabPageCategories.Controls.Add(this.picLogo);
            this.tabPageCategories.Controls.Add(this.btnSelectCategoryImage);
            this.tabPageCategories.Controls.Add(this.picBoxCategory);
            this.tabPageCategories.Controls.Add(this.btnNavigateToItems);
            this.tabPageCategories.Controls.Add(this.dgvCategories);
            this.tabPageCategories.Controls.Add(this.txtCategoryName);
            this.tabPageCategories.Controls.Add(this.btnAddCategory);
            this.tabPageCategories.Controls.Add(this.btnEditCategory);
            this.tabPageCategories.Controls.Add(this.btnDeleteCategory);
            this.tabPageCategories.Controls.Add(this.lblCategoryName);
            this.tabPageCategories.Controls.Add(this.lblCategoryImage);
            this.tabPageCategories.ForeColor = System.Drawing.Color.White;
            this.tabPageCategories.Location = new System.Drawing.Point(4, 29);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(842, 617);
            this.tabPageCategories.TabIndex = 0;
            this.tabPageCategories.Text = "الأقسام";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(710, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(124, 130);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // btnSelectCategoryImage
            // 
            this.btnSelectCategoryImage.BackColor = System.Drawing.Color.Gold;
            this.btnSelectCategoryImage.ForeColor = System.Drawing.Color.Black;
            this.btnSelectCategoryImage.Location = new System.Drawing.Point(100, 154);
            this.btnSelectCategoryImage.Name = "btnSelectCategoryImage";
            this.btnSelectCategoryImage.Size = new System.Drawing.Size(160, 33);
            this.btnSelectCategoryImage.TabIndex = 7;
            this.btnSelectCategoryImage.Text = "اختيار صورة القسم";
            this.btnSelectCategoryImage.UseVisualStyleBackColor = false;
            this.btnSelectCategoryImage.Click += new System.EventHandler(this.btnSelectCategoryImage_Click);
            // 
            // picBoxCategory
            // 
            this.picBoxCategory.BackColor = System.Drawing.Color.White;
            this.picBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxCategory.Location = new System.Drawing.Point(100, 50);
            this.picBoxCategory.Name = "picBoxCategory";
            this.picBoxCategory.Size = new System.Drawing.Size(160, 98);
            this.picBoxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCategory.TabIndex = 6;
            this.picBoxCategory.TabStop = false;
            // 
            // btnNavigateToItems
            // 
            this.btnNavigateToItems.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavigateToItems.ForeColor = System.Drawing.Color.White;
            this.btnNavigateToItems.Location = new System.Drawing.Point(101, 198);
            this.btnNavigateToItems.Name = "btnNavigateToItems";
            this.btnNavigateToItems.Size = new System.Drawing.Size(160, 33);
            this.btnNavigateToItems.TabIndex = 8;
            this.btnNavigateToItems.Text = "الانتقال للأصناف";
            this.btnNavigateToItems.UseVisualStyleBackColor = false;
            this.btnNavigateToItems.Click += new System.EventHandler(this.btnNavigateToItems_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(300, 246);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(500, 350);
            this.dgvCategories.TabIndex = 0;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(300, 80);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(400, 27);
            this.txtCategoryName.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.Gold;
            this.btnAddCategory.ForeColor = System.Drawing.Color.Black;
            this.btnAddCategory.Location = new System.Drawing.Point(328, 113);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(108, 33);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "اضافة القسم";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.Gold;
            this.btnEditCategory.ForeColor = System.Drawing.Color.Black;
            this.btnEditCategory.Location = new System.Drawing.Point(386, 152);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(75, 33);
            this.btnEditCategory.TabIndex = 3;
            this.btnEditCategory.Text = "تعديل";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Gold;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCategory.Location = new System.Drawing.Point(300, 152);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "حذف";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.Color.Gold;
            this.lblCategoryName.Location = new System.Drawing.Point(626, 57);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(78, 20);
            this.lblCategoryName.TabIndex = 5;
            this.lblCategoryName.Text = "اسم القسم";
            // 
            // lblCategoryImage
            // 
            this.lblCategoryImage.AutoSize = true;
            this.lblCategoryImage.ForeColor = System.Drawing.Color.Gold;
            this.lblCategoryImage.Location = new System.Drawing.Point(141, 27);
            this.lblCategoryImage.Name = "lblCategoryImage";
            this.lblCategoryImage.Size = new System.Drawing.Size(88, 20);
            this.lblCategoryImage.TabIndex = 9;
            this.lblCategoryImage.Text = "صورة القسم";
            // 
            // tabPageItems
            // 
            this.tabPageItems.BackColor = System.Drawing.Color.Black;
            this.tabPageItems.Controls.Add(this.pictureBox1);
            this.tabPageItems.Controls.Add(this.btnNavigateToCategories);
            this.tabPageItems.Controls.Add(this.dgvItems);
            this.tabPageItems.Controls.Add(this.txtItemName);
            this.tabPageItems.Controls.Add(this.nudPrice);
            this.tabPageItems.Controls.Add(this.nudQuantity);
            this.tabPageItems.Controls.Add(this.cmbAvailability);
            this.tabPageItems.Controls.Add(this.cmbCategory);
            this.tabPageItems.Controls.Add(this.picBoxItem);
            this.tabPageItems.Controls.Add(this.btnSelectImage);
            this.tabPageItems.Controls.Add(this.btnAddItem);
            this.tabPageItems.Controls.Add(this.btnEditItem);
            this.tabPageItems.Controls.Add(this.btnDeleteItem);
            this.tabPageItems.Controls.Add(this.lblItemName);
            this.tabPageItems.Controls.Add(this.lblPrice);
            this.tabPageItems.Controls.Add(this.lblQuantity);
            this.tabPageItems.Controls.Add(this.lblAvailability);
            this.tabPageItems.Controls.Add(this.lblCategory);
            this.tabPageItems.Controls.Add(this.lblImagePreview);
            this.tabPageItems.ForeColor = System.Drawing.Color.White;
            this.tabPageItems.Location = new System.Drawing.Point(4, 29);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(842, 617);
            this.tabPageItems.TabIndex = 1;
            this.tabPageItems.Text = "الأصناف";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(731, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnNavigateToCategories
            // 
            this.btnNavigateToCategories.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNavigateToCategories.ForeColor = System.Drawing.Color.White;
            this.btnNavigateToCategories.Location = new System.Drawing.Point(133, 228);
            this.btnNavigateToCategories.Name = "btnNavigateToCategories";
            this.btnNavigateToCategories.Size = new System.Drawing.Size(160, 33);
            this.btnNavigateToCategories.TabIndex = 17;
            this.btnNavigateToCategories.Text = "الانتقال للأقسام";
            this.btnNavigateToCategories.UseVisualStyleBackColor = false;
            this.btnNavigateToCategories.Click += new System.EventHandler(this.btnNavigateToCategories_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(71, 279);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(700, 280);
            this.dgvItems.TabIndex = 0;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(462, 50);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(250, 27);
            this.txtItemName.TabIndex = 1;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(510, 84);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(100, 27);
            this.nudPrice.TabIndex = 2;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(510, 117);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(100, 27);
            this.nudQuantity.TabIndex = 3;
            // 
            // cmbAvailability
            // 
            this.cmbAvailability.Items.AddRange(new object[] {
            "متوفر",
            "غير متوفر"});
            this.cmbAvailability.Location = new System.Drawing.Point(462, 152);
            this.cmbAvailability.Name = "cmbAvailability";
            this.cmbAvailability.Size = new System.Drawing.Size(150, 28);
            this.cmbAvailability.TabIndex = 4;
            this.cmbAvailability.SelectedIndexChanged += new System.EventHandler(this.cmbAvailability_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new System.Drawing.Point(462, 185);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 28);
            this.cmbCategory.TabIndex = 5;
            // 
            // picBoxItem
            // 
            this.picBoxItem.BackColor = System.Drawing.Color.White;
            this.picBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxItem.Location = new System.Drawing.Point(133, 62);
            this.picBoxItem.Name = "picBoxItem";
            this.picBoxItem.Size = new System.Drawing.Size(160, 120);
            this.picBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxItem.TabIndex = 6;
            this.picBoxItem.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.Gold;
            this.btnSelectImage.ForeColor = System.Drawing.Color.Black;
            this.btnSelectImage.Location = new System.Drawing.Point(133, 188);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(160, 34);
            this.btnSelectImage.TabIndex = 7;
            this.btnSelectImage.Text = "اختيار صورة الصنف";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Gold;
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.Location = new System.Drawing.Point(649, 241);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(122, 32);
            this.btnAddItem.TabIndex = 8;
            this.btnAddItem.Text = "اضافة الصنف";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.Gold;
            this.btnEditItem.ForeColor = System.Drawing.Color.Black;
            this.btnEditItem.Location = new System.Drawing.Point(568, 241);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(75, 32);
            this.btnEditItem.TabIndex = 9;
            this.btnEditItem.Text = "تعديل";
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Gold;
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteItem.Location = new System.Drawing.Point(488, 241);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 32);
            this.btnDeleteItem.TabIndex = 10;
            this.btnDeleteItem.Text = "حذف";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.ForeColor = System.Drawing.Color.Gold;
            this.lblItemName.Location = new System.Drawing.Point(625, 23);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(100, 23);
            this.lblItemName.TabIndex = 11;
            this.lblItemName.Text = "اسم الصنف";
            // 
            // lblPrice
            // 
            this.lblPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblPrice.Location = new System.Drawing.Point(616, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(100, 23);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "السعر";
            // 
            // lblQuantity
            // 
            this.lblQuantity.ForeColor = System.Drawing.Color.Gold;
            this.lblQuantity.Location = new System.Drawing.Point(616, 121);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 23);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "الكمية";
            // 
            // lblAvailability
            // 
            this.lblAvailability.ForeColor = System.Drawing.Color.Gold;
            this.lblAvailability.Location = new System.Drawing.Point(625, 155);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(100, 23);
            this.lblAvailability.TabIndex = 14;
            this.lblAvailability.Text = "حالة التوفر";
            // 
            // lblCategory
            // 
            this.lblCategory.ForeColor = System.Drawing.Color.Gold;
            this.lblCategory.Location = new System.Drawing.Point(625, 188);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "القسم";
            // 
            // lblImagePreview
            // 
            this.lblImagePreview.ForeColor = System.Drawing.Color.Gold;
            this.lblImagePreview.Location = new System.Drawing.Point(175, 36);
            this.lblImagePreview.Name = "lblImagePreview";
            this.lblImagePreview.Size = new System.Drawing.Size(100, 23);
            this.lblImagePreview.TabIndex = 16;
            this.lblImagePreview.Text = "معاينة الصورة";
            this.lblImagePreview.Click += new System.EventHandler(this.lblImagePreview_Click);
            // 
            // FrmMenuItems
            // 
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FrmMenuItems";
            this.Text = "إدارة الأقسام والأصناف";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCategories.ResumeLayout(false);
            this.tabPageCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.tabPageItems.ResumeLayout(false);
            this.tabPageItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.PictureBox picBoxItem;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblImagePreview;
        private System.Windows.Forms.Button btnSelectCategoryImage;
        private System.Windows.Forms.PictureBox picBoxCategory;
        private System.Windows.Forms.Label lblCategoryImage;
        private System.Windows.Forms.Button btnNavigateToItems;
        private System.Windows.Forms.Button btnNavigateToCategories;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}