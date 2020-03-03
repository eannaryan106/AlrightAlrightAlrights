namespace Hospital_Source_Code
{
    partial class PatientsDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsDashboard));
            this.tabPatient = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.pnlInsertPatient = new System.Windows.Forms.Panel();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.pnlErrors = new System.Windows.Forms.Panel();
            this.lblKinError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblGenderError = new System.Windows.Forms.Label();
            this.lblDOBError = new System.Windows.Forms.Label();
            this.lblSurnameError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.cmbPatientGender = new System.Windows.Forms.ComboBox();
            this.txtPatientNOK = new System.Windows.Forms.TextBox();
            this.btnInsertPatient = new System.Windows.Forms.Button();
            this.lblPatientKin = new System.Windows.Forms.Label();
            this.lblPatientPhone = new System.Windows.Forms.Label();
            this.lblPatientAddress = new System.Windows.Forms.Label();
            this.lblPatientGender = new System.Windows.Forms.Label();
            this.lblPatientDOB = new System.Windows.Forms.Label();
            this.lblPatientSurname = new System.Windows.Forms.Label();
            this.lblPatientForename = new System.Windows.Forms.Label();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPatientDOB = new System.Windows.Forms.TextBox();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPatientForename = new System.Windows.Forms.TextBox();
            this.pnlHomescreen = new System.Windows.Forms.Panel();
            this.pnlLeftPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lblAddPatients = new System.Windows.Forms.Label();
            this.lblSearchpatients = new System.Windows.Forms.Label();
            this.comboSearchPatient = new System.Windows.Forms.ComboBox();
            this.txtSearchPat = new System.Windows.Forms.TextBox();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.tabPatient.SuspendLayout();
            this.tabPatients.SuspendLayout();
            this.pnlInsertPatient.SuspendLayout();
            this.pnlErrors.SuspendLayout();
            this.pnlLeftPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.tabPatients);
            this.tabPatient.Controls.Add(this.tabRooms);
            this.tabPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatient.ItemSize = new System.Drawing.Size(100, 40);
            this.tabPatient.Location = new System.Drawing.Point(0, 0);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.SelectedIndex = 0;
            this.tabPatient.Size = new System.Drawing.Size(1073, 685);
            this.tabPatient.TabIndex = 0;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.pnlInsertPatient);
            this.tabPatients.Controls.Add(this.pnlHomescreen);
            this.tabPatients.Controls.Add(this.pnlLeftPane);
            this.tabPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPatients.Location = new System.Drawing.Point(4, 44);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(1065, 637);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "    PATIENTS   ";
            this.tabPatients.UseVisualStyleBackColor = true;
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
            this.pnlInsertPatient.Controls.Add(this.lblPatientForename);
            this.pnlInsertPatient.Controls.Add(this.txtPatientPhone);
            this.pnlInsertPatient.Controls.Add(this.txtPatientDOB);
            this.pnlInsertPatient.Controls.Add(this.txtPatientSurname);
            this.pnlInsertPatient.Controls.Add(this.txtPatientForename);
            this.pnlInsertPatient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInsertPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInsertPatient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnlInsertPatient.Location = new System.Drawing.Point(273, -5);
            this.pnlInsertPatient.Name = "pnlInsertPatient";
            this.pnlInsertPatient.Size = new System.Drawing.Size(789, 639);
            this.pnlInsertPatient.TabIndex = 20;
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
            this.txtPatientAddress.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            this.txtPatientAddress.Leave += new System.EventHandler(this.txtPatientAddress_Leave_1);
            // 
            // pnlErrors
            // 
            this.pnlErrors.BackColor = System.Drawing.Color.Transparent;
            this.pnlErrors.Controls.Add(this.lblKinError);
            this.pnlErrors.Controls.Add(this.lblPhoneError);
            this.pnlErrors.Controls.Add(this.lblAddressError);
            this.pnlErrors.Controls.Add(this.lblGenderError);
            this.pnlErrors.Controls.Add(this.lblDOBError);
            this.pnlErrors.Controls.Add(this.lblSurnameError);
            this.pnlErrors.Controls.Add(this.lblNameError);
            this.pnlErrors.Location = new System.Drawing.Point(441, 60);
            this.pnlErrors.Name = "pnlErrors";
            this.pnlErrors.Size = new System.Drawing.Size(343, 451);
            this.pnlErrors.TabIndex = 18;
            // 
            // lblKinError
            // 
            this.lblKinError.AutoSize = true;
            this.lblKinError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinError.ForeColor = System.Drawing.Color.Red;
            this.lblKinError.Location = new System.Drawing.Point(13, 405);
            this.lblKinError.Name = "lblKinError";
            this.lblKinError.Size = new System.Drawing.Size(72, 14);
            this.lblKinError.TabIndex = 6;
            this.lblKinError.Text = "Invalid entry";
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(13, 347);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(72, 14);
            this.lblPhoneError.TabIndex = 5;
            this.lblPhoneError.Text = "Invalid entry";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(97, 233);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(72, 14);
            this.lblAddressError.TabIndex = 4;
            this.lblAddressError.Text = "Invalid entry";
            // 
            // lblGenderError
            // 
            this.lblGenderError.AutoSize = true;
            this.lblGenderError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderError.ForeColor = System.Drawing.Color.Red;
            this.lblGenderError.Location = new System.Drawing.Point(13, 175);
            this.lblGenderError.Name = "lblGenderError";
            this.lblGenderError.Size = new System.Drawing.Size(72, 14);
            this.lblGenderError.TabIndex = 3;
            this.lblGenderError.Text = "Invalid entry";
            // 
            // lblDOBError
            // 
            this.lblDOBError.AutoSize = true;
            this.lblDOBError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBError.ForeColor = System.Drawing.Color.Red;
            this.lblDOBError.Location = new System.Drawing.Point(13, 119);
            this.lblDOBError.Name = "lblDOBError";
            this.lblDOBError.Size = new System.Drawing.Size(72, 14);
            this.lblDOBError.TabIndex = 2;
            this.lblDOBError.Text = "Invalid entry";
            // 
            // lblSurnameError
            // 
            this.lblSurnameError.AutoSize = true;
            this.lblSurnameError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameError.ForeColor = System.Drawing.Color.Red;
            this.lblSurnameError.Location = new System.Drawing.Point(13, 57);
            this.lblSurnameError.Name = "lblSurnameError";
            this.lblSurnameError.Size = new System.Drawing.Size(72, 14);
            this.lblSurnameError.TabIndex = 1;
            this.lblSurnameError.Text = "Invalid entry";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(13, 3);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(72, 14);
            this.lblNameError.TabIndex = 0;
            this.lblNameError.Text = "Invalid entry";
            // 
            // cmbPatientGender
            // 
            this.cmbPatientGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.cmbPatientGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.cmbPatientGender.FormattingEnabled = true;
            this.cmbPatientGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbPatientGender.Location = new System.Drawing.Point(232, 235);
            this.cmbPatientGender.Name = "cmbPatientGender";
            this.cmbPatientGender.Size = new System.Drawing.Size(203, 32);
            this.cmbPatientGender.TabIndex = 5;
            this.cmbPatientGender.Text = " Select...";
            this.cmbPatientGender.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            // 
            // txtPatientNOK
            // 
            this.txtPatientNOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientNOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientNOK.Location = new System.Drawing.Point(232, 465);
            this.txtPatientNOK.Name = "txtPatientNOK";
            this.txtPatientNOK.Size = new System.Drawing.Size(203, 32);
            this.txtPatientNOK.TabIndex = 17;
            this.txtPatientNOK.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            this.txtPatientNOK.Leave += new System.EventHandler(this.txtPatientNOK_Leave_1);
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
            this.lblPatientSurname.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            // 
            // lblPatientForename
            // 
            this.lblPatientForename.AutoSize = true;
            this.lblPatientForename.Location = new System.Drawing.Point(82, 63);
            this.lblPatientForename.Name = "lblPatientForename";
            this.lblPatientForename.Size = new System.Drawing.Size(108, 24);
            this.lblPatientForename.TabIndex = 10;
            this.lblPatientForename.Text = "First name:";
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientPhone.Location = new System.Drawing.Point(232, 404);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(203, 32);
            this.txtPatientPhone.TabIndex = 8;
            this.txtPatientPhone.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            this.txtPatientPhone.Leave += new System.EventHandler(this.txtPatientPhone_Leave_1);
            // 
            // txtPatientDOB
            // 
            this.txtPatientDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientDOB.Location = new System.Drawing.Point(232, 177);
            this.txtPatientDOB.Name = "txtPatientDOB";
            this.txtPatientDOB.Size = new System.Drawing.Size(203, 32);
            this.txtPatientDOB.TabIndex = 7;
            this.txtPatientDOB.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            this.txtPatientDOB.Leave += new System.EventHandler(this.txtPatientDOB_Leave_1);
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientSurname.Location = new System.Drawing.Point(232, 118);
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(203, 32);
            this.txtPatientSurname.TabIndex = 6;
            this.txtPatientSurname.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            this.txtPatientSurname.Leave += new System.EventHandler(this.txtPatientSurname_Leave_1);
            // 
            // txtPatientForename
            // 
            this.txtPatientForename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.txtPatientForename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtPatientForename.Location = new System.Drawing.Point(232, 60);
            this.txtPatientForename.Name = "txtPatientForename";
            this.txtPatientForename.Size = new System.Drawing.Size(203, 32);
            this.txtPatientForename.TabIndex = 5;
            this.txtPatientForename.TextChanged += new System.EventHandler(this.txtPatientForename_TextChanged);
            this.txtPatientForename.Leave += new System.EventHandler(this.txtPatientForename_Leave_1);
            // 
            // pnlHomescreen
            // 
            this.pnlHomescreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHomescreen.BackgroundImage")));
            this.pnlHomescreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHomescreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomescreen.Location = new System.Drawing.Point(273, 3);
            this.pnlHomescreen.Name = "pnlHomescreen";
            this.pnlHomescreen.Size = new System.Drawing.Size(789, 638);
            this.pnlHomescreen.TabIndex = 3;
            // 
            // pnlLeftPane
            // 
            this.pnlLeftPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.pnlLeftPane.Controls.Add(this.label1);
            this.pnlLeftPane.Controls.Add(this.btnSearchPatient);
            this.pnlLeftPane.Controls.Add(this.btnAddPatient);
            this.pnlLeftPane.Controls.Add(this.lblAddPatients);
            this.pnlLeftPane.Controls.Add(this.lblSearchpatients);
            this.pnlLeftPane.Controls.Add(this.comboSearchPatient);
            this.pnlLeftPane.Controls.Add(this.txtSearchPat);
            this.pnlLeftPane.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftPane.Location = new System.Drawing.Point(3, 3);
            this.pnlLeftPane.Name = "pnlLeftPane";
            this.pnlLeftPane.Size = new System.Drawing.Size(270, 631);
            this.pnlLeftPane.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(49, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type...";
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatient.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearchPatient.Location = new System.Drawing.Point(62, 238);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(131, 46);
            this.btnSearchPatient.TabIndex = 5;
            this.btnSearchPatient.Text = "SEARCH";
            this.btnSearchPatient.UseVisualStyleBackColor = false;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblAddPatients.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblSearchpatients.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchpatients.ForeColor = System.Drawing.Color.White;
            this.lblSearchpatients.Location = new System.Drawing.Point(45, 45);
            this.lblSearchpatients.Name = "lblSearchpatients";
            this.lblSearchpatients.Size = new System.Drawing.Size(152, 24);
            this.lblSearchpatients.TabIndex = 2;
            this.lblSearchpatients.Text = "Search patients:";
            // 
            // comboSearchPatient
            // 
            this.comboSearchPatient.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchPatient.ForeColor = System.Drawing.Color.MidnightBlue;
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
            // txtSearchPat
            // 
            this.txtSearchPat.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(81)))), ((int)(((byte)(123)))));
            this.txtSearchPat.Location = new System.Drawing.Point(45, 171);
            this.txtSearchPat.Name = "txtSearchPat";
            this.txtSearchPat.Size = new System.Drawing.Size(166, 32);
            this.txtSearchPat.TabIndex = 0;
            this.txtSearchPat.Enter += new System.EventHandler(this.txtSearchLastName_Enter);
            this.txtSearchPat.Leave += new System.EventHandler(this.txtSearchLastName_Leave);
            // 
            // tabRooms
            // 
            this.tabRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRooms.Location = new System.Drawing.Point(4, 44);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(1065, 637);
            this.tabRooms.TabIndex = 1;
            this.tabRooms.Text = "    ROOMS    ";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // PatientsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 685);
            this.Controls.Add(this.tabPatient);
            this.Name = "PatientsDashboard";
            this.Text = "PatientsDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PatientsDashboard_FormClosing);
            this.tabPatient.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            this.pnlInsertPatient.ResumeLayout(false);
            this.pnlInsertPatient.PerformLayout();
            this.pnlErrors.ResumeLayout(false);
            this.pnlErrors.PerformLayout();
            this.pnlLeftPane.ResumeLayout(false);
            this.pnlLeftPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPatient;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.Panel pnlLeftPane;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblAddPatients;
        private System.Windows.Forms.Label lblSearchpatients;
        public System.Windows.Forms.ComboBox comboSearchPatient;
        private System.Windows.Forms.TextBox txtSearchPat;
        private System.Windows.Forms.Panel pnlHomescreen;
        private System.Windows.Forms.Panel pnlInsertPatient;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.Panel pnlErrors;
        private System.Windows.Forms.Label lblKinError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblGenderError;
        private System.Windows.Forms.Label lblDOBError;
        private System.Windows.Forms.Label lblSurnameError;
        private System.Windows.Forms.Label lblNameError;
        public System.Windows.Forms.ComboBox cmbPatientGender;
        private System.Windows.Forms.TextBox txtPatientNOK;
        private System.Windows.Forms.Button btnInsertPatient;
        private System.Windows.Forms.Label lblPatientKin;
        private System.Windows.Forms.Label lblPatientPhone;
        private System.Windows.Forms.Label lblPatientAddress;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.Label lblPatientDOB;
        private System.Windows.Forms.Label lblPatientSurname;
        private System.Windows.Forms.Label lblPatientForename;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPatientDOB;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientForename;
        private System.Windows.Forms.Label label1;
    }
}