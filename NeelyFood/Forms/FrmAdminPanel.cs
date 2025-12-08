using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyMenuItems = NeelyFood.Forms.FrmMenuItems;


//
using NeelyFood.Models; // للوصول للكلاسات
using System.Data.Entity; // للعمل مع EF6

namespace NeelyFood
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();
        }

       private void BtnUsers_Click(object sender, EventArgs e)
        {
            FrmManageUsers frm = new FrmManageUsers();
            frm.ShowDialog();
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            MyMenuItems frm = new MyMenuItems();
            frm.ShowDialog();

            frm.ShowDialog();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }
        
           

        private void btOrders_Click(object sender, EventArgs e)
        {
             FrmOrders frm = new FrmOrders();
            frm.Show();
        
        }

        private void btnRepert_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();
            frm.Show();
        }

    }
}