using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace project_cb.Objects.DAO
{
    class sql_connection
    {
        public string connection_string() {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_cbv.mdf;Integrated Security=True;Connect Timeout=30");
            
            return sqlconn.ToString();
        }
    }
}
