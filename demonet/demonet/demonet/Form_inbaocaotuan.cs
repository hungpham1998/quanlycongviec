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
using Microsoft.Reporting.WinForms;

namespace demonet
{
    public partial class Form_inbaocaotuan : Form
    {
        private string quyen;
        private int Id { get; }
        public Form_inbaocaotuan(string qu,int id)
        {
            InitializeComponent();
            Id = id;
            quyen = qu;
        }
        public Form_inbaocaotuan()
        {
            InitializeComponent();         
        }

        private void Form_inbaocaotuan_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = "inbaocaotuan.rdlc";
            
            ReportDataSource ds = new ReportDataSource();
            inbaocaotuan_DAL d = new inbaocaotuan_DAL();
            ds.Name = "inbaocaotuan";
            ds.Value = d.Get_baocaotuan(Id);
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CANCEL_Click(object sender, EventArgs e)
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
    }
}
