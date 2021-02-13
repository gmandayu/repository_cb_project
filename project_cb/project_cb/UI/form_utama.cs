using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using project_cb.Exceptions;
using MetroFramework.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace project_cb.UI
{
    public partial class form_utama : MetroForm
    {
        public form_utama()
        {
            InitializeComponent();
        }

        private static show_exception se = new show_exception();

        private void form_utama_Load(object sender, EventArgs e)
        {
            Excel.Application excel_app = new Microsoft.Office.Interop.Excel.Application();
            if (excel_app == null)
            {
                MessageBox.Show("Excel isn't properly installed!","Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Workbook excel_workbook;
            Excel.Worksheet excel_worksheet;
            object misValue = System.Reflection.Missing.Value;

            excel_workbook = excel_app.Workbooks.Add(misValue);
            excel_worksheet = (Excel.Worksheet)excel_workbook.Worksheets.get_Item(1);

            excel_worksheet.Cells[1, 1] = "ID";

            excel_workbook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            excel_workbook.Close(true, misValue, misValue);
            excel_app.Quit();

            Marshal.ReleaseComObject(excel_worksheet);
            Marshal.ReleaseComObject(excel_workbook);
            Marshal.ReleaseComObject(excel_app);

            MessageBox.Show("Excel file created!");
        }
        
        private void set_datagridview_anggota(DataGridView dg)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            
        }
    }
}
