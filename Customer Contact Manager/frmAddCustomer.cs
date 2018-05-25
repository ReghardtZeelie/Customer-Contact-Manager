using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Customer_Contact_Manager
{
    public partial class frmAddCustomer : Form
    { 
        #region ClassRefs
        BLL Logic = new BLL();
        #endregion
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        //Make sure that the data is corret
        private bool ValidateSave()
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Please enter customer name.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtName.BackColor = Color.IndianRed;
                return false;
            }

            if (txtLat.Text == "")
            {
                MessageBox.Show("Please enter Latitude.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLat.BackColor = Color.IndianRed;
                return false;            
            }

            if (txtLat.Text != "")
            {

                try
                {
                    decimal x = decimal.Parse(txtLat.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Please enter only decimal values.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLat.BackColor = Color.IndianRed;
                    return false;
                }
            }
            if (txtLong.Text == "")
            {
                MessageBox.Show("Please enter Longitude.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLat.BackColor = Color.IndianRed;
                return false;
            }
            if (txtLong.Text != "")
            {

                try
                {
                    decimal x = decimal.Parse(txtLong.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Please enter only decimal values.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLong.BackColor = Color.IndianRed;
                    return false;
                }
            }              

            return true;
        }
        //Saves the customer in the database
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            if (ValidateSave())
            {
                try
                {
                    DS = Logic.ICustomer(TxtName.Text.Trim(),
                                       Convert.ToDecimal(txtLong.Text.Trim()),
                                       Convert.ToDecimal(txtLat.Text.Trim()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please contact your system administrator an error has occurred.", "Sytem Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if (DS.Tables.Count > 0)
                {
                    if (DS.Tables[0].Rows.Count > 0)
                    { 
                       MessageBox.Show(DS.Tables[0].Rows[0]["Message"].ToString(),"System Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                       ClearFields();
                    }
                }
               
            }
        }

        //Clears the fields for next customer
        private void ClearFields()
        {
            TxtName.Text = "";
            txtLat.Text = "";
            txtLong.Text = "";
            txtLat.BackColor = Color.White;
            txtLong.BackColor = Color.White;
            TxtName.BackColor = Color.White;
        }
       
    }
}
