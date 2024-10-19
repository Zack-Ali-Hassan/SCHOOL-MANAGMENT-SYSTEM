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
using System.IO;
namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class frmRegistration : UserControl
    {
        public static string imageName;
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtFirstNameStudent.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastNameStudent.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtAddressStudent.Text == "")
                {
                    MessageBox.Show("Enter you Address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxSexStudent.Text == "Select")
                {
                    MessageBox.Show("Enter you sex", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ComboBoxClassName.Text == "Select")
                {
                    MessageBox.Show("Enter you class", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStudent.Text == "")
                {
                    MessageBox.Show("Enter you mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!isValidDateOfBirth())
                {
                    MessageBox.Show("Student BirthDate Must be greater then 6 year and less then 55 years", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStudent.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                       
                        if (exiss())
                            MessageBox.Show("Student exist");
                        else
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "allProStudent";
                            cmd.Parameters.AddWithValue("@id", "");
                            cmd.Parameters.AddWithValue("@fname", txtFirstNameStudent.Text);
                            cmd.Parameters.AddWithValue("@lname", txtLastNameStudent.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddressStudent.Text);
                            cmd.Parameters.AddWithValue("@sex", cboxSexStudent.Text);
                            cmd.Parameters.AddWithValue("@c_id", ComboBoxClassName.Text);
                            cmd.Parameters.AddWithValue("@mobile", txtMobileStudent.Text);
                            cmd.Parameters.AddWithValue("@date", dateOfBirthStudent.Value);
                            MemoryStream mstr = new MemoryStream();
                            myImage.Image.Save(mstr, myImage.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@image", mstr.ToArray());
                            cmd.Parameters.AddWithValue("@type", "insert");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New student has been Register Thanks..","Message");
                            clear();
                            getStudentList();
                            frmdashboards.getStudents(frmdashboards.lbl3);
                            txtFirstNameStudent.Focus();
                            btnAddStudent.Enabled = true;
                            btnUpdateStudent.Enabled = false;
                            btnDeleteStudent.Enabled = false;
                            dateOfBirthStudent.Value = DateTime.Now;
                            myImage.SizeMode = PictureBoxSizeMode.StretchImage;
                            myPanel.SendToBack();
                            myImage.BringToFront();
                            myImage.Image = Properties.Resources.users3;
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }

        }
        private bool exiss()
        {
            SqlConnection conn = ConnectionClass.connection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "allCheckStudent";
            cmd1.Parameters.AddWithValue("@mobile", txtMobileStudent.Text);
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

        public void clear()
        {
            txtFirstNameStudent.Text = "";
            txtLastNameStudent.Text = "";
            txtMobileStudent.Text = "";
            txtAddressStudent.Text = "";
            txtSearchStudent.Text = "";
            ComboBoxClassName.SelectedIndex = 0;
            cboxSexStudent.SelectedIndex = 0;
            myImage.Image = null;
        }
        private void getStudentList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter(" select student_id,firstname,lastname,address,sex,classname,mobile,dateofbirth from class c inner join student s on c.class_id=s.class_id", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvStudent.DataSource = dt;
            }
        }
        public void getTotalStudentList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM STUDENT", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                frmdashboards frmdashboards = new frmdashboards();
            }
        }
        //private void getComboBox()
        //{
        //    using (SqlConnection conn = ConnectionClass.connection())
        //    {
        //        var da = new SqlCommand("select class_id from class", conn);
        //        var reader = da.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            if (reader.HasRows)
        //            {
        //                ComboBoxClassName.Items.Add(reader[0].ToString());
        //            }
        //        }
        //    }
        //}

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            myImage.SizeMode = PictureBoxSizeMode.StretchImage;
            myPanel.SendToBack();
            myImage.BringToFront();
            dateOfBirthStudent.Value = DateTime.Now;
            readClass();
            //using (SqlConnection conn = ConnectionClass.connection())
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("select class_id from class", conn);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    ComboBoxClassName.DataSource = dt;
            //    ComboBoxClassName.DisplayMember = "class_id";
            //    ComboBoxClassName.Text = "";
            //}
            getStudentList();
            btnAddStudent.Enabled = true;
            btnUpdateStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
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
                        ComboBoxClassName.Items.Add(reader[0].ToString());
                    }
                }
            }
        }
        private void dGvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static Image getImage(object reader)
        {
            var ms = new MemoryStream((byte[])reader);
            Image img = Image.FromStream(ms);
            return img;

        }
        private Image getUserImage(int id)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var cmd = new SqlCommand("rImageProStudent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                var reader = cmd.ExecuteReader();
                reader.Read();
                var img = getImage(reader[0]);
                conn.Close();
                return img;

            }
        }
        private void dGvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getComboBox();
            int id = (int)dGvStudent.CurrentRow.Cells[0].Value;
            lblDisplaySId.Text = dGvStudent.CurrentRow.Cells[0].Value.ToString();
            txtFirstNameStudent.Text = dGvStudent.CurrentRow.Cells[1].Value.ToString();
            txtLastNameStudent.Text = dGvStudent.CurrentRow.Cells[2].Value.ToString();
            txtAddressStudent.Text = dGvStudent.CurrentRow.Cells[3].Value.ToString();
            cboxSexStudent.SelectedItem = dGvStudent.CurrentRow.Cells[4].Value.ToString();
           ComboBoxClassName.SelectedValue = dGvStudent.CurrentRow.Cells[5].Value.ToString();
            txtMobileStudent.Text = dGvStudent.CurrentRow.Cells[6].Value.ToString();
            dateOfBirthStudent.Value = (DateTime)dGvStudent.CurrentRow.Cells[7].Value;
            myImage.SizeMode = PictureBoxSizeMode.StretchImage;
            myImage.Image = getUserImage(id);
            if (dashboard.role != "Admin")
            {
                btnDeleteStudent.Enabled = false;
                btnUpdateStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
                btnUpdateStudent.Enabled = true;
                btnDeleteStudent.Enabled = true;
            }
           
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            
            searchUser();
        }
        private void searchUser()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM STUDENT WHERE STUDENT_ID LIKE'" + txtSearchStudent.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvStudent.DataSource = dt;

            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtFirstNameStudent.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastNameStudent.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtAddressStudent.Text == "")
                {
                    MessageBox.Show("Enter you Address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxSexStudent.Text == "Select")
                {
                    MessageBox.Show("Enter you sex", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ComboBoxClassName.Text == "Select")
                {
                    MessageBox.Show("Enter you classname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStudent.Text == "")
                {
                    MessageBox.Show("Enter you mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dateOfBirthStudent.Value.Equals(DateTime.Now))
                {
                    MessageBox.Show("Enter you date of birth", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStudent.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to update this student??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            //if (exiss())
                            //    MessageBox.Show("Student exist");
                            //else
                            //{
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "allProStudent";
                                cmd.Parameters.AddWithValue("@id", lblDisplaySId.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFirstNameStudent.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLastNameStudent.Text);
                                cmd.Parameters.AddWithValue("@address", txtAddressStudent.Text);
                                cmd.Parameters.AddWithValue("@sex", cboxSexStudent.Text);
                                cmd.Parameters.AddWithValue("@c_id", ComboBoxClassName.Text);
                                cmd.Parameters.AddWithValue("@mobile", txtMobileStudent.Text);
                                cmd.Parameters.AddWithValue("@date", dateOfBirthStudent.Value);
                                MemoryStream mstr = new MemoryStream();
                                myImage.Image.Save(mstr, myImage.Image.RawFormat);
                                cmd.Parameters.AddWithValue("@image", mstr.ToArray());
                                cmd.Parameters.AddWithValue("@type", "update");
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Student has been Update Thanks...");
                                clear();
                                getStudentList();
                                dateOfBirthStudent.Value = DateTime.Now;
                                myImage.SizeMode = PictureBoxSizeMode.StretchImage;
                                myPanel.SendToBack();
                                myImage.BringToFront();
                                myImage.Image = Properties.Resources.users3;
                                txtFirstNameStudent.Focus();
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

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------Delete:Store Procedures----------
                if (lblDisplaySId.Text == "")
                {
                    MessageBox.Show("please choose Student to delete", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to delete this Student??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "pdeleteStudent";
                        cmd.Parameters.AddWithValue("@id", lblDisplaySId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student has been Delete Thanks...");
                        clear();
                        getStudentList();
                        frmdashboards.getStudents(frmdashboards.lbl3);
                        txtFirstNameStudent.Focus();
                        dateOfBirthStudent.Value = DateTime.Now;
                        btnAddStudent.Enabled = true;
                        btnUpdateStudent.Enabled = false;
                        btnDeleteStudent.Enabled = true;
                        myImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        myImage.BringToFront();
                        myPanel.SendToBack();
                        lblPhoto.SendToBack();
                        myImage.Image = Properties.Resources.users3;
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
        }

        private void txtMobileStudent_TextChanged(object sender, EventArgs e)
        {
            if (txtMobileStudent.Text == "")
                return;
            if (!this.txtMobileStudent.Text.StartsWith("6"))
            {
                MessageBox.Show("Mobile Must start 6.");
                this.txtMobileStudent.Clear();
            }
        }

        private void txtMobileStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers..", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFirstNameStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastNameStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddressStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void ComboBoxClassName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private bool isValidDateOfBirth()
        {
            SqlConnection conn = ConnectionClass.connection();
         
            var command = new SqlCommand("isValidDate", conn);
            command.CommandType=CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@date1",dateOfBirthStudent.Value);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                  int year = Convert.ToInt32(reader[0]);
                   if (year >= 6 && year <= 55)
                  {
                       return true;
                  }
                }
            }


            conn.Close();



                return false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            try
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    imageName = fd.FileName;
                    Bitmap newImg = new Bitmap(imageName);
                    myImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    myImage.Image = (Image)newImg;
                    myPanel.SendToBack();
                }
                fd = null;
            }
            catch (System.AccessViolationException ea)
            {
                imageName = " ";
                MessageBox.Show(ea.Message.ToString(), "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message.ToString(), "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGvStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dGvStudent.CurrentRow.Cells[0].Value;
            lblDisplaySId.Text = dGvStudent.CurrentRow.Cells[0].Value.ToString();
            txtFirstNameStudent.Text = dGvStudent.CurrentRow.Cells[1].Value.ToString();
            txtLastNameStudent.Text = dGvStudent.CurrentRow.Cells[2].Value.ToString();
            txtAddressStudent.Text = dGvStudent.CurrentRow.Cells[3].Value.ToString();
            cboxSexStudent.SelectedItem = dGvStudent.CurrentRow.Cells[4].Value.ToString();
            ComboBoxClassName.SelectedItem = dGvStudent.CurrentRow.Cells[5].Value.ToString();
            txtMobileStudent.Text = dGvStudent.CurrentRow.Cells[6].Value.ToString();
            dateOfBirthStudent.Value = (DateTime)dGvStudent.CurrentRow.Cells[7].Value;
            myImage.SizeMode = PictureBoxSizeMode.StretchImage;
            myImage.Image = getUserImage(id);
            if (dashboard.role != "Admin")
            {
                btnDeleteStudent.Enabled = false;
                btnUpdateStudent.Enabled = false;
            }
            else
            {
                btnAddStudent.Enabled = true;
                btnUpdateStudent.Enabled = true;
                btnDeleteStudent.Enabled = true;
            }
        }

        private void dGvStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchStudent_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtSearchStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
