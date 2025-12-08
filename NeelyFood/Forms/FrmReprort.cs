using System;
using System.Linq;
using System.Windows.Forms;
using NeelyFood.Models;

namespace NeelyFood
{
    public partial class FrmReport : Form
    {
        private AppDbContext db = new AppDbContext();

        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            tabControlReports.ForeColor = System.Drawing.Color.Gold;

            // تهيئة الـ DataGridViews
            LoadDailyOrders();
            LoadMonthlyOrders();
        }

        // ============================
        // تحميل الطلبات اليومية
        // ============================
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

            dgvDailyReport.DataSource = dailyOrders;
            FormatDataGridView(dgvDailyReport);
        }

        // ============================
        // تحميل الطلبات الشهرية
        // ============================
        private void LoadMonthlyOrders()
        {
            var monthlyOrders = db.Orders
                .Where(o => o.IsReservation == false)
                .GroupBy(o => o.OrderDate.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    TotalOrders = g.Count(),
                    TotalAmount = g.Sum(x => x.TotalAmount)
                })
                .ToList();

            dgvMonthlyReport.DataSource = monthlyOrders;
            FormatDataGridView(dgvMonthlyReport);
        }

        // ============================
        // تنسيق DataGridView
        // ============================
        private void FormatDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ForeColor = System.Drawing.Color.Black;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Gold;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmOrders orders = new FrmOrders();
            orders.Show();
            this.Close();
        }
    }
}
