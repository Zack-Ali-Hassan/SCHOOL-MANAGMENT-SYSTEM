using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class StudentSpecificReport : UserControl
    {
        public StudentSpecificReport()
        {
            InitializeComponent();
        }

        private void gunaPictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmReport frmrep = new FrmReport();
            frmrep.Visible = true;
        }
    }
}
