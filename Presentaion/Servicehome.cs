using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_service_center_management_system.Presentaion
{
    public partial class Servicehome : Form
    {
        public Servicehome()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Carservicesfrm carservices = new Carservicesfrm();
            carservices.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            Bikeservicesfrm bikeservices = new Bikeservicesfrm();
            bikeservices.Show();
            this.Hide();

        }
    }
}
