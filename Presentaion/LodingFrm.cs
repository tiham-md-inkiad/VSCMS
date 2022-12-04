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
    public partial class LodingFrm : Form
    {
        public LodingFrm()
        {
            InitializeComponent();
        }

        


        int startpoint = 0; 
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            progressBar.Value = startpoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void LodingFrm_Load(object sender, EventArgs e)
        {
            this .timer1.Start();
                }
    }
}
