using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class baocaotonghop_BUS
    {
        baocaotonghop_DAL ma = new baocaotonghop_DAL();
        public DataTable Get_baocaotonghop()
        {
            return ma.Get_baocaotonghop();
        }
        public int baocaotonghop_them(DOT_baocaotonghop nv)
        {
            return ma.baocaotonghop_them(nv);

        }
        public bool baocaotonghop_sua(DOT_baocaotonghop baocaotonghop)
        {
            return ma.baocaotonghop_sua(baocaotonghop);
        }
        public bool baocaotonghop_xoa(DOT_baocaotonghop baocaotonghop)
        {
            return ma.baocaotonghop_xoa(baocaotonghop);
        }
       
    }
}
