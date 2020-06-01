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
    public partial class Form_DANHGIA : Form
    {
        private string quyen = "";
        congviec_BUS cv = new congviec_BUS();
        danhgia_BUS dg = new danhgia_BUS();
        nhanvien_BUS nv = new nhanvien_BUS();
        public Form_DANHGIA()
        {
            InitializeComponent();
        }
        public Form_DANHGIA(string manv) : this()
        {
            field_manv.Text= manv;
            quyen = manv;
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

        private void button1_Click(object sender, EventArgs e)
        {
            View2.Visible = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View1.Visible = true;
           
        }

        private void Form_DANHGIA_Load(object sender, EventArgs e)
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
            View1.DataSource = cv.Get_congviec();
            View2.DataSource = nv.Get_nhanvien();
            dgv.DataSource = dg.Get_danhgia();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (  field_tiendo.Text != " ")
            {
                DOT_danhgia m = new DOT_danhgia(0, Convert.ToInt32(field_manv.Text), Convert.ToInt32(field_macv.Text), field_tiendo.Text);
                Convert.ToString(dg.danhgia_them(m));
                MessageBox.Show("Thêm thành công");
                dgv.DataSource = dg.Get_danhgia();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (field_tiendo.Text != " ")
            {
                DOT_danhgia m = new DOT_danhgia(Convert.ToInt32(field_id.Text), Convert.ToInt32(field_manv.Text), Convert.ToInt32(field_macv.Text), field_tiendo.Text);
                dg.danhgia_sua(m);
                MessageBox.Show("sửa thành công");
                dgv.DataSource = dg.Get_danhgia();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DOT_danhgia m = new DOT_danhgia(Convert.ToInt32(field_id.Text),Convert.ToInt32(field_manv.Text),Convert.ToInt32(field_macv.Text), field_tiendo.Text);
            dg.danhgia_xoa(m);
            MessageBox.Show("xóa thành công nhân viên ");
            dgv.DataSource = dg.Get_danhgia();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) return;
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            field_id.Text = row.Cells[0].Value.ToString();
            field_manv.Text = row.Cells[1].Value.ToString();
            field_macv.Text = row.Cells[2].Value.ToString();
            field_tiendo.Text = row.Cells[3].Value.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (View1.SelectedCells.Count == 0) return;
            DataGridViewRow row = View1.SelectedCells[0].OwningRow;
            field_macv.Text = row.Cells[0].Value.ToString();
            View1.Visible = false;
           

        }

        private void View2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (View2.SelectedCells.Count == 0) return;
            DataGridViewRow row = View2.SelectedCells[0].OwningRow;
            field_manv.Text = row.Cells[0].Value.ToString();
            View2.Visible = false;
            
        }

      
    }
}
