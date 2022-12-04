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
    public class CarAccessories
    {
        
            SqlConnection conn;
            public CarAccessories()
            {
                string connStr = @"Server=DESKTOP-OE3MTST\MSSQLSERVER02;Database=vscmsDB;Integrated Security=true";
                conn = new SqlConnection(connStr);
            }
            public List<CarAccessorie> GetAllCarAccessorie()
            {
                string query = "select * from CarAccessories";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                List<CarAccessorie> data = new List<CarAccessorie>();

                while (reader.Read())
                {
                    CarAccessorie acc = new CarAccessorie();
                    acc.ProductID = reader.GetInt32(reader.GetOrdinal("ProductID "));
                    acc.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                    acc.Quntity = reader.GetInt32(reader.GetOrdinal("Quntity"));
                    acc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                    acc.Description = reader.GetString(reader.GetOrdinal("Description"));

                data.Add(acc);
                }
                conn.Close();
                return data;
            }

            public bool Insert(CarAccessorie acc)
            {
                string query = String.Format("Insert into CarAccessories values ('{0}','{1}','{2}','{3}','{4}')", acc.ProductID, acc.ProductName, acc.Quntity, acc.Price, acc.Description);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;

            }
           
            public CarAccessorie Search(string pname)
            {
                string query = String.Format("select * from CarAccessories where ProductName ='{0}'", pname);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                CarAccessorie acc = null;
                while (reader.Read())
                {
                acc = new CarAccessorie();
                acc.ProductID = reader.GetInt32(reader.GetOrdinal("ProductID "));
                acc.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                acc.Quntity = reader.GetInt32(reader.GetOrdinal("Quntity"));
                acc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                acc.Description = reader.GetString(reader.GetOrdinal("Description"));
            }
                conn.Close();
                return acc;

            }
            public bool Update(CarAccessorie acc)
            {
                string query = String.Format("Update CarAccessories set ProductID ='{0}' , Quntity ='{1}', Price ='{2}',Description ='{3}' where ProductName ='{4}'", acc.ProductID, acc.ProductName, acc.Quntity, acc.Price, acc.Description);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;

            }
            public bool Delete(string pdname)
            {
                string query = String.Format("delete from CarAccessories where ProductName='{0}'", pdname);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rs = cmd.ExecuteNonQuery();
                conn.Close();
                if (rs > 0) { return true; }
                return false;
            }
        }
    }

