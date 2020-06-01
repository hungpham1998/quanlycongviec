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
    public partial class Form_CONGVIEC : Form
    {
        private string quyen = "";
        congviec_BUS cv = new congviec_BUS();
        duan_BUS da = new duan_BUS();
        public Form_CONGVIEC()
        {
            InitializeComponent();
        }
        public Form_CONGVIEC(string mada) : this()
        {
            field_duan.Text = mada;
            quyen = mada;
        }
        private void Form_CONGVIEC_Load(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                buttonUpdate.Visible = true;
                buttonInsert.Visible = true;
                buttonDelete.Visible = true;
                View1.Visible = false;
            }
            else
            {
                buttonUpdate.Visible = false;
                buttonInsert.Visible = false;
                buttonDelete.Visible = false;
                View1.Visible = false;
            }
            dgv.DataSource = cv.Get_congviec();
            View1.DataSource = da.Get_duan();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) return;
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            field_id.Text = row.Cells[0].Value.ToString();
            field_duan.Text = row.Cells[1].Value.ToString();
            field_noidung.Text = row.Cells[2].Value.ToString();
            field_ngaybd.Text = row.Cells[3].Value.ToString();
            field_tencv.Text = row.Cells[4].Value.ToString();
            field_thoihan.Text = row.Cells[5].Value.ToString();
        }
            private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (field_noidung.Text != "" && field_ngaybd.Text != " " && field_thoihan.Text != " " )
            {
                DOT_congviec m = new DOT_congviec(0, Convert.ToInt32(field_duan.Text), field_tencv.Text, field_noidung.Text,field_thoihan.Text,field_ngaybd.Text);
                Convert.ToString(cv.congviec_them(m));
                MessageBox.Show("Thêm thành công");
                dgv.DataSource = cv.Get_congviec();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        { 
                Owner.Show();
                this.Close(); 
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (field_noidung.Text != "" && field_ngaybd.Text != " " && field_thoihan.Text != " ")
            {
                DOT_congviec m = new DOT_congviec(Convert.ToInt32(field_id.Text), Convert.ToInt32(field_duan.Text), field_tencv.Text, field_noidung.Text, field_thoihan.Text, field_ngaybd.Text);
                cv.congviec_sua(m);
                MessageBox.Show("sửa thành công");
                dgv.DataSource = cv.Get_congviec();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View1.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DOT_congviec m = new DOT_congviec(Convert.ToInt32(field_id.Text), Convert.ToInt32(field_duan.Text), field_tencv.Text, field_noidung.Text, field_thoihan.Text, field_ngaybd.Text);
            cv.congviec_xoa(m);
            MessageBox.Show("xóa thành công nhân viên ");
            dgv.DataSource = cv.Get_congviec();
        }

        private void View1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (View1.SelectedCells.Count == 0) return;
            DataGridViewRow row = View1.SelectedCells[0].OwningRow;
            field_duan.Text = row.Cells[0].Value.ToString();
            View1.Visible = false;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            if (txttim.Text != "")
            {
                DOT_congviec a = new DOT_congviec(0,0, txttim.Text,txttim.Text, null, null);
                dgv.DataSource = cv.congviec_tim(a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

            xlWorkBook.SaveAs("csharp.net-phancongcongviec.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            //  releaseObject(xlWorkSheet);
            //   releaseObject(xlWorkBook);
            //   releaseObject(xlApp);

            MessageBox.Show("Excel file created , bạn có muốn xuất file file c:\\csharp.net-phancongcongviec.xls");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                Form_xemcongviec frm = new Form_xemcongviec(quyen, (int)this.dgv.SelectedRows[0].Cells["mada"].Value);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_xemcongviec frm = new Form_xemcongviec();
                frm.Show();
                this.Hide();
            }
        }

        private void field_thoihan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void field_tencv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
