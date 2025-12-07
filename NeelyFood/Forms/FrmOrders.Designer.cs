namespace NeelyFood
{
    partial class FrmOrders
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDailyOrders;
        private System.Windows.Forms.TabPage tabReservationOrders;
        private System.Windows.Forms.DataGridView dgvDailyOrders;
        private System.Windows.Forms.DataGridView dgvReservationOrders;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDailyOrders = new System.Windows.Forms.TabPage();
            this.dgvDailyOrders = new System.Windows.Forms.DataGridView();
            this.tabReservationOrders = new System.Windows.Forms.TabPage();
            this.dgvReservationOrders = new System.Windows.Forms.DataGridView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDailyOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyOrders)).BeginInit();
            this.tabReservationOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDailyOrders);
            this.tabControl1.Controls.Add(this.tabReservationOrders);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDailyOrders
            // 
            this.tabDailyOrders.BackColor = System.Drawing.Color.Black;
            this.tabDailyOrders.Controls.Add(this.dgvDailyOrders);
            this.tabDailyOrders.Location = new System.Drawing.Point(4, 25);
            this.tabDailyOrders.Name = "tabDailyOrders";
            this.tabDailyOrders.Size = new System.Drawing.Size(892, 465);
            this.tabDailyOrders.TabIndex = 0;
            this.tabDailyOrders.Text = "الطلبات اليومية";
            // 
            // dgvDailyOrders
            // 
            this.dgvDailyOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDailyOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvDailyOrders.Name = "dgvDailyOrders";
            this.dgvDailyOrders.Size = new System.Drawing.Size(892, 465);
            this.dgvDailyOrders.TabIndex = 0;
            // 
            // tabReservationOrders
            // 
            this.tabReservationOrders.BackColor = System.Drawing.Color.Black;
            this.tabReservationOrders.Controls.Add(this.dgvReservationOrders);
            this.tabReservationOrders.Location = new System.Drawing.Point(4, 25);
            this.tabReservationOrders.Name = "tabReservationOrders";
            this.tabReservationOrders.Size = new System.Drawing.Size(892, 465);
            this.tabReservationOrders.TabIndex = 1;
            this.tabReservationOrders.Text = "الحجوزات المستقبلية";
            // 
            // dgvReservationOrders
            // 
            this.dgvReservationOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservationOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvReservationOrders.Name = "dgvReservationOrders";
            this.dgvReservationOrders.Size = new System.Drawing.Size(892, 465);
            this.dgvReservationOrders.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Location = new System.Drawing.Point(700, 512);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(205, 33);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = " تسجيل الدخول بحساب اخر";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmOrders
            // 
            this.ClientSize = new System.Drawing.Size(924, 562);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmOrders";
            this.Text = "إدارة الطلبات";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDailyOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyOrders)).EndInit();
            this.tabReservationOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationOrders)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnLogin;
    }
}
