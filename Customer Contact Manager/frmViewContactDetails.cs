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

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            if (e.ColumnIndex == 0)
            {
                if (e.FormattedValue.ToString() == "")
                {
                    MessageBox.Show("Please enter contact Name.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (e.FormattedValue.ToString() == "")
                {
                    MessageBox.Show("Please Contact E-mail address.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (e.FormattedValue.ToString() == "")
                {
                    MessageBox.Show("Please enter contact Contact Number.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }
            }

        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            string Name = "";
            string Email = "";
            string ContactDetails = "";
            int ID = 0;

            if (e.RowIndex > -1 && e.ColumnIndex < 3)
            {
                Name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                Email = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                ContactDetails = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                ID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[3].Value.ToString());
                try
                {
                    Logic.UCustomerContactDetails(ID,
                                                  Name,
                                                  Email,
                                                  ContactDetails);

                }
                 catch (Exception  ex)
                {
                    MessageBox.Show("Please contact your system administrator an error has occurred.", "Sytem Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


        }
    }
}
