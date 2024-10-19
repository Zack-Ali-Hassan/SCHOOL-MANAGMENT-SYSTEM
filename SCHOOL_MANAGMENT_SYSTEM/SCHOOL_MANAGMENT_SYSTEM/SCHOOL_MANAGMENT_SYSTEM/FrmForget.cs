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
    public partial class FrmForget : Form
    {
        public FrmForget()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login frmlogin = new Login();
            frmlogin.Show();
            this.Hide();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool exiss()
        {
            SqlConnection conn = ConnectionClass.connection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "CheckproForgetPassword";
            int temp;
            if(int.TryParse(txtUsernameOrMobile.Text,out temp))
            {
                temp = int.Parse(txtUsernameOrMobile.Text);
                cmd1.Parameters.AddWithValue("@mobile", temp);
                cmd1.Parameters.AddWithValue("@username", txtUsernameOrMobile.Text);
            }else
            {
                cmd1.Parameters.AddWithValue("@mobile", 0);
                cmd1.Parameters.AddWithValue("@username", txtUsernameOrMobile.Text);
            }
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtUsernameOrMobile.Text == "")
                {
                    MessageBox.Show("Enter Username Or Mobile.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNewPassword.Text == "")
                {
                    MessageBox.Show("Enter New Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtConfirmNewPassword.Text == "")
                {
                    MessageBox.Show("Enter Confirm New Password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                {
                    MessageBox.Show("Please Enter Confirm Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtConfirmNewPassword.Clear();
                    return;
                }
                else
                {
                    try
                    {
                        if (exiss())
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "proForgetPasswordUpdate";

                            int temp;
                            if (int.TryParse(txtUsernameOrMobile.Text, out temp))
                            {
                                temp = int.Parse(txtUsernameOrMobile.Text);
                                cmd.Parameters.AddWithValue("@tmobile", temp);
                                cmd.Parameters.AddWithValue("@tusername", txtUsernameOrMobile.Text);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@tmobile", 0);
                                cmd.Parameters.AddWithValue("@tusername", txtUsernameOrMobile.Text);
                            }
                         
                            cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password has been Update Thanks...");
                            txtUsernameOrMobile.Clear();
                            txtNewPassword.Clear();
                            txtConfirmNewPassword.Clear();
                            txtUsernameOrMobile.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Username or Mobile not exist");
                        }
                            
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                }
            }
        }
    }
}
