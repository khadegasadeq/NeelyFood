namespace NeelyFood
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLblSignup = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.rdCustomer = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(190, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(245, 201);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Gold;
            this.lblUserName.Location = new System.Drawing.Point(202, 182);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "user name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(204, 211);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 24);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gold;
            this.lblPassword.Location = new System.Drawing.Point(202, 241);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 21);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 269);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(229, 24);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gold;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(222, 345);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(193, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLblSignup
            // 
            this.linkLblSignup.AutoSize = true;
            this.linkLblSignup.BackColor = System.Drawing.Color.White;
            this.linkLblSignup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.linkLblSignup.Location = new System.Drawing.Point(386, 407);
            this.linkLblSignup.Name = "linkLblSignup";
            this.linkLblSignup.Size = new System.Drawing.Size(64, 21);
            this.linkLblSignup.TabIndex = 10;
            this.linkLblSignup.TabStop = true;
            this.linkLblSignup.Text = "Sign up";
            this.linkLblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSignup_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(156, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "if you don\'t have an account:";
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdAdmin.ForeColor = System.Drawing.Color.White;
            this.rdAdmin.Location = new System.Drawing.Point(362, 302);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(67, 21);
            this.rdAdmin.TabIndex = 14;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Admin";
            this.rdAdmin.UseVisualStyleBackColor = true;
            this.rdAdmin.CheckedChanged += new System.EventHandler(this.rdAdmin_CheckedChanged);
            // 
            // rdCustomer
            // 
            this.rdCustomer.AutoSize = true;
            this.rdCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdCustomer.ForeColor = System.Drawing.Color.White;
            this.rdCustomer.Location = new System.Drawing.Point(272, 302);
            this.rdCustomer.Name = "rdCustomer";
            this.rdCustomer.Size = new System.Drawing.Size(89, 21);
            this.rdCustomer.TabIndex = 13;
            this.rdCustomer.TabStop = true;
            this.rdCustomer.Text = "Customer";
            this.rdCustomer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(200, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "login as:";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(629, 523);
            this.Controls.Add(this.rdAdmin);
            this.Controls.Add(this.rdCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLblSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.picLogo);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLblSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.RadioButton rdCustomer;
        private System.Windows.Forms.Label label3;
    }
}

