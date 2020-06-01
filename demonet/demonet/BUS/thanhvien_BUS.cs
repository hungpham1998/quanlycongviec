using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public class thanhvien_BUS
    {
        thanhvien_DAL ma = new thanhvien_DAL();
        public DataTable Get_thanhvien()
        {
            return ma.Get_thanhvien();
        }
        public int thanhvien_them(DOT_thanhvien nv)
        {
            return ma.thanhvien_them(nv);

        }
        public bool thanhvien_sua(DOT_thanhvien thanhvien)
        {
            return ma.thanhvien_sua(thanhvien);
        }
        public bool thanhvien_xoa(DOT_thanhvien thanhvien)
        {
            return ma.thanhvien_xoa(thanhvien);
        }
        public DataTable thanhvien_tim(DOT_thanhvien thanhvien)
        {
            return ma.thanhvien_tim(thanhvien);
        }
    }
}
