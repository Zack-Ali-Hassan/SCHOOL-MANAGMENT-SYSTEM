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
namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class View : Form
    {
        public DateTime selectedDate { get; set; }
        public View()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Load(object sender, EventArgs e)
        {
            dateOfAttendence.Value = DateTime.Now;
          //  getAttendance();
            readClass();
            cBClassname.SelectedIndex = 0;
           
            
        }
        private void readClass()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("select class_id from class ", conn);
                var reader = da.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                       cBClassname.Items.Add(reader[0].ToString());
                    }
                }
            }
        }
        private void getAttendance()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select s.student_id,s.firstname + ' ' + s.lastname as fullname,attendence_status,attendence_date from attendence a inner join student s on a.student_id=s.student_id inner join class c on s.class_id=c.class_id where attendence_date = '" + dateOfAttendence.Value + "'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvDisplayAttendance.DataSource = dt;

            }
        }

        private void dGvDisplayAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblDisplayId.Text = dGvDisplayAttendance.CurrentRow.Cells[0].Value.ToString();
                cBStatus.SelectedItem = dGvDisplayAttendance.CurrentRow.Cells[2].Value.ToString();
                selectedDate = (DateTime)dGvDisplayAttendance.CurrentRow.Cells[3].Value;
            }
            catch(Exception error){
                MessageBox.Show(error.Message);
            }
            //dateOfAttendence.Value = (DateTime)dGvDisplayAttendance.CurrentRow.Cells[1].Value;
        }

        private void btnUpdateAttendance_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = ConnectionClass.connection())
            {
                try
                {
                    if (cBStatus.SelectedItem.ToString() == "Select")
                    {
                        MessageBox.Show("Please select Status", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateViewAttendance";
                    cmd.Parameters.AddWithValue("@id", lblDisplayId.Text);
                    cmd.Parameters.AddWithValue("@status", cBStatus.SelectedItem);
                    cmd.Parameters.AddWithValue("@date", selectedDate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance has been Update...","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    getAttendance();
                    clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        private void clear()
        {
            cBStatus.SelectedItem = "Select";
            dateOfAttendence.Value = DateTime.Now;
            txtSearch.Clear();
        }

        private void dateOfAttendence_ValueChanged(object sender, EventArgs e)
        {
            getAttendance();
        }

        // attendance date
        private void getAttendanceData()
        {
            var conn = ConnectionClass.connection();
            var cmd = new SqlCommand("allCheckAttendance", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", dateOfAttendence.Value);
            cmd.Parameters.AddWithValue("@c_id", int.Parse(cBClassname.Text));
            var data = new SqlDataAdapter(cmd);
            var table = new DataTable();
            data.Fill(table);
            dGvDisplayAttendance.DataSource = table;
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select s.student_id,s.firstname + ' ' + s.lastname as fullname,attendence_status,attendence_date from attendence a inner join student s on a.student_id=s.student_id inner join class c on s.class_id=c.class_id WHERE s.student_id LIKE'" + txtSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvDisplayAttendance.DataSource = dt;

            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //getAttendance();
            getAttendanceData();
        }

        private void cBClassname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
