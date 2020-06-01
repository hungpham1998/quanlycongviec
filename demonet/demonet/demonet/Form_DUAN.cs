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
    public partial class Form_DUAN : Form
    {
        duan_BUS da = new duan_BUS();
        public Form_DUAN()
        {
            InitializeComponent();
        }
        private string quyen = "";
        public string id = "";
        public Form_DUAN(string id):this()
        {
            quyen = id;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if ( field_tenda.Text !="" && field_noidung.Text != ""  && field_thoihan.Text != " ")
            {
                DOT_duan m = new DOT_duan(0,field_tenda.Text, field_noidung.Text, field_ngaybd.Text, field_thoihan.Text, field_hoanthanh.Text);
                Convert.ToString(da.duan_them(m));
                MessageBox.Show("Thêm thành công");
                dgv.DataSource = da.Get_duan();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (field_tenda.Text != "" && field_noidung.Text != "" && field_ngaybd.Text != " " && field_thoihan.Text != " ")
            {
                DOT_duan m = new DOT_duan(Convert.ToInt32(field_id.Text), field_tenda.Text, field_noidung.Text, field_ngaybd.Text, field_thoihan.Text, field_hoanthanh.Text);
                da.duan_sua(m);
                MessageBox.Show("Sửa thành công");
                dgv.DataSource = da.Get_duan();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DOT_duan m = new DOT_duan(Convert.ToInt32(field_id.Text), field_tenda.Text, field_noidung.Text, field_ngaybd.Text, field_thoihan.Text, field_hoanthanh.Text);
            da.duan_xoa(m);
            MessageBox.Show("xóa thành công nhân viên ");
            dgv.DataSource = da.Get_duan();
        }

        private void chon_Click(object sender, EventArgs e)
        {
           id=field_id.Text;
            Owner.Show();
            this.Hide();
        }

        private void Form_DUAN_Load(object sender, EventArgs e)
        {
            if(quyen == "admin")
            {
                buttonUpdate.Visible = true;
                buttonInsert.Visible = true;
                buttonDelete.Visible = true;
            }
            else
            {
                buttonUpdate.Visible = false;
                buttonInsert.Visible = false;
                buttonDelete.Visible = false;
            }
            dgv.DataSource = da.Get_duan();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) return;
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            field_id.Text = row.Cells[0].Value.ToString();
            field_tenda.Text = row.Cells[1].Value.ToString();
            field_noidung.Text = row.Cells[2].Value.ToString();
            field_ngaybd.Text = row.Cells[3].Value.ToString();
            field_thoihan.Text = row.Cells[4].Value.ToString();
            field_hoanthanh.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_CONGVIEC frm = new Form_CONGVIEC(field_id.Text);            
            frm.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txttim.Text != "")
            {
                DOT_duan a = new DOT_duan(0, txttim.Text, txttim.Text, null, null,null);
                dgv.DataSource = da.duan_tim(a);
            }
        }

        private void field_ngaybd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

            xlWorkBook.SaveAs("csharp.net-duan.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            //  releaseObject(xlWorkSheet);
            //   releaseObject(xlWorkBook);
            //   releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\csharp.net-duan.xls");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                Form_xemduan frm = new Form_xemduan(quyen, (int)this.dgv.SelectedRows[0].Cells["mada"].Value);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_xemduan frm = new Form_xemduan();
                frm.Show();
                this.Hide();
            }
        }
    }
}
