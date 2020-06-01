using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
  public  class danhgia_BUS
    {
        danhgia_DAL ma = new danhgia_DAL();
        public DataTable Get_danhgia()
        {
            return ma.Get_danhgia();
        }
        public int danhgia_them(DOT_danhgia nv)
        {
            return ma.danhgia_them(nv);

        }
        public bool danhgia_sua(DOT_danhgia danhgia)
        {
            return ma.danhgia_sua(danhgia);
        }
        public bool danhgia_xoa(DOT_danhgia danhgia)
        {
            return ma.danhgia_xoa(danhgia);
        }
       
    }
}
