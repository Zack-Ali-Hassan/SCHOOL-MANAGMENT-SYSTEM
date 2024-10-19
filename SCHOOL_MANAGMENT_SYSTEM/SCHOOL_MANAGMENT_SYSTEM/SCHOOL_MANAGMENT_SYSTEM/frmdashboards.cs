using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class frmdashboards : UserControl
    {

        public static Label lbl = new Label();
        public static Label lbl1 = new Label();
        public static Label lbl2 = new Label();
        public static Label lbl3 = new Label();
        public static Label lbl4 = new Label();
        public static Label lbl5 = new Label();
        public frmdashboards()
        {
            InitializeComponent();
            lbl=lblTotalClass;
            lbl1 = lblTotalSubjects;
            lbl2 = lblTotalTeachers;
            lbl3 = lblTotalStudent;
            lbl4 = lblTotalUsers;
            lbl5 = lblTotalStaffes;
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalUsers_Click(object sender, EventArgs e)
        {
           
        }

        private void frmdashboards_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDisplayTime.Text = DateTime.Now.ToLongTimeString();
            lblDisplayTime2.Text = DateTime.Now.ToLongDateString();
            getTotalUser(lblTotalUsers);
            getStudents(lblTotalStudent);
            getStaff(lblTotalStaffes);
            getClass(lblTotalClass);
            getSubject(lblTotalSubjects);
            getTeaches(lblTotalTeachers);
        }
        public static void getTotalUser(Label lbl4)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var  da = new SqlCommand("SELECT count(*) FROM USERS", conn);
                var reader = da.ExecuteScalar();

                lbl4.Text = reader.ToString();
            }
           
        }

        public static void getStudents(Label lbl3)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("SELECT count(*) FROM student", conn);
                var reader = da.ExecuteScalar();

                lbl3.Text = reader.ToString();
            }

        }

        public static void getTeaches(Label lbl2)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("SELECT count(*) FROM teacher", conn);
                var reader = da.ExecuteScalar();

                lbl2.Text = reader.ToString();
            }

        }
        public static void getSubject(Label lbl1)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("SELECT count(*) FROM subject", conn);
                var reader = da.ExecuteScalar();

                lbl1.Text = reader.ToString();
            }

        }

        public static void getClass(Label lbl)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("SELECT count(*) FROM class", conn);
                var reader = da.ExecuteScalar();

                lbl.Text = reader.ToString();
            }

        }

        public static void getStaff(Label lbl5)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("SELECT count(*) FROM staff", conn);
                var reader = da.ExecuteScalar();

                lbl5.Text = reader.ToString();
            }

        }

        private void lblTotalStaffes_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalTeachers_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplayTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
