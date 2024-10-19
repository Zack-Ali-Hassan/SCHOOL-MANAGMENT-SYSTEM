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
using System.Drawing;
namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class profile : UserControl
    {
        public static string imageName;
        public profile()
        {
            InitializeComponent();
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
                else if (txtLastName.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                else if (txtMoblie.Text == "")
                {
                    MessageBox.Show("Enter you Mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else if (txtUsername.Text == "")
                {
                    MessageBox.Show("Enter you UserName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("Enter you password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                //SqlCommand cmd = new SqlCommand("Update USERS SET FirstName = '"+txtFirstName.Text+"', LastName = '"+txtLastName.Text+"', mobile = '"+txtMoblie.Text+"', username = '"+txtUsername.Text+"',Password = '"+txtPassword.Text+"' where user_id = '"+txtUserId.Text+"'  ",conn);
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "allPrOFileUpdate";
                                cmd.Parameters.AddWithValue("@id", txtUserId.Text);
                                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                                cmd.Parameters.AddWithValue("@mobile", txtMoblie.Text);
                                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                                cmd.Parameters.AddWithValue("@image",frmUsers.ImageToStream(myImage.Image).ToArray());
                                cmd.Parameters.AddWithValue("@type", "update");
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("User has been Update Thanks...","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                clear();
                                txtUserId.Focus();
                                Application.Restart();
                                myPanel.BringToFront();
                                lblPhoto.BringToFront();
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show(error.Message);
                            }
                        
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        public void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            //txtSearchUser.Text = "";
            txtMoblie.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
           // txtConfirmPassword.Text = "";
            //cbxDetailsUser.SelectedIndex = 0;
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
                if (txtUserId.Text == "")
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
                        cmd.Parameters.AddWithValue("@id", txtUserId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User has been Delete Thanks...");
                        myPanel.BringToFront();
                        lblPhoto.BringToFront();
                        Application.Restart();
                      
                    }
                   
                }
            }
        }


        private void profile_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlCommand cmd = new SqlCommand("SELECT user_id,FirstName,LastName,mobile,UserName,Password,images   FROM USERS where username = '" + dashboard.username + "' ", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUserId.Text = reader["user_id"].ToString();
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtMoblie.Text = reader["mobile"].ToString();
                    txtUsername.Text = reader["username"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    myImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    myImage.Image = getUserImage(int.Parse(txtUserId.Text.ToString()));
                    myPanel.SendToBack();
                }
                conn.Close();
                
                
            }
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
                var img = frmUsers.getImage(reader[0]);
                conn.Close();
                return img;

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
                    myImage.SizeMode = PictureBoxSizeMode.Zoom;
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

        private void txtMoblie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers..", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
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
    }
}
