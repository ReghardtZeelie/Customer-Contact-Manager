namespace Customer_Contact_Manager
{
    partial class frmAddCustomer
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
            this.lblLong = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grmMain
            // 
            this.grmMain.Controls.Add(this.lblLong);
            this.grmMain.Controls.Add(this.lblLat);
            this.grmMain.Controls.Add(this.txtLong);
            this.grmMain.Controls.Add(this.txtLat);
            this.grmMain.Controls.Add(this.TxtName);
            this.grmMain.Controls.Add(this.lblName);
            this.grmMain.Controls.Add(this.btnSave);
            this.grmMain.Location = new System.Drawing.Point(12, 12);
            this.grmMain.Name = "grmMain";
            this.grmMain.Size = new System.Drawing.Size(384, 155);
            this.grmMain.TabIndex = 0;
            this.grmMain.TabStop = false;
            this.grmMain.Text = "Please complete the following:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(17, 87);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(57, 13);
            this.lblLong.TabIndex = 27;
            this.lblLong.Text = "Longitude:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(17, 61);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(48, 13);
            this.lblLat.TabIndex = 26;
            this.lblLat.Text = "Latitude:";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(111, 84);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(253, 20);
            this.txtLong.TabIndex = 24;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(111, 58);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(253, 20);
            this.txtLat.TabIndex = 23;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(111, 32);
            this.TxtName.MaxLength = 100;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(253, 20);
            this.TxtName.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(236, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 38);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 178);
            this.Controls.Add(this.grmMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Add Customer ::";
           
            this.grmMain.ResumeLayout(false);
            this.grmMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grmMain;
        private System.Windows.Forms.Label lblLong;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
    }
}