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
    public partial class frmStaff : UserControl
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------

                if (txtFirstNameStaff.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastNameStaff.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStaff.Text == "")
                {
                    MessageBox.Show("Enter you Mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxSexStaff.Text == "Select")
                {
                    MessageBox.Show("Enter you Sex", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtSalaryStaff.Text == "")
                {
                    MessageBox.Show("Enter you salary", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtAddressStaff.Text == "")
                {
                    MessageBox.Show("Enter you address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStaff.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (int.Parse(txtSalaryStaff.Text) > 1000)
                {
                    MessageBox.Show("does'nt accept salary greater than 1000.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalaryStaff.Clear();
                    return;
                }
                else
                {
                    try
                    {

                        if (exiss())
                            MessageBox.Show("Staff exist");
                        else
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "allProStaff";
                            cmd.Parameters.AddWithValue("@id", "");
                            cmd.Parameters.AddWithValue("@fname", txtFirstNameStaff.Text);
                            cmd.Parameters.AddWithValue("@lname", txtLastNameStaff.Text);
                            cmd.Parameters.AddWithValue("@mobile", txtMobileStaff.Text);
                            cmd.Parameters.AddWithValue("@sex", cboxSexStaff.Text);
                            cmd.Parameters.AddWithValue("@salary", txtSalaryStaff.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddressStaff.Text);
                            cmd.Parameters.AddWithValue("@type", "insert");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("New staff has been Register Thanks..");
                            clear();
                            getStaffList();
                            frmdashboards.getStaff(frmdashboards.lbl5);
                            txtFirstNameStaff.Focus();
                            btnAddStaff.Enabled = true;
                            btnUpdateStaff.Enabled = false;
                            btnDeleteStaff.Enabled = false;
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
            txtFirstNameStaff.Text = "";
            txtLastNameStaff.Text = "";
            txtSearchStaff.Text = "";
            txtMobileStaff.Text = "";
            cboxSexStaff.SelectedIndex = 0;
            txtSalaryStaff.Text = "";
            txtAddressStaff.Text = "";

        }
        private bool exiss()
        {
            SqlConnection conn = ConnectionClass.connection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "allCheckStaff";
            cmd1.Parameters.AddWithValue("@mobile", txtMobileStaff.Text);
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
        private void getStaffList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM STAFF", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvStaff.DataSource = dt;
            }
        }
        public void getTotalStaffList()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) FROM STAFF", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                frmdashboards frmdashboards = new frmdashboards();
                //frmdashboards.lblTotalStaffes.Text = dt.;
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            getStaffList();
            btnAddStaff.Enabled = true;
            btnUpdateStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
        }

        private void dGvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblDisplayStaffId.Text = dGvStaff.CurrentRow.Cells[0].Value.ToString();
            txtFirstNameStaff.Text = dGvStaff.CurrentRow.Cells[1].Value.ToString();
            txtLastNameStaff.Text = dGvStaff.CurrentRow.Cells[2].Value.ToString();
            txtMobileStaff.Text = dGvStaff.CurrentRow.Cells[3].Value.ToString();
            cboxSexStaff.Text = dGvStaff.CurrentRow.Cells[4].Value.ToString();
            txtSalaryStaff.Text = dGvStaff.CurrentRow.Cells[5].Value.ToString();
            txtAddressStaff.Text = dGvStaff.CurrentRow.Cells[6].Value.ToString();
            if (dashboard.role != "Admin")
            {
                btnUpdateStaff.Enabled = false;
                btnDeleteStaff.Enabled = false;
            }
            else
            {
                btnAddStaff.Enabled = true;
                btnUpdateStaff.Enabled = true;
                btnDeleteStaff.Enabled = true;
            }
        }
        private void searchStaff()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM STAFF WHERE MOBILE LIKE'" + txtSearchStaff.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGvStaff.DataSource = dt;

            }
        }

        private void txtSearchStaff_TextChanged(object sender, EventArgs e)
        {
            searchStaff();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------insert three:Store Procedures----------
                if (txtFirstNameStaff.Text == "")
                {
                    MessageBox.Show("Enter you FirstName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtLastNameStaff.Text == "")
                {
                    MessageBox.Show("Enter you LastName", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStaff.Text == "")
                {
                    MessageBox.Show("Enter you Mobile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cboxSexStaff.Text == "Select")
                {
                    MessageBox.Show("Enter you Sex", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtSalaryStaff.Text == "")
                {
                    MessageBox.Show("Enter you Salary", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtAddressStaff.Text == "")
                {
                    MessageBox.Show("Enter you Address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtMobileStaff.Text.Length < 9)
                {
                    MessageBox.Show("Mobile digits is lessthan 9.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (int.Parse(txtSalaryStaff.Text) > 1000)
                {
                    MessageBox.Show("does'nt accept salary greater than 1000.", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalaryStaff.Clear();
                    return;
                    
                }
                else
                {

                    DialogResult result;
                    result = MessageBox.Show("Do you want to update this staff??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            //if (exiss())
                            //    MessageBox.Show("Staff exist");
                            //else
                            //{
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "allProStaff";
                            cmd.Parameters.AddWithValue("@id", lblDisplayStaffId.Text);
                            cmd.Parameters.AddWithValue("@fname", txtFirstNameStaff.Text);
                            cmd.Parameters.AddWithValue("@lname", txtLastNameStaff.Text);
                            cmd.Parameters.AddWithValue("@mobile", txtMobileStaff.Text);
                            cmd.Parameters.AddWithValue("@sex", cboxSexStaff.Text);
                            cmd.Parameters.AddWithValue("@salary", txtSalaryStaff.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddressStaff.Text);
                            cmd.Parameters.AddWithValue("@type", "update");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Staff has been Update Thanks...");
                            clear();
                            getStaffList();
                            txtFirstNameStaff.Focus();
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

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                //-------------------Delete:Store Procedures----------
                if (lblDisplayStaffId.Text == "")
                {
                    MessageBox.Show("please choose staff to delete", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to delete this staff??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "deleteproStaff";
                        cmd.Parameters.AddWithValue("@id", lblDisplayStaffId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff has been Delete Thanks...");
                        clear();
                        getStaffList();
                        frmdashboards.getStaff(frmdashboards.lbl5);
                        txtFirstNameStaff.Focus();
                        btnAddStaff.Enabled = true;
                        btnUpdateStaff.Enabled = false;
                        btnDeleteStaff.Enabled = true;
                    }
                    else
                    {
                        this.Show();
                    }
                }
            }
        }

        private void txtFirstNameStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstNameStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLastNameStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddressStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMobileStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers..", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSalaryStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Only numeric and decimal..", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMobileStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtMobileStaff.Text == "")
                return;
            if (!this.txtMobileStaff.Text.StartsWith("6"))
            {
                MessageBox.Show("Mobile Must start 6.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMobileStaff.Clear();
            }

            

        }

        private void txtMobileStaff_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtMobileStaff_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtMobileStaff_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dGvStaff_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblDisplayStaffId.Text = dGvStaff.CurrentRow.Cells[0].Value.ToString();
                txtFirstNameStaff.Text = dGvStaff.CurrentRow.Cells[1].Value.ToString();
                txtLastNameStaff.Text = dGvStaff.CurrentRow.Cells[2].Value.ToString();
                txtMobileStaff.Text = dGvStaff.CurrentRow.Cells[3].Value.ToString();
                cboxSexStaff.Text = dGvStaff.CurrentRow.Cells[4].Value.ToString();
                txtSalaryStaff.Text = dGvStaff.CurrentRow.Cells[5].Value.ToString();
                txtAddressStaff.Text = dGvStaff.CurrentRow.Cells[6].Value.ToString();
                if (dashboard.role != "Admin")
                {
                    btnUpdateStaff.Enabled = false;
                    btnDeleteStaff.Enabled = false;
                }
                else
                {
                    btnAddStaff.Enabled = true;
                    btnUpdateStaff.Enabled = true;
                    btnDeleteStaff.Enabled = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearchStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
