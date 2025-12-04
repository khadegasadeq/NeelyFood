using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NeelyFood.Models;

namespace NeelyFood
{
    public partial class FrmCustomerPanel : Form
    {
        public int CurrentUserId; 

        private AppDbContext db = new AppDbContext();

        // سلتان
        private List<OrderItem> dailyCart = new List<OrderItem>();
        private List<OrderItem> reservationCart = new List<OrderItem>();

        public string CustomerName = ""; // تضع اسم العميل عند تسجيل الدخول

        public FrmCustomerPanel()
        {
            InitializeComponent();
        }

        private void FrmCustomerPanel_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            lblWelcome.ForeColor = Color.Gold;
            lblAccountNumber.ForeColor = Color.Gold;

            lblWelcome.Text = "مرحبًا " + CustomerName;
            lblAccountNumber.Text = "رقم الحساب: 123456789"; // رقم افتراضي يمكنك تغييره
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            pnlMenuItems.Controls.Clear();

            // جلب كل الأصناف من قاعدة البيانات
            var menuItems = db.MenuItems.ToList();

            int x = 10;
            int y = 10;
            int cardWidth = 150;
            int cardHeight = 200;
            int margin = 10;

            foreach (var item in menuItems)
            {
                Panel card = new Panel
                {
                    Width = cardWidth,
                    Height = cardHeight,
                    BackColor = Color.DarkGoldenrod,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = item
                };

                // اسم الصنف
                Label lblName = new Label
                {
                    Text = item.Name,
                    Location = new Point(5, 5),
                    AutoSize = false,
                    Width = cardWidth - 10,
                    Height = 40,
                    ForeColor = Color.White
                };

                // السعر
                Label lblPrice = new Label
                {
                    Text = "السعر: " + item.Price,
                    Location = new Point(5, 50),
                    AutoSize = false,
                    Width = cardWidth - 10,
                    Height = 20,
                    ForeColor = Color.White
                };

                // حالة التوفر
                Label lblAvailable = new Label
                {
                    Text = item.IsAvailable ? "متوفر" : "غير متوفر",
                    Location = new Point(5, 75),
                    AutoSize = false,
                    Width = cardWidth - 10,
                    Height = 20,
                    ForeColor = item.IsAvailable ? Color.Green : Color.Red
                };

                // زر إضافة للسلة اليومية
                Button btnAddDaily = new Button
                {
                    Text = "إضافة يومي",
                    Location = new Point(5, 100),
                    Width = cardWidth - 10,
                    BackColor = Color.Gold,
                    ForeColor = Color.Black
                };
                btnAddDaily.Click += BtnAddDaily_Click;

                // زر إضافة للحجز
                Button btnAddReservation = new Button
                {
                    Text = "حجز مستقبلي",
                    Location = new Point(5, 140),
                    Width = cardWidth - 10,
                    BackColor = Color.Gold,
                    ForeColor = Color.Black
                };
                btnAddReservation.Click += BtnAddReservation_Click;

                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblAvailable);
                card.Controls.Add(btnAddDaily);
                card.Controls.Add(btnAddReservation);

                pnlMenuItems.Controls.Add(card);

                // ترتيب البطاقات
                card.Location = new Point(x, y);
                x += cardWidth + margin;
                if (x + cardWidth > pnlMenuItems.Width)
                {
                    x = 10;
                    y += cardHeight + margin;
                }
            }
        }

        private void BtnAddDaily_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel card = btn.Parent as Panel;
            NeelyFood.Models.MenuItem item = card.Tag as NeelyFood.Models.MenuItem;

            if (!item.IsAvailable)
            {
                MessageBox.Show("هذا الصنف غير متوفر اليوم.");
                return;
            }

            dailyCart.Add(new OrderItem
            {
                MenuItemId = item.Id,
                Quantity = 1,
                Price = item.Price
            });

            UpdateDailyCart();
        }

        private void BtnAddReservation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel card = btn.Parent as Panel;
            NeelyFood.Models.MenuItem item = card.Tag as NeelyFood.Models.MenuItem;

            reservationCart.Add(new OrderItem
            {
                MenuItemId = item.Id,
                Quantity = 1,
                Price = item.Price
            });

            UpdateReservationCart();
        }

        private void UpdateDailyCart()
        {
            lstDailyCart.Items.Clear();
            foreach (var oi in dailyCart)
            {
                var menu = db.MenuItems.Find(oi.MenuItemId);
                lstDailyCart.Items.Add(menu.Name + " - " + oi.Quantity + " × " + oi.Price);
            }

            lblDailyTotal.Text = "المجموع: " + dailyCart.Sum(o => o.Quantity * o.Price);
        }

        private void UpdateReservationCart()
        {
            lstReservationCart.Items.Clear();
            foreach (var oi in reservationCart)
            {
                var menu = db.MenuItems.Find(oi.MenuItemId);
                lstReservationCart.Items.Add(menu.Name + " - " + oi.Quantity + " × " + oi.Price);
            }

            lblReservationTotal.Text = "المجموع: " + reservationCart.Sum(o => o.Quantity * o.Price);
        }

        private void btnSubmitDailyOrder_Click(object sender, EventArgs e)
        {
            if (dailyCart.Count == 0)
            {
                MessageBox.Show("السلة فارغة.");
                return;
            }

            Order order = new Order
            {
                UserId = CurrentUserId, 
                OrderDate = DateTime.Now,
                IsReservation = false,
                TotalAmount = dailyCart.Sum(o => o.Quantity * o.Price),
                Status = "Pending",
                OrderItems = dailyCart.ToList()
            };

            db.Orders.Add(order);
            db.SaveChanges();

            dailyCart.Clear();
            UpdateDailyCart();
            MessageBox.Show("تم إرسال الطلب اليومي بنجاح.");
        }

        private void btnSubmitReservationOrder_Click(object sender, EventArgs e)
        {
            if (reservationCart.Count == 0)
            {
                MessageBox.Show("سلة الحجز فارغة.");
                return;
            }

            Order order = new Order
            {
                UserId = CurrentUserId, 
                OrderDate = DateTime.Now,
                IsReservation = true,
                TotalAmount = reservationCart.Sum(o => o.Quantity * o.Price),
                Status = "Pending",
                ReservationDate = dtpReservationDate.Value,
                OrderItems = reservationCart.ToList()
            };

            db.Orders.Add(order);
            db.SaveChanges();

            reservationCart.Clear();
            UpdateReservationCart();
            MessageBox.Show("تم إرسال الحجز المستقبلي بنجاح.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
