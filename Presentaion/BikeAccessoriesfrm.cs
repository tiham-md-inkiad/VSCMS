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
    public partial class BikeAccessoriesfrm : Form
    {
        public BikeAccessoriesfrm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Accessorieshomefrm accessorieshome = new Accessorieshomefrm();
            accessorieshome.Show();
            this.Hide();
        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            Accessorieshomefrm accessorieshome = new Accessorieshomefrm();
            accessorieshome.Show();
            this.Hide();
        }
    }
}
