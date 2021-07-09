using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* INITATE METRO UI */
using Guna.UI2.WinForms;

using System.Data.SqlClient;
using project_cb.UI;
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

        controller_login controllerLogin = new controller_login();

        private void btn_batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (controllerLogin.validateLogin(txt_username.Text, txt_password.Text) != "")
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_cbv.mdf;Integrated Security=True;Connect Timeout=30");
                //SqlCommand sqlcmd = new SqlCommand("SELECT * FROM tbl_user WHERE username='" + txt_username.Text + "' AND password='" + txt_password.Text + "'");
                //SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd.ToString(), sqlconn);
                SqlDataAdapter sqladapter = new SqlDataAdapter("SELECT * FROM tbl_user WHERE username='" + txt_username.Text + "' AND password='" + txt_password.Text + "'", sqlconn);

                DataTable dt = new DataTable();
                sqladapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string getrole_user = controllerLogin.get_role_user(txt_username.Text, txt_password.Text);
                    if (getrole_user.Equals("admin"))
                    {
                        this.Hide();
                        form_utama fr_utama = new form_utama();
                        fr_utama.ShowDialog();
                        this.Close();
                    }
                    else if (getrole_user.Equals("staff"))
                    {
                        this.Hide();
                        form_utama fr_utama = new form_utama();
                        fr_utama.ShowDialog();
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "USERNAME ATAU PASSWORD SALAH!", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MetroMessageBox.ActiveForm.(this, "USERNAME ATAU PASSWORD SALAH!", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MetroMessageBox(this, "USERNAME ATAU PASSWORD SALAH!", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_cbv.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sql_data_adapter = new SqlDataAdapter("SELECT * FROM tbl_user WHERE username='" + txt_username.Text + "' AND password='" + txt_password.Text + "'", sqlconn);

            DataTable dt = new DataTable();
            sql_data_adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                form_utama fr_utama = new form_utama();
                fr_utama.ShowDialog();
                this.Close();
            }
            */
            /*
            if (cont_login.validate_login(txt_username.Text, txt_password.Text) != "")
            {
                string role = cont_login.get_role_user(txt_username.Text, txt_password.Text);
                if (role == "admin")
                {
                    this.Hide();
                    form_utama fr_utama = new form_utama();
                    fr_utama.ShowDialog();
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
            */
        }

        private void linkGantiPassword_Click(object sender, EventArgs e)
        {
            uc_login uc_login = new uc_login();
            uc_login.Visible = true;

        }
    }
}
