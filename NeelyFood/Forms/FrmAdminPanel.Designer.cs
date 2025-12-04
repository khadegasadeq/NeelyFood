namespace NeelyFood
{
    partial class FrmAdminPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnCategoriesaAndMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPanel));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnCategoriesaAndMenu = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(217, 122);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(207, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "مرحبا بالريس ^^";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Gold;
            this.btnUsers.Location = new System.Drawing.Point(187, 190);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(253, 40);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "إدارة المستخدمين";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // btnCategoriesaAndMenu
            // 
            this.btnCategoriesaAndMenu.BackColor = System.Drawing.Color.Gold;
            this.btnCategoriesaAndMenu.Location = new System.Drawing.Point(187, 250);
            this.btnCategoriesaAndMenu.Name = "btnCategoriesaAndMenu";
            this.btnCategoriesaAndMenu.Size = new System.Drawing.Size(253, 40);
            this.btnCategoriesaAndMenu.TabIndex = 2;
            this.btnCategoriesaAndMenu.Text = "إدارة الأقسام والأصناف";
            this.btnCategoriesaAndMenu.UseVisualStyleBackColor = false;
            this.btnCategoriesaAndMenu.Click += new System.EventHandler(this.BtnCategories_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Silver;
            this.btnLogin.Location = new System.Drawing.Point(12, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 33);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = " تسجيل الدخول";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(430, -5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(193, 142);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // btOrders
            // 
            this.btOrders.BackColor = System.Drawing.Color.Gold;
            this.btOrders.Location = new System.Drawing.Point(187, 308);
            this.btOrders.Name = "btOrders";
            this.btOrders.Size = new System.Drawing.Size(253, 40);
            this.btOrders.TabIndex = 7;
            this.btOrders.Text = "عرض الطلبات";
            this.btOrders.UseVisualStyleBackColor = false;
            this.btOrders.Click += new System.EventHandler(this.btOrders_Click);
            // 
            // FrmAdminPanel
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(623, 461);
            this.Controls.Add(this.btOrders);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnCategoriesaAndMenu);
            this.Name = "FrmAdminPanel";
            this.Text = "لوحة المدير";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btOrders;
    }
}
