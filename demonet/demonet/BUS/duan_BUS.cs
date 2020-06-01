using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public class duan_BUS
    {
        duan_DAL ma = new duan_DAL();
        public DataTable Get_duan()
        {
            return ma.Get_duan();
        }
        public int duan_them(DOT_duan nv)
        {
            return ma.duan_them(nv);

        }
        public bool duan_sua(DOT_duan duan)
        {
            return ma.duan_sua(duan);
        }
        public bool duan_xoa(DOT_duan duan)
        {
            return ma.duan_xoa(duan);
        }
        public DataTable duan_tim(DOT_duan duan)
        {
            return ma.duan_tim(duan);
        }
    }
}
