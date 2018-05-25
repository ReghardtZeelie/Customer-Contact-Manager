namespace Customer_Contact_Manager
{
    partial class frmAddCustomerContacts
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
            this.grmMain = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grmMain
            // 
            this.grmMain.Controls.Add(this.btnSave);
            this.grmMain.Controls.Add(this.lblContact);
            this.grmMain.Controls.Add(this.lblEmail);
            this.grmMain.Controls.Add(this.cboCustomer);
            this.grmMain.Controls.Add(this.lblName);
            this.grmMain.Controls.Add(this.txtContact);
            this.grmMain.Controls.Add(this.txtemail);
            this.grmMain.Controls.Add(this.txtName);
            this.grmMain.Location = new System.Drawing.Point(12, 12);
            this.grmMain.Name = "grmMain";
            this.grmMain.Size = new System.Drawing.Size(444, 207);
            this.grmMain.TabIndex = 0;
            this.grmMain.TabStop = false;
            this.grmMain.Text = "Please complete the following:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(310, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 66);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(6, 113);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(87, 13);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Mail:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(6, 24);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(432, 21);
            this.cboCustomer.TabIndex = 4;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(96, 110);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(342, 20);
            this.txtContact.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(96, 84);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(342, 20);
            this.txtemail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(342, 20);
            this.txtName.TabIndex = 0;
            // 
            // frmAddCustomerContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 231);
            this.Controls.Add(this.grmMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCustomerContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = ":: Add Customer Contacts ::";
            this.Load += new System.EventHandler(this.frmAddCustomerContacts_Load);
            this.grmMain.ResumeLayout(false);
            this.grmMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grmMain;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
    }
}