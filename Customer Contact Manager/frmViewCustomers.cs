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
    public partial class frmViewCustomers : Form
    { 
        #region ClassRefs
        BLL Logic = new BLL();
        #endregion
        public frmViewCustomers()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            DataSet DS = new DataSet();
            DS = Logic.qCustomer();
            dgv.DataSource = DS.Tables[0];
        
        }
        private bool Test_Db_Connection()
        {

            if (Logic.TestConnection() == false)
            {
                MessageBox.Show("There was a error connection to the database.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            } return true;
        }
        private void frmViewCustomers_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            //First test to see if the Program can make a connection to the DB 
            if (!Test_Db_Connection())
            {
                //if The connection can not be made disable the main menu to prevent errors. 
                dgv.Enabled = false;
                return;
            }
            LoadGrid();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 3)
                {
                    //Set it to int32 because it can become a very big number.
                    int CustomerID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[4].Value.ToString());
                    frmViewContactDetails Details = new frmViewContactDetails(CustomerID);
                    Details.ShowDialog();
                
                }
            }

        }
    }
}
