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
    public partial class FrmReport : UserControl
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void cRvReport_Load(object sender, EventArgs e)
        {

        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            readStudent();
            if (cBoxAll.SelectedItem.ToString() == "All")
            {
                btnGenerate.Enabled = false;
                ComboBoxClassName.Enabled = false;
            }
            else if (cBoxAll.SelectedItem.ToString() == "Custom")
            {
                btnGenerate.Enabled = true;
                ComboBoxClassName.Enabled = true;
            }
           
        }
        private void readStudent()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("select student_id from student order by student_id desc", conn);
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void cBoxAll_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cBoxAll.SelectedItem.ToString()== "All")
            {
                btnGenerate.Enabled = false;
                ComboBoxClassName.Enabled = false;
            }
            else if (cBoxAll.SelectedItem.ToString()== "Custom")
            {
                btnGenerate.Enabled = true;
                ComboBoxClassName.Enabled = true;
            }
        }

        private void ComboBoxClassName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            if (ComboBoxClassName.SelectedItem.ToString() == "Select")
            {
                MessageBox.Show("Select student id","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (SqlConnection conn = ConnectionClass.connection())
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procSpecificStudent";
                    cmd.Parameters.AddWithValue("@id", int.Parse(ComboBoxClassName.Text));
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    AllReportStudent cr = new AllReportStudent();
                    cr.SetDataSource(dt);
                    //StudentReport sr = new StudentReport();
                    //sr.cRvReportStudentSpecifc.ReportSource = cr;
                    //sr.Show();
                    cRvReport.ReportSource = cr;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
