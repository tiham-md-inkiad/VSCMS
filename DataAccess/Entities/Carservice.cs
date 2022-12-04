using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_service_center_management_system.DataAccess.Entities
{
    public class Carservice
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
