using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cb.DAO
{
    class dbconnection
    {
        private string server, database, userid, password;
        public string connectionString()
        {
            // LOCALHOST PAKAI INI //
            server = "localhost"; database = ""; userid = "root"; password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            return connectionString;
        }
    }
}
