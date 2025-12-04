using System.Drawing;
namespace NeelyFood
{
    partial class FrmCustomerPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMenuItems;
        private System.Windows.Forms.ListBox lstDailyCart;
        private System.Windows.Forms.ListBox lstReservationCart;
        private System.Windows.Forms.Label lblDailyTotal;
        private System.Windows.Forms.Label lblReservationTotal;
        private System.Windows.Forms.Button btnSubmitDailyOrder;
        private System.Windows.Forms.Button btnSubmitReservationOrder;
        private System.Windows.Forms.DateTimePicker dtpReservationDate;
        private System.Windows.Forms.Label lblDailyCart;
        private System.Windows.Forms.Label lblReservationCart;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAccountNumber;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMenuItems = new System.Windows.Forms.Panel();
            this.lstDailyCart = new System.Windows.Forms.ListBox();
            this.lstReservationCart = new System.Windows.Forms.ListBox();
            this.lblDailyTotal = new System.Windows.Forms.Label();
            this.lblReservationTotal = new System.Windows.Forms.Label();
            this.btnSubmitDailyOrder = new System.Windows.Forms.Button();
            this.btnSubmitReservationOrder = new System.Windows.Forms.Button();
            this.dtpReservationDate = new System.Windows.Forms.DateTimePicker();
            this.lblDailyCart = new System.Windows.Forms.Label();
            this.lblReservationCart = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlMenuItems
            // 
            this.pnlMenuItems.AutoScroll = true;
            this.pnlMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuItems.Location = new System.Drawing.Point(14, 65);
            this.pnlMenuItems.Name = "pnlMenuItems";
            this.pnlMenuItems.Size = new System.Drawing.Size(583, 568);
            this.pnlMenuItems.TabIndex = 0;
            // 
            // lstDailyCart
            // 
            this.lstDailyCart.FormattingEnabled = true;
            this.lstDailyCart.ItemHeight = 16;
            this.lstDailyCart.Location = new System.Drawing.Point(622, 65);
            this.lstDailyCart.Name = "lstDailyCart";
            this.lstDailyCart.Size = new System.Drawing.Size(291, 164);
            this.lstDailyCart.TabIndex = 2;
            // 
            // lstReservationCart
            // 
            this.lstReservationCart.FormattingEnabled = true;
            this.lstReservationCart.ItemHeight = 16;
            this.lstReservationCart.Location = new System.Drawing.Point(621, 386);
            this.lstReservationCart.Name = "lstReservationCart";
            this.lstReservationCart.Size = new System.Drawing.Size(291, 132);
            this.lstReservationCart.TabIndex = 6;
            // 
            // lblDailyTotal
            // 
            this.lblDailyTotal.AutoSize = true;
            this.lblDailyTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDailyTotal.ForeColor = System.Drawing.Color.White;
            this.lblDailyTotal.Location = new System.Drawing.Point(618, 244);
            this.lblDailyTotal.Name = "lblDailyTotal";
            this.lblDailyTotal.Size = new System.Drawing.Size(74, 17);
            this.lblDailyTotal.TabIndex = 3;
            this.lblDailyTotal.Text = "المجموع: 0";
            // 
            // lblReservationTotal
            // 
            this.lblReservationTotal.AutoSize = true;
            this.lblReservationTotal.ForeColor = System.Drawing.Color.White;
            this.lblReservationTotal.Location = new System.Drawing.Point(622, 684);
            this.lblReservationTotal.Name = "lblReservationTotal";
            this.lblReservationTotal.Size = new System.Drawing.Size(74, 17);
            this.lblReservationTotal.TabIndex = 7;
            this.lblReservationTotal.Text = "المجموع: 0";
            // 
            // btnSubmitDailyOrder
            // 
            this.btnSubmitDailyOrder.BackColor = System.Drawing.Color.Gold;
            this.btnSubmitDailyOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitDailyOrder.Location = new System.Drawing.Point(621, 305);
            this.btnSubmitDailyOrder.Name = "btnSubmitDailyOrder";
            this.btnSubmitDailyOrder.Size = new System.Drawing.Size(292, 37);
            this.btnSubmitDailyOrder.TabIndex = 4;
            this.btnSubmitDailyOrder.Text = "إرسال الطلب اليومي";
            this.btnSubmitDailyOrder.UseVisualStyleBackColor = false;
            this.btnSubmitDailyOrder.Click += new System.EventHandler(this.btnSubmitDailyOrder_Click);
            // 
            // btnSubmitReservationOrder
            // 
            this.btnSubmitReservationOrder.BackColor = System.Drawing.Color.Gold;
            this.btnSubmitReservationOrder.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitReservationOrder.Location = new System.Drawing.Point(625, 585);
            this.btnSubmitReservationOrder.Name = "btnSubmitReservationOrder";
            this.btnSubmitReservationOrder.Size = new System.Drawing.Size(292, 37);
            this.btnSubmitReservationOrder.TabIndex = 9;
            this.btnSubmitReservationOrder.Text = "إرسال الحجز المستقبلي";
            this.btnSubmitReservationOrder.UseVisualStyleBackColor = false;
            this.btnSubmitReservationOrder.Click += new System.EventHandler(this.btnSubmitReservationOrder_Click);
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReservationDate.Location = new System.Drawing.Point(625, 542);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(291, 24);
            this.dtpReservationDate.TabIndex = 8;
            // 
            // lblDailyCart
            // 
            this.lblDailyCart.AutoSize = true;
            this.lblDailyCart.ForeColor = System.Drawing.Color.Gold;
            this.lblDailyCart.Location = new System.Drawing.Point(618, 43);
            this.lblDailyCart.Name = "lblDailyCart";
            this.lblDailyCart.Size = new System.Drawing.Size(123, 17);
            this.lblDailyCart.TabIndex = 1;
            this.lblDailyCart.Text = "سلة الطلبات اليومية";
            // 
            // lblReservationCart
            // 
            this.lblReservationCart.AutoSize = true;
            this.lblReservationCart.ForeColor = System.Drawing.Color.Black;
            this.lblReservationCart.Location = new System.Drawing.Point(618, 356);
            this.lblReservationCart.Name = "lblReservationCart";
            this.lblReservationCart.Size = new System.Drawing.Size(161, 17);
            this.lblReservationCart.TabIndex = 5;
            this.lblReservationCart.Text = "سلة الحجوزات المستقبلية";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Coral;
            this.lblWelcome.Location = new System.Drawing.Point(36, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(130, 24);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "مرحبًا العميل";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(618, 275);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(89, 17);
            this.lblAccountNumber.TabIndex = 12;
            this.lblAccountNumber.Text = "رقم الحساب: ";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Location = new System.Drawing.Point(392, 26);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(205, 33);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = " تسجيل الدخول بحساب اخر";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(622, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "تاريخ الحجز";
            // 
            // FrmCustomerPanel
            // 
            this.ClientSize = new System.Drawing.Size(933, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSubmitReservationOrder);
            this.Controls.Add(this.dtpReservationDate);
            this.Controls.Add(this.lblReservationTotal);
            this.Controls.Add(this.lstReservationCart);
            this.Controls.Add(this.lblReservationCart);
            this.Controls.Add(this.btnSubmitDailyOrder);
            this.Controls.Add(this.lblDailyTotal);
            this.Controls.Add(this.lstDailyCart);
            this.Controls.Add(this.lblDailyCart);
            this.Controls.Add(this.pnlMenuItems);
            this.Name = "FrmCustomerPanel";
            this.Text = "لوحة العميل";
            this.Load += new System.EventHandler(this.FrmCustomerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
    }
}
