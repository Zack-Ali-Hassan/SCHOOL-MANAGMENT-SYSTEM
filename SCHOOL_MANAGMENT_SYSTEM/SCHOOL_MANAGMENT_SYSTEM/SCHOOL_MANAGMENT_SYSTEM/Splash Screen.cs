using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ProgressBar1.Increment(2);
            if (ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Login frmlogin = new Login();
                frmlogin.Show();
                this.Hide();
            }
        }
    }
}
