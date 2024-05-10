namespace DVLD
{
    partial class frmAddEditPerson
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
            this.ctrlAddEditPeron1 = new DVLD.ctrlAddEditPeron();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(851, 32);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "?????";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlAddEditPeron1
            // 
            this.ctrlAddEditPeron1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(213)))), ((int)(((byte)(217)))));
            this.ctrlAddEditPeron1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ctrlAddEditPeron1.Location = new System.Drawing.Point(33, 84);
            this.ctrlAddEditPeron1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlAddEditPeron1.MinimumSize = new System.Drawing.Size(829, 420);
            this.ctrlAddEditPeron1.Name = "ctrlAddEditPeron1";
            this.ctrlAddEditPeron1.Padding = new System.Windows.Forms.Padding(10);
            this.ctrlAddEditPeron1.Size = new System.Drawing.Size(829, 420);
            this.ctrlAddEditPeron1.TabIndex = 41;
            this.ctrlAddEditPeron1.onClickClose += new System.Action<bool>(this.ctrlAddEditPeron1_onClickClose);
            this.ctrlAddEditPeron1.OnPersonAdded += new System.Action<int>(this.ctrlAddEditPeron1_OnPersonAdded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "PersonID: ";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(134, 62);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(26, 18);
            this.lblPersonID.TabIndex = 43;
            this.lblPersonID.Text = "??";
            this.lblPersonID.Visible = false;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 547);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlAddEditPeron1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEditPerson";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "Add / Edit Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private ctrlAddEditPeron ctrlAddEditPeron1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonID;
    }
}