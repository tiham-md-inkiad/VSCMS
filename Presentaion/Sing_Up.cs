using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Entities;
using DataAccess;

namespace vehicle_service_center_management_system.Presentaion
{
    public partial class Sing_Up : Form
    {
        public Sing_Up()
        {
            InitializeComponent();
            Database db = new Database();
        }

        private void btnclicksingin_Click(object sender, EventArgs e)
        {
            var useername = txtemusername.Text;
            var name = txtfullname.Text;
            var password = txtpass.Text;
            var address = txtaddress.Text;
            var number = txtEmpnumber.Text;
            Employee emp = new Employee();

            emp.User_name = useername;
            emp.Full_name = name;
            emp.Password = password;
            emp.Address = address;
            emp.Number = number;

            Database db = new Database();
            var r = db.Employees.Insert(emp);
            if (r)
            {
                MessageBox.Show("Inserted");
                this.Hide();
                new Login().Show();
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void tbnbacklogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
