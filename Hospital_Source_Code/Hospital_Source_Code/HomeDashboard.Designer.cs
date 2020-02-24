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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.lblDocIdlabel = new System.Windows.Forms.Label();
            this.lblDocID = new System.Windows.Forms.Label();
            this.lblDocDepartmentID2 = new System.Windows.Forms.Label();
            this.lblDocQualification2 = new System.Windows.Forms.Label();
            this.lblDocPhoneNumber2 = new System.Windows.Forms.Label();
            this.lblDocAddress2 = new System.Windows.Forms.Label();
            this.lblDocGender2 = new System.Windows.Forms.Label();
            this.lblDocLastName2 = new System.Windows.Forms.Label();
            this.lblDocFirstName2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDocQualification = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearchDocCriteria = new System.Windows.Forms.Label();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lblSearchDoc1 = new System.Windows.Forms.Label();
            this.txtSearchDoc1 = new System.Windows.Forms.TextBox();
            this.btnSearchDoc = new System.Windows.Forms.Button();
            this.txtDocPhoneNo = new System.Windows.Forms.TextBox();
            this.txtDocAddress = new System.Windows.Forms.TextBox();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.cmbDocGender = new System.Windows.Forms.ComboBox();
            this.cmbDocDeptID = new System.Windows.Forms.ComboBox();
            this.txtDocLastName = new System.Windows.Forms.TextBox();
            this.txtDocFirstName = new System.Windows.Forms.TextBox();
            this.tabBilling = new System.Windows.Forms.TabPage();
            this.tabBeds = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hospitalDatabaseDataSet = new Hospital_Source_Code.HospitalDatabaseDataSet();
            this.patientDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDetailsTableAdapter = new Hospital_Source_Code.HospitalDatabaseDataSetTableAdapters.PatientDetailsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.pnlInsertPatient.SuspendLayout();
            this.pnlLeftPane.SuspendLayout();
            this.tabDoctor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabBeds.SuspendLayout();
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
            this.pnlInsertPatient.Controls.Add(this.cmbPatientGender);
            this.pnlInsertPatient.Controls.Add(this.txtPatientNOK);
            this.pnlInsertPatient.Controls.Add(this.btnInsertPatient);
            this.pnlInsertPatient.Controls.Add(this.label9);
            this.pnlInsertPatient.Controls.Add(this.label10);
            this.pnlInsertPatient.Controls.Add(this.label11);
            this.pnlInsertPatient.Controls.Add(this.label12);
            this.pnlInsertPatient.Controls.Add(this.label13);
            this.pnlInsertPatient.Controls.Add(this.label14);
            this.pnlInsertPatient.Controls.Add(this.label15);
            this.pnlInsertPatient.Controls.Add(this.txtPatientAddress);
            this.pnlInsertPatient.Controls.Add(this.txtPatientPhone);
            this.pnlInsertPatient.Controls.Add(this.txtPatientDOB);
            this.pnlInsertPatient.Controls.Add(this.txtPatientSurname);
            this.pnlInsertPatient.Controls.Add(this.txtPatientForename);
            this.pnlInsertPatient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInsertPatient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlInsertPatient.Location = new System.Drawing.Point(273, 6);
            this.pnlInsertPatient.Name = "pnlInsertPatient";
            this.pnlInsertPatient.Size = new System.Drawing.Size(789, 628);
            this.pnlInsertPatient.TabIndex = 18;
            // 
            // cmbPatientGender
            // 
            this.cmbPatientGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.cmbPatientGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbPatientGender.FormattingEnabled = true;
            this.cmbPatientGender.Items.AddRange(new object[] {
            "ID",
            "Last name",
            "ID",
            "Last name"});
            this.cmbPatientGender.Location = new System.Drawing.Point(232, 235);
            this.cmbPatientGender.Name = "cmbPatientGender";
            this.cmbPatientGender.Size = new System.Drawing.Size(166, 32);
            this.cmbPatientGender.TabIndex = 5;
            this.cmbPatientGender.Text = " Select...";
            // 
            // txtPatientNOK
            // 
            this.txtPatientNOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientNOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientNOK.Location = new System.Drawing.Point(232, 465);
            this.txtPatientNOK.Name = "txtPatientNOK";
            this.txtPatientNOK.Size = new System.Drawing.Size(166, 32);
            this.txtPatientNOK.TabIndex = 17;
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
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Next of kin:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Gender:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "DOB:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Second name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 24);
            this.label15.TabIndex = 10;
            this.label15.Text = "First name:";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientAddress.Location = new System.Drawing.Point(232, 293);
            this.txtPatientAddress.Multiline = true;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(294, 84);
            this.txtPatientAddress.TabIndex = 9;
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
            // txtPatientDOB
            // 
            this.txtPatientDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientDOB.Location = new System.Drawing.Point(232, 177);
            this.txtPatientDOB.Name = "txtPatientDOB";
            this.txtPatientDOB.Size = new System.Drawing.Size(166, 32);
            this.txtPatientDOB.TabIndex = 7;
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
            // txtPatientForename
            // 
            this.txtPatientForename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientForename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientForename.Location = new System.Drawing.Point(232, 60);
            this.txtPatientForename.Name = "txtPatientForename";
            this.txtPatientForename.Size = new System.Drawing.Size(166, 32);
            this.txtPatientForename.TabIndex = 5;
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
            this.tabDoctor.Controls.Add(this.lblDocIdlabel);
            this.tabDoctor.Controls.Add(this.lblDocID);
            this.tabDoctor.Controls.Add(this.lblDocDepartmentID2);
            this.tabDoctor.Controls.Add(this.lblDocQualification2);
            this.tabDoctor.Controls.Add(this.lblDocPhoneNumber2);
            this.tabDoctor.Controls.Add(this.lblDocAddress2);
            this.tabDoctor.Controls.Add(this.lblDocGender2);
            this.tabDoctor.Controls.Add(this.lblDocLastName2);
            this.tabDoctor.Controls.Add(this.lblDocFirstName2);
            this.tabDoctor.Controls.Add(this.label19);
            this.tabDoctor.Controls.Add(this.txtDocQualification);
            this.tabDoctor.Controls.Add(this.panel2);
            this.tabDoctor.Controls.Add(this.txtDocPhoneNo);
            this.tabDoctor.Controls.Add(this.txtDocAddress);
            this.tabDoctor.Controls.Add(this.btnUpdateDoctor);
            this.tabDoctor.Controls.Add(this.cmbDocGender);
            this.tabDoctor.Controls.Add(this.cmbDocDeptID);
            this.tabDoctor.Controls.Add(this.txtDocLastName);
            this.tabDoctor.Controls.Add(this.txtDocFirstName);
            this.tabDoctor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDoctor.Location = new System.Drawing.Point(4, 44);
            this.tabDoctor.Name = "tabDoctor";
            this.tabDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctor.Size = new System.Drawing.Size(1065, 637);
            this.tabDoctor.TabIndex = 1;
            this.tabDoctor.Text = "   DOCTORS   ";
            this.tabDoctor.UseVisualStyleBackColor = true;
            // 
            // lblDocIdlabel
            // 
            this.lblDocIdlabel.AutoSize = true;
            this.lblDocIdlabel.BackColor = System.Drawing.Color.Transparent;
            this.lblDocIdlabel.ForeColor = System.Drawing.Color.Black;
            this.lblDocIdlabel.Location = new System.Drawing.Point(918, 24);
            this.lblDocIdlabel.Name = "lblDocIdlabel";
            this.lblDocIdlabel.Size = new System.Drawing.Size(33, 24);
            this.lblDocIdlabel.TabIndex = 43;
            this.lblDocIdlabel.Text = "ID:";
            // 
            // lblDocID
            // 
            this.lblDocID.AutoSize = true;
            this.lblDocID.BackColor = System.Drawing.Color.Transparent;
            this.lblDocID.ForeColor = System.Drawing.Color.Black;
            this.lblDocID.Location = new System.Drawing.Point(957, 24);
            this.lblDocID.Name = "lblDocID";
            this.lblDocID.Size = new System.Drawing.Size(21, 24);
            this.lblDocID.TabIndex = 42;
            this.lblDocID.Text = "1";
            // 
            // lblDocDepartmentID2
            // 
            this.lblDocDepartmentID2.AutoSize = true;
            this.lblDocDepartmentID2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocDepartmentID2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocDepartmentID2.ForeColor = System.Drawing.Color.Black;
            this.lblDocDepartmentID2.Location = new System.Drawing.Point(294, 452);
            this.lblDocDepartmentID2.Name = "lblDocDepartmentID2";
            this.lblDocDepartmentID2.Size = new System.Drawing.Size(104, 18);
            this.lblDocDepartmentID2.TabIndex = 41;
            this.lblDocDepartmentID2.Text = "DepartmentID";
            // 
            // lblDocQualification2
            // 
            this.lblDocQualification2.AutoSize = true;
            this.lblDocQualification2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocQualification2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocQualification2.ForeColor = System.Drawing.Color.Black;
            this.lblDocQualification2.Location = new System.Drawing.Point(294, 385);
            this.lblDocQualification2.Name = "lblDocQualification2";
            this.lblDocQualification2.Size = new System.Drawing.Size(95, 18);
            this.lblDocQualification2.TabIndex = 40;
            this.lblDocQualification2.Text = "Qualification";
            // 
            // lblDocPhoneNumber2
            // 
            this.lblDocPhoneNumber2.AutoSize = true;
            this.lblDocPhoneNumber2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocPhoneNumber2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocPhoneNumber2.ForeColor = System.Drawing.Color.Black;
            this.lblDocPhoneNumber2.Location = new System.Drawing.Point(293, 321);
            this.lblDocPhoneNumber2.Name = "lblDocPhoneNumber2";
            this.lblDocPhoneNumber2.Size = new System.Drawing.Size(110, 18);
            this.lblDocPhoneNumber2.TabIndex = 39;
            this.lblDocPhoneNumber2.Text = "Phone Number";
            // 
            // lblDocAddress2
            // 
            this.lblDocAddress2.AutoSize = true;
            this.lblDocAddress2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocAddress2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocAddress2.ForeColor = System.Drawing.Color.Black;
            this.lblDocAddress2.Location = new System.Drawing.Point(294, 214);
            this.lblDocAddress2.Name = "lblDocAddress2";
            this.lblDocAddress2.Size = new System.Drawing.Size(61, 18);
            this.lblDocAddress2.TabIndex = 38;
            this.lblDocAddress2.Text = "Address";
            // 
            // lblDocGender2
            // 
            this.lblDocGender2.AutoSize = true;
            this.lblDocGender2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocGender2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocGender2.ForeColor = System.Drawing.Color.Black;
            this.lblDocGender2.Location = new System.Drawing.Point(293, 158);
            this.lblDocGender2.Name = "lblDocGender2";
            this.lblDocGender2.Size = new System.Drawing.Size(57, 18);
            this.lblDocGender2.TabIndex = 37;
            this.lblDocGender2.Text = "Gender";
            // 
            // lblDocLastName2
            // 
            this.lblDocLastName2.AutoSize = true;
            this.lblDocLastName2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocLastName2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocLastName2.ForeColor = System.Drawing.Color.Black;
            this.lblDocLastName2.Location = new System.Drawing.Point(293, 102);
            this.lblDocLastName2.Name = "lblDocLastName2";
            this.lblDocLastName2.Size = new System.Drawing.Size(78, 18);
            this.lblDocLastName2.TabIndex = 36;
            this.lblDocLastName2.Text = "Last Name";
            // 
            // lblDocFirstName2
            // 
            this.lblDocFirstName2.AutoSize = true;
            this.lblDocFirstName2.BackColor = System.Drawing.Color.Transparent;
            this.lblDocFirstName2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocFirstName2.ForeColor = System.Drawing.Color.Black;
            this.lblDocFirstName2.Location = new System.Drawing.Point(293, 46);
            this.lblDocFirstName2.Name = "lblDocFirstName2";
            this.lblDocFirstName2.Size = new System.Drawing.Size(79, 18);
            this.lblDocFirstName2.TabIndex = 35;
            this.lblDocFirstName2.Text = "First Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(292, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 24);
            this.label19.TabIndex = 24;
            this.label19.Text = "Doctor Details";
            // 
            // txtDocQualification
            // 
            this.txtDocQualification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtDocQualification.Location = new System.Drawing.Point(297, 406);
            this.txtDocQualification.Name = "txtDocQualification";
            this.txtDocQualification.Size = new System.Drawing.Size(460, 32);
            this.txtDocQualification.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel2.Controls.Add(this.lblSearchDocCriteria);
            this.panel2.Controls.Add(this.cmbSearchCriteria);
            this.panel2.Controls.Add(this.lblSearchDoc1);
            this.panel2.Controls.Add(this.txtSearchDoc1);
            this.panel2.Controls.Add(this.btnSearchDoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 631);
            this.panel2.TabIndex = 0;
            // 
            // lblSearchDocCriteria
            // 
            this.lblSearchDocCriteria.AutoSize = true;
            this.lblSearchDocCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDocCriteria.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDocCriteria.ForeColor = System.Drawing.Color.Black;
            this.lblSearchDocCriteria.Location = new System.Drawing.Point(20, 43);
            this.lblSearchDocCriteria.Name = "lblSearchDocCriteria";
            this.lblSearchDocCriteria.Size = new System.Drawing.Size(149, 18);
            this.lblSearchDocCriteria.TabIndex = 21;
            this.lblSearchDocCriteria.Text = "Select Search Criteria";
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "ID",
            "Surname"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(23, 64);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(209, 32);
            this.cmbSearchCriteria.TabIndex = 20;
            this.cmbSearchCriteria.Text = " Select...";
            // 
            // lblSearchDoc1
            // 
            this.lblSearchDoc1.AutoSize = true;
            this.lblSearchDoc1.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDoc1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDoc1.ForeColor = System.Drawing.Color.Black;
            this.lblSearchDoc1.Location = new System.Drawing.Point(23, 125);
            this.lblSearchDoc1.Name = "lblSearchDoc1";
            this.lblSearchDoc1.Size = new System.Drawing.Size(107, 18);
            this.lblSearchDoc1.TabIndex = 20;
            this.lblSearchDoc1.Text = "Enter Surname";
            // 
            // txtSearchDoc1
            // 
            this.txtSearchDoc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtSearchDoc1.Location = new System.Drawing.Point(26, 146);
            this.txtSearchDoc1.Name = "txtSearchDoc1";
            this.txtSearchDoc1.Size = new System.Drawing.Size(206, 32);
            this.txtSearchDoc1.TabIndex = 20;
            // 
            // btnSearchDoc
            // 
            this.btnSearchDoc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnSearchDoc.Location = new System.Drawing.Point(26, 211);
            this.btnSearchDoc.Name = "btnSearchDoc";
            this.btnSearchDoc.Size = new System.Drawing.Size(131, 46);
            this.btnSearchDoc.TabIndex = 20;
            this.btnSearchDoc.Text = "Search";
            this.btnSearchDoc.UseVisualStyleBackColor = true;
            this.btnSearchDoc.Click += new System.EventHandler(this.btnSearchDoc_Click);
            // 
            // txtDocPhoneNo
            // 
            this.txtDocPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtDocPhoneNo.Location = new System.Drawing.Point(297, 342);
            this.txtDocPhoneNo.Name = "txtDocPhoneNo";
            this.txtDocPhoneNo.Size = new System.Drawing.Size(460, 32);
            this.txtDocPhoneNo.TabIndex = 11;
            // 
            // txtDocAddress
            // 
            this.txtDocAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtDocAddress.Location = new System.Drawing.Point(296, 235);
            this.txtDocAddress.Multiline = true;
            this.txtDocAddress.Name = "txtDocAddress";
            this.txtDocAddress.Size = new System.Drawing.Size(460, 83);
            this.txtDocAddress.TabIndex = 10;
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.btnUpdateDoctor.Location = new System.Drawing.Point(297, 521);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(131, 46);
            this.btnUpdateDoctor.TabIndex = 5;
            this.btnUpdateDoctor.Text = "Submit";
            this.btnUpdateDoctor.UseVisualStyleBackColor = true;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // cmbDocGender
            // 
            this.cmbDocGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbDocGender.FormattingEnabled = true;
            this.cmbDocGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbDocGender.Location = new System.Drawing.Point(296, 179);
            this.cmbDocGender.Name = "cmbDocGender";
            this.cmbDocGender.Size = new System.Drawing.Size(214, 32);
            this.cmbDocGender.TabIndex = 9;
            this.cmbDocGender.Text = " Select...";
            // 
            // cmbDocDeptID
            // 
            this.cmbDocDeptID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbDocDeptID.FormattingEnabled = true;
            this.cmbDocDeptID.Location = new System.Drawing.Point(297, 473);
            this.cmbDocDeptID.Name = "cmbDocDeptID";
            this.cmbDocDeptID.Size = new System.Drawing.Size(214, 32);
            this.cmbDocDeptID.TabIndex = 6;
            this.cmbDocDeptID.Text = " Select...";
            // 
            // txtDocLastName
            // 
            this.txtDocLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtDocLastName.Location = new System.Drawing.Point(296, 123);
            this.txtDocLastName.Name = "txtDocLastName";
            this.txtDocLastName.Size = new System.Drawing.Size(460, 32);
            this.txtDocLastName.TabIndex = 8;
            // 
            // txtDocFirstName
            // 
            this.txtDocFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtDocFirstName.Location = new System.Drawing.Point(296, 67);
            this.txtDocFirstName.Name = "txtDocFirstName";
            this.txtDocFirstName.Size = new System.Drawing.Size(460, 32);
            this.txtDocFirstName.TabIndex = 7;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(303, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
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
            this.tabDoctor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabBeds.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlLeftPane;
        private System.Windows.Forms.TextBox txtSearchLastName;
        public System.Windows.Forms.ComboBox comboSearchPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblAddPatients;
        private System.Windows.Forms.Label lblSearchpatients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDocQualification;
        private System.Windows.Forms.TextBox txtDocPhoneNo;
        private System.Windows.Forms.TextBox txtDocAddress;
        public System.Windows.Forms.ComboBox cmbDocGender;
        private System.Windows.Forms.TextBox txtDocLastName;
        private System.Windows.Forms.TextBox txtDocFirstName;
        public System.Windows.Forms.ComboBox cmbDocDeptID;
        private System.Windows.Forms.Button btnUpdateDoctor;
        private System.Windows.Forms.Panel pnlHomescreen;
        private System.Windows.Forms.Button btnSearchPatient;
        private HospitalDatabaseDataSet hospitalDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientDetailsBindingSource;
        private HospitalDatabaseDataSetTableAdapters.PatientDetailsTableAdapter patientDetailsTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSearchDocCriteria;
        public System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.Label lblSearchDoc1;
        private System.Windows.Forms.TextBox txtSearchDoc1;
        private System.Windows.Forms.Button btnSearchDoc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlInsertPatient;
        public System.Windows.Forms.ComboBox cmbPatientGender;
        private System.Windows.Forms.TextBox txtPatientNOK;
        private System.Windows.Forms.Button btnInsertPatient;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPatientDOB;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientForename;
        private System.Windows.Forms.Label lblDocDepartmentID2;
        private System.Windows.Forms.Label lblDocQualification2;
        private System.Windows.Forms.Label lblDocPhoneNumber2;
        private System.Windows.Forms.Label lblDocAddress2;
        private System.Windows.Forms.Label lblDocGender2;
        private System.Windows.Forms.Label lblDocLastName2;
        private System.Windows.Forms.Label lblDocFirstName2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDocIdlabel;
        private System.Windows.Forms.Label lblDocID;
    }
}