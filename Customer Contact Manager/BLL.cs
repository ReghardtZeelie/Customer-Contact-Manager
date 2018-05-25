using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Customer_Contact_Manager
{
    class BLL
    {
        #region ClassRefs

        DAL DataClass = new DAL();

        #endregion
        #region Buisness Logic Layer Methods

        public bool TestConnection()
        {
          return DataClass.TestConnection();
        }
        public DataSet ICustomer(string Name,
            decimal Long,
            decimal Lat)
        {
            DataSet DS = new DataSet();
            DS = DataClass.ICustomer(Name, Long, Lat);
            return DS;
        }
        public DataSet QCustomersCombo()
        {
            DataSet DS = new DataSet();
            DS = DataClass.QCustomersCombo();
            return DS;

        }
        public DataSet ICustomerContact(int ContactID,
           string ContactName,
           string Email,
           string ContactDetail)
        {
            DataSet DS = new DataSet();
            DS = DataClass.ICustomerContact(ContactID, ContactName, Email, ContactDetail);
            return DS;
        }
        public DataSet qCustomer()
        {
            DataSet DS = new DataSet();
            DS = DataClass.qCustomer();
            return DS;
        }
        public DataSet QCustomerContacts(int CustomerID)
        {
            DataSet DS = new DataSet();
            DS = DataClass.QCustomerContacts(CustomerID);
            return DS;
        }
        public void UCustomerDetails(string Name,
           decimal Long,
           decimal Lat,
            int cID)
        {          
             DataClass.UCustomerDetails(Name, Long, Lat,cID);            
        }
        public void UCustomerContactDetails(int ContactID,
          string ContactName,
          string Email,
          string ContactDetail)
        {

            DataClass.UCustomerContactDetails(ContactID, ContactName, Email, ContactDetail);

        }
        #endregion
    }
}
