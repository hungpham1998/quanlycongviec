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
    public partial class Form1 : Form
    {
        public string id="";
        login_BUS dn = new login_BUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtuser.Text != " " && txtpass.Text != " ")
            {
                string tk = txtuser.Text;
                string mk = txtpass.Text;
                bool kt = dn.dangnhap(tk, mk);
                if (kt == false)
                {
                    MessageBox.Show("dang nhap khong thanh cong!");
                }
                else
                {
                    MessageBox.Show("dang nhap thanh cong");
                    menu na = new menu(txtuser.Text);
                    na.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
