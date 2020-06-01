using DAL;
using Microsoft.Reporting.WinForms;
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
    public partial class Form_inbaocaotonghop : Form
    {
        private int Id { get; }
        private string quyen = "";
        public Form_inbaocaotonghop()
        {
            InitializeComponent();          
        }
        public Form_inbaocaotonghop(string a, int b)
        {
            InitializeComponent();
            quyen = a;
            Id = b;
        }

        private void Form_inbaocaotonghop_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = "inbaocaotonghop.rdlc";

            ReportDataSource ds = new ReportDataSource();
            inbaocaotonghop_DAL d = new inbaocaotonghop_DAL();
            ds.Name = "inbaocaotonghop";
            ds.Value = d.Get_baocaotonghop(Id);
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.RefreshReport();
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
