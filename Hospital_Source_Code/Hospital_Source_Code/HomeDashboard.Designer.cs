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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lblAddPatients = new System.Windows.Forms.Label();
            this.lblSearchpatients = new System.Windows.Forms.Label();
            this.comboSearchPatient = new System.Windows.Forms.ComboBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.tabDoctor = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQualifcation = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbDeptID = new System.Windows.Forms.ComboBox();
            this.btnInsertDoctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.tabBeds = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlInsertPatient = new System.Windows.Forms.Panel();
            this.txtPatientForname = new System.Windows.Forms.TextBox();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPateientAddress = new System.Windows.Forms.TextBox();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPatientNextOfKin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlHomescreen = new System.Windows.Forms.Panel();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.hospitalDatabaseDataSet = new Hospital_Source_Code.HospitalDatabaseDataSet();
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDetailsTableAdapter = new Hospital_Source_Code.HospitalDatabaseDataSetTableAdapters.PatientDetailsTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabDoctor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBeds.SuspendLayout();
            this.pnlInsertPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1073, 685);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.pnlHomescreen);
            this.tabPatient.Controls.Add(this.pnlInsertPatient);
            this.tabPatient.Controls.Add(this.panel1);
            this.tabPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatient.Location = new System.Drawing.Point(4, 44);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(1065, 637);
            this.tabPatient.TabIndex = 0;
            this.tabPatient.Text = "   PATIENTS   ";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel1.Controls.Add(this.btnSearchPatient);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Controls.Add(this.lblAddPatients);
            this.panel1.Controls.Add(this.lblSearchpatients);
            this.panel1.Controls.Add(this.comboSearchPatient);
            this.panel1.Controls.Add(this.txtSearchLastName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 631);
            this.panel1.TabIndex = 0;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnAddPatient.Location = new System.Drawing.Point(62, 399);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(131, 46);
            this.btnAddPatient.TabIndex = 4;
            this.btnAddPatient.Text = "ADD";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // lblAddPatients
            // 
            this.lblAddPatients.AutoSize = true;
            this.lblAddPatients.ForeColor = System.Drawing.Color.White;
            this.lblAddPatients.Location = new System.Drawing.Point(45, 348);
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
            this.tabDoctor.Size = new System.Drawing.Size(970, 531);
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
            this.panel2.Size = new System.Drawing.Size(270, 525);
            this.panel2.TabIndex = 0;
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
            // txtPhoneNo
            // 
            this.txtPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPhoneNo.Location = new System.Drawing.Point(49, 248);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(166, 32);
            this.txtPhoneNo.TabIndex = 11;
            this.txtPhoneNo.Text = "Phone Number...";
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
            // txtLastName
            // 
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtLastName.Location = new System.Drawing.Point(49, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(166, 32);
            this.txtLastName.TabIndex = 8;
            this.txtLastName.Text = "Last Name...";
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
            this.tabBeds.Controls.Add(this.tableLayoutPanel1);
            this.tabBeds.Controls.Add(this.panel3);
            this.tabBeds.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBeds.Location = new System.Drawing.Point(4, 44);
            this.tabBeds.Name = "tabBeds";
            this.tabBeds.Size = new System.Drawing.Size(1045, 647);
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
            this.panel3.Size = new System.Drawing.Size(270, 647);
            this.panel3.TabIndex = 0;
            // 
            // pnlInsertPatient
            // 
            this.pnlInsertPatient.Controls.Add(this.comboBox1);
            this.pnlInsertPatient.Controls.Add(this.textBox1);
            this.pnlInsertPatient.Controls.Add(this.button1);
            this.pnlInsertPatient.Controls.Add(this.label8);
            this.pnlInsertPatient.Controls.Add(this.label7);
            this.pnlInsertPatient.Controls.Add(this.label6);
            this.pnlInsertPatient.Controls.Add(this.label5);
            this.pnlInsertPatient.Controls.Add(this.label4);
            this.pnlInsertPatient.Controls.Add(this.label3);
            this.pnlInsertPatient.Controls.Add(this.label2);
            this.pnlInsertPatient.Controls.Add(this.txtPatientNextOfKin);
            this.pnlInsertPatient.Controls.Add(this.txtPatientPhone);
            this.pnlInsertPatient.Controls.Add(this.txtPateientAddress);
            this.pnlInsertPatient.Controls.Add(this.txtPatientSurname);
            this.pnlInsertPatient.Controls.Add(this.txtPatientForname);
            this.pnlInsertPatient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInsertPatient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlInsertPatient.Location = new System.Drawing.Point(273, 6);
            this.pnlInsertPatient.Name = "pnlInsertPatient";
            this.pnlInsertPatient.Size = new System.Drawing.Size(789, 628);
            this.pnlInsertPatient.TabIndex = 1;
            // 
            // txtPatientForname
            // 
            this.txtPatientForname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientForname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientForname.Location = new System.Drawing.Point(232, 60);
            this.txtPatientForname.Name = "txtPatientForname";
            this.txtPatientForname.Size = new System.Drawing.Size(166, 32);
            this.txtPatientForname.TabIndex = 5;
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientSurname.Location = new System.Drawing.Point(232, 118);
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(166, 32);
            this.txtPatientSurname.TabIndex = 6;
            // 
            // txtPateientAddress
            // 
            this.txtPateientAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPateientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPateientAddress.Location = new System.Drawing.Point(232, 177);
            this.txtPateientAddress.Name = "txtPateientAddress";
            this.txtPateientAddress.Size = new System.Drawing.Size(166, 32);
            this.txtPateientAddress.TabIndex = 7;
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientPhone.Location = new System.Drawing.Point(232, 404);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(166, 32);
            this.txtPatientPhone.TabIndex = 8;
            // 
            // txtPatientNextOfKin
            // 
            this.txtPatientNextOfKin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientNextOfKin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientNextOfKin.Location = new System.Drawing.Point(232, 293);
            this.txtPatientNextOfKin.Multiline = true;
            this.txtPatientNextOfKin.Name = "txtPatientNextOfKin";
            this.txtPatientNextOfKin.Size = new System.Drawing.Size(294, 84);
            this.txtPatientNextOfKin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Second name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "DOB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Next of kin:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.button1.Location = new System.Drawing.Point(541, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.textBox1.Location = new System.Drawing.Point(232, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 32);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Last name"});
            this.comboBox1.Location = new System.Drawing.Point(232, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 32);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = " Select...";
            // 
            // pnlHomescreen
            // 
            this.pnlHomescreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomescreen.BackgroundImage")));
            this.pnlHomescreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomescreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomescreen.Location = new System.Drawing.Point(273, 3);
            this.pnlHomescreen.Name = "pnlHomescreen";
            this.pnlHomescreen.Size = new System.Drawing.Size(789, 638);
            this.pnlHomescreen.TabIndex = 2;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnSearchPatient.Location = new System.Drawing.Point(62, 238);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(131, 46);
            this.btnSearchPatient.TabIndex = 5;
            this.btnSearchPatient.Text = "SEARCH";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            // 
            // hospitalDatabaseDataSet
            // 
            this.hospitalDatabaseDataSet.DataSetName = "HospitalDatabaseDataSet";
            this.hospitalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDetailsBindingSource
            // 
            this.patientDetailsBindingSource.DataMember = "PatientDetails";
            this.patientDetailsBindingSource.DataSource = this.hospitalDatabaseDataSet;
            // 
            // patientDetailsTableAdapter
            // 
            this.patientDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(364, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 211);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 685);
            this.Controls.Add(this.tabControl1);
            this.Name = "HomeDashboard";
            this.Text = "HomeDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeDashboard_FormClosing);
            this.Load += new System.EventHandler(this.HomeDashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPatient.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDoctor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabBeds.ResumeLayout(false);
            this.pnlInsertPatient.ResumeLayout(false);
            this.pnlInsertPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnAddPatient;
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
        private System.Windows.Forms.Panel pnlInsertPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientNextOfKin;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPateientAddress;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientForname;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlHomescreen;
        private System.Windows.Forms.Button btnSearchPatient;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
        private HospitalDatabaseDataSetTableAdapters.PatientDetailsTableAdapter patientDetailsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}