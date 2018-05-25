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
    public partial class frmViewContactDetails : Form
    {
        #region GlobalVars
        int _CustomerID = 0;
        #endregion

        #region ClassRefs
        BLL Logic = new BLL();
        #endregion
        public frmViewContactDetails(int CustomerID)
        {
            _CustomerID = CustomerID;
            InitializeComponent();
        }
        //Loads all the contacts for that Customer
        private void LoadCustomerContacts()
        {

            DataSet DS = new DataSet();
            DS = Logic.QCustomerContacts(_CustomerID);
            if (DS.Tables[0].Rows.Count > 0)
            {

                dgv.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("This Customer has no Contacts", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmViewContactDetails_Load(object sender, EventArgs e)
        {
            //Prevent the grid from showing columns that dont need to be there.
            dgv.AutoGenerateColumns = false;
            if (Logic.TestConnection() == false)
            {
                MessageBox.Show("There was a error connection to the database.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadCustomerContacts();

        }
    }
}
