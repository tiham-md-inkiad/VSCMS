using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Entities
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string Full_name { get; set; }

        public string Address { get; set; }
        public string Number { get; set; }
    }
}