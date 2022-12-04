using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vehicle_service_center_management_system.DataAccess.Entities;

namespace vehicle_service_center_management_system.DataAccess.Table
{
    public class BikeAccessories
    {
        SqlConnection conn;
        public BikeAccessories()
        {
            string connStr = @"Server=DESKTOP-OE3MTST\MSSQLSERVER02;Database=vscmsDB;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }
        public List<BikeAccessorie> GetAllBikeAccessorie()
        {
            string query = "select * from BikeAccessories";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<BikeAccessorie> data = new List<BikeAccessorie>();

            while (reader.Read())
            {
                BikeAccessorie bcc = new BikeAccessorie();
                bcc.ProductID = reader.GetInt32(reader.GetOrdinal("ProductID "));
                bcc.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                bcc.Quntity = reader.GetInt32(reader.GetOrdinal("Quntity"));
                bcc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                bcc.Description = reader.GetString(reader.GetOrdinal("Description"));

                data.Add(bcc);
            }
            conn.Close();
            return data;
        }

        public bool Insert(BikeAccessorie bcc)
        {
            string query = String.Format("Insert into BikeAccessories values ('{0}','{1}','{2}','{3}','{4}')", bcc.ProductID, bcc.ProductName, bcc.Quntity, bcc.Price, bcc.Description);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }

        public BikeAccessorie Search(string pname)
        {
            string query = String.Format("select * from BikeAccessories where ProductName='{0}'", pname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            BikeAccessorie bcc = null;
            while (reader.Read())
            {
                bcc = new BikeAccessorie();
                bcc.ProductID = reader.GetInt32(reader.GetOrdinal("ProductID "));
                bcc.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                bcc.Quntity = reader.GetInt32(reader.GetOrdinal("Quntity"));
                bcc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                bcc.Description = reader.GetString(reader.GetOrdinal("Description"));
            }
            conn.Close();
            return bcc;

        }
        public bool Update(BikeAccessorie bcc)
        {
            string query = String.Format("Update BikeAccessories set ProductID ='{0}' , Quntity ='{1}', Price ='{2}',Description ='{3}' where ProductName ='{4}'", bcc.ProductID, bcc.ProductName, bcc.Quntity, bcc.Price, bcc.Description);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string pdname)
        {
            string query = String.Format("delete from BikeAccessories where ProductName='{0}'", pdname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }
    }
}
