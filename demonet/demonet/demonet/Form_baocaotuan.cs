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
    
    public partial class Form_baocaotuan : Form
    {
        baocaotuan_BUS bct = new baocaotuan_BUS();
        nhanvien_BUS nv = new nhanvien_BUS();
        congviec_BUS cv = new congviec_BUS();

        public Form_baocaotuan()
        {
            InitializeComponent();
        }
        private string quyen = " ";
        public Form_baocaotuan(string id):this()
        {
            quyen = id;
        }
        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) return;
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            field_id.Text = row.Cells[0].Value.ToString();
            field_macv.Text = row.Cells[1].Value.ToString();
            field_manv.Text = row.Cells[2].Value.ToString();
            field_ngaybd.Text = row.Cells[3].Value.ToString();
            field_tiendo.Text = row.Cells[4].Value.ToString();
            field_ghichu.Text = row.Cells[5].Value.ToString();
            field_dexuat.Text = row.Cells[6].Value.ToString();
        }

        private void Form_baocaotuan_Load(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                buttonUpdate.Visible = true;
                buttonInsert.Visible = true;
                buttonDelete.Visible = true;
                view2.Visible = false;
                view1.Visible = false;
            }
            else
            {
                buttonUpdate.Visible = false;
                buttonInsert.Visible = false;
                buttonDelete.Visible = false;
                view2.Visible = false;
                view1.Visible = false;
            }
            view1.DataSource = nv.Get_nhanvien();
            view2.DataSource = cv.Get_congviec();
            dgv.DataSource = bct.Get_baocaotuan();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (field_tiendo.Text != "" && field_ghichu.Text != " " && field_dexuat.Text != " ")
            {
                DOT_baocaotuan m = new DOT_baocaotuan(0, Convert.ToInt32(field_macv.Text), Convert.ToInt32(field_manv.Text), field_ngaybd.Text, field_tiendo.Text, field_ghichu.Text, field_dexuat.Text);
                Convert.ToString(bct.baocaotuan_them(m));
                MessageBox.Show("Thêm thành công");
                dgv.DataSource = bct.Get_baocaotuan();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            if (field_tiendo.Text != "" && field_ghichu.Text != " " && field_dexuat.Text != " ")
            {
                DOT_baocaotuan m = new DOT_baocaotuan(Convert.ToInt32(field_id.Text), Convert.ToInt32(field_macv.Text), Convert.ToInt32(field_manv.Text), field_ngaybd.Text, field_tiendo.Text, field_ghichu.Text, field_dexuat.Text);
                bct.baocaotuan_sua(m);
                MessageBox.Show("sửa thành công");
                dgv.DataSource = bct.Get_baocaotuan();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view1.Visible = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            view2.Visible = true;  
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DOT_baocaotuan m = new DOT_baocaotuan(Convert.ToInt32(field_id.Text), Convert.ToInt32(field_macv.Text), Convert.ToInt32(field_manv.Text), field_ngaybd.Text, field_tiendo.Text, field_ghichu.Text, field_dexuat.Text);
            bct.baocaotuan_xoa(m);
            MessageBox.Show("xóa thành công nhân viên ");
            dgv.DataSource = bct.Get_baocaotuan();
        }

        private void view1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (view1.SelectedCells.Count == 0) return;
            DataGridViewRow row = view1.SelectedCells[0].OwningRow;
            field_manv.Text = row.Cells[0].Value.ToString();
            view1.Visible = false;
        }

        private void view2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (view2.SelectedCells.Count == 0) return;
            DataGridViewRow row = view2.SelectedCells[0].OwningRow;
            field_macv.Text = row.Cells[0].Value.ToString();
            view2.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                Form_inbaocaotuan frm = new Form_inbaocaotuan(quyen, (int)this.dgv.SelectedRows[0].Cells["mabcn"].Value);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_inbaocaotuan frm = new Form_inbaocaotuan();
                frm.Show();
                this.Hide();
            }
        }
    }
}
