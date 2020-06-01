using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace demonet
{
    public partial class Form_xemcongviec : Form
    {
        view_BUS view = new view_BUS();
        public Form_xemcongviec()
        {
            InitializeComponent();
        }
        private int id;
        private string quyen = "";
        public Form_xemcongviec(string a,int b):this()
        {
            quyen = a;
            id = b;
        }

        private void Form_xemcongviec_Load(object sender, EventArgs e)
        {
            dgv.DataSource = view.Get_viewcongviec(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                Owner.Show();
                this.Close();
            }
            else
            {
                menu frm = new menu();
                frm.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 1; i <= dgv.ColumnCount; i++)
            {
                xlWorkSheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }
            for (i = 0; i < dgv.RowCount; i++)
            {
                for (j = 0; j < dgv.ColumnCount; j++)
                {
                    DataGridViewCell cell = dgv[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("csharp.net-thongtincongviec.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            //  releaseObject(xlWorkSheet);
            //   releaseObject(xlWorkBook);
            //   releaseObject(xlApp);

            MessageBox.Show("Excel file created , bạn lưu file tại c:\\csharp.net-thongtincongviec.xls");
        }
    }
}
