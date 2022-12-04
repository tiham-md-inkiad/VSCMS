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
    public class Bikeservices
    {

        SqlConnection conn;
        public Bikeservices()
        {
            string connStr = @"Server=DESKTOP-OE3MTST\MSSQLSERVER02;Database=vscmsDB;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }
        public List<Bikeservice> GetAllBikeservice()
        {
            string query = "select * from Bikeservices";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Bikeservice> data = new List<Bikeservice>();

            while (reader.Read())
            {
                Bikeservice bscc = new Bikeservice();
                bscc.ServiceID = reader.GetInt32(reader.GetOrdinal("ServiceID"));
                bscc.ServiceName = reader.GetString(reader.GetOrdinal("ServiceName"));
                bscc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                bscc.Description = reader.GetString(reader.GetOrdinal("Description"));

                data.Add(bscc);
            }
            conn.Close();
            return data;
        }

        public bool Insert(Bikeservice bscc)
        {
            string query = String.Format("Insert into Bikeservice values ('{0}','{1}','{2}','{3}','{4}')", bscc.ServiceID, bscc.ServiceName, bscc.Price, bscc.Price, bscc.Description);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }

        public Bikeservice Search(string sname)
        {
            string query = String.Format("select * from Bikeservices  where ServiceName ='{0}'", sname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Bikeservice bscc = null;
            while (reader.Read())
            {
                bscc = new Bikeservice();
                bscc.ServiceID = reader.GetInt32(reader.GetOrdinal("ServiceID"));
                bscc.ServiceName = reader.GetString(reader.GetOrdinal("ServiceName"));
                bscc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                bscc.Description = reader.GetString(reader.GetOrdinal("Description"));
            }
            conn.Close();
            return bscc;

        }
        public bool Update(Bikeservice bscc)
        {
            string query = String.Format("Update Bikeservices set ServiceID ='{0}', Price ='{1}'  ,Description ='{2}'where ServiceName ='{3}'", bscc.ServiceID, bscc.ServiceName, bscc.Price, bscc.Price, bscc.Description);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string pdname)
        {
            string query = String.Format("delete from Bikeservices where ServiceName='{0}'", pdname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }
    }
}
