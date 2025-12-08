namespace NeelyFood
{
    partial class FrmReport
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.DataGridView dgvDailyReport;
        private System.Windows.Forms.DataGridView dgvMonthlyReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDailyTitle;
        private System.Windows.Forms.Label lblMonthlyTitle;

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
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.lblDailyTitle = new System.Windows.Forms.Label();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.dgvMonthlyReport = new System.Windows.Forms.DataGridView();
            this.lblMonthlyTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControlReports.SuspendLayout();
            this.tabDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            this.tabMonthly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabDaily);
            this.tabControlReports.Controls.Add(this.tabMonthly);
            this.tabControlReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(760, 390);
            this.tabControlReports.TabIndex = 0;
            // 
            // tabDaily
            // 
            this.tabDaily.BackColor = System.Drawing.Color.Black;
            this.tabDaily.Controls.Add(this.lblDailyTitle);
            this.tabDaily.Controls.Add(this.dgvDailyReport);
            this.tabDaily.Location = new System.Drawing.Point(4, 22);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(752, 364);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily Report";
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.Location = new System.Drawing.Point(6, 50);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.Size = new System.Drawing.Size(740, 300);
            this.dgvDailyReport.TabIndex = 0;
            // 
            // lblDailyTitle
            // 
            this.lblDailyTitle.AutoSize = true;
            this.lblDailyTitle.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.lblDailyTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblDailyTitle.Location = new System.Drawing.Point(6, 10);
            this.lblDailyTitle.Name = "lblDailyTitle";
            this.lblDailyTitle.Size = new System.Drawing.Size(182, 37);
            this.lblDailyTitle.TabIndex = 1;
            this.lblDailyTitle.Text = "DAILY REPORT";
            // 
            // tabMonthly
            // 
            this.tabMonthly.BackColor = System.Drawing.Color.Black;
            this.tabMonthly.Controls.Add(this.lblMonthlyTitle);
            this.tabMonthly.Controls.Add(this.dgvMonthlyReport);
            this.tabMonthly.Location = new System.Drawing.Point(4, 22);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthly.Size = new System.Drawing.Size(752, 364);
            this.tabMonthly.TabIndex = 1;
            this.tabMonthly.Text = "Monthly Report";
            // 
            // dgvMonthlyReport
            // 
            this.dgvMonthlyReport.Location = new System.Drawing.Point(6, 50);
            this.dgvMonthlyReport.Name = "dgvMonthlyReport";
            this.dgvMonthlyReport.Size = new System.Drawing.Size(740, 300);
            this.dgvMonthlyReport.TabIndex = 0;
            // 
            // lblMonthlyTitle
            // 
            this.lblMonthlyTitle.AutoSize = true;
            this.lblMonthlyTitle.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.lblMonthlyTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblMonthlyTitle.Location = new System.Drawing.Point(6, 10);
            this.lblMonthlyTitle.Name = "lblMonthlyTitle";
            this.lblMonthlyTitle.Size = new System.Drawing.Size(212, 37);
            this.lblMonthlyTitle.TabIndex = 1;
            this.lblMonthlyTitle.Text = "MONTHLY REPORT";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gold;
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(650, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmReport
            // 
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabControlReports);
            this.Name = "FrmReport";
            this.Text = "FrmReport";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.tabControlReports.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            this.tabDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            this.tabMonthly.ResumeLayout(false);
            this.tabMonthly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyReport)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
