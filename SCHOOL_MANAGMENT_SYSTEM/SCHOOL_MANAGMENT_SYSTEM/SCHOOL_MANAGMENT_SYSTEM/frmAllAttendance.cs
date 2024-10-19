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
    public partial class frmAllAttendance : UserControl
    {
        public frmAllAttendance()
        {
            InitializeComponent();
        }

        private void frmAllAttendance_Load(object sender, EventArgs e)
        {
            dateEnd.Value = DateTime.Now;
            BeginDate.Value = DateTime.Now;
            readClass();
        }
        private void readClass()
        {
            using (SqlConnection conn = ConnectionClass.connection())
            {
                var da = new SqlCommand("select class_id from class", conn);
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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (ComboBoxClassName.SelectedItem.ToString()== "Select")
            {
                MessageBox.Show("please Select class to report...","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                BeginDate.Value = DateTime.Now;
                dateEnd.Value = DateTime.Now;
                return;
            }
            if (BeginDate.Value > dateEnd.Value)
            {
                MessageBox.Show("Invalid Begin date is greater than End date...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BeginDate.Value = DateTime.Now;
                dateEnd.Value = DateTime.Now;
                return;
            }
            try
            {
                using (SqlConnection conn = ConnectionClass.connection())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ReadAllAttendance";
                    cmd.Parameters.AddWithValue("@Bdate", BeginDate.Value);
                    cmd.Parameters.AddWithValue("@Edate", dateEnd.Value);
                    cmd.Parameters.AddWithValue("@c_id", int.Parse(ComboBoxClassName.Text));
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    AllCrystalReportAttendance crr = new AllCrystalReportAttendance();
                    crr.SetDataSource(dt);
                    cRvReportAttendance.ReportSource = crr;

                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }

        private void ComboBoxClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateOfAttendence_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
