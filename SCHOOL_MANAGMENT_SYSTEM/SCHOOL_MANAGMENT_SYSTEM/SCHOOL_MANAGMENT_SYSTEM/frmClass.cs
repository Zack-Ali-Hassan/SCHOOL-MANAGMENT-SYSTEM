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
    public partial class frmClass : UserControl
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtClassName.Text == "")
                {
                    MessageBox.Show("Enter classname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    try
                    {
                        if (exiss())
                            MessageBox.Show("Class exist");
                        else
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "allProClass";
                            cmd.Parameters.AddWithValue("@id", "");
                            cmd.Parameters.AddWithValue("@cname", txtClassName.Text);
                            cmd.Parameters.AddWithValue("@type", "insert");
                            cmd.ExecuteNonQuery();
                            frmdashboards.getClass(frmdashboards.lbl);
                            MessageBox.Show("New class has been Register Thanks..");
                            clear();
                            getClassList();
                            frmdashboards.getClass(frmdashboards.lbl);
                            btnAddClass.Enabled = true;
                            btnUpdateClass.Enabled = false;
                            btnDeleteClass.Enabled = false; 
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
            cmd1.CommandText = "allCheckClass";
            cmd1.Parameters.AddWithValue("@cname", txtClassName.Text);
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

        private void getClassList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLASS", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvClass.DataSource = dt;
            }
        }

        public void clear()
        {
            txtClassName.Text = "";
            txtSearchClass.Text = "";
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CLASS WHERE CLASSNAME LIKE'" + txtSearchClass.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvClass.DataSource = dt;

            }
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            getClassList();
            btnAddClass.Enabled = true;
            btnUpdateClass.Enabled = false;
            btnDeleteClass.Enabled = false; 
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtClassName.Text == "")
                {
                    MessageBox.Show("Enter classname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to update this class??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {

                            //if (exiss())
                            //    MessageBox.Show("Class exist");
                            //else
                            //{
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "allProClass";
                                cmd.Parameters.AddWithValue("@id", lblDisplayCId.Text);
                                cmd.Parameters.AddWithValue("@cname", txtClassName.Text);
                                cmd.Parameters.AddWithValue("@type", "update");
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("New class has been Update Thanks..");
                                clear();
                                getClassList();
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

        private void dGvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDisplayCId.Text = dGvClass.CurrentRow.Cells[0].Value.ToString();
            txtClassName.Text = dGvClass.CurrentRow.Cells[1].Value.ToString();
            if (dashboard.role != "Admin")
            {
                btnUpdateClass.Enabled = false;
                btnDeleteClass.Enabled = false;
            }
            else
            {
                btnAddClass.Enabled = true;
                btnUpdateClass.Enabled = true;
                btnDeleteClass.Enabled = true;
            }
            
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------Delete:Store Procedures----------
                if (lblDisplayCId.Text == "")
                {
                    MessageBox.Show("please choose class to delete", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    try
                    {
                        DialogResult result;
                        result = MessageBox.Show("Do you want to delete this class??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "deleteProClass";
                            cmd.Parameters.AddWithValue("@id", lblDisplayCId.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("class has been Delete Thanks...");
                            clear();
                            getClassList();
                            frmdashboards.getClass(frmdashboards.lbl);
                            btnAddClass.Enabled = true;
                            btnUpdateClass.Enabled = false;
                            btnDeleteClass.Enabled = true;
                        }
                        else
                        {
                            this.Show();
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void txtClassName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtSearchClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dGvClass_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            lblDisplayCId.Text = dGvClass.CurrentRow.Cells[0].Value.ToString();
            txtClassName.Text = dGvClass.CurrentRow.Cells[1].Value.ToString();
            if (dashboard.role != "Admin")
            {
                btnUpdateClass.Enabled = false;
                btnDeleteClass.Enabled = false;
            }
            else
            {
                btnAddClass.Enabled = true;
                btnUpdateClass.Enabled = true;
                btnDeleteClass.Enabled = true;
            }
        }

    }
}
