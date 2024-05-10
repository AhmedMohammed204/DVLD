namespace DVLD
{
    partial class frmDrivingLicenseServices
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gbAddNew = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddNewInternationalLicense = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewLocalLicense = new Guna.UI2.WinForms.Guna2Button();
            this.btnReplacement = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gbAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(641, 62);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Driving License Services";
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 5;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Gray;
            this.btnBack.FillColor2 = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(17, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 34);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbAddNew
            // 
            this.gbAddNew.Controls.Add(this.btnAddNewInternationalLicense);
            this.gbAddNew.Controls.Add(this.btnAddNewLocalLicense);
            this.gbAddNew.FillColor = System.Drawing.Color.Transparent;
            this.gbAddNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbAddNew.Location = new System.Drawing.Point(81, 162);
            this.gbAddNew.Name = "gbAddNew";
            this.gbAddNew.Size = new System.Drawing.Size(243, 231);
            this.gbAddNew.TabIndex = 12;
            this.gbAddNew.Text = "Add New";
            // 
            // btnAddNewInternationalLicense
            // 
            this.btnAddNewInternationalLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewInternationalLicense.BorderRadius = 20;
            this.btnAddNewInternationalLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewInternationalLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewInternationalLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewInternationalLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewInternationalLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnAddNewInternationalLicense.ForeColor = System.Drawing.Color.White;
            this.btnAddNewInternationalLicense.Location = new System.Drawing.Point(-2, 130);
            this.btnAddNewInternationalLicense.Name = "btnAddNewInternationalLicense";
            this.btnAddNewInternationalLicense.Size = new System.Drawing.Size(242, 42);
            this.btnAddNewInternationalLicense.TabIndex = 15;
            this.btnAddNewInternationalLicense.Text = "International License";
            this.btnAddNewInternationalLicense.Click += new System.EventHandler(this.btnAddNewInternationalLicense_Click);
            // 
            // btnAddNewLocalLicense
            // 
            this.btnAddNewLocalLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewLocalLicense.BorderRadius = 20;
            this.btnAddNewLocalLicense.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewLocalLicense.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewLocalLicense.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewLocalLicense.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewLocalLicense.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnAddNewLocalLicense.ForeColor = System.Drawing.Color.White;
            this.btnAddNewLocalLicense.Location = new System.Drawing.Point(-2, 64);
            this.btnAddNewLocalLicense.Name = "btnAddNewLocalLicense";
            this.btnAddNewLocalLicense.Size = new System.Drawing.Size(242, 42);
            this.btnAddNewLocalLicense.TabIndex = 14;
            this.btnAddNewLocalLicense.Text = "Local License";
            this.btnAddNewLocalLicense.Click += new System.EventHandler(this.btnAddNewLocalLicense_Click);
            // 
            // btnReplacement
            // 
            this.btnReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplacement.BackColor = System.Drawing.Color.Transparent;
            this.btnReplacement.BorderRadius = 20;
            this.btnReplacement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReplacement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReplacement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReplacement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReplacement.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnReplacement.ForeColor = System.Drawing.Color.White;
            this.btnReplacement.Location = new System.Drawing.Point(360, 162);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Size = new System.Drawing.Size(242, 42);
            this.btnReplacement.TabIndex = 16;
            this.btnReplacement.Text = "Replacement License";
            this.btnReplacement.Click += new System.EventHandler(this.btnReplacement_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(360, 226);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(242, 42);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "Renew License";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmDrivingLicenseServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnReplacement);
            this.Controls.Add(this.gbAddNew);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmDrivingLicenseServices";
            this.Text = "frmDrivingLicenseServices";
            this.Load += new System.EventHandler(this.frmDrivingLicenseServices_Load);
            this.gbAddNew.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        private Guna.UI2.WinForms.Guna2GroupBox gbAddNew;
        private Guna.UI2.WinForms.Guna2Button btnAddNewLocalLicense;
        private Guna.UI2.WinForms.Guna2Button btnAddNewInternationalLicense;
        private Guna.UI2.WinForms.Guna2Button btnReplacement;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}