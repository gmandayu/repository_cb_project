﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using project_cb.Objects.DAO; 

namespace project_cb.Controllers
{
    class controller_login
    {
        dao_login dao_login = new dao_login();
        public string validateLogin(string _username, string _password)
        {
            return dao_login.validateLogin(_username, _password);
        }

        public string validateUser(string _username, string _password)
        {
            return "";
        }

        public string validate_login(string username, string password)
        { return dao_login.validate_login(username, password); }

        public bool validate_user(string username, string password)
        { return dao_login.validate_user(username, password); }

        public string get_role_user(string username, string password)
        { return dao_login.get_user_role(username, password); }
    }
}
