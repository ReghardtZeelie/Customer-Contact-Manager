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

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                string Name = "";
                decimal Lar = 0m;
                decimal Long = 0m;
                int cID = 0;


                 Name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();              
                 Lar = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                 Long = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[2].Value.ToString());
                 cID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[4].Value.ToString());
                 try
                 {
                 Logic.UCustomerDetails(Name,
                                        Long,
                                        Lar,
                                        cID);
                 }
                catch (Exception  ex)
                {
                    MessageBox.Show("Please contact your system administrator an error has occurred.", "Sytem Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                string Name = "";
                decimal Lat = 0m;
                decimal Long = 0m;
                int cID = 0;

               
                Lat = decimal.Parse(dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                Name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                Long = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[2].Value.ToString());
                cID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[4].Value.ToString());
                 try
                {
                Logic.UCustomerDetails(Name,
                                       Long,
                                       Lat,
                                       cID);
                }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Please contact your system administrator an error has occurred.", "Sytem Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 }

            }
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                string Name = "";
                decimal Lat = 0m;
                decimal Long = 0m;
                int cID = 0;

 
                Long = decimal.Parse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString());
                Name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                Lat = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[1].Value.ToString());
                cID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[4].Value.ToString());

                try
                {
                    Logic.UCustomerDetails(Name,
                                           Long,
                                           Lat,
                                           cID);
                }
                catch (Exception  ex)
                {
                    MessageBox.Show("Please contact your system administrator an error has occurred.", "Sytem Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            //does the validations befor the values change 
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                
                decimal Lat = 0m;
             

                try
                {
                    Lat = decimal.Parse(e.FormattedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("Please enter only decimals.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }

              

            }
            if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
               
                decimal Long = 0m;
               

                try
                {
                    Long = decimal.Parse(e.FormattedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("Please enter only decimals.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                }

                

            }
        }
    }
}
