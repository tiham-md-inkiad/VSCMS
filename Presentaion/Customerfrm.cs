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
    public partial class Customerfrm : Form
    {
        public Customerfrm()
        {
            InitializeComponent();
        }

        private void btnshowcus_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            try
            {
                dtvgcus.DataSource = db.Customers.GetAllCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnaddcusm_Click(object sender, EventArgs e)
        {

            var name = txtcusfullname.Text;
            var address = txtcusaddress.Text;
            var number = txtcusnumber.Text;
            Customer cusm = new Customer();


            cusm.Full_name = name;
            cusm.Address = address;
            cusm.Number = number;

            Database db = new Database();
            var r = db.Customers.Insert(cusm);
            if (r)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void btncuSearch_Click(object sender, EventArgs e)
        {
            string name = txtcusfullname.Text;
            Database db = new Database();
            Customer cusm = db.Customers.cuSearch(name);
            if (cusm == null)
            {
                MessageBox.Show("Customer not found");

                txtcusaddress.Text = "";
                txtcusnumber.Text = "";
            }
            else
            {

                txtcusaddress.Text = cusm.Address;
                txtcusnumber.Text = cusm.Number;
            }
        }

        private void btncudelete_Click(object sender, EventArgs e)
        {
            string cuname = txtcusfullname.Text;
            Database db = new Database();
            bool rs = db.Customers.Delete(cuname);
            if (rs)
            {
                dtvgcus.DataSource = db.Customers.GetAllCustomers();
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed to delete");
            }
        }

        private void btneditcu_Click(object sender, EventArgs e)
        {
            
            string updateaddress = txtcusaddress.Text;
            string updatenumber = txtcusnumber.Text;
            Customer cusm = new Customer();
            
            cusm.Address = txtcusaddress.Text;
            cusm.Number = txtcusnumber.Text;
            Database db = new Database();
            bool rs = db.Customers.Update(cusm);
            if (rs)
            {
                dtvgcus.DataSource = db.Customers.GetAllCustomers();
                MessageBox.Show("Updated");

            }
            else
            {
                MessageBox.Show("Failed to update");
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
