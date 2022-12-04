using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DataAccess.Table;
using vehicle_service_center_management_system.DataAccess.Table;

namespace DataAccess
{
    public class Database
    {

        public Employees Employees { get; set; }
        public Customers Customers { get; set; }
        public Bikeservices Bikeservices { get; set; }

        public Carservices carservices { get; set; }
        public BikeAccessories BikeAccessories { get; set; }
        public CarAccessories CarAccessories { get; set; }

        public Database()
        {

            Employees = new Employees();
            Customers = new Customers();
            Bikeservices = new Bikeservices();
            carservices = new Carservices();
            BikeAccessories = new BikeAccessories();
            CarAccessories = new CarAccessories();
        }
    }
}