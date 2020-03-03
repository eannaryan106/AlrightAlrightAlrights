namespace Hospital_test
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.PnlUp = new System.Windows.Forms.Panel();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblHospital = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblMgmtSyst = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblIcon = new System.Windows.Forms.Label();
            this.LblForgotPassword = new System.Windows.Forms.Label();
            this.PnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUp
            // 
            this.PnlUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PnlUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlUp.BackgroundImage")));
            this.PnlUp.Controls.Add(this.LblIcon);
            this.PnlUp.Controls.Add(this.BtnClose);
            this.PnlUp.Controls.Add(this.LblMgmtSyst);
            this.PnlUp.Controls.Add(this.LblHospital);
            this.PnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUp.Location = new System.Drawing.Point(0, 0);
            this.PnlUp.Name = "PnlUp";
            this.PnlUp.Size = new System.Drawing.Size(301, 171);
            this.PnlUp.TabIndex = 3;
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtUsername.Location = new System.Drawing.Point(42, 236);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(219, 32);
            this.TxtUsername.TabIndex = 4;
            // 
            // LblHospital
            // 
            this.LblHospital.AutoSize = true;
            this.LblHospital.BackColor = System.Drawing.Color.Transparent;
            this.LblHospital.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHospital.ForeColor = System.Drawing.Color.AliceBlue;
            this.LblHospital.Location = new System.Drawing.Point(58, 44);
            this.LblHospital.Name = "LblHospital";
            this.LblHospital.Size = new System.Drawing.Size(183, 41);
            this.LblHospital.TabIndex = 0;
            this.LblHospital.Text = "HOSPITAL";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblUsername.Location = new System.Drawing.Point(94, 200);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(106, 24);
            this.LblUsername.TabIndex = 5;
            this.LblUsername.Text = "Username:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblPassword.Location = new System.Drawing.Point(98, 281);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(99, 24);
            this.LblPassword.TabIndex = 6;
            this.LblPassword.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtPassword.Location = new System.Drawing.Point(42, 316);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(219, 32);
            this.TxtPassword.TabIndex = 7;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(87, 371);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(119, 41);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // LblMgmtSyst
            // 
            this.LblMgmtSyst.AutoSize = true;
            this.LblMgmtSyst.BackColor = System.Drawing.Color.Transparent;
            this.LblMgmtSyst.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMgmtSyst.ForeColor = System.Drawing.SystemColors.Menu;
            this.LblMgmtSyst.Location = new System.Drawing.Point(67, 81);
            this.LblMgmtSyst.Name = "LblMgmtSyst";
            this.LblMgmtSyst.Size = new System.Drawing.Size(164, 17);
            this.LblMgmtSyst.TabIndex = 1;
            this.LblMgmtSyst.Text = "MANAGEMENT SYSTEM";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Wingdings 2", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BtnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnClose.Location = new System.Drawing.Point(274, -3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(33, 38);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "U";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // LblIcon
            // 
            this.LblIcon.AutoSize = true;
            this.LblIcon.BackColor = System.Drawing.Color.Transparent;
            this.LblIcon.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.LblIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblIcon.Location = new System.Drawing.Point(100, 95);
            this.LblIcon.Name = "LblIcon";
            this.LblIcon.Size = new System.Drawing.Size(92, 65);
            this.LblIcon.TabIndex = 3;
            this.LblIcon.Text = "h";
            // 
            // LblForgotPassword
            // 
            this.LblForgotPassword.AutoSize = true;
            this.LblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgotPassword.Location = new System.Drawing.Point(99, 417);
            this.LblForgotPassword.Name = "LblForgotPassword";
            this.LblForgotPassword.Size = new System.Drawing.Size(98, 15);
            this.LblForgotPassword.TabIndex = 9;
            this.LblForgotPassword.Text = "Forgot password";
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(301, 464);
            this.Controls.Add(this.LblForgotPassword);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.PnlUp);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrm";
            this.Text = "Form1";
            this.PnlUp.ResumeLayout(false);
            this.PnlUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlUp;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label LblHospital;
        private System.Windows.Forms.Label LblIcon;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblMgmtSyst;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblForgotPassword;
    }
}

