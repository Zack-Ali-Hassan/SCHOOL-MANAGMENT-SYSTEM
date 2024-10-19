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
    public partial class frmSubject : UserControl
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtSubjectName.Text == "")
                {
                    MessageBox.Show("Enter subjectname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxClassnameSubject.Text == "Select")
                {
                    MessageBox.Show("Enter classtname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //else
                //{
                //    try
                //    {

                        if (exiss())
                            MessageBox.Show("Subject exist");
                        else
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "allProSubject";
                            cmd.Parameters.AddWithValue("@id", "");
                            cmd.Parameters.AddWithValue("@sname", txtSubjectName.Text);
                            cmd.Parameters.AddWithValue("@c_id", cboxClassnameSubject.Text);
                            cmd.Parameters.AddWithValue("@type", "insert");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New subject has been Register Thanks..");
                            clear();
                            getSubjectList();
                            frmdashboards.getSubject(frmdashboards.lbl1);
                            txtSubjectName.Focus();
                            btnAddSubject.Enabled = true;
                            btnUpdateSubject.Enabled = false;
                            btnDeleteSubject.Enabled = false;
                        }
                    //}
                    //catch (Exception error)
                    //{
                    //    MessageBox.Show(error.Message);
                    //}
                //}
            }
        }
        private bool exiss()
        {
            SqlConnection conn = ConnectionClass.connection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "allCheckSubject";
        
            cmd1.Parameters.AddWithValue("@sname", txtSubjectName.Text);
       
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                if (reader1.HasRows)
                {
                //    MessageBox.Show("Subject exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

            }
            conn.Close();
            reader1.Close();
            return false;

        }
        private void getSubjectList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("select subject_id,subjectname,classname from class c inner join subject s on c.class_id=s.class_id", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvSubject.DataSource = dt;
            }
        }
        //public void getTotalSubjectList()
        //{
        //    using (SqlConnection conn = ConnectionClass.connection())
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) SUBJECT", conn);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        frmdashboards frmdashboards = new frmdashboards();
        //        //frmdashboards.lblTotalSubjects.Text = dt;
        //    }
        //}
        public void clear()
        {
            txtSubjectName.Text = "";
            cboxClassnameSubject.SelectedIndex = 0;
            txtSearchSubject.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDisplaySId.Text = dGvSubject.CurrentRow.Cells[0].Value.ToString();
            txtSubjectName.Text = dGvSubject.CurrentRow.Cells[1].Value.ToString();
            cboxClassnameSubject.SelectedItem = dGvSubject.CurrentRow.Cells[2].Value.ToString();
            if (dashboard.role != "Admin")
            {
                btnUpdateSubject.Enabled = false;
                btnDeleteSubject.Enabled = false;
            }
            else
            {
                btnAddSubject.Enabled = true;
                btnUpdateSubject.Enabled = true;
                btnDeleteSubject.Enabled = true;
            }
        }

        private void dGvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboxClassnameSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtSubjectName.Text == "")
                {
                    MessageBox.Show("Enter subjectname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxClassnameSubject.Text == "Select")
                {
                    MessageBox.Show("Enter classtname", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    try
                    {
                        //if (exiss())
                        //    MessageBox.Show("Subject exist");
                        //else
                        //{
                            DialogResult result;
                            result = MessageBox.Show("Do you want to update this Subject??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = conn;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "allProSubject";
                                cmd.Parameters.AddWithValue("@id", lblDisplaySId.Text);
                                cmd.Parameters.AddWithValue("@sname", txtSubjectName.Text);
                                cmd.Parameters.AddWithValue("@c_id", cboxClassnameSubject.Text);
                                cmd.Parameters.AddWithValue("@type", "update");
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("New Subject has been Update Thanks..");
                                clear();
                                getSubjectList();
                                txtSubjectName.Focus();
                            }
                            else
                            {
                                this.Show();
                            }
                        //}
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            readClass();
            getSubjectList();
            btnAddSubject.Enabled = true;
            btnUpdateSubject.Enabled = false;
            btnDeleteSubject.Enabled = false;
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
                        cboxClassnameSubject.Items.Add(reader[0].ToString());
                    }
                }
            }
        }
        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------Delete:Store Procedures----------
                if (lblDisplaySId.Text == "")
                {
                    MessageBox.Show("please choose Subject to delete", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to delete this subject??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "deleteProSubject";
                            cmd.Parameters.AddWithValue("@id", lblDisplaySId.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Subject has been Delete Thanks...");
                            clear();
                            getSubjectList();
                            frmdashboards.getSubject(frmdashboards.lbl1);
                            btnAddSubject.Enabled = true;
                            btnUpdateSubject.Enabled = false;
                            btnDeleteSubject.Enabled = true;
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

        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SUBJECT WHERE SUBJECTNAME LIKE'" + txtSearchSubject.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvSubject.DataSource = dt;

            }
        }

        private void txtSubjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&& (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void dGvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDisplaySId.Text = dGvSubject.CurrentRow.Cells[0].Value.ToString();
            txtSubjectName.Text = dGvSubject.CurrentRow.Cells[1].Value.ToString();
            cboxClassnameSubject.SelectedItem = dGvSubject.CurrentRow.Cells[2].Value.ToString();
            if (dashboard.role != "Admin")
            {
                btnUpdateSubject.Enabled = false;
                btnDeleteSubject.Enabled = false;
            }
            else
            {
                btnAddSubject.Enabled = true;
                btnUpdateSubject.Enabled = true;
                btnDeleteSubject.Enabled = true;
            }
        }

        private void txtSearchSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
