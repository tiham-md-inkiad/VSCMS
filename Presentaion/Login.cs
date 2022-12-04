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
    public partial class Login : Form
    {
        public Login()

        {
            InitializeComponent();

            Database db = new Database();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();

        }



        private void btnhide_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                btnshow.BringToFront();
                txtpassword.PasswordChar = '*';
            }

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                btnhide.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcler_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";

        }

        private void btnclicklogin_Click(object sender, EventArgs e)
        {
            string uname = txtusername.Text;
            string pass = txtpassword.Text;
            Database db = new Database();
            try
            {
                bool rs = db.Employees.CheckLogin(uname, pass);
                if (rs == true)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Usename password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btncler_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void btnopnsingin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sing_Up().Show();
        }

        private void lblogin_Click(object sender, EventArgs e)
        {

        }
    }
}
