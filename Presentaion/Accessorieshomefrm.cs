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
    public partial class Accessorieshomefrm : Form
    {
        public Accessorieshomefrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarAccessoriesfrm CarAccessories = new CarAccessoriesfrm();
            CarAccessories.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BikeAccessoriesfrm bikeAccessories = new BikeAccessoriesfrm();
            bikeAccessories.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Accessorieshome_Load(object sender, EventArgs e)
        {

        }
    }
}
