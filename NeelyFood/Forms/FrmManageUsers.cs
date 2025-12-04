using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NeelyFood.Models;

namespace NeelyFood
{
    public partial class FrmManageUsers : Form
    {
        public FrmManageUsers()
        {
            InitializeComponent();
        }

        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers(string search = "")
        {
            using (var context = new AppDbContext())
            {
                var usersQuery = context.Users.AsQueryable();

                if (!string.IsNullOrEmpty(search))
                {
                    search = search.ToLower();
                    usersQuery = usersQuery.Where(u => u.Username.ToLower().Contains(search) || u.Role.ToLower().Contains(search));
                }

                var users = usersQuery
                            .Select(u => new
                            {
                                u.Id,
                                u.Username,
                                u.Password,
                                u.Role
                            })
                            .ToList();

                dgvUsers.DataSource = null;
                dgvUsers.Columns.Clear();

                // ترقيم تلقائي
                DataGridViewTextBoxColumn colNo = new DataGridViewTextBoxColumn();
                colNo.Name = "No";
                colNo.HeaderText = "رقم";
                colNo.Width = 50;
                dgvUsers.Columns.Add(colNo);

                // اسم المستخدم
                DataGridViewTextBoxColumn colUsername = new DataGridViewTextBoxColumn();
                colUsername.Name = "Username";
                colUsername.HeaderText = "اسم المستخدم";
                colUsername.DataPropertyName = "Username";
                dgvUsers.Columns.Add(colUsername);

                // كلمة المرور مخفية
                DataGridViewTextBoxColumn colPassword = new DataGridViewTextBoxColumn();
                colPassword.Name = "Password";
                colPassword.HeaderText = "كلمة المرور";
                colPassword.DataPropertyName = "Password";
                colPassword.Visible = false;
                dgvUsers.Columns.Add(colPassword);

                // ComboBox للدور
                DataGridViewComboBoxColumn colRole = new DataGridViewComboBoxColumn();
                colRole.Name = "RoleCombo";
                colRole.HeaderText = "الدور";
                colRole.DataPropertyName = "Role";
                colRole.Items.AddRange("Admin", "Customer");
                dgvUsers.Columns.Add(colRole);

                // زر حذف
                DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
                colDelete.Name = "DeleteButton";
                colDelete.HeaderText = "حذف المستخدم";
                colDelete.Text = "حذف";
                colDelete.UseColumnTextForButtonValue = true;
                colDelete.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                colDelete.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgvUsers.Columns.Add(colDelete);

                // ربط البيانات
                for (int i = 0; i < users.Count; i++)
                {
                    dgvUsers.Rows.Add();
                    dgvUsers.Rows[i].Cells["No"].Value = i + 1; // ترقيم يبدأ من 1
                    dgvUsers.Rows[i].Cells["Username"].Value = users[i].Username;
                    dgvUsers.Rows[i].Cells["Password"].Value = users[i].Password;
                    dgvUsers.Rows[i].Cells["RoleCombo"].Value = users[i].Role != null ? users[i].Role : "Customer";
                }

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.Columns[e.ColumnIndex].Name == "DeleteButton")
            {
                int rowNo = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["No"].Value);

                var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا المستخدم؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    using (var context = new AppDbContext())
                    {
                        // نبحث حسب Username لضمان التوافق مع الترقيم
                        string username = Convert.ToString(dgvUsers.Rows[e.RowIndex].Cells["Username"].Value);
                        var user = context.Users.FirstOrDefault(u => u.Username == username);
                        if (user != null)
                        {
                            context.Users.Remove(user);
                            context.SaveChanges();
                        }
                    }
                    LoadUsers(txtSearch.Text.Trim());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    if (row.IsNewRow) continue;

                    string username = Convert.ToString(row.Cells["Username"].Value);
                    string newRole = Convert.ToString(row.Cells["RoleCombo"].Value);

                    var user = context.Users.FirstOrDefault(u => u.Username == username);
                    if (user != null && !string.IsNullOrEmpty(newRole))
                    {
                        user.Role = newRole;                        
                    }
                }
                context.SaveChanges();
            }

            MessageBox.Show("تم حفظ التعديلات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUsers(txtSearch.Text.Trim());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // البحث التلقائي أثناء الكتابة
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim());
        }
    }
}
