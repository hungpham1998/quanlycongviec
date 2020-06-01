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
    public partial class Form_BAOCAOTONGHOP : Form
    {
        private string quyen = "";
        baocaotonghop_BUS bc = new baocaotonghop_BUS();
        duan_BUS da = new duan_BUS();
        thanhvien_BUS tv = new thanhvien_BUS();
        public Form_BAOCAOTONGHOP()
        {
            InitializeComponent();
        }
        public Form_BAOCAOTONGHOP(string matv):this()
        {
            quyen = matv;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            View2.Visible = true;
        }

        private void Form_BAOCAOTONGHOP_Load(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                buttonUpdate.Visible = true;
                buttonInsert.Visible = true;
                buttonDelete.Visible = true;               
                view1.Visible = false;
                View2.Visible = false;
            }
            else
            {
                buttonUpdate.Visible = false;
                buttonInsert.Visible = false;
                buttonDelete.Visible = false;
                view1.Visible = false;
                View2.Visible = false;
            }
            dgv.DataSource = bc.Get_baocaotonghop();
            view1.DataSource = da.Get_duan();
            View2.DataSource = tv.Get_thanhvien();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (field_tondong.Text != ""  && field_dexuat.Text != " ")
            {
                DOT_baocaotonghop m = new DOT_baocaotonghop(0, Convert.ToInt32(field_mada.Text), Convert.ToInt32(field_manv.Text), field_tondong.Text, field_ngaybd.Text, field_dexuat.Text);
                Convert.ToString(bc.baocaotonghop_them(m));
                MessageBox.Show("Thêm thành công");
                dgv.DataSource = bc.Get_baocaotonghop();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (field_tondong.Text != "" && field_dexuat.Text != " ")
            {
                DOT_baocaotonghop m = new DOT_baocaotonghop(Convert.ToInt32(field_id.Text),Convert.ToInt32(field_mada.Text), Convert.ToInt32(field_manv.Text), field_tondong.Text, field_ngaybd.Text, field_dexuat.Text);
                bc.baocaotonghop_sua(m);
                MessageBox.Show("Sửa thành công");
                dgv.DataSource = bc.Get_baocaotonghop();
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            view1.Visible = true;

        }

        private void view1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (view1.SelectedCells.Count == 0) return;
            DataGridViewRow row = view1.SelectedCells[0].OwningRow;
            field_mada.Text = row.Cells[0].Value.ToString();
            view1.Visible = false;
           
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedCells.Count == 0) return;
            DataGridViewRow row = dgv.SelectedCells[0].OwningRow;
            field_id.Text = row.Cells[0].Value.ToString();
            field_mada.Text = row.Cells[1].Value.ToString();
            field_manv.Text = row.Cells[2].Value.ToString();
            field_tondong.Text = row.Cells[3].Value.ToString();
            field_ngaybd.Text = row.Cells[4].Value.ToString();                
            field_dexuat.Text = row.Cells[5].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DOT_baocaotonghop m = new DOT_baocaotonghop(Convert.ToInt32(field_id.Text), Convert.ToInt32(field_mada.Text), Convert.ToInt32(field_manv.Text), field_tondong.Text, field_ngaybd.Text, field_dexuat.Text);
            bc.baocaotonghop_xoa(m);
            MessageBox.Show("xóa thành công");
            dgv.DataSource = bc.Get_baocaotonghop();
        }

        private void View2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (View2.SelectedCells.Count == 0) return;
            DataGridViewRow row = View2.SelectedCells[0].OwningRow;
            field_manv.Text = row.Cells[0].Value.ToString();
            View2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                Form_inbaocaotonghop frm = new Form_inbaocaotonghop(quyen, (int)this.dgv.SelectedRows[0].Cells["mabcth"].Value);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_inbaocaotonghop frm = new Form_inbaocaotonghop();
                frm.Show();
                this.Hide();
            }
        }
    
    }
}
