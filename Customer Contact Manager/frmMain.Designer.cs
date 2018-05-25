namespace Customer_Contact_Manager
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
            this.PMainPannel = new System.Windows.Forms.Panel();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnAddCustomerContacts = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.PMainPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMainPannel
            // 
            this.PMainPannel.Controls.Add(this.btnViewCustomers);
            this.PMainPannel.Controls.Add(this.btnAddCustomerContacts);
            this.PMainPannel.Controls.Add(this.btnAddCustomer);
            this.PMainPannel.Location = new System.Drawing.Point(167, 129);
            this.PMainPannel.Name = "PMainPannel";
            this.PMainPannel.Size = new System.Drawing.Size(454, 285);
            this.PMainPannel.TabIndex = 0;
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewCustomers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.Location = new System.Drawing.Point(3, 193);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(448, 89);
            this.btnViewCustomers.TabIndex = 23;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnAddCustomerContacts
            // 
            this.btnAddCustomerContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomerContacts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCustomerContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomerContacts.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomerContacts.Location = new System.Drawing.Point(3, 98);
            this.btnAddCustomerContacts.Name = "btnAddCustomerContacts";
            this.btnAddCustomerContacts.Size = new System.Drawing.Size(448, 89);
            this.btnAddCustomerContacts.TabIndex = 22;
            this.btnAddCustomerContacts.Text = "Add Customer Contacts";
            this.btnAddCustomerContacts.UseVisualStyleBackColor = false;
            this.btnAddCustomerContacts.Click += new System.EventHandler(this.btnAddCustomerContacts_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(448, 89);
            this.btnAddCustomer.TabIndex = 21;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 584);
            this.Controls.Add(this.PMainPannel);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged_1);
            this.PMainPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMainPannel;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnAddCustomerContacts;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}