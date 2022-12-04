using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vehicle_service_center_management_system.Presentaion;

namespace vehicle_service_center_management_system
{
    public partial class Employesfrm : Form
    {
        public Employesfrm()
        {
            InitializeComponent();

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            try
            {
                dtvgemp.DataSource = db.Employees.GetAllEmployess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void employes_Load(object sender, EventArgs e)
        {

        }

     

        private void btnedit_Click(object sender, EventArgs e)
        {
            string updatedName = txtfullname.Text;
            string updatedAddress = txtaddress.Text;
            string updatePassword = txtpass.Text;
            string updateNumber= txtEmpnumber.Text;
            Employee emp = new Employee();

            emp.User_name = txtemusername.Text;
            emp.Full_name = txtfullname.Text;
            
            emp.Address = txtaddress.Text;
            emp.Password = txtpass.Text;
            emp.Number = txtEmpnumber.Text;
 
            Database db = new Database();
            bool rs = db.Employees.Update(emp);
            if (rs)
            {
                dtvgemp.DataSource = db.Employees.GetAllEmployess();
                MessageBox.Show("Updated");

            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string username = txtemusername.Text;
            Database db = new Database();
            bool rs = db.Employees.Delete(username);
            if (rs)
            {
                dtvgemp.DataSource = db.Employees.GetAllEmployess();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void dtvgemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string uname = txtemusername.Text;
            Database db = new Database();
            Employee emp = db.Employees.Search(uname);
            if (emp == null)
            {
                MessageBox.Show("Employee not found");
                txtfullname.Text = "";
                txtaddress.Text = "";
                txtpass.Text = "";
                txtEmpnumber.Text = "";
            }
            else
            {
                txtfullname.Text = emp.Full_name;
                txtaddress.Text = emp.Address;
                txtpass.Text = emp.Password;
                txtEmpnumber.Text = emp.Number;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var useername = txtemusername.Text;
            var name = txtfullname.Text;
            
            var address = txtaddress.Text;
            var password = txtpass.Text;
            var number= txtEmpnumber.Text;
            Employee emp = new Employee();
            
            emp.User_name = useername;
            emp.Full_name = name;

            emp.Password = password;
            emp.Number = number;
            
            Database db = new Database();
            var r = db.Employees.Insert(emp);
            if (r)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }
    }
}
