﻿namespace Hospital_Source_Code
{
    partial class SearchDoctorsSurname
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
            this.dGDDoctors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGDDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dGDDoctors
            // 
            this.dGDDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGDDoctors.Location = new System.Drawing.Point(44, 29);
            this.dGDDoctors.Name = "dGDDoctors";
            this.dGDDoctors.Size = new System.Drawing.Size(543, 255);
            this.dGDDoctors.TabIndex = 0;
            // 
            // SearchDoctorsSurname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGDDoctors);
            this.Name = "SearchDoctorsSurname";
            this.Text = "SearchDoctorsSurname";
            ((System.ComponentModel.ISupportInitialize)(this.dGDDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGDDoctors;
    }
}