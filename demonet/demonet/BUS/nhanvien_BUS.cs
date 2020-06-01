using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class nhanvien_BUS
    {
        nhanvien_DAL ma = new nhanvien_DAL();
        public DataTable Get_nhanvien()
        {
            return ma.Get_nhanvien();
        }
        public int nhanvien_them(DOT_nhanvien nv)
        {
            return ma.nhanvien_them(nv);

        }
        public bool nhanvien_sua(DOT_nhanvien nhanvien)
        {
            return ma.nhanvien_sua(nhanvien);
        }
        public bool nhanvien_xoa(DOT_nhanvien nhanvien)
        {
            return ma.nhanvien_xoa(nhanvien);
        }
        public DataTable nhanvien_tim(DOT_nhanvien nhanvien)
        {
            return ma.nhanvien_tim(nhanvien);
        }
    }
}
