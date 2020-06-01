using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
namespace demonet
{
    public partial class Form_THANHVIEN : Form
    {
        private string quyen = "";
        thanhvien_BUS tv = new thanhvien_BUS();
        nhanvien_BUS nv = new nhanvien_BUS();
        duan_BUS da = new duan_BUS();
        public Form_THANHVIEN()
        {
            InitializeComponent();
        }
        public Form_THANHVIEN(string mada) : this()
        {
            quyen = mada;
        }
        private void label_hoten_Click(object sender, EventArgs e)
        {

        }

        private void Form_THANHVIEN_Load(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                buttonUpdate.Visible = true;
                buttonInsert.Visible = true;
                buttonDelete.Visible = true;
                View1.Visible = false;
                View2.Visible = false;
            }
            else
            {
                buttonUpdate.Visible = false;
                buttonInsert.Visible = false;
                buttonDelete.Visible = false;
                View1.Visible = false;
                View2.Visible = false;
            }
            dgv.DataSource = tv.Get_thanhvien();
            View1.DataSource = nv.Get_nhanvien();
            View2.DataSource = da.Get_duan();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) return;
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            field_id.Text = row.Cells[0].Value.ToString();
            field_manv.Text = row.Cells[1].Value.ToString();
            field_macv.Text = row.Cells[2].Value.ToString();
            field_chucvu.Text = row.Cells[3].Value.ToString();
            field_congviec.Text = row.Cells[4].Value.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(quyen =="admin")
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
            if (field_chucvu.Text != " " && field_congviec.Text != "")
            {
                DOT_thanhvien m = new DOT_thanhvien(0, Convert.ToInt32(field_manv.Text), Convert.ToInt32(field_macv.Text), field_congviec.Text, field_chucvu.Text);
                Convert.ToString(tv.thanhvien_them(m));
                MessageBox.Show("Thêm thành công");
                dgv.DataSource = tv.Get_thanhvien();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View1.Visible = true;
            txttim.Visible = false;
            tim.Visible = false;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View2.Visible = true;
            txttim.Visible = false;
            tim.Visible = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (field_chucvu.Text != " " && field_congviec.Text != "")
            {
                DOT_thanhvien m = new DOT_thanhvien(Convert.ToInt32(field_id), Convert.ToInt32(field_manv), Convert.ToInt32(field_macv), field_congviec.Text, field_chucvu.Text);
                tv.thanhvien_sua(m);
                MessageBox.Show("sửa thành công");
                dgv.DataSource = tv.Get_thanhvien();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DOT_thanhvien m = new DOT_thanhvien(Convert.ToInt32(field_id), Convert.ToInt32(field_manv), Convert.ToInt32(field_macv), field_congviec.Text, field_chucvu.Text);
            tv.thanhvien_xoa(m);
            MessageBox.Show("xóa thành công nhân viên ");
            dgv.DataSource = tv.Get_thanhvien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_BAOCAOTONGHOP frm = new Form_BAOCAOTONGHOP(field_id.Text);
            frm.Show();
            this.Hide();
        }

        private void View1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (View1.SelectedCells.Count == 0) return;
            DataGridViewRow row = View1.SelectedCells[0].OwningRow;
            field_manv.Text = row.Cells[0].Value.ToString();
            View1.Visible = false;
            txttim.Visible = true;
            tim.Visible = true;
        }

        private void View2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (View2.SelectedCells.Count == 0) return;
            DataGridViewRow row = View2.SelectedCells[0].OwningRow;
            field_macv.Text = row.Cells[0].Value.ToString();
            View2.Visible = false;
            txttim.Visible = true;
            tim.Visible = true;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            if (txttim.Text != "")
            {
                DOT_thanhvien a = new DOT_thanhvien(0, 0,0,txttim.Text, txttim.Text);
                dgv.DataSource = tv.thanhvien_tim(a);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                Form_xemduan frm = new Form_xemduan(quyen, (int)this.dgv.SelectedRows[0].Cells["matv"].Value);
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
