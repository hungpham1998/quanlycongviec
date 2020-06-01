using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DOT_duan
    {
        public int mada { get; set; }
        public string tenda { get; set; }
        public string noidung { get; set; }
        public string ngaybd { get; set; }
        public string thoihan { get; set; }
        public string hoanthanh { get; set; }
        public DOT_duan(int mada, string tenda, string noidung, string ngaybd, string thoihan, string hoanthanh)
        {
            this.mada = mada;
            this.tenda = tenda;
            this.noidung = noidung;
            this.ngaybd = ngaybd;
            this.thoihan = thoihan;
            this.hoanthanh = hoanthanh;
        }
    }
}
