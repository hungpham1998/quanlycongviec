using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demonet
{
    public partial class menu : Form
    {
        private string a = "";
        public menu()
        {
            InitializeComponent();
        }
        public menu(string id):this()
        {
            chao.Text = id;
            a = id;
        }
        private void menu_Load(object sender, EventArgs e)
        {
            if (a == "admin")
            {
                chao.Visible = false;
            }
            else
                chao.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (a == "admin")
            {
                chao.Visible = false;
            }
            else
                chao.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(a == "admin")
            {               
                Form_NHANVIEN frm = new Form_NHANVIEN(chao.Text);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_NHANVIEN frm = new Form_NHANVIEN();
                frm.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a == "admin")
            {
                Form_DUAN frm = new Form_DUAN(chao.Text);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_DUAN frm = new Form_DUAN();
                frm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a == "admin")
            {
                Form_THANHVIEN frm = new Form_THANHVIEN(chao.Text);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_THANHVIEN frm = new Form_THANHVIEN();
                frm.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (a == "admin")
            {
                Form_CONGVIEC frm = new Form_CONGVIEC(chao.Text);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_CONGVIEC frm = new Form_CONGVIEC();
                frm.Show(this);
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a == "admin")
            {
                Form_DANHGIA frm = new Form_DANHGIA(chao.Text);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_DANHGIA frm = new Form_DANHGIA();
                frm.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == "admin")
            {
                Form_baocaotuan frm = new Form_baocaotuan(chao.Text);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_baocaotuan frm = new Form_baocaotuan();
                frm.Show();
                this.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (a == "admin")
            {
                Form_BAOCAOTONGHOP frm = new Form_BAOCAOTONGHOP(chao.Text);
                frm.Show(this);
                this.Hide();
            }
            else
            {
                Form_BAOCAOTONGHOP frm = new Form_BAOCAOTONGHOP();
                frm.Show();
                this.Hide();
            }
        }

       
    }
}
