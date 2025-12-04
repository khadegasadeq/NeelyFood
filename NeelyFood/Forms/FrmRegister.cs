using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using NeelyFood.Models;


namespace NeelyFood
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // when rigister button clicked:
        private void button1_Click(object sender, EventArgs e)
        {
            // التأكد من مطابقة الباسورد
            if (txtPassword.Text != txtAgainPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (var context = new AppDbContext())
            {
                // التحقق من اسم المستخدم
                if (context.Users.Any(u => u.Username == txtUsername.Text))
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }

                // إنشاء مستخدم جديد
                var user = new User
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Role = "Customer" // دائمًا عميل عادي
                };

                context.Users.Add(user);
                context.SaveChanges();

                MessageBox.Show("Account created successfully!");
                this.Close();
            }
        }
        

        private void cmbBoxLoginAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length < 8)
            {
                lblPassword.Text = "Password must be at least 8 characters";
                lblPassword.ForeColor = Color.Red;
            }
            else
            {
                lblPassword.Text = ""; // لا يوجد تحذير إذا الطول صحيح
            }
        }

        // رفاس 
        private void txtAgainPassword_TextChanged(object sender, EventArgs e)
        {
            // تحقق إذا النصين متطابقين
            if (txtAgainPassword.Text != txtPassword.Text)
            {
                lblPassword.Text = "Passwords do not match"; // رسالة تحذير
                lblPassword.ForeColor = Color.Red;
            }
            else
            {
                lblPassword.Text = "Passwords match"; // رسالة نجاح
                lblPassword.ForeColor = Color.Green;
            }
        }


    }
}
