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
    public partial class frmTeachers : UserControl
    {
        public frmTeachers()
        {
            InitializeComponent();
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtFirstNameTeacher.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastNameTeacher.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileTeacher.Text == "")
                {
                    MessageBox.Show("Enter you Mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxSexTeacher.Text == "Select")
                {
                    MessageBox.Show("Enter you sex", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ComboBoxSubjects.Text == "Select")
                {
                    MessageBox.Show("Enter  subject", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dateOfBirthTeacher.Value.Equals(DateTime.Now))
                {
                    MessageBox.Show("Enter you date of birth", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileTeacher.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (int.Parse(txtSalaryTeacher.Text) > 1000)
                {
                    MessageBox.Show("does'nt accept salary greater than 1000.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalaryTeacher.Clear();
                    return;
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to update this teacher??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            //if (exiss())
                            //    MessageBox.Show("Teacher exist");
                            //else
                            //{
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "allProTeacher";
                                cmd.Parameters.AddWithValue("@id", lblDisplayTId.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFirstNameTeacher.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLastNameTeacher.Text);
                                cmd.Parameters.AddWithValue("@mobile", txtMobileTeacher.Text);
                                cmd.Parameters.AddWithValue("@sex", cboxSexTeacher.Text);
                                cmd.Parameters.AddWithValue("@s_id", ComboBoxSubjects.Text);
                                cmd.Parameters.AddWithValue("@salary", txtSalaryTeacher.Text);
                                cmd.Parameters.AddWithValue("@date", dateOfBirthTeacher.Value);
                                cmd.Parameters.AddWithValue("@type", "update");
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Teacher has been Update Thanks...");
                                clear();
                                getTeacherList();
                                dateOfBirthTeacher.Value = DateTime.Now;
                                txtFirstNameTeacher.Focus();
                            //}
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
        }
        private bool isValidDateOfBirth()
        {
            SqlConnection conn = ConnectionClass.connection();

            var command = new SqlCommand("isValidDate", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@date1", dateOfBirthTeacher.Value);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    int year = Convert.ToInt32(reader[0]);
                    if (year >= 6 && year <= 40)
                    {
                        return true;
                    }
                }
            }


            conn.Close();



            return false;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtFirstNameTeacher.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastNameTeacher.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileTeacher.Text == "")
                {
                    MessageBox.Show("Enter you Mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxSexTeacher.Text == "Select")
                {
                    MessageBox.Show("Enter you sex", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ComboBoxSubjects.Text == "Select")
                {
                    MessageBox.Show("Enter  subject", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!isValidDateOfBirth())
                {
                    MessageBox.Show("Teacher age Must be Grater then 18 year and less then 63 years", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileTeacher.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (int.Parse(txtSalaryTeacher.Text) > 1000)
                {
                    MessageBox.Show("does'nt accept salary greater than 1000.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalaryTeacher.Clear();
                    return;
                }
                
                else
                {
                    try
                    {


                        if (exiss())
                            MessageBox.Show("Teacher exist");
                        else
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "allProTeacher";
                            cmd.Parameters.AddWithValue("@id", "");
                            cmd.Parameters.AddWithValue("@fname", txtFirstNameTeacher.Text);
                            cmd.Parameters.AddWithValue("@lname", txtLastNameTeacher.Text);
                            cmd.Parameters.AddWithValue("@mobile", txtMobileTeacher.Text);
                            cmd.Parameters.AddWithValue("@sex", cboxSexTeacher.Text);
                            cmd.Parameters.AddWithValue("@s_id", ComboBoxSubjects.Text);
                            cmd.Parameters.AddWithValue("@salary", txtSalaryTeacher.Text);
                            cmd.Parameters.AddWithValue("@date", dateOfBirthTeacher.Value);
                            cmd.Parameters.AddWithValue("@type", "insert");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New teacher has been Register Thanks..");
                            clear();
                            getTeacherList();
                            frmdashboards.getTeaches(frmdashboards.lbl2);
                            txtFirstNameTeacher.Focus();
                            dateOfBirthTeacher.Value = DateTime.Now;
                            btnAddTeacher.Enabled = true;
                            btnUpdateTeacher.Enabled = false;
                            btnDeleteTeacher.Enabled = false;
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }




                }
            }

        }
        public void clear()
        {
            txtFirstNameTeacher.Text = "";
            txtLastNameTeacher.Text = "";
            txtSearchTeacher.Text = "";
            txtMobileTeacher.Text = "";
            cboxSexTeacher.SelectedIndex = 0;
            txtSalaryTeacher.Text = "";
            ComboBoxSubjects.SelectedIndex = 0;
            dateOfBirthTeacher.Value.Equals(DateTime.Now);

        }
        private bool exiss()
        {
            SqlConnection conn = ConnectionClass.connection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "allCheckTeacher";
            cmd1.Parameters.AddWithValue("@mobile", txtMobileTeacher.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                if (reader1.HasRows)
                {
                    return true;
                }

            }
            reader1.Close();
            return false;

        }
        private void getTeacherList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select teacher_id,firstname,lastname,mobile,subjectname,sex,salary,dateofbirth from teacher t inner join subject s on s.subject_id=t.subject_id", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvTeacher.DataSource = dt;
            }
        }
        public void getTotalTeacherList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM TEACHER", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                frmdashboards frmdashboards = new frmdashboards();
                //frmdashboards.lblTotalTeachers.Text = dt;
            }
        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            dateOfBirthTeacher.Value = DateTime.Now;
            readSubject();
            getTeacherList();
            btnAddTeacher.Enabled = true;
            btnUpdateTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
        }
        private void readSubject()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("select subject_id from subject order by subject_id desc", conn);
                var reader = da.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        ComboBoxSubjects.Items.Add(reader[0].ToString());
                    }
                }
            }
        }
        private void dGvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDisplayTId.Text = dGvTeacher.CurrentRow.Cells[0].Value.ToString();
            txtFirstNameTeacher.Text = dGvTeacher.CurrentRow.Cells[1].Value.ToString();
            txtLastNameTeacher.Text = dGvTeacher.CurrentRow.Cells[2].Value.ToString();
            txtMobileTeacher.Text = dGvTeacher.CurrentRow.Cells[3].Value.ToString();
            cboxSexTeacher.SelectedItem = dGvTeacher.CurrentRow.Cells[4].Value.ToString();
            ComboBoxSubjects.SelectedItem = dGvTeacher.CurrentRow.Cells[5].Value.ToString();
            txtSalaryTeacher.Text = dGvTeacher.CurrentRow.Cells[6].Value.ToString();
            dateOfBirthTeacher.Value = (DateTime)dGvTeacher.CurrentRow.Cells[7].Value;
            if (dashboard.role != "Admin")
            {
                btnUpdateTeacher.Enabled = false;
                btnDeleteTeacher.Enabled = false;
            }
            else
            {
                btnAddTeacher.Enabled = true;
                btnUpdateTeacher.Enabled = true;
                btnDeleteTeacher.Enabled = true;
            }
        }

        private void txtSearchTeacher_TextChanged(object sender, EventArgs e)
        {
            searchTeacher();
        }
        private void searchTeacher()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM teacher WHERE MOBILE LIKE'" + txtSearchTeacher.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvTeacher.DataSource = dt;

            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------Delete:Store Procedures----------
                if (lblDisplayTId.Text == "")
                {
                    MessageBox.Show("please choose teacher to delete", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to delete this teacher??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "deleteProTeacher";
                            cmd.Parameters.AddWithValue("@id", lblDisplayTId.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Teacher has been Delete Thanks...");
                            clear();
                            getTeacherList();
                            frmdashboards.getTeaches(frmdashboards.lbl2);
                            txtFirstNameTeacher.Focus();
                            dateOfBirthTeacher.Value = DateTime.Now;
                            btnAddTeacher.Enabled = true;
                            btnUpdateTeacher.Enabled = false;
                            btnDeleteTeacher.Enabled = true;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }

        }

        private void txtFirstNameTeacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstNameTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastNameTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobileTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers..", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSalaryTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileTeacher_TextChanged(object sender, EventArgs e)
        {
            if (txtMobileTeacher.Text == "")
                return;
            if (!this.txtMobileTeacher.Text.StartsWith("6"))
            {
                MessageBox.Show("Mobile Must start 6.");
                this.txtMobileTeacher.Clear();
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

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

        private void dGvTeacher_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lblDisplayTId.Text = dGvTeacher.CurrentRow.Cells[0].Value.ToString();
            txtFirstNameTeacher.Text = dGvTeacher.CurrentRow.Cells[1].Value.ToString();
            txtLastNameTeacher.Text = dGvTeacher.CurrentRow.Cells[2].Value.ToString();
            txtMobileTeacher.Text = dGvTeacher.CurrentRow.Cells[3].Value.ToString();
            cboxSexTeacher.SelectedItem = dGvTeacher.CurrentRow.Cells[4].Value.ToString();
            ComboBoxSubjects.SelectedItem = dGvTeacher.CurrentRow.Cells[5].Value.ToString();
            txtSalaryTeacher.Text = dGvTeacher.CurrentRow.Cells[6].Value.ToString();
            dateOfBirthTeacher.Value = (DateTime)dGvTeacher.CurrentRow.Cells[7].Value;
            if (dashboard.role != "Admin")
            {
                btnUpdateTeacher.Enabled = false;
                btnDeleteTeacher.Enabled = false;
            }
            else
            {
                btnAddTeacher.Enabled = true;
                btnUpdateTeacher.Enabled = true;
                btnDeleteTeacher.Enabled = true;
            }
        }

        private void txtSearchTeacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
