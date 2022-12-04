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
    public class Carservices
    {

        SqlConnection conn;
        public Carservices()
        {
            string connStr = @"Server=DESKTOP-OE3MTST\MSSQLSERVER02;Database=vscmsDB;Integrated Security=true";
            conn = new SqlConnection(connStr);
        }
        public List<Carservice> GetAllCarservice()
        {
            string query = "select * from Carservices";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Carservice> data = new List<Carservice>();

            while (reader.Read())
            {
                Carservice cscc = new Carservice();
                cscc.ServiceID = reader.GetInt32(reader.GetOrdinal("ServiceID"));
                cscc.ServiceName = reader.GetString(reader.GetOrdinal("ServiceName"));
                cscc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                cscc.Description = reader.GetString(reader.GetOrdinal("Description"));

                data.Add(cscc);
            }
            conn.Close();
            return data;
        }
        public bool Insert(Carservice bscc)
        {
            string query = String.Format("Insert into Carservices values ('{0}','{1}','{2}','{3}','{4}')", bscc.ServiceID, bscc.ServiceName, bscc.Price, bscc.Price, bscc.Description);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
         public Carservice Search(string sname)
        {
            string query = String.Format("select * from Carservices where ServiceName ='{0}'", sname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Carservice cscc = null;
            while (reader.Read())
            {
                cscc = new Carservice();
                cscc.ServiceID = reader.GetInt32(reader.GetOrdinal("ServiceID"));
                cscc.ServiceName = reader.GetString(reader.GetOrdinal("ServiceName"));
                cscc.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                cscc.Description = reader.GetString(reader.GetOrdinal("Description"));
            }
            conn.Close();
            return cscc;

        }
        public bool Update(Carservice bscc)
        {
            string query = String.Format("Update Carservices set ServiceID ='{0}', Price ='{1}'  ,Description ='{2}'where ServiceName ='{3}'", bscc.ServiceID, bscc.ServiceName, bscc.Price, bscc.Price, bscc.Description);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;

        }
        public bool Delete(string pdname)
        {
            string query = String.Format("delete from Carservices where ServiceName='{0}'", pdname);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rs = cmd.ExecuteNonQuery();
            conn.Close();
            if (rs > 0) { return true; }
            return false;
        }
    }
}
