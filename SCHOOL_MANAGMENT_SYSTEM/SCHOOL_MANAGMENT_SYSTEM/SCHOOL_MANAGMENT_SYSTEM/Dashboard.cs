using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class dashboard : Form
    {
        public static string role;
        public static string username;
        public dashboard()
        {
            InitializeComponent();
        }


        public dashboard(string user, string type, Image img)
        {
            InitializeComponent();
            lbluserRole.Text = type;
            role = lbluserRole.Text;
            lblUsername.Text = user;
            username = lblUsername.Text;
            imageProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            imageProfile.Image = img;
        }
        private void getImage()
        {

        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            ////profile1.Visible = false;
            if (role != "Admin")
            {
                btnUsers.Enabled = false;
                btnReport.Enabled = false;
                frmRegistration std = new frmRegistration();
                std.btnDeleteStudent.Enabled = false;
                std.btnUpdateStudent.Enabled = false;
                
            }
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaPictureBox8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.gunaPanel2.Controls.Clear();
            Student frmstudent = new Student();
            frmstudent.TopLevel = false;
            this.gunaPanel2.Controls.Add(frmstudent);
            frmstudent.Dock = DockStyle.None;
            this.gunaPanel2.Tag = frmstudent;
            frmstudent.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.gunaPanel2.Controls.Clear();
            Staff frmstaff = new Staff();
            frmstaff.TopLevel = false;
            this.gunaPanel2.Controls.Add(frmstaff);
            frmstaff.Dock = DockStyle.None;
            this.gunaPanel2.Tag = frmstaff;
            frmstaff.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.gunaPanel2.Controls.Clear();
            Attendence frmAttendence = new Attendence();
            frmAttendence.TopLevel = false;
            this.gunaPanel2.Controls.Add(frmAttendence);
            frmAttendence.Dock = DockStyle.None;
            this.gunaPanel2.Tag = frmAttendence;
            frmAttendence.Show();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
             DialogResult result;
                result = MessageBox.Show("Do you want to log out ??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Login frmlogin = new Login();
                    //Login frmlogin = new Login();
                    frmlogin.Show();
                    this.Hide();
                }
                else
                {
                    this.Show();
                }
            
        }

        public void btnTeachers_Click(object sender, EventArgs e)
        {
            
            lblDisplay.Text = "Teacher Admission Form";
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            frmdashboards1.Visible = false;
            frmStaff1.Visible = false;
            frmAttendence1.Visible = false;
            frmUsers1.Visible = false;
            frmRegistration2.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmTeachers1.Visible = true;
        }

        private void frmTeachers1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPictureBoxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void gunaPictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnUsers_Click(object sender, EventArgs e)
        {
            
            lblDisplay.Text = "User Form";
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            frmdashboards1.Visible = false;
            frmStaff1.Visible = false;
            frmAttendence1.Visible = false;
            frmTeachers1.Visible = false;
            frmRegistration2.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmUsers1.Visible = true;
        }

        private void frmUsers1_Load(object sender, EventArgs e)
        {

        }

        public void btnRegistaration_Click(object sender, EventArgs e)
        {
            
            lblDisplay.Text = "Student Admission Form";
            frmRegistration2.Visible = true;
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            frmTeachers1.Visible = false;
            frmUsers1.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmAttendence1.Visible = false;
            frmStaff1.Visible = false;
            frmdashboards1.Visible = false;
        }

        public void btnClass_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Class Form";
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            frmdashboards1.Visible = false;
            frmStaff1.Visible = false;
            frmAttendence1.Visible = false;
            frmRegistration2.Visible = false;
            frmTeachers1.Visible = false;
            frmUsers1.Visible = false;
            frmSubject1.Visible = false;
            frmClass1.Visible = true;
        }

        public void btnSubject_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Subject Form";
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            frmdashboards1.Visible = false;
            frmStaff1.Visible = false;
            frmAttendence1.Visible = false;
            frmRegistration2.Visible = false;
            frmTeachers1.Visible = false;
            frmUsers1.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = true;
        }

        public void btnAttendence_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Attendence Form";
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            frmStaff1.Visible = false;
            frmRegistration2.Visible = false;
            frmTeachers1.Visible = false;
            frmUsers1.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmdashboards1.Visible = false;
            frmAttendence1.Visible = true;
        }

        public void btnstaff_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Staff Addmission Form";
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            frmdashboards1.Visible = false;
            frmRegistration2.Visible = false;
            frmTeachers1.Visible = false;
            frmUsers1.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmAttendence1.Visible = false;
            frmStaff1.Visible = true;
        }

        public void btnDashboard_Click(object sender, EventArgs e)
        {
            frmdashboards.getSubject(frmdashboards.lbl1);
            frmdashboards.getStaff(frmdashboards.lbl5);
            frmdashboards.getTeaches(frmdashboards.lbl2);
            frmdashboards.getStudents(frmdashboards.lbl3);
            frmdashboards.getTotalUser(frmdashboards.lbl4);
            frmdashboards.getClass(frmdashboards.lbl);
            lblDisplay.Text = "Dashboard Form";
            frmdashboards1.Visible = true;
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            frmReport1.Visible = false;
            profile1.Visible = false;
            profile1.Visible = false;
            frmRegistration2.Visible = false;
            frmTeachers1.Visible = false;
            frmUsers1.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmAttendence1.Visible = false;
            frmStaff1.Visible = false;
        }

        private void frmStaff1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbluserRole_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imageProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Edit Profile";
            profile1.Visible = true;
            frmReport1.Visible = false;
            frmdashboards1.Visible = false;
            frmStaff1.Visible = false;
            frmAttendence1.Visible = false;
            frmTeachers1.Visible = false;
            frmRegistration2.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmUsers1.Visible = false;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           
        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "procAllStudent";
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                AllReportStudent cr = new AllReportStudent();
                cr.SetDataSource(dt);
                frmReport1.cRvReport.ReportSource = cr;

            }
            lblDisplay.Text = "Student Report";
            frmReport1.Visible = true;
            frmAllAttendance1.Visible = false;
            studentSpecificReport1.Visible = false;
            profile1.Visible = false;
            frmdashboards1.Visible = false;
            frmStaff1.Visible = false;
            frmAttendence1.Visible = false;
            frmTeachers1.Visible = false;
            frmRegistration2.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmUsers1.Visible = false;
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            lblDisplay.Text = "Attendance Report";
            frmAllAttendance1.Visible = true;
            frmReport1.Visible = false;
            studentSpecificReport1.Visible = false;
            profile1.Visible = false;
            frmdashboards1.Visible = false;
            frmStaff1.Visible = false;
            frmAttendence1.Visible = false;
            frmTeachers1.Visible = false;
            frmRegistration2.Visible = false;
            frmClass1.Visible = false;
            frmSubject1.Visible = false;
            frmUsers1.Visible = false;
        }


        
    }
}
