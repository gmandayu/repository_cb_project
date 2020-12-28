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


namespace project_cb
{
    public partial class form_login : MetroForm
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }
    }
}
