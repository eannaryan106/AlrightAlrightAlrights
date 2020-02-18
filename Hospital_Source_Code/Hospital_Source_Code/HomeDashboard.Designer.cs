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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertPatient = new System.Windows.Forms.Button();
            this.lblAddPatients = new System.Windows.Forms.Label();
            this.lblSearchpatients = new System.Windows.Forms.Label();
            this.comboSearchPatient = new System.Windows.Forms.ComboBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.tabDoctor = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.tabBeds = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInsertDoctor = new System.Windows.Forms.Button();
            this.cmbDeptID = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtQualifcation = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDoctor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBeds.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(270, 431);
            this.panel1.TabIndex = 0;
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
            this.comboSearchPatient.SelectedIndexChanged += new System.EventHandler(this.comboSearchPatient_SelectedIndexChanged);
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtSearchLastName.Location = new System.Drawing.Point(45, 171);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(166, 32);
            this.txtSearchLastName.TabIndex = 0;
            this.txtSearchLastName.Text = " Type...";
            this.txtSearchLastName.Enter += new System.EventHandler(this.txtSearchLastName_Enter);
            this.txtSearchLastName.Leave += new System.EventHandler(this.txtSearchLastName_Leave);
            // 
            // tabDoctor
            // 
            this.tabDoctor.Controls.Add(this.panel2);
            this.tabDoctor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoctor.Location = new System.Drawing.Point(4, 44);
            this.tabDoctor.Name = "tabDoctor";
            this.tabDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctor.Size = new System.Drawing.Size(791, 437);
            this.tabDoctor.TabIndex = 1;
            this.tabDoctor.Text = "   DOCTORS   ";
            this.tabDoctor.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.txtQualifcation);
            this.panel2.Controls.Add(this.txtPhoneNo);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.cmbGender);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.cmbDeptID);
            this.panel2.Controls.Add(this.btnInsertDoctor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 431);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Doctors:";
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
            this.tabBeds.Controls.Add(this.panel3);
            this.tabBeds.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBeds.Location = new System.Drawing.Point(4, 44);
            this.tabBeds.Name = "tabBeds";
            this.tabBeds.Size = new System.Drawing.Size(791, 437);
            this.tabBeds.TabIndex = 3;
            this.tabBeds.Text = "       BEDS      ";
            this.tabBeds.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 437);
            this.panel3.TabIndex = 0;
            // 
            // btnInsertDoctor
            // 
            this.btnInsertDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsertDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnInsertDoctor.Location = new System.Drawing.Point(61, 382);
            this.btnInsertDoctor.Name = "btnInsertDoctor";
            this.btnInsertDoctor.Size = new System.Drawing.Size(131, 46);
            this.btnInsertDoctor.TabIndex = 5;
            this.btnInsertDoctor.Text = "INSERT";
            this.btnInsertDoctor.UseVisualStyleBackColor = true;
            this.btnInsertDoctor.Click += new System.EventHandler(this.btnInsertDoctor_Click);
            // 
            // cmbDeptID
            // 
            this.cmbDeptID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbDeptID.FormattingEnabled = true;
            this.cmbDeptID.Items.AddRange(new object[] {
            "ID",
            "Last name"});
            this.cmbDeptID.Location = new System.Drawing.Point(49, 344);
            this.cmbDeptID.Name = "cmbDeptID";
            this.cmbDeptID.Size = new System.Drawing.Size(166, 32);
            this.cmbDeptID.TabIndex = 6;
            this.cmbDeptID.Text = " Select...";
            // 
            // txtFirstName
            // 
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtFirstName.Location = new System.Drawing.Point(49, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(166, 32);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.Text = "First Name...";
            // 
            // txtLastName
            // 
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtLastName.Location = new System.Drawing.Point(49, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(166, 32);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.Text = "Last Name...";
            // 
            // cmbGender
            // 
            this.cmbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(49, 134);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(166, 32);
            this.cmbGender.TabIndex = 9;
            this.cmbGender.Text = " Select...";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtAddress.Location = new System.Drawing.Point(49, 181);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 61);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Text = "Address...";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPhoneNo.Location = new System.Drawing.Point(49, 248);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(166, 32);
            this.txtPhoneNo.TabIndex = 11;
            this.txtPhoneNo.Text = "Phone Number...";
            // 
            // txtQualifcation
            // 
            this.txtQualifcation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtQualifcation.Location = new System.Drawing.Point(49, 296);
            this.txtQualifcation.Name = "txtQualifcation";
            this.txtQualifcation.Size = new System.Drawing.Size(166, 32);
            this.txtQualifcation.TabIndex = 12;
            this.txtQualifcation.Text = "Qualification...";
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
            this.tabDoctor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabBeds.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQualifcation;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.ComboBox cmbDeptID;
        private System.Windows.Forms.Button btnInsertDoctor;
    }
}