using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DOT_congviec
    {

        public int macv { get; set; }
        public int mada { get; set; }
        public string noidung { get; set; }
        public string thoihan { get; set; }
        public string ngaybd { get; set; }
        public string tencv { get; set; }

        public DOT_congviec(int macv, int mada,string tencv, string noidung, string thoihan, string ngaybd)
        {
            this.macv = macv;
            this.mada = mada;
            this.tencv = tencv;
            this.noidung = noidung;
            this.thoihan = thoihan;
            this.ngaybd = ngaybd;
        }
    }
}
