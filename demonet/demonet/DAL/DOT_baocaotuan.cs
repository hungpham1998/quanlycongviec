using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DOT_baocaotuan
    {
        public int mabcn { get; set; }
        public int macv { get; set; }
        public int manv { get; set; }
        public string ngay { get; set; }
        public string tiendo { get; set; }
        public string ghichu { get; set; }
        public  string dexuat { get; set; }

        public DOT_baocaotuan(int mabcn, int macv, int manv, string ngay, string tiendo, string ghichu, string dexuat)
        {
            this.mabcn = mabcn;
            this.macv = macv;
            this.manv = manv;
            this.ngay = ngay;
            this.tiendo = tiendo;
            this.ghichu = ghichu;
            this.dexuat = dexuat;
        }
    }
}
