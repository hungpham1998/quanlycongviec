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
    public partial class Form_NHANVIEN : Form
    {
        nhanvien_BUS nv = new nhanvien_BUS();
        public Form_NHANVIEN()
        {
            InitializeComponent();
        }
        private string quyen="";
        public  Form_NHANVIEN(string id):this()
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

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) return;
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            field_id.Text = row.Cells[0].Value.ToString();
            field_hoten.Text = row.Cells[1].Value.ToString();
            field_ngaysinh.Text = row.Cells[2].Value.ToString();
            field_diachi.Text = row.Cells[3].Value.ToString();
            field_sdt.Text = row.Cells[4].Value.ToString();
            field_chucvu.Text = row.Cells[5].Value.ToString();
            field_taikhoan.Text = row.Cells[6].Value.ToString();
            field_matkhau.Text = row.Cells[7].Value.ToString();
        }

        private void Form_NHANVIEN_Load(object sender, EventArgs e)
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
            dgv.DataSource = nv.Get_nhanvien();
           
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            if (field_hoten.Text != "" && field_ngaysinh.Text != " " && field_diachi.Text != " " && field_chucvu.Text != " ")
            {
                DOT_nhanvien m = new DOT_nhanvien(0, field_hoten.Text, field_ngaysinh.Text, field_diachi.Text,field_sdt.Text, field_chucvu.Text, field_taikhoan.Text, field_matkhau.Text);
                Convert.ToString(nv.nhanvien_them(m));
                MessageBox.Show("Thêm thành công");
                dgv.DataSource = nv.Get_nhanvien();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (field_hoten.Text != "" && field_ngaysinh.Text != " " && field_diachi.Text != " " && field_chucvu.Text != " ")
            {
                DOT_nhanvien m = new DOT_nhanvien(Convert.ToInt32(field_id.Text), field_hoten.Text, field_ngaysinh.Text, field_diachi.Text, field_sdt.Text, field_chucvu.Text, field_taikhoan.Text, field_matkhau.Text);
                nv.nhanvien_sua(m);
                MessageBox.Show(" Sửa thành công");
                dgv.DataSource = nv.Get_nhanvien();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (field_hoten.Text != " ")
            {
                DOT_nhanvien m = new DOT_nhanvien(Convert.ToInt32(field_id.Text), field_hoten.Text, field_ngaysinh.Text, field_diachi.Text,field_sdt.Text, field_chucvu.Text, field_taikhoan.Text, field_matkhau.Text);
                nv.nhanvien_xoa(m);
                MessageBox.Show("xóa thành công nhân viên ");
                dgv.DataSource = nv.Get_nhanvien();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {       
            Form_CONGVIEC frm = new Form_CONGVIEC(field_id.Text);        
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_DANHGIA frm = new Form_DANHGIA(field_id.Text);
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txttim.Text != "")
            {
                DOT_nhanvien a = new DOT_nhanvien(0, txttim.Text, null,null, null,txttim.Text, null, null);
                dgv.DataSource = nv.nhanvien_tim(a);
            }
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
            for(i=1; i<= dgv.ColumnCount;i++)
            {
                xlWorkSheet.Cells[1, i] = dgv.Columns[i-1].HeaderText;
            }
            for (i = 0; i < dgv.RowCount; i++)
            {
                for (j = 0; j < dgv.ColumnCount; j++)
                {
                    DataGridViewCell cell = dgv[j,i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("csharp.net-thongtinnhansu.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

          //  releaseObject(xlWorkSheet);
         //   releaseObject(xlWorkBook);
         //   releaseObject(xlApp);

            MessageBox.Show("Excel file created , bạn lưu file tại c:\\csharp.net-thongtinnhansu.xls");
        }
    }
}
