using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using project_cb.Controllers;


namespace project_cb
{
    public partial class form_login : MetroForm
    {
        public form_login()
        {
            InitializeComponent();
        }

        controller_login cont_login = new controller_login();

        private void btn_batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cont_login.validate_login(txt_username.Text, txt_password.Text) != "")
            {
                string role = cont_login.get_role_user(txt_username.Text, txt_password.Text);
                if (role == "admin")
                {
                    this.Hide();
                    form_login fr_login = new form_login();
                    fr_login.ShowDialog();
                    this.Close();
                }
                else if (role == "staff")
                {
                    this.Hide();
                    form_login fr_login = new form_login();
                    fr_login.ShowDialog();
                    this.Close();
                }
                else
                {
                    //MetroMessageBox.Show(this, "USERNAME ATAU PASSWORD SALAH!", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MetroMessageBox.ActiveForm.Show(this, "USERNAME ATAU PASSWORD SALAH!", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
