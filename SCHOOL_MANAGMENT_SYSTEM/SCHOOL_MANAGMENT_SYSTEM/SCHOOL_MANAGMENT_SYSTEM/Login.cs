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
using System.Drawing;
using System.IO;
namespace SCHOOL_MANAGMENT_SYSTEM
{
    public partial class Login : Form
    {

        public Image userImage;
        public Login()
        {
            InitializeComponent();
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.password;
                chRememberMe.Checked = true;
            }
        }
        public string username;
        public string type;
        SqlConnection conn = ConnectionClass.connection();
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text;
            password = txtPassword.Text;

            if (txtUsername.Text == "" && txtPassword.Text == "")

                MessageBox.Show("Blank not allowed", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                if (CheckUser())
                {
                    new dashboard(username, type,userImage).Show();
                    this.Hide();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        private bool CheckUser()
        {
            var isVaid = false;
            try
            {

                string querry = "SELECT * FROM USERS WHERE UserName ='" + txtUsername.Text + "'AND Password = '" + txtPassword.Text
                    + "'";
                SqlCommand sda = new SqlCommand(querry, conn);
                SqlDataReader reader = sda.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        username = reader[5].ToString();
                        type = reader[3].ToString();
                        userImage = getImage(reader[7]);
                        isVaid = true;
                    }
                }
                reader.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return isVaid;
        }
        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void picBoxHide_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                gunaPictureBox3.BringToFront();
            }
        }

        private void gunaPictureBox3_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '*')
            {
                txtPassword.PasswordChar = '*';
                gunaPictureBox4.BringToFront();
            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            FrmForget forget = new FrmForget();
            forget.Show();
            forget.txtUsernameOrMobile.Focus();
            this.Hide();
        }


        private Image getImage(object reader)
        {
            var straem = new MemoryStream((byte[])reader);
            Image img = Image.FromStream(straem);
            return img;

        }

        private void chRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chRememberMe.Checked)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                Properties.Settings.Default.UserName = username;
                Properties.Settings.Default.password = txtPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
