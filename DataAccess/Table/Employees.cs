using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Table
{
    public class Employees
    {
        SqlConnection conn;
        public Employees()
        {
            string connStr = @"Server=DESKTOP-OE3MTST\MSSQLSERVER02;Database=vscmsDB;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }
        public List<Employee> GetAllEmployess()
        {
            string query = "select * from Employees";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Employee> data = new List<Employee>();

            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                emp.Full_name = reader.GetString(reader.GetOrdinal("Full_name"));
                emp.User_name = reader.GetString(reader.GetOrdinal("User_name"));
                emp.Address = reader.GetString(reader.GetOrdinal("Address"));
                emp.Password = reader.GetString(reader.GetOrdinal("Password"));
                
                emp.Number = reader.GetString(reader.GetOrdinal("Number"));
                data.Add(emp);
            }
            conn.Close();
            return data;
        }

        public bool Insert(Employee emp)
        {
            string query = String.Format("Insert into Employees values ('{0}','{1}','{2}','{3}','{4}')", emp.Full_name, emp.User_name, emp.Address, emp.Password, emp.Number);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool CheckLogin(string username, string password)
        {
            string query = String.Format("select Full_name from Employees where User_name='{0}' and Password='{1}'", username, password);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
            return false;

        }
        public Employee Search(string uname)
        {
            string query = String.Format("select * from Employees where User_name='{0}'", uname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp = null;
            while (reader.Read())
            {
                emp = new Employee();
                emp.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                emp.Full_name = reader.GetString(reader.GetOrdinal("Full_name"));
                emp.User_name = reader.GetString(reader.GetOrdinal("User_name"));
                emp.Address = reader.GetString(reader.GetOrdinal("Address"));
                emp.Password = reader.GetString(reader.GetOrdinal("Password"));
                emp.Number = reader.GetString(reader.GetOrdinal("Number"));
            }
            conn.Close();
            return emp;

        }
        public bool Update(Employee emp)
        {
            string query = String.Format("Update Employees set Full_name ='{0}' , Address ='{1}',Password ='{2}',Number ='{3}' where User_name='{4}'", emp.Full_name,  emp.Address, emp.Password, emp.Number, emp.User_name);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string username)
        {
            string query = String.Format("delete from Employees where User_name='{0}'", username);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }
    }
}