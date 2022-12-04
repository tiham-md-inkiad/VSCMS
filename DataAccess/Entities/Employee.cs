using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Full_name { get; set; }
        public string User_name { get; set; }
        
        public string Address { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
    }
}