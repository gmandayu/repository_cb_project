using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_cb.Exceptions
{
    class show_exception
    {
        public void show_message(string message, string type)
        {
            string[] temp = message.Split((char)13);
            MessageBox.Show("Kesalahan: " + temp[0], type, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
