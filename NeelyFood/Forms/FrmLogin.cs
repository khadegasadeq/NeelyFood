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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // when login clicked
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
        {
            var user = context.Users
                .FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show("Welcome !" + user.Username +" Role: " + user.Role);
                this.Hide();

                // فتح الفورم المناسب بناءً على الدور
                if (user.Role == "Admin")
                    new FrmAdminPanel().Show();
                else
                    new FrmCustomerPanel().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
        }

        private void cmbBoxLoginAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create a new instance of the registration form
            FrmRegister registerForm = new FrmRegister();

            // Show the form
            registerForm.Show();

            // or
           //  new FrmRegister().Show();

            // Using Show(): opens the form as non-modal,
            // user can switch between this form and the previous form freely.

            // If you use ShowDialog() instead:
            // ShowDialog() opens the form as modal,
            // user must close it before returning to the previous form.

            // Optionally hide the current (Login) form
            // this.Hide(); // or this.Close(); free re
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // تحقق من طول النص
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


    }
}
