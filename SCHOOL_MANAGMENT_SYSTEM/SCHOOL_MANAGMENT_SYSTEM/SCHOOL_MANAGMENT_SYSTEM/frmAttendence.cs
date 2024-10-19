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
    public partial class frmAttendence : UserControl
    {
        public frmAttendence()
        {
            InitializeComponent();
        }

        private void frmAttendence_Load(object sender, EventArgs e)
        {


            if (dashboard.role != "Admin")
            {
                btnViewAttendance.Enabled = false;
            }
            else
            {
                btnViewAttendance.Enabled = true;
            }
            dateOfAttendence.Value = DateTime.Now;
            readClass();
            dgvAttendence.Visible = false;
            DataGridViewCheckBoxColumn pic1 = new DataGridViewCheckBoxColumn();
            pic1.HeaderText = "Student Status";
            dgvAttendence.Columns.Add(pic1);
        }
        private void readClass()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("select class_id from class order by class_id desc", conn);
                var reader = da.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        ComboBoxClassNameaTTENDENCE.Items.Add(reader[0].ToString());
                    }
                }
            }
        }
        public void btnSaveAttendence_Click(object sender, EventArgs e)
        {
            
            if (ComboBoxClassNameaTTENDENCE.SelectedItem.ToString()=="Select")
            {
                MessageBox.Show("Please Select Class?","message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (dateOfAttendence.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid date please select correct date?", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateOfAttendence.Value = DateTime.Now;
                return;
            }
            if (exiss())
            {
                MessageBox.Show("Attendance already make", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    for (int i = 0; i < dgvAttendence.Rows.Count; i++)
                    {
                        var state = "";
                        bool status = (bool)dgvAttendence.Rows[i].Cells[0].Value;
                        if (status)
                            state = "Present";
                        else
                            state = "Absent";

                        takeAttendance(
                            (int)dgvAttendence.Rows[i].Cells[1].Value,
                            state,
                            dateOfAttendence.Value

                            );

                    }

                    MessageBox.Show("Save Attendance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }
            }
        }
        private void clear()
        {
            //ComboBoxClassNameaTTENDENCE.SelectedItem = "Select";
            dateOfAttendence.Value = DateTime.Now;
        }
        private bool exiss()
        {
            SqlConnection conn = ConnectionClass.connection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "allCheckAttendance";
            cmd1.Parameters.AddWithValue("@date", dateOfAttendence.Value);
            cmd1.Parameters.AddWithValue("@c_id", ComboBoxClassNameaTTENDENCE.SelectedItem);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                if (reader1.HasRows)
                {
                    return true;
                }

            }
            conn.Close();
            reader1.Close();
            return false;

        }

        public void btnEditAttendence_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void chSelectAll_CheckedChanged(object sender, EventArgs e)
        {
         
            if (chSelectAll.Checked)
            {
                for (int i = 0; i < dgvAttendence.Rows.Count; i++)
                {
                    dgvAttendence.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvAttendence.Rows.Count; i++)
                {
                    dgvAttendence.Rows[i].Cells[0].Value = false;
                }
            }
            
        }

        private void dateOfBirthStudent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAttendence.Visible = true;
            readStudets();
            dgvAttendence.Columns[1].ReadOnly = true;
            dgvAttendence.Columns[2].ReadOnly = true;
        }


        private void readStudets()
        {
            try
            {
                SqlConnection conn = ConnectionClass.connection();

                SqlCommand da = new SqlCommand("readStd", conn);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@id", int.Parse(ComboBoxClassNameaTTENDENCE.Text));
                var reader = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                reader.Fill(dt);
                dgvAttendence.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
              
        }



        private void getAttendancedate()
        {

        }

        private void takeAttendance(int id,string status,DateTime date)
        {
            SqlConnection conn = ConnectionClass.connection();

            SqlCommand da = new SqlCommand("takeAttendance", conn);
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@std_id", id);
            da.Parameters.AddWithValue("@status", status);
            da.Parameters.AddWithValue("@date", date);
            da.ExecuteNonQuery();
        }

        private void dgvAttendence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            View frmView = new View();
            frmView.Show();
        }
        private void btnView(object sender, EventArgs e)
        {
        View frmView = new View();
            frmView.Show();
        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            View frmView = new View();
            frmView.Show();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
