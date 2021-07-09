using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cb.Objects.DAO
{
    class dao_login
    {
        public string validateLogin(string _username, string _password)
        {
            string username, password, id_user = "";
            try
            {
                username = _username;
                password = _password;
                id_user = username;
                return id_user;
            }
            catch (Exception _exception)
            {
                Console.WriteLine(_exception.Message);
                return id_user;
            }
        }

        public bool validateUser(string _username, string _password)
        {
            string username, password;
            bool isValid;
            try
            {
                username = _username;
                password = _password;
                isValid = true;

                return isValid;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isValid = false;

                return isValid;
            }
        }

        public string validate_login(string uname, string pass)
        {
            string username, password, id_user = "";
            try
            {
                username = uname;
                password = pass;
                id_user = username;
                return id_user;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return id_user;
            }
        }

        public bool validate_user(string uname, string pass)
        {
            string username, password;
            try
            {
                username = uname;
                password = pass;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public string get_user_role(string uname, string pass)
        {
            string username, password, role = "";
            try
            {
                username = uname;
                password = pass;
                if (username.Equals(uname) && password.Equals(pass))
                { role = "admin"; }
                else
                { role = ""; }
                return role;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return role;
            }
        }
    }
}