namespace Hospital_Source_Code
{
    partial class BedDashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSearchDocCriteria = new System.Windows.Forms.Label();
            this.cmbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.lblSearchDoc1 = new System.Windows.Forms.Label();
            this.txtSearchDoc1 = new System.Windows.Forms.TextBox();
            this.btnSearchDoc = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(149)))), ((int)(((byte)(193)))));
            this.panel4.Controls.Add(this.lblSearchDocCriteria);
            this.panel4.Controls.Add(this.cmbSearchCriteria);
            this.panel4.Controls.Add(this.lblSearchDoc1);
            this.panel4.Controls.Add(this.txtSearchDoc1);
            this.panel4.Controls.Add(this.btnSearchDoc);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 760);
            this.panel4.TabIndex = 2;
            // 
            // lblSearchDocCriteria
            // 
            this.lblSearchDocCriteria.AutoSize = true;
            this.lblSearchDocCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchDocCriteria.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDocCriteria.ForeColor = System.Drawing.Color.White;
            this.lblSearchDocCriteria.Location = new System.Drawing.Point(20, 43);
            this.lblSearchDocCriteria.Name = "lblSearchDocCriteria";
            this.lblSearchDocCriteria.Size = new System.Drawing.Size(199, 24);
            this.lblSearchDocCriteria.TabIndex = 21;
            this.lblSearchDocCriteria.Text = "Select Search Criteria";
            // 
            // cmbSearchCriteria
            // 
            this.cmbSearchCriteria.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbSearchCriteria.FormattingEnabled = true;
            this.cmbSearchCriteria.Items.AddRange(new object[] {
            "ID",
            "Surname"});
            this.cmbSearchCriteria.Location = new System.Drawing.Point(45, 102);
            this.cmbSearchCriteria.Name = "cmbSearchCriteria";
            this.cmbSearchCriteria.Size = new System.Drawing.Size(166, 21);
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
            this.lblSearchDoc1.Size = new System.Drawing.Size(0, 18);
            this.lblSearchDoc1.TabIndex = 20;
            // 
            // txtSearchDoc1
            // 
            this.txtSearchDoc1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSearchDoc1.Location = new System.Drawing.Point(45, 171);
            this.txtSearchDoc1.Name = "txtSearchDoc1";
            this.txtSearchDoc1.Size = new System.Drawing.Size(166, 20);
            this.txtSearchDoc1.TabIndex = 20;
            // 
            // btnSearchDoc
            // 
            this.btnSearchDoc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearchDoc.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnSearchDoc.Location = new System.Drawing.Point(62, 238);
            this.btnSearchDoc.Name = "btnSearchDoc";
            this.btnSearchDoc.Size = new System.Drawing.Size(131, 46);
            this.btnSearchDoc.TabIndex = 20;
            this.btnSearchDoc.Text = "SEARCH";
            this.btnSearchDoc.UseVisualStyleBackColor = true;
            this.btnSearchDoc.Click += new System.EventHandler(this.btnSearchDoc_Click);
            // 
            // BedDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1217, 760);
            this.Controls.Add(this.panel4);
            this.Name = "BedDashboard";
            this.Text = "BedDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSearchDocCriteria;
        public System.Windows.Forms.ComboBox cmbSearchCriteria;
        private System.Windows.Forms.Label lblSearchDoc1;
        private System.Windows.Forms.TextBox txtSearchDoc1;
        private System.Windows.Forms.Button btnSearchDoc;
    }
}