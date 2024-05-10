namespace DVLD
{
    partial class ctrlFindPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbAddPerson = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbFindUser = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 59);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbAddPerson);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pbFindUser);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtFilter);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cbFilter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(116, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(859, 59);
            this.panel2.TabIndex = 9;
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddPerson.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbAddPerson.Image = global::DVLD.Properties.Resources.AddNewPerson;
            this.pbAddPerson.Location = new System.Drawing.Point(712, 15);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(48, 29);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPerson.TabIndex = 16;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.Click += new System.EventHandler(this.pbAddPerson_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(499, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 29);
            this.panel5.TabIndex = 15;
            // 
            // pbFindUser
            // 
            this.pbFindUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFindUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbFindUser.Image = global::DVLD.Properties.Resources.Search;
            this.pbFindUser.Location = new System.Drawing.Point(451, 15);
            this.pbFindUser.Name = "pbFindUser";
            this.pbFindUser.Size = new System.Drawing.Size(48, 29);
            this.pbFindUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFindUser.TabIndex = 14;
            this.pbFindUser.TabStop = false;
            this.pbFindUser.Click += new System.EventHandler(this.pbFindUser_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(441, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 29);
            this.panel4.TabIndex = 13;
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFilter.Font = new System.Drawing.Font("Arial", 9.7F);
            this.txtFilter.Location = new System.Drawing.Point(248, 15);
            this.txtFilter.MaxLength = 50;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(193, 15);
            this.txtFilter.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(201, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 29);
            this.panel3.TabIndex = 11;
            // 
            // cbFilter
            // 
            this.cbFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "National No.",
            "PersonID"});
            this.cbFilter.Location = new System.Drawing.Point(15, 15);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(186, 24);
            this.cbFilter.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.AutoSize = true;
            this.ctrlPersonInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.ctrlPersonInfo1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 59);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(975, 311);
            this.ctrlPersonInfo1.TabIndex = 0;
            this.ctrlPersonInfo1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfo1_OnPersonSelected);
            this.ctrlPersonInfo1.Load += new System.EventHandler(this.ctrlPersonInfo1_Load);
            // 
            // ctrlFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(975, 370);
            this.Name = "ctrlFindPerson";
            this.Size = new System.Drawing.Size(975, 370);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbFindUser;
        private System.Windows.Forms.PictureBox pbAddPerson;
    }
}
