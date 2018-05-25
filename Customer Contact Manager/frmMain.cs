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
    public partial class frmMain : Form
    {
        #region ClassRefs
        BLL Logic = new BLL();
        #endregion
        public frmMain()
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
      
        private void frmMain_Load(object sender, EventArgs e)
        {
            //First test to see if the Program can make a connection to the DB 
            if (!Test_Db_Connection())
            {
                //if The connection can not be made disable the main menu to prevent errors. 
                PMainPannel.Enabled = false;
                return;
            }          
               
            
        }
        

        private void frmMain_SizeChanged_1(object sender, EventArgs e)
        {
            //Reghardt 2018-05-24 
            //Makes sure the MainMenu options stay in the center for the screen. 
            //No matter the state ie Maximised or custom size. 
            PMainPannel.Location = new Point(this.ClientSize.Width / 2 - PMainPannel.Size.Width / 2, this.ClientSize.Height / 2 - PMainPannel.Size.Height / 2); PMainPannel.Anchor = AnchorStyles.None;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Loads the form for adding customers
            frmAddCustomer addCustomer = new frmAddCustomer();
            addCustomer.ShowDialog();
        }

        private void btnAddCustomerContacts_Click(object sender, EventArgs e)
        {
            //Loads the form to add customers Contacts
            frmAddCustomerContacts customerContact = new frmAddCustomerContacts();
            customerContact.ShowDialog();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            //Loads the form to view the contacts and contact details
            frmViewCustomers view = new frmViewCustomers();
            view.ShowDialog();
        }
    }
}
        


