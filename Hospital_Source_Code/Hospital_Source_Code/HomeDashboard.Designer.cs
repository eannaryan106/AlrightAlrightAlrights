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
            this.pnlInsertPatient = new System.Windows.Forms.Panel();
            this.cmbPatientGender = new System.Windows.Forms.ComboBox();
            this.txtPatientNOK = new System.Windows.Forms.TextBox();
            this.btnInsertPatient = new System.Windows.Forms.Button();
            this.lblPatientKin = new System.Windows.Forms.Label();
            this.lblPatientPhone = new System.Windows.Forms.Label();
            this.lblPatientAddress = new System.Windows.Forms.Label();
            this.lblPatientGender = new System.Windows.Forms.Label();
            this.lblPatientDOB = new System.Windows.Forms.Label();
            this.lblPatientSurname = new System.Windows.Forms.Label();
            this.lblPatientForname = new System.Windows.Forms.Label();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPatientDOB = new System.Windows.Forms.TextBox();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPatientForename = new System.Windows.Forms.TextBox();
            this.pnlHomescreen = new System.Windows.Forms.Panel();
            this.pnlLeftPane = new System.Windows.Forms.Panel();
            this.btnSearchPatient = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hospitalDatabaseDataSet = new Hospital_Source_Code.HospitalDatabaseDataSet();
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDetailsTableAdapter = new Hospital_Source_Code.HospitalDatabaseDataSetTableAdapters.PatientDetailsTableAdapter();
            this.pnlErrors = new System.Windows.Forms.Panel();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblSurnameError = new System.Windows.Forms.Label();
            this.LblGenderError = new System.Windows.Forms.Label();
            this.LblAddressError = new System.Windows.Forms.Label();
            this.LblPhoneError = new System.Windows.Forms.Label();
            this.lblDOBError = new System.Windows.Forms.Label();
            this.LblKinError = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.pnlInsertPatient.SuspendLayout();
            this.pnlLeftPane.SuspendLayout();
            this.tabDoctor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).BeginInit();
            this.pnlErrors.SuspendLayout();
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
            this.tabPatient.Controls.Add(this.pnlInsertPatient);
            this.tabPatient.Controls.Add(this.pnlHomescreen);
            this.tabPatient.Controls.Add(this.pnlLeftPane);
            this.tabPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatient.Location = new System.Drawing.Point(4, 44);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(1065, 637);
            this.tabPatient.TabIndex = 0;
            this.tabPatient.Text = "   PATIENTS   ";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // pnlInsertPatient
            // 
            this.pnlInsertPatient.BackColor = System.Drawing.Color.White;
            this.pnlInsertPatient.Controls.Add(this.txtPatientAddress);
            this.pnlInsertPatient.Controls.Add(this.pnlErrors);
            this.pnlInsertPatient.Controls.Add(this.cmbPatientGender);
            this.pnlInsertPatient.Controls.Add(this.txtPatientNOK);
            this.pnlInsertPatient.Controls.Add(this.btnInsertPatient);
            this.pnlInsertPatient.Controls.Add(this.lblPatientKin);
            this.pnlInsertPatient.Controls.Add(this.lblPatientPhone);
            this.pnlInsertPatient.Controls.Add(this.lblPatientAddress);
            this.pnlInsertPatient.Controls.Add(this.lblPatientGender);
            this.pnlInsertPatient.Controls.Add(this.lblPatientDOB);
            this.pnlInsertPatient.Controls.Add(this.lblPatientSurname);
            this.pnlInsertPatient.Controls.Add(this.lblPatientForname);
            this.pnlInsertPatient.Controls.Add(this.txtPatientPhone);
            this.pnlInsertPatient.Controls.Add(this.txtPatientDOB);
            this.pnlInsertPatient.Controls.Add(this.txtPatientSurname);
            this.pnlInsertPatient.Controls.Add(this.txtPatientForename);
            this.pnlInsertPatient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInsertPatient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlInsertPatient.Location = new System.Drawing.Point(273, 0);
            this.pnlInsertPatient.Name = "pnlInsertPatient";
            this.pnlInsertPatient.Size = new System.Drawing.Size(789, 634);
            this.pnlInsertPatient.TabIndex = 18;
            // 
            // cmbPatientGender
            // 
            this.cmbPatientGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPatientGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbPatientGender.FormattingEnabled = true;
            this.cmbPatientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbPatientGender.Location = new System.Drawing.Point(232, 235);
            this.cmbPatientGender.Name = "cmbPatientGender";
            this.cmbPatientGender.Size = new System.Drawing.Size(166, 32);
            this.cmbPatientGender.TabIndex = 5;
            this.cmbPatientGender.Text = " Select...";
            this.cmbPatientGender.SelectedIndexChanged += new System.EventHandler(this.cmbPatientGender_SelectedIndexChanged);
            // 
            // txtPatientNOK
            // 
            this.txtPatientNOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientNOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientNOK.Location = new System.Drawing.Point(232, 465);
            this.txtPatientNOK.Name = "txtPatientNOK";
            this.txtPatientNOK.Size = new System.Drawing.Size(166, 32);
            this.txtPatientNOK.TabIndex = 17;
            this.txtPatientNOK.Leave += new System.EventHandler(this.txtPatientNOK_Leave);
            // 
            // btnInsertPatient
            // 
            this.btnInsertPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInsertPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnInsertPatient.Location = new System.Drawing.Point(541, 538);
            this.btnInsertPatient.Name = "btnInsertPatient";
            this.btnInsertPatient.Size = new System.Drawing.Size(131, 46);
            this.btnInsertPatient.TabIndex = 5;
            this.btnInsertPatient.Text = "INSERT";
            this.btnInsertPatient.UseVisualStyleBackColor = true;
            this.btnInsertPatient.Click += new System.EventHandler(this.btnInsertPatient_Click);
            // 
            // lblPatientKin
            // 
            this.lblPatientKin.AutoSize = true;
            this.lblPatientKin.Location = new System.Drawing.Point(82, 468);
            this.lblPatientKin.Name = "lblPatientKin";
            this.lblPatientKin.Size = new System.Drawing.Size(111, 24);
            this.lblPatientKin.TabIndex = 16;
            this.lblPatientKin.Text = "Next of kin:";
            // 
            // lblPatientPhone
            // 
            this.lblPatientPhone.AutoSize = true;
            this.lblPatientPhone.Location = new System.Drawing.Point(82, 407);
            this.lblPatientPhone.Name = "lblPatientPhone";
            this.lblPatientPhone.Size = new System.Drawing.Size(72, 24);
            this.lblPatientPhone.TabIndex = 15;
            this.lblPatientPhone.Text = "Phone:";
            // 
            // lblPatientAddress
            // 
            this.lblPatientAddress.AutoSize = true;
            this.lblPatientAddress.Location = new System.Drawing.Point(82, 296);
            this.lblPatientAddress.Name = "lblPatientAddress";
            this.lblPatientAddress.Size = new System.Drawing.Size(87, 24);
            this.lblPatientAddress.TabIndex = 14;
            this.lblPatientAddress.Text = "Address:";
            // 
            // lblPatientGender
            // 
            this.lblPatientGender.AutoSize = true;
            this.lblPatientGender.Location = new System.Drawing.Point(82, 238);
            this.lblPatientGender.Name = "lblPatientGender";
            this.lblPatientGender.Size = new System.Drawing.Size(81, 24);
            this.lblPatientGender.TabIndex = 13;
            this.lblPatientGender.Text = "Gender:";
            // 
            // lblPatientDOB
            // 
            this.lblPatientDOB.AutoSize = true;
            this.lblPatientDOB.Location = new System.Drawing.Point(82, 180);
            this.lblPatientDOB.Name = "lblPatientDOB";
            this.lblPatientDOB.Size = new System.Drawing.Size(55, 24);
            this.lblPatientDOB.TabIndex = 12;
            this.lblPatientDOB.Text = "DOB:";
            // 
            // lblPatientSurname
            // 
            this.lblPatientSurname.AutoSize = true;
            this.lblPatientSurname.Location = new System.Drawing.Point(82, 121);
            this.lblPatientSurname.Name = "lblPatientSurname";
            this.lblPatientSurname.Size = new System.Drawing.Size(137, 24);
            this.lblPatientSurname.TabIndex = 11;
            this.lblPatientSurname.Text = "Second name:";
            // 
            // lblPatientForname
            // 
            this.lblPatientForname.AutoSize = true;
            this.lblPatientForname.Location = new System.Drawing.Point(82, 63);
            this.lblPatientForname.Name = "lblPatientForname";
            this.lblPatientForname.Size = new System.Drawing.Size(108, 24);
            this.lblPatientForname.TabIndex = 10;
            this.lblPatientForname.Text = "First name:";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientAddress.Location = new System.Drawing.Point(232, 293);
            this.txtPatientAddress.Multiline = true;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(294, 84);
            this.txtPatientAddress.TabIndex = 9;
            this.txtPatientAddress.Leave += new System.EventHandler(this.txtPatientAddress_Leave);
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientPhone.Location = new System.Drawing.Point(232, 404);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(166, 32);
            this.txtPatientPhone.TabIndex = 8;
            this.txtPatientPhone.Leave += new System.EventHandler(this.txtPatientPhone_Leave);
            // 
            // txtPatientDOB
            // 
            this.txtPatientDOB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientDOB.Location = new System.Drawing.Point(232, 177);
            this.txtPatientDOB.Name = "txtPatientDOB";
            this.txtPatientDOB.Size = new System.Drawing.Size(166, 32);
            this.txtPatientDOB.TabIndex = 7;
            this.txtPatientDOB.Leave += new System.EventHandler(this.txtPatientDOB_Leave);
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientSurname.Location = new System.Drawing.Point(232, 118);
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(166, 32);
            this.txtPatientSurname.TabIndex = 6;
            this.txtPatientSurname.Leave += new System.EventHandler(this.txtPatientSurname_Leave);
            // 
            // txtPatientForename
            // 
            this.txtPatientForename.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientForename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientForename.Location = new System.Drawing.Point(232, 60);
            this.txtPatientForename.Name = "txtPatientForename";
            this.txtPatientForename.Size = new System.Drawing.Size(166, 32);
            this.txtPatientForename.TabIndex = 5;
            this.txtPatientForename.Leave += new System.EventHandler(this.txtPatientForename_Leave);
            // 
            // pnlHomescreen
            // 
            this.pnlHomescreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomescreen.BackgroundImage")));
            this.pnlHomescreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomescreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomescreen.Location = new System.Drawing.Point(273, 3);
            this.pnlHomescreen.Name = "pnlHomescreen";
            this.pnlHomescreen.Size = new System.Drawing.Size(789, 634);
            this.pnlHomescreen.TabIndex = 2;
            // 
            // pnlLeftPane
            // 
            this.pnlLeftPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.pnlLeftPane.Controls.Add(this.btnSearchPatient);
            this.pnlLeftPane.Controls.Add(this.btnAddPatient);
            this.pnlLeftPane.Controls.Add(this.lblAddPatients);
            this.pnlLeftPane.Controls.Add(this.lblSearchpatients);
            this.pnlLeftPane.Controls.Add(this.comboSearchPatient);
            this.pnlLeftPane.Controls.Add(this.txtSearchLastName);
            this.pnlLeftPane.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftPane.Location = new System.Drawing.Point(3, 3);
            this.pnlLeftPane.Name = "pnlLeftPane";
            this.pnlLeftPane.Size = new System.Drawing.Size(270, 631);
            this.pnlLeftPane.TabIndex = 0;
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
            this.tabDoctor.Size = new System.Drawing.Size(1065, 637);
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
            this.panel2.Size = new System.Drawing.Size(270, 631);
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
            this.tabBilling.Size = new System.Drawing.Size(1065, 637);
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
            this.tabBeds.Size = new System.Drawing.Size(1065, 637);
            this.tabBeds.TabIndex = 3;
            this.tabBeds.Text = "       BEDS      ";
            this.tabBeds.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(303, 32);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 637);
            this.panel3.TabIndex = 0;
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
            // pnlErrors
            // 
            this.pnlErrors.BackColor = System.Drawing.Color.Transparent;
            this.pnlErrors.Controls.Add(this.LblKinError);
            this.pnlErrors.Controls.Add(this.lblDOBError);
            this.pnlErrors.Controls.Add(this.LblPhoneError);
            this.pnlErrors.Controls.Add(this.LblAddressError);
            this.pnlErrors.Controls.Add(this.LblGenderError);
            this.pnlErrors.Controls.Add(this.lblSurnameError);
            this.pnlErrors.Controls.Add(this.lblNameError);
            this.pnlErrors.Location = new System.Drawing.Point(416, 48);
            this.pnlErrors.Name = "pnlErrors";
            this.pnlErrors.Size = new System.Drawing.Size(355, 462);
            this.pnlErrors.TabIndex = 19;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(3, 12);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(141, 14);
            this.lblNameError.TabIndex = 19;
            this.lblNameError.Text = "Please insert a valid name";
            // 
            // lblSurnameError
            // 
            this.lblSurnameError.AutoSize = true;
            this.lblSurnameError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameError.ForeColor = System.Drawing.Color.Red;
            this.lblSurnameError.Location = new System.Drawing.Point(3, 73);
            this.lblSurnameError.Name = "lblSurnameError";
            this.lblSurnameError.Size = new System.Drawing.Size(157, 14);
            this.lblSurnameError.TabIndex = 20;
            this.lblSurnameError.Text = "Please insert a valid surname";
            // 
            // LblGenderError
            // 
            this.LblGenderError.AutoSize = true;
            this.LblGenderError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenderError.ForeColor = System.Drawing.Color.Red;
            this.LblGenderError.Location = new System.Drawing.Point(3, 186);
            this.LblGenderError.Name = "LblGenderError";
            this.LblGenderError.Size = new System.Drawing.Size(165, 14);
            this.LblGenderError.TabIndex = 21;
            this.LblGenderError.Text = "Please select one of the values";
            // 
            // LblAddressError
            // 
            this.LblAddressError.AutoSize = true;
            this.LblAddressError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressError.ForeColor = System.Drawing.Color.Red;
            this.LblAddressError.Location = new System.Drawing.Point(121, 247);
            this.LblAddressError.Name = "LblAddressError";
            this.LblAddressError.Size = new System.Drawing.Size(142, 14);
            this.LblAddressError.TabIndex = 22;
            this.LblAddressError.Text = "Please insert your address";
            // 
            // LblPhoneError
            // 
            this.LblPhoneError.AutoSize = true;
            this.LblPhoneError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.LblPhoneError.Location = new System.Drawing.Point(3, 359);
            this.LblPhoneError.Name = "LblPhoneError";
            this.LblPhoneError.Size = new System.Drawing.Size(190, 14);
            this.LblPhoneError.TabIndex = 23;
            this.LblPhoneError.Text = "Please insert a valid phone number";
            // 
            // lblDOBError
            // 
            this.lblDOBError.AutoSize = true;
            this.lblDOBError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBError.ForeColor = System.Drawing.Color.Red;
            this.lblDOBError.Location = new System.Drawing.Point(3, 129);
            this.lblDOBError.Name = "lblDOBError";
            this.lblDOBError.Size = new System.Drawing.Size(293, 28);
            this.lblDOBError.TabIndex = 24;
            this.lblDOBError.Text = "Invalid date format\r\nDOB needs to be in the following format: dd/mm/yyyy";
            // 
            // LblKinError
            // 
            this.LblKinError.AutoSize = true;
            this.LblKinError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKinError.ForeColor = System.Drawing.Color.Red;
            this.LblKinError.Location = new System.Drawing.Point(3, 420);
            this.LblKinError.Name = "LblKinError";
            this.LblKinError.Size = new System.Drawing.Size(157, 14);
            this.LblKinError.TabIndex = 25;
            this.LblKinError.Text = "Please insert your next of kin";
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
            this.pnlInsertPatient.ResumeLayout(false);
            this.pnlInsertPatient.PerformLayout();
            this.pnlLeftPane.ResumeLayout(false);
            this.pnlLeftPane.PerformLayout();
            this.tabDoctor.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabBeds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailsBindingSource)).EndInit();
            this.pnlErrors.ResumeLayout(false);
            this.pnlErrors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.TabPage tabDoctor;
        private System.Windows.Forms.TabPage tabBilling;
        private System.Windows.Forms.TabPage tabBeds;
        private System.Windows.Forms.Panel pnlLeftPane;
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
        private System.Windows.Forms.Panel pnlHomescreen;
        private System.Windows.Forms.Button btnSearchPatient;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
        private HospitalDatabaseDataSetTableAdapters.PatientDetailsTableAdapter patientDetailsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlInsertPatient;
        public System.Windows.Forms.ComboBox cmbPatientGender;
        private System.Windows.Forms.TextBox txtPatientNOK;
        private System.Windows.Forms.Button btnInsertPatient;
        private System.Windows.Forms.Label lblPatientKin;
        private System.Windows.Forms.Label lblPatientPhone;
        private System.Windows.Forms.Label lblPatientAddress;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.Label lblPatientDOB;
        private System.Windows.Forms.Label lblPatientSurname;
        private System.Windows.Forms.Label lblPatientForname;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPatientDOB;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientForename;
        private System.Windows.Forms.Panel pnlErrors;
        private System.Windows.Forms.Label LblGenderError;
        private System.Windows.Forms.Label lblSurnameError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label LblKinError;
        private System.Windows.Forms.Label lblDOBError;
        private System.Windows.Forms.Label LblPhoneError;
        private System.Windows.Forms.Label LblAddressError;
    }
}