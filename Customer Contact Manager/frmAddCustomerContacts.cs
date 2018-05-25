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
    public partial class frmAddCustomerContacts : Form
    {
        #region Public Vars
        DataTable DT_Customers = new DataTable();
        #endregion
        #region ClassRefs
        BLL Logic = new BLL();
        #endregion
        public frmAddCustomerContacts()
        {
            InitializeComponent();
        }
        private bool Test_Db_Connection()
        {

            if (Logic.TestConnection() == false)
            {
                MessageBox.Show("There was a error connection to the database.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            } return true;
        }

        private void LoadCustomerCombo()
        {
            DataSet DS = new DataSet();

            DS = Logic.QCustomersCombo();
            DT_Customers = DS.Tables[1].Copy();
            DataRow DR = DS.Tables[0].NewRow();
            DR["ID"] = 0;
            DR["Desc"] = "--Please click the drop down or type in the Customer Name.--";

            DS.Tables[0].Rows.InsertAt(DR, 0);
            DS.AcceptChanges();

            cboCustomer.DataSource = DS.Tables[0];
            cboCustomer.DisplayMember = "Desc";
            cboCustomer.ValueMember = "ID";

        }
        private void frmAddCustomerContacts_Load(object sender, EventArgs e)
        {
            //First test to see if the Program can make a connection to the DB 
            if (!Test_Db_Connection())
            {
                //if The connection can not be made disable the main menu to prevent errors. 
                grmMain.Enabled = false;
                return;
            }          
            //Loads the customer Cobobox 
            LoadCustomerCombo();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedIndex > 0)
            {

                DataRow[] Row = DT_Customers.Select("cID = '" + cboCustomer.SelectedValue.ToString() + "'");
                if (Row.Length > 0)
                {
                   
                }
                else
                {
                    MessageBox.Show("Could not Retrieve data.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }
        private bool validateSave()
        {
            if (cboCustomer.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a Customer.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCustomer.DroppedDown = true;
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter contact name.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.BackColor = Color.IndianRed;
                return false;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("Please enter contact e-mail.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtemail.BackColor = Color.IndianRed;
                return false;
            }
            if (txtContact.Text == "")
            {
                MessageBox.Show("Please enter contact, contact number.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContact.BackColor = Color.IndianRed;
                return false;
            }
            return true;
        }
        //Clears the fields for next customer
        private void ClearFields()
        {
            LoadCustomerCombo();
            txtName.Text = "";
            txtemail.Text = "";
            txtContact.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateSave())
            {
                DataSet DS = new DataSet();
               DS =  Logic.ICustomerContact(Convert.ToInt32(cboCustomer.SelectedValue.ToString()),
                                       txtName.Text.Trim(),
                                       txtemail.Text.Trim(),
                                       txtContact.Text.Trim());

                if (DS.Tables.Count > 0)
                {
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show(DS.Tables[0].Rows[0]["Message"].ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
        }
    }
}
