using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace SCHOOL_MANAGMENT_SYSTEM
{
    class ConnectionClass
    {
        public static SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-6816U5B\\SQLEXPRESS;Initial Catalog=SYL_MANAGMENT_SYSTEM;Integrated Security=True;");
            conn.Open();
            return conn;
        }
    }
}
