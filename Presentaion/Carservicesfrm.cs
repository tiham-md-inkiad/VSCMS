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
    public partial class Carservicesfrm : Form
    {
        public Carservicesfrm()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Servicehome servicehome = new Servicehome();
            servicehome.Show();
            this.Hide();
        }

       
    }
}
