using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
//using Microsoft.ApplicationBlocks.Data;
namespace Customer_Contact_Manager
{
    //This Class is for handeling SQL connections and any SQL related function    
    class DAL
    {
            #region  Connection string(s)
                    public string strConn = @"data source=(local)\DB2;persist security info=False;initial catalog=CCM;Connection Lifetime=30; user ID=FAMEUser;Password=Example#1";
            #endregion
        #region Data Access Layer Methods

                    public bool TestConnection()
                    {
                        SqlConnection Connection = new SqlConnection(strConn);
                        SqlCommand cmd = Connection.CreateCommand();
                        try
                        {
                            Connection.Open();
                        }
                        catch(Exception ex)
                        {
                            return false;
                        }

                        Connection.Close();
                        return true;

                    }

        //inserts the new Customer into the DB and returns the message from db.
        public DataSet  ICustomer(string Name,
            decimal Long,
            decimal Lat)
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(strConn);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Latitude", Lat);
            cmd.Parameters.AddWithValue("@Longitude", Long);
            cmd.CommandText = "ICustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(DS);
            connection.Close();
            connection.Dispose();
            return DS;
        }

        public DataSet QCustomersCombo()
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(strConn);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "QCustomersCombo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 3600;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(DS);
            connection.Close();
            connection.Dispose();
            return DS;
        }

        public DataSet ICustomerContact(int ContactID,
            string ContactName,
            string Email,
            string ContactDetail)
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(strConn);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.Parameters.AddWithValue("@CustomerID", ContactID);
            cmd.Parameters.AddWithValue("@ContactName", ContactName);
            cmd.Parameters.AddWithValue("@ContactEmail", Email);
            cmd.Parameters.AddWithValue("@ContactDetail", ContactDetail);
            cmd.CommandText = "ICustomerContact";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(DS);
            connection.Close();
            connection.Dispose();
            return DS;
        }

        public DataSet qCustomer()
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(strConn);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.CommandText = "qCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 3600;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(DS);
            connection.Close();
            connection.Dispose();
            return DS;
        }
        public DataSet QCustomerContacts(int CustomerID)
        {
            DataSet DS = new DataSet();
            SqlConnection connection = new SqlConnection(strConn);
            SqlCommand cmd = connection.CreateCommand();
            connection.Open();
            cmd.Parameters.AddWithValue("@ContactID", CustomerID);
            cmd.CommandText = "QCustomerContacts";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 3600;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(DS);
            connection.Close();
            connection.Dispose();
            return DS;
        }
        #endregion

    }
}
