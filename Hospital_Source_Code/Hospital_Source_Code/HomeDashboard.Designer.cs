namespace Hospital_Source_Code
{
    partial class HomeDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.tabDoctor = new System.Windows.Forms.TabPage();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.tabBeds = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.comboSearchPatient = new System.Windows.Forms.ComboBox();
            this.lblSearchpatients = new System.Windows.Forms.Label();
            this.lblAddPatients = new System.Windows.Forms.Label();
            this.btnInsertPatient = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPatient);
            this.tabControl1.Controls.Add(this.tabDoctor);
            this.tabControl1.Controls.Add(this.tabBilling);
            this.tabControl1.Controls.Add(this.tabBeds);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.panel1);
            this.tabPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatient.Location = new System.Drawing.Point(4, 44);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(791, 437);
            this.tabPatient.TabIndex = 0;
            this.tabPatient.Text = "   PATIENTS   ";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // tabDoctor
            // 
            this.tabDoctor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoctor.Location = new System.Drawing.Point(4, 44);
            this.tabDoctor.Name = "tabDoctor";
            this.tabDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctor.Size = new System.Drawing.Size(791, 437);
            this.tabDoctor.TabIndex = 1;
            this.tabDoctor.Text = "   DOCTORS   ";
            this.tabDoctor.UseVisualStyleBackColor = true;
            // 
            // tabBilling
            // 
            this.tabBilling.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBilling.Location = new System.Drawing.Point(4, 44);
            this.tabBilling.Name = "tabBilling";
            this.tabBilling.Size = new System.Drawing.Size(791, 437);
            this.tabBilling.TabIndex = 2;
            this.tabBilling.Text = "   BILLING    ";
            this.tabBilling.UseVisualStyleBackColor = true;
            // 
            // tabBeds
            // 
            this.tabBeds.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBeds.Location = new System.Drawing.Point(4, 44);
            this.tabBeds.Name = "tabBeds";
            this.tabBeds.Size = new System.Drawing.Size(792, 402);
            this.tabBeds.TabIndex = 3;
            this.tabBeds.Text = "       BEDS      ";
            this.tabBeds.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.btnInsertPatient);
            this.panel1.Controls.Add(this.lblAddPatients);
            this.panel1.Controls.Add(this.lblSearchpatients);
            this.panel1.Controls.Add(this.comboSearchPatient);
            this.panel1.Controls.Add(this.txtSearchLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 431);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtSearchLastName.Location = new System.Drawing.Point(45, 171);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(166, 32);
            this.txtSearchLastName.TabIndex = 0;
            this.txtSearchLastName.Text = " Type...";
            // 
            // comboSearchPatient
            // 
            this.comboSearchPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.comboSearchPatient.FormattingEnabled = true;
            this.comboSearchPatient.Items.AddRange(new object[] {
            "ID",
            "Last name"});
            this.comboSearchPatient.Location = new System.Drawing.Point(45, 102);
            this.comboSearchPatient.Name = "comboSearchPatient";
            this.comboSearchPatient.Size = new System.Drawing.Size(166, 32);
            this.comboSearchPatient.TabIndex = 1;
            this.comboSearchPatient.Text = " Select...";
            // 
            // lblSearchpatients
            // 
            this.lblSearchpatients.AutoSize = true;
            this.lblSearchpatients.ForeColor = System.Drawing.Color.White;
            this.lblSearchpatients.Location = new System.Drawing.Point(45, 45);
            this.lblSearchpatients.Name = "lblSearchpatients";
            this.lblSearchpatients.Size = new System.Drawing.Size(152, 24);
            this.lblSearchpatients.TabIndex = 2;
            this.lblSearchpatients.Text = "Search patients:";
            // 
            // lblAddPatients
            // 
            this.lblAddPatients.AutoSize = true;
            this.lblAddPatients.ForeColor = System.Drawing.Color.White;
            this.lblAddPatients.Location = new System.Drawing.Point(45, 241);
            this.lblAddPatients.Name = "lblAddPatients";
            this.lblAddPatients.Size = new System.Drawing.Size(168, 24);
            this.lblAddPatients.TabIndex = 3;
            this.lblAddPatients.Text = "Add new patients";
            // 
            // btnInsertPatient
            // 
            this.btnInsertPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsertPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnInsertPatient.Location = new System.Drawing.Point(62, 292);
            this.btnInsertPatient.Name = "btnInsertPatient";
            this.btnInsertPatient.Size = new System.Drawing.Size(131, 46);
            this.btnInsertPatient.TabIndex = 4;
            this.btnInsertPatient.Text = "INSERT";
            this.btnInsertPatient.UseVisualStyleBackColor = true;
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomeDashboard";
            this.Text = "HomeDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeDashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPatient.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.TabPage tabDoctor;
        private System.Windows.Forms.TabPage tabBilling;
        private System.Windows.Forms.TabPage tabBeds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchLastName;
        public System.Windows.Forms.ComboBox comboSearchPatient;
        private System.Windows.Forms.Button btnInsertPatient;
        private System.Windows.Forms.Label lblAddPatients;
        private System.Windows.Forms.Label lblSearchpatients;
    }
}