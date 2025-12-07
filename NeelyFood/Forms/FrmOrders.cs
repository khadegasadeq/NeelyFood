using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NeelyFood.Models;

namespace NeelyFood
{
    public partial class FrmOrders : Form
    {
        private AppDbContext db = new AppDbContext();

        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            tabControl1.ForeColor = System.Drawing.Color.Gold;

            LoadDailyOrders();
            LoadReservationOrders();
        }

        private void LoadDailyOrders()
        {
            var dailyOrders = db.Orders
                .Where(o => o.IsReservation == false)
                .Select(o => new
                {
                    o.Id,
                    Customer = o.User.Username,
                    o.OrderDate,
                    o.TotalAmount,
                    o.Status
                })
                .ToList();

            dgvDailyOrders.DataSource = dailyOrders;
            dgvDailyOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDailyOrders.BackgroundColor = System.Drawing.Color.Black;
            dgvDailyOrders.ForeColor = System.Drawing.Color.Gold;
            dgvDailyOrders.EnableHeadersVisualStyles = false;
            dgvDailyOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkGoldenrod;
            dgvDailyOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        }

        private void LoadReservationOrders()
        {
            var reservationOrders = db.Orders
                .Where(o => o.IsReservation == true)
                .Select(o => new
                {
                    o.Id,
                    Customer = o.User.Username,
                    o.OrderDate,
                    o.ReservationDate,
                    o.TotalAmount,
                    o.Status
                })
                .ToList();

            dgvReservationOrders.DataSource = reservationOrders;
            dgvReservationOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationOrders.BackgroundColor = System.Drawing.Color.Black;
            dgvReservationOrders.ForeColor = System.Drawing.Color.Gold;
            dgvReservationOrders.EnableHeadersVisualStyles = false;
            dgvReservationOrders.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkGoldenrod;
            dgvReservationOrders.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }
    }
}
