    using System;
    using System.Data.Entity;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using NeelyFood.Models;
    using MyMenuItems = NeelyFood.Models.MenuItem;

    namespace NeelyFood.Forms
    {
        public partial class FrmMenuItems : Form
        {
            private AppDbContext db = new AppDbContext();
            private string categoryImagePath = "";
            private string itemImagePath = "";
            private Button btnShowCategoryImage = new Button();
            private Button btnShowItemImage = new Button();

            public FrmMenuItems()
            {
                InitializeComponent();
                InitializeCustomButtons();
                LoadCategories();
                LoadItems();
            }

            private void InitializeCustomButtons()
            {
                // زر عرض صورة القسم في DataGridView
                btnShowCategoryImage.Text = "عرض الصورة";
                btnShowCategoryImage.BackColor = Color.Gold;
                btnShowCategoryImage.ForeColor = Color.Black;
                btnShowCategoryImage.Location = new Point(526, 120);
                btnShowCategoryImage.Size = new Size(90, 33);
                btnShowCategoryImage.Click += btnShowCategoryImage_Click;
                tabPageCategories.Controls.Add(btnShowCategoryImage);

                // زر عرض صورة الصنف في DataGridView
                btnShowItemImage.Text = "عرض الصورة";
                btnShowItemImage.BackColor = Color.Gold;
                btnShowItemImage.ForeColor = Color.Black;
                btnShowItemImage.Location = new Point(385, 241);
                btnShowItemImage.Size = new Size(90, 32);
                btnShowItemImage.Click += btnShowItemImage_Click;
                tabPageItems.Controls.Add(btnShowItemImage);
            }

            #region Categories

            private void LoadCategories()
            {
                dgvCategories.DataSource = db.Categories
                                            .Select(c => new { c.Id, c.Name, c.ImagePath })
                                            .ToList();

                //dgvCategories.Columns["ImagePath"].Visible = false; // إخفاء عمود المسار

                cmbCategory.DataSource = db.Categories.ToList();
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
            }

            private void btnAddCategory_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("الرجاء إدخال اسم القسم!");
                    return;
                }

                // التحقق من وجود صورة
                if (string.IsNullOrEmpty(categoryImagePath))
                {
                    MessageBox.Show("الرجاء اختيار صورة للقسم!");
                    return;
                }

                Category cat = new Category
                {
                    Name = txtCategoryName.Text
                };

                // نسخ الصورة
                string destFolder = Path.Combine(Application.StartupPath, "Images", "Categories");
                Directory.CreateDirectory(destFolder);
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(categoryImagePath);
                string destFile = Path.Combine(destFolder, fileName);
                File.Copy(categoryImagePath, destFile, true);
                cat.ImagePath = destFile;

                db.Categories.Add(cat);
                db.SaveChanges();
            
                // إعادة تعيين الحقول
                txtCategoryName.Clear();
                categoryImagePath = "";
                picBoxCategory.Image = null;
                LoadCategories();
            
                MessageBox.Show("تمت إضافة القسم بنجاح!");
            }

            private void btnEditCategory_Click(object sender, EventArgs e)
            {
                if (dgvCategories.CurrentRow == null) return;

                int id = (int)dgvCategories.CurrentRow.Cells["Id"].Value;
                Category cat = db.Categories.Find(id);
                if (cat == null) return;

                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    MessageBox.Show("الرجاء إدخال اسم القسم!");
                    return;
                }

                cat.Name = txtCategoryName.Text;

                // إذا تم اختيار صورة جديدة
                if (!string.IsNullOrEmpty(categoryImagePath))
                {
                    string destFolder = Path.Combine(Application.StartupPath, "Images", "Categories");
                    Directory.CreateDirectory(destFolder);
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(categoryImagePath);
                    string destFile = Path.Combine(destFolder, fileName);
                    File.Copy(categoryImagePath, destFile, true);
                    cat.ImagePath = destFile;
                }

                db.SaveChanges();
                txtCategoryName.Clear();
                categoryImagePath = "";
                picBoxCategory.Image = null;
                LoadCategories();
            
                MessageBox.Show("تم تعديل القسم بنجاح!");
            }

            private void btnDeleteCategory_Click(object sender, EventArgs e)
            {
                if (dgvCategories.CurrentRow == null) return;

                int id = (int)dgvCategories.CurrentRow.Cells["Id"].Value;
                Category cat = db.Categories.Find(id);
                if (cat == null) return;

                if (MessageBox.Show("هل أنت متأكد من حذف هذا القسم؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                    LoadCategories();
                    MessageBox.Show("تم حذف القسم بنجاح!");
                }
            }

            private void btnSelectCategoryImage_Click(object sender, EventArgs e)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "الصور|*.jpg;*.jpeg;*.png;*.bmp|كل الملفات|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    categoryImagePath = dlg.FileName;
                    picBoxCategory.Image = Image.FromFile(categoryImagePath);
                }
            }

            private void btnShowCategoryImage_Click(object sender, EventArgs e)
            {
                if (dgvCategories.CurrentRow == null)
                {
                    MessageBox.Show("الرجاء اختيار قسم من القائمة!");
                    return;
                }

                string path = dgvCategories.CurrentRow.Cells["ImagePath"].Value as string;
                ShowImage(path, "صورة القسم");
            }

            #endregion

            #region Items

            private void LoadItems()
            {
                dgvItems.DataSource = db.MenuItems.Include(i => i.Category)
                                            .Select(i => new
                                            {
                                                i.Id,
                                                i.Name,
                                                i.Price,
                                                i.Quantity,
                                                Availability = i.IsAvailable ? "متوفر" : "غير متوفر",
                                                Category = i.Category.Name,
                                                i.ImagePath
                                            })
                                            .ToList();
                dgvItems.Columns["ImagePath"].Visible = false; // إخفاء عمود المسار
            }

            private void btnAddItem_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtItemName.Text))
                {
                    MessageBox.Show("الرجاء إدخال اسم الصنف!");
                    return;
                }

                if (cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show("الرجاء اختيار القسم!");
                    return;
                }

                // التحقق من وجود صورة
                if (string.IsNullOrEmpty(itemImagePath))
                {
                    MessageBox.Show("الرجاء اختيار صورة للصنف!");
                    return;
                }

                MyMenuItems item = new MyMenuItems
                {
                    Name = txtItemName.Text,
                    Price = nudPrice.Value,
                    Quantity = (int)nudQuantity.Value,
                    IsAvailable = (cmbAvailability.SelectedItem != null && cmbAvailability.SelectedItem.ToString().Trim() == "متوفر"),
                    CategoryId = ((Category)cmbCategory.SelectedItem).Id
                };

                // نسخ الصورة
                string destFolder = Path.Combine(Application.StartupPath, "Images", "MenuItems");
                Directory.CreateDirectory(destFolder);
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(itemImagePath);
                string destFile = Path.Combine(destFolder, fileName);
                File.Copy(itemImagePath, destFile, true);
                item.ImagePath = destFile;

                db.MenuItems.Add(item);
                db.SaveChanges();
                ClearItemFields();
                LoadItems();
            
                MessageBox.Show("تمت إضافة الصنف بنجاح!");
            }

            private void btnEditItem_Click(object sender, EventArgs e)
            {
                if (dgvItems.CurrentRow == null) return;

                int id = (int)dgvItems.CurrentRow.Cells["Id"].Value;
                MyMenuItems item = db.MenuItems.Find(id);
                if (item == null) return;

                if (string.IsNullOrWhiteSpace(txtItemName.Text))
                {
                    MessageBox.Show("الرجاء إدخال اسم الصنف!");
                    return;
                }

                item.Name = txtItemName.Text;
                item.Price = nudPrice.Value;
                item.Quantity = (int)nudQuantity.Value;
                item.IsAvailable = (cmbAvailability.SelectedItem != null && cmbAvailability.SelectedItem.ToString().Trim() == "متوفر");
                item.CategoryId = ((Category)cmbCategory.SelectedItem).Id;

                // إذا تم اختيار صورة جديدة
                if (!string.IsNullOrEmpty(itemImagePath))
                {
                    string destFolder = Path.Combine(Application.StartupPath, "Images", "MenuItems");
                    Directory.CreateDirectory(destFolder);
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(itemImagePath);
                    string destFile = Path.Combine(destFolder, fileName);
                    File.Copy(itemImagePath, destFile, true);
                    item.ImagePath = destFile;
                }

                db.SaveChanges();
                ClearItemFields();
                LoadItems();
            
                MessageBox.Show("تم تعديل الصنف بنجاح!");
            }

            private void btnDeleteItem_Click(object sender, EventArgs e)
            {
                if (dgvItems.CurrentRow == null) return;

                int id = (int)dgvItems.CurrentRow.Cells["Id"].Value;
                MyMenuItems item = db.MenuItems.Find(id);
                if (item == null) return;

                if (MessageBox.Show("هل أنت متأكد من حذف هذا الصنف؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.MenuItems.Remove(item);
                    db.SaveChanges();
                    LoadItems();
                    MessageBox.Show("تم حذف الصنف بنجاح!");
                }
            }

            private void btnSelectImage_Click(object sender, EventArgs e)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "الصور|*.jpg;*.jpeg;*.png;*.bmp|كل الملفات|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    itemImagePath = dlg.FileName;
                    picBoxItem.Image = Image.FromFile(itemImagePath);
                }
            }

            private void btnShowItemImage_Click(object sender, EventArgs e)
            {
                if (dgvItems.CurrentRow == null)
                {
                    MessageBox.Show("الرجاء اختيار صنف من القائمة!");
                    return;
                }

                string path = dgvItems.CurrentRow.Cells["ImagePath"].Value as string;
                ShowImage(path, "صورة الصنف");
            }

            private void ClearItemFields()
            {
                txtItemName.Clear();
                nudPrice.Value = 0;
                nudQuantity.Value = 0;
                cmbAvailability.SelectedIndex = -1;
                cmbCategory.SelectedIndex = -1;
                picBoxItem.Image = null;
                itemImagePath = "";
            }

            #endregion

            #region Utility Methods

            private void ShowImage(string imagePath, string title)
            {
                if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                {
                    MessageBox.Show("الصورة غير متوفرة!");
                    return;
                }

                try
                {
                    Form imageForm = new Form();
                    imageForm.Text = title;
                    imageForm.StartPosition = FormStartPosition.CenterScreen;
                    imageForm.Size = new Size(500, 500);
                    imageForm.BackColor = Color.Black;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = Image.FromFile(imagePath);

                    imageForm.Controls.Add(pictureBox);
                    imageForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ في عرض الصورة: "+ex.Message);
                }
            }

            private void btnNavigateToItems_Click(object sender, EventArgs e)
            {
                tabControlMain.SelectedTab = tabPageItems;
            }

            private void btnNavigateToCategories_Click(object sender, EventArgs e)
            {
                tabControlMain.SelectedTab = tabPageCategories;
            }

            #endregion

            private void lblImagePreview_Click(object sender, EventArgs e)
            {

            }

            private void cmbAvailability_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }