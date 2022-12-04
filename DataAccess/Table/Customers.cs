using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Table
{
    public class Customers
    {
        SqlConnection conn;
        public Customers()
        {
            string connStr = @"Server=DESKTOP-OE3MTST\MSSQLSERVER02;Database=vscmsDB;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }
        public List<Customer> GetAllCustomers()
        {
            string query = "select * from Customers";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Customer> data = new List<Customer>();

            while (reader.Read())
            {
                Customer cusm = new Customer();
                cusm.Customer_Id = reader.GetInt32(reader.GetOrdinal("Customer_Id"));
                cusm.Full_name = reader.GetString(reader.GetOrdinal("Full_name"));
                cusm.Address = reader.GetString(reader.GetOrdinal("Address"));
                cusm.Number = reader.GetString(reader.GetOrdinal("Number"));
                data.Add(cusm);
            }
            conn.Close();
            return data;
        }
        public bool Insert(Customer cusm)
        {
            string query = String.Format("Insert into Customers values ('{0}','{1}','{2}')", cusm.Full_name, cusm.Address, cusm.Number);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public Customer cuSearch(string name)
        {
            string query = String.Format("select * from Customers where Full_name='{0}'", name);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer cusm = null;
            while (reader.Read())
            {
                cusm = new Customer();
                cusm.Customer_Id = reader.GetInt32(reader.GetOrdinal("Customer_Id"));
                cusm.Full_name = reader.GetString(reader.GetOrdinal("Full_name"));
                cusm.Address = reader.GetString(reader.GetOrdinal("Address"));
                cusm.Number = reader.GetString(reader.GetOrdinal("Number"));
            }
            conn.Close();
            return cusm;

        }
        public bool Update(Customer emp)
        {
            string query = String.Format("Update Customers  set  Address ='{0}',Number ='{1}' where Full_name ='{2}'", emp.Address, emp.Number, emp.Full_name);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string cuname)
        {
            string query = String.Format("delete from Customers where Full_name='{0}'", cuname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }
    }
}
