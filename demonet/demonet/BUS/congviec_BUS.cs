using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
   public class congviec_BUS
    {
        congviec_DAL ma = new congviec_DAL();
        public DataTable Get_congviec()
        {
            return ma.Get_congviec();
        }
        public int congviec_them(DOT_congviec nv)
        {
            return ma.congviec_them(nv);

        }
        public bool congviec_sua(DOT_congviec congviec)
        {
            return ma.congviec_sua(congviec);
        }
        public bool congviec_xoa(DOT_congviec congviec)
        {
            return ma.congviec_xoa(congviec);
        }
        public DataTable congviec_tim(DOT_congviec congviec)
        {
            return ma.congviec_tim(congviec);
        }
    }
}
