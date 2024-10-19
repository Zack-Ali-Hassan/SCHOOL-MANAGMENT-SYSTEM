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
    public partial class frmUsers : UserControl
    {
        public static string imageName;
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            myImage.SizeMode = PictureBoxSizeMode.StretchImage;
            getUserList();
            myPanel.SendToBack();
            lblDisplayId.SendToBack();
            myImage.BringToFront();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

        }
        public void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtSearchUser.Text = "";
            txtMoblie.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cbxDetailsUser.SelectedIndex = 0;
            myImage.Image = null;
        }
        private void getUserList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select user_id,firstname,lastname,details,mobile,username,password from users where username != '" + dashboard.username + "' ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //dGvUsers.RowTemplate.Height = 75;
                dGvUsers.DataSource = dt;
                //DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
                //pic1 = (DataGridViewImageColumn)dGvUsers.Columns[7];
                //pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
        }
        public void getTotalUserList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM USERS", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                frmdashboards frmdashboards = new frmdashboards();
                //frmdashboards.lblTotalUsers.Text = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbxDetailsUser.Text == "Select")
                {
                    MessageBox.Show("Enter you Detail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMoblie.Text == "")
                {
                    MessageBox.Show("Enter you Mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Enter you UserName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter you password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Enter you Confirm password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Please Enter Confirm Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMoblie.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to update this user??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                            try
                            {
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "allProUser";
                                cmd.Parameters.AddWithValue("@id", lblDisplayId.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@detail", cbxDetailsUser.Text);
                                cmd.Parameters.AddWithValue("@mobile", txtMoblie.Text);
                                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                                MemoryStream mstr = new MemoryStream();
                                myImage.Image.Save(mstr, myImage.Image.RawFormat);
                                cmd.Parameters.AddWithValue("@image", mstr.ToArray());
                                cmd.Parameters.AddWithValue("@type", "update");
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("User has been Update Thanks...");
                                clear();
                                getUserList();
                                myPanel.SendToBack();
                                myImage.BringToFront();
                                myImage.Image = Properties.Resources.users3;
                                txtFirstName.Focus();
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
        private bool exiss()
        {
            SqlConnection conn = ConnectionClass.connection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "checkInsert";
            cmd1.Parameters.AddWithValue("@mobile", txtMoblie.Text);
            cmd1.Parameters.AddWithValue("@username", txtUsername.Text);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------Delete:Store Procedures----------
                if (lblDisplayId.Text == "")
                {
                    MessageBox.Show("please choose user to delete", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to delete this user??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "deleteProUser";
                        cmd.Parameters.AddWithValue("@id", lblDisplayId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User has been Delete Thanks...");
                        clear();
                        getUserList();
                        frmdashboards.getTotalUser(frmdashboards.lbl4);
                        txtFirstName.Focus();
                        myImage.BringToFront();
                        myPanel.SendToBack();
                        lblPhoto.SendToBack();
                        myImage.Image = Properties.Resources.users3;
                        btnAdd.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
        }
        private void searchUser()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USERS WHERE Username LIKE'" + txtSearchUser.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dGvUsers.DataSource = dt;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }
                
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            searchUser();
        }

        private void dGvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dGvUsers.CurrentRow.Cells[0].Value;
            lblDisplayId.Text = dGvUsers.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dGvUsers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dGvUsers.CurrentRow.Cells[2].Value.ToString();
            cbxDetailsUser.Text = dGvUsers.CurrentRow.Cells[3].Value.ToString();
            txtMoblie.Text = dGvUsers.CurrentRow.Cells[4].Value.ToString();
            txtUsername.Text = dGvUsers.CurrentRow.Cells[5].Value.ToString();
            txtPassword.Text = dGvUsers.CurrentRow.Cells[6].Value.ToString();
            txtConfirmPassword.Text = dGvUsers.CurrentRow.Cells[6].Value.ToString();
            myImage.SizeMode = PictureBoxSizeMode.StretchImage;
            myImage.Image = getUserImage(id);
            //MemoryStream str = new MemoryStream((byte[])dGvUsers.CurrentRow.Cells[7].Value);
            //myImage.Image = Image.FromStream(str);
            myPanel.Visible = false;
            if (dashboard.role != "Admin")
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtMoblie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers..","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtMoblie_TextChanged(object sender, EventArgs e)
        {
            if (txtMoblie.Text == "")
                return;
            if (!this.txtMoblie.Text.StartsWith("6"))
            {
                MessageBox.Show("Mobile Must start 6.");
                this.txtMoblie.Clear();
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtSearchUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbxDetailsUser.Text == "Select")
                {
                    MessageBox.Show("Enter you Detail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMoblie.Text == "")
                {
                    MessageBox.Show("Enter you Mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtUsername.Text == "")
                {
                    MessageBox.Show("Enter you UserName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter you password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtConfirmPassword.Text == "")
                {
                    MessageBox.Show("Enter you Confirm password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Please Enter Confirm Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMoblie.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.","Messsage",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else
                {

                    if (exiss())
                        MessageBox.Show("User exist");
                    else
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "allProUser";
                            cmd.Parameters.AddWithValue("@id", "");
                            cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                            cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                            cmd.Parameters.AddWithValue("@detail", cbxDetailsUser.Text);
                            cmd.Parameters.AddWithValue("@mobile", txtMoblie.Text);
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            MemoryStream mstr = new MemoryStream();
                            myImage.Image.Save(mstr, myImage.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@image", mstr.ToArray());
                            cmd.Parameters.AddWithValue("@type", "insert");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New user has been Register Thanks..");
                            clear();
                            getUserList();
                            frmdashboards.getTotalUser(frmdashboards.lbl4);
                            txtFirstName.Focus();
                            btnAdd.Enabled = true;
                            btnUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            myImage.BringToFront();
                            myImage.Image = Properties.Resources.users3;
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                }
            }
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

        public static MemoryStream ImageToStream(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms;
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
                var cmd = new SqlCommand("rImagePro", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                var reader = cmd.ExecuteReader();
                reader.Read();
                var img = getImage(reader[0]);
                conn.Close();
                return img;

            }
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void dGvUsers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dGvUsers.CurrentRow.Cells[0].Value;
            lblDisplayId.Text = dGvUsers.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dGvUsers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dGvUsers.CurrentRow.Cells[2].Value.ToString();
            cbxDetailsUser.Text = dGvUsers.CurrentRow.Cells[3].Value.ToString();
            txtMoblie.Text = dGvUsers.CurrentRow.Cells[4].Value.ToString();
            txtUsername.Text = dGvUsers.CurrentRow.Cells[5].Value.ToString();
            txtPassword.Text = dGvUsers.CurrentRow.Cells[6].Value.ToString();
            txtConfirmPassword.Text = dGvUsers.CurrentRow.Cells[6].Value.ToString();
            myImage.SizeMode = PictureBoxSizeMode.StretchImage;
            myImage.Image = getUserImage(id);
            //MemoryStream str = new MemoryStream((byte[])dGvUsers.CurrentRow.Cells[7].Value);
            //myImage.Image = Image.FromStream(str);
            myPanel.Visible = false;
            if (dashboard.role != "Admin")
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }



    }
}
