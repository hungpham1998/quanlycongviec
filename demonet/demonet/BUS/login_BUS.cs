using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public class login_BUS
    {
        login_DAL dn = new login_DAL();
        public bool dangnhap(String taikhoan, String matkhau)
        {
            return dn.dangnhap(taikhoan, matkhau);
        }
    }
}
