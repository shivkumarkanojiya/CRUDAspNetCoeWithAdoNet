using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AspNetCoreCURDMVC_Demo.Models
{
    public class CustomerDataAccess_Layer
    {
      
        //To View all Customers details      
        public IEnumerable<Customer> GetAllCustomers(SqlConnection connection)
        {
            List<Customer> lstCustomer = new List<Customer>();

           
                SqlCommand cmd = new SqlCommand("sp_GetAllCustomers", connection);
                cmd.CommandType = CommandType.StoredProcedure;

              connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Customer Customer = new Customer();

                    Customer.ID = Convert.ToInt32(sdr["CustomerID"]);
                    Customer.Name = sdr["Name"].ToString();
                    Customer.Address = sdr["Address"].ToString();
                    Customer.Gender = sdr["Gender"].ToString();
                    Customer.Country = sdr["Country"].ToString();
                    Customer.City = sdr["City"].ToString();
                    Customer.Mobile = sdr["MobileNo"].ToString();
                    Customer.Email = sdr["MailId"].ToString();
                    lstCustomer.Add(Customer);
                }
                connection.Close();
           
            return lstCustomer;
        }

        //To Add new Customer record      
        public void AddCustomer(SqlConnection connection,Customer Customer)
        {
           
                SqlCommand cmd = new SqlCommand("sp_AddCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Address", Customer.Address);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@City", Customer.City);
                cmd.Parameters.AddWithValue("@MobileNo", Customer.Mobile);
                cmd.Parameters.AddWithValue("@MailId", Customer.Email);
                 connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            
        }

        //To Update the records of a particluar Customer    
        public void UpdateCustomer(SqlConnection connection,Customer Customer)
        {
           
                SqlCommand cmd = new SqlCommand("sp_UpdateCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerId", Customer.ID);
                cmd.Parameters.AddWithValue("@Name", Customer.Name);
                cmd.Parameters.AddWithValue("@Address", Customer.Address);
                cmd.Parameters.AddWithValue("@Gender", Customer.Gender);
                cmd.Parameters.AddWithValue("@Country", Customer.Country);
                cmd.Parameters.AddWithValue("@City", Customer.City);
                cmd.Parameters.AddWithValue("@MobileNo", Customer.Mobile);
                cmd.Parameters.AddWithValue("@MailId", Customer.Email);

                 connection.Open();
                 cmd.ExecuteNonQuery();
                 connection.Close();
           
        }

        //Get the details of a particular Customer    
        public Customer GetCustomerData(SqlConnection connection,int? id)
        {
            Customer Customer = new Customer();

                SqlCommand cmd = new SqlCommand("sp_GetCustomerByID", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerId", id);
                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Customer.ID = Convert.ToInt32(sdr["CustomerID"]);
                    Customer.Name = sdr["Name"].ToString();
                    Customer.Address = sdr["Address"].ToString();
                    Customer.Gender = sdr["Gender"].ToString();
                    Customer.Country = sdr["Country"].ToString();
                    Customer.City = sdr["City"].ToString();
                    Customer.Mobile = sdr["MobileNo"].ToString();
                    Customer.Email = sdr["MailId"].ToString();
                }

            connection.Close();
            return Customer;
        }

        //To Delete the record on a particular Customer    
        public void DeleteCustomer(SqlConnection connection,int? id)
        {

            
                SqlCommand cmd = new SqlCommand("sp_DeleteCustomer", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerId", id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
           
        }
    }
}
