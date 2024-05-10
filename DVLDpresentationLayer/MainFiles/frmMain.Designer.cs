namespace DVLD
{
    partial class frmMain
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
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnManagePeople = new System.Windows.Forms.Button();
            this.panelApplications = new System.Windows.Forms.Panel();
            this.panelManageApplication = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnManageLocalApplications = new System.Windows.Forms.Button();
            this.btnManageApplications = new System.Windows.Forms.Button();
            this.panelDrivingLicenseServices = new System.Windows.Forms.Panel();
            this.panelAddNewDrivingLicense = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddLocalDrivingLicense = new System.Windows.Forms.Button();
            this.btnAddNewDrivingLicense = new System.Windows.Forms.Button();
            this.btnDrivingLicenseServices = new System.Windows.Forms.Button();
            this.btnManageTestTypes = new System.Windows.Forms.Button();
            this.btnApplicationTypes = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelAccountSubMenu = new System.Windows.Forms.Panel();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCurrentUserInfo = new System.Windows.Forms.Button();
            this.btnAccountSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblPageName = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelLeftSide.SuspendLayout();
            this.panelApplications.SuspendLayout();
            this.panelManageApplication.SuspendLayout();
            this.panelDrivingLicenseServices.SuspendLayout();
            this.panelAddNewDrivingLicense.SuspendLayout();
            this.panelAccountSubMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.AutoScroll = true;
            this.panelLeftSide.Controls.Add(this.btnDrivers);
            this.panelLeftSide.Controls.Add(this.btnManagePeople);
            this.panelLeftSide.Controls.Add(this.panelApplications);
            this.panelLeftSide.Controls.Add(this.btnApplications);
            this.panelLeftSide.Controls.Add(this.btnUsers);
            this.panelLeftSide.Controls.Add(this.panelAccountSubMenu);
            this.panelLeftSide.Controls.Add(this.btnAccountSettings);
            this.panelLeftSide.Controls.Add(this.panel1);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(247, 593);
            this.panelLeftSide.TabIndex = 0;
            this.panelLeftSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftSide_Paint);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.Transparent;
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Location = new System.Drawing.Point(0, 687);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(230, 63);
            this.btnDrivers.TabIndex = 7;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnManagePeople
            // 
            this.btnManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.btnManagePeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagePeople.FlatAppearance.BorderSize = 0;
            this.btnManagePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagePeople.Location = new System.Drawing.Point(0, 624);
            this.btnManagePeople.Name = "btnManagePeople";
            this.btnManagePeople.Size = new System.Drawing.Size(230, 63);
            this.btnManagePeople.TabIndex = 6;
            this.btnManagePeople.Text = "People";
            this.btnManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagePeople.UseVisualStyleBackColor = false;
            this.btnManagePeople.Click += new System.EventHandler(this.btnManagePeople_Click);
            // 
            // panelApplications
            // 
            this.panelApplications.AutoScroll = true;
            this.panelApplications.Controls.Add(this.panelManageApplication);
            this.panelApplications.Controls.Add(this.btnManageApplications);
            this.panelApplications.Controls.Add(this.panelDrivingLicenseServices);
            this.panelApplications.Controls.Add(this.btnDrivingLicenseServices);
            this.panelApplications.Controls.Add(this.btnManageTestTypes);
            this.panelApplications.Controls.Add(this.btnApplicationTypes);
            this.panelApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApplications.Location = new System.Drawing.Point(0, 451);
            this.panelApplications.Name = "panelApplications";
            this.panelApplications.Size = new System.Drawing.Size(230, 173);
            this.panelApplications.TabIndex = 5;
            this.panelApplications.Visible = false;
            // 
            // panelManageApplication
            // 
            this.panelManageApplication.Controls.Add(this.button2);
            this.panelManageApplication.Controls.Add(this.btnManageLocalApplications);
            this.panelManageApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageApplication.Location = new System.Drawing.Point(0, 400);
            this.panelManageApplication.Name = "panelManageApplication";
            this.panelManageApplication.Size = new System.Drawing.Size(213, 120);
            this.panelManageApplication.TabIndex = 10;
            this.panelManageApplication.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 56);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(213, 61);
            this.button2.TabIndex = 10;
            this.button2.Text = "International Driving License";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManageLocalApplications
            // 
            this.btnManageLocalApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnManageLocalApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageLocalApplications.FlatAppearance.BorderSize = 0;
            this.btnManageLocalApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLocalApplications.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLocalApplications.Location = new System.Drawing.Point(0, 0);
            this.btnManageLocalApplications.Name = "btnManageLocalApplications";
            this.btnManageLocalApplications.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnManageLocalApplications.Size = new System.Drawing.Size(213, 56);
            this.btnManageLocalApplications.TabIndex = 9;
            this.btnManageLocalApplications.Text = "Local Driving License";
            this.btnManageLocalApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageLocalApplications.UseVisualStyleBackColor = false;
            this.btnManageLocalApplications.Click += new System.EventHandler(this.btnManageLocalApplications_Click);
            // 
            // btnManageApplications
            // 
            this.btnManageApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnManageApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageApplications.FlatAppearance.BorderSize = 0;
            this.btnManageApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApplications.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageApplications.Location = new System.Drawing.Point(0, 344);
            this.btnManageApplications.Name = "btnManageApplications";
            this.btnManageApplications.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageApplications.Size = new System.Drawing.Size(213, 56);
            this.btnManageApplications.TabIndex = 9;
            this.btnManageApplications.Text = "Manage Applications";
            this.btnManageApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApplications.UseVisualStyleBackColor = false;
            this.btnManageApplications.Click += new System.EventHandler(this.btnManageApplications_Click);
            // 
            // panelDrivingLicenseServices
            // 
            this.panelDrivingLicenseServices.Controls.Add(this.panelAddNewDrivingLicense);
            this.panelDrivingLicenseServices.Controls.Add(this.btnAddNewDrivingLicense);
            this.panelDrivingLicenseServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrivingLicenseServices.Location = new System.Drawing.Point(0, 168);
            this.panelDrivingLicenseServices.Name = "panelDrivingLicenseServices";
            this.panelDrivingLicenseServices.Size = new System.Drawing.Size(213, 176);
            this.panelDrivingLicenseServices.TabIndex = 8;
            this.panelDrivingLicenseServices.Visible = false;
            // 
            // panelAddNewDrivingLicense
            // 
            this.panelAddNewDrivingLicense.Controls.Add(this.button1);
            this.panelAddNewDrivingLicense.Controls.Add(this.btnAddLocalDrivingLicense);
            this.panelAddNewDrivingLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddNewDrivingLicense.Location = new System.Drawing.Point(0, 56);
            this.panelAddNewDrivingLicense.Name = "panelAddNewDrivingLicense";
            this.panelAddNewDrivingLicense.Size = new System.Drawing.Size(213, 137);
            this.panelAddNewDrivingLicense.TabIndex = 9;
            this.panelAddNewDrivingLicense.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 56);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(213, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "International Driving License";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddLocalDrivingLicense
            // 
            this.btnAddLocalDrivingLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLocalDrivingLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddLocalDrivingLicense.FlatAppearance.BorderSize = 0;
            this.btnAddLocalDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocalDrivingLicense.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocalDrivingLicense.Location = new System.Drawing.Point(0, 0);
            this.btnAddLocalDrivingLicense.Name = "btnAddLocalDrivingLicense";
            this.btnAddLocalDrivingLicense.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAddLocalDrivingLicense.Size = new System.Drawing.Size(213, 56);
            this.btnAddLocalDrivingLicense.TabIndex = 9;
            this.btnAddLocalDrivingLicense.Text = "Local Driving License";
            this.btnAddLocalDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLocalDrivingLicense.UseVisualStyleBackColor = false;
            this.btnAddLocalDrivingLicense.Click += new System.EventHandler(this.btnAddLocalDrivingLicense_Click);
            // 
            // btnAddNewDrivingLicense
            // 
            this.btnAddNewDrivingLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewDrivingLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewDrivingLicense.FlatAppearance.BorderSize = 0;
            this.btnAddNewDrivingLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewDrivingLicense.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewDrivingLicense.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewDrivingLicense.Name = "btnAddNewDrivingLicense";
            this.btnAddNewDrivingLicense.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAddNewDrivingLicense.Size = new System.Drawing.Size(213, 56);
            this.btnAddNewDrivingLicense.TabIndex = 8;
            this.btnAddNewDrivingLicense.Text = "Add New";
            this.btnAddNewDrivingLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewDrivingLicense.UseVisualStyleBackColor = false;
            this.btnAddNewDrivingLicense.Click += new System.EventHandler(this.btnAddNewDrivingLicense_Click);
            // 
            // btnDrivingLicenseServices
            // 
            this.btnDrivingLicenseServices.BackColor = System.Drawing.Color.Transparent;
            this.btnDrivingLicenseServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivingLicenseServices.FlatAppearance.BorderSize = 0;
            this.btnDrivingLicenseServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivingLicenseServices.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivingLicenseServices.Location = new System.Drawing.Point(0, 112);
            this.btnDrivingLicenseServices.Name = "btnDrivingLicenseServices";
            this.btnDrivingLicenseServices.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDrivingLicenseServices.Size = new System.Drawing.Size(213, 56);
            this.btnDrivingLicenseServices.TabIndex = 7;
            this.btnDrivingLicenseServices.Text = "Driving License Services";
            this.btnDrivingLicenseServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivingLicenseServices.UseVisualStyleBackColor = false;
            this.btnDrivingLicenseServices.Click += new System.EventHandler(this.btnDrivingLicenseServices_Click);
            // 
            // btnManageTestTypes
            // 
            this.btnManageTestTypes.BackColor = System.Drawing.Color.Transparent;
            this.btnManageTestTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageTestTypes.FlatAppearance.BorderSize = 0;
            this.btnManageTestTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTestTypes.Location = new System.Drawing.Point(0, 56);
            this.btnManageTestTypes.Name = "btnManageTestTypes";
            this.btnManageTestTypes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageTestTypes.Size = new System.Drawing.Size(213, 56);
            this.btnManageTestTypes.TabIndex = 6;
            this.btnManageTestTypes.Text = "Manage Test Types";
            this.btnManageTestTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageTestTypes.UseVisualStyleBackColor = false;
            this.btnManageTestTypes.Click += new System.EventHandler(this.btnManageTestTypes_Click);
            // 
            // btnApplicationTypes
            // 
            this.btnApplicationTypes.BackColor = System.Drawing.Color.Transparent;
            this.btnApplicationTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplicationTypes.FlatAppearance.BorderSize = 0;
            this.btnApplicationTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicationTypes.Location = new System.Drawing.Point(0, 0);
            this.btnApplicationTypes.Name = "btnApplicationTypes";
            this.btnApplicationTypes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnApplicationTypes.Size = new System.Drawing.Size(213, 56);
            this.btnApplicationTypes.TabIndex = 5;
            this.btnApplicationTypes.Text = "Application Types";
            this.btnApplicationTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicationTypes.UseVisualStyleBackColor = false;
            this.btnApplicationTypes.Click += new System.EventHandler(this.btnApplicationTypes_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Location = new System.Drawing.Point(0, 388);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(230, 63);
            this.btnApplications.TabIndex = 4;
            this.btnApplications.Text = "Applications";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Location = new System.Drawing.Point(0, 325);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(230, 63);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelAccountSubMenu
            // 
            this.panelAccountSubMenu.Controls.Add(this.btnSignout);
            this.panelAccountSubMenu.Controls.Add(this.btnChangePassword);
            this.panelAccountSubMenu.Controls.Add(this.btnCurrentUserInfo);
            this.panelAccountSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccountSubMenu.Location = new System.Drawing.Point(0, 163);
            this.panelAccountSubMenu.Name = "panelAccountSubMenu";
            this.panelAccountSubMenu.Size = new System.Drawing.Size(230, 162);
            this.panelAccountSubMenu.TabIndex = 2;
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.Transparent;
            this.btnSignout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Location = new System.Drawing.Point(0, 106);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSignout.Size = new System.Drawing.Size(230, 56);
            this.btnSignout.TabIndex = 4;
            this.btnSignout.Text = "Sign out";
            this.btnSignout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Location = new System.Drawing.Point(0, 53);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(230, 53);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCurrentUserInfo
            // 
            this.btnCurrentUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrentUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrentUserInfo.FlatAppearance.BorderSize = 0;
            this.btnCurrentUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentUserInfo.Location = new System.Drawing.Point(0, 0);
            this.btnCurrentUserInfo.Name = "btnCurrentUserInfo";
            this.btnCurrentUserInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCurrentUserInfo.Size = new System.Drawing.Size(230, 53);
            this.btnCurrentUserInfo.TabIndex = 2;
            this.btnCurrentUserInfo.Text = "Current user info";
            this.btnCurrentUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurrentUserInfo.UseVisualStyleBackColor = false;
            this.btnCurrentUserInfo.Click += new System.EventHandler(this.btnCurrentUserInfo_Click);
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountSettings.FlatAppearance.BorderSize = 0;
            this.btnAccountSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSettings.Location = new System.Drawing.Point(0, 100);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.Size = new System.Drawing.Size(230, 63);
            this.btnAccountSettings.TabIndex = 1;
            this.btnAccountSettings.Text = "Account Settings";
            this.btnAccountSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSettings.UseVisualStyleBackColor = false;
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblPageName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(247, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(946, 100);
            this.panelTop.TabIndex = 1;
            // 
            // lblPageName
            // 
            this.lblPageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.Location = new System.Drawing.Point(0, 0);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(946, 100);
            this.lblPageName.TabIndex = 0;
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Black;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(247, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(946, 493);
            this.panelChildForm.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1193, 593);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeftSide);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "DVLD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.panelLeftSide.ResumeLayout(false);
            this.panelApplications.ResumeLayout(false);
            this.panelManageApplication.ResumeLayout(false);
            this.panelDrivingLicenseServices.ResumeLayout(false);
            this.panelAddNewDrivingLicense.ResumeLayout(false);
            this.panelAccountSubMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnAccountSettings;
        private System.Windows.Forms.Panel panelAccountSubMenu;
        private System.Windows.Forms.Button btnCurrentUserInfo;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Panel panelApplications;
        private System.Windows.Forms.Button btnApplicationTypes;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnManageTestTypes;
        private System.Windows.Forms.Button btnManagePeople;
        private System.Windows.Forms.Button btnDrivingLicenseServices;
        private System.Windows.Forms.Panel panelDrivingLicenseServices;
        private System.Windows.Forms.Button btnAddNewDrivingLicense;
        private System.Windows.Forms.Panel panelAddNewDrivingLicense;
        private System.Windows.Forms.Button btnAddLocalDrivingLicense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManageApplications;
        private System.Windows.Forms.Panel panelManageApplication;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnManageLocalApplications;
        private System.Windows.Forms.Button btnDrivers;
    }
}

