using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DOT_login
    {
        public string taikhoan { get; set; }
        public string matkhau { get; set; }
        public DOT_login(string taikhoan, string matkhau)
        {
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }
    }
}
