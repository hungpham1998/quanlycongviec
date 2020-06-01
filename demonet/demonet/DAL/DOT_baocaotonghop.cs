using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DOT_baocaotonghop
    {
        public int mabcth { get; set; }
        public int mada { get; set; }
        public int matv { get; set; }
        public string tondong { get; set; }
        public string ngayht { get; set; }
        public string dexuat { get; set; }

        public DOT_baocaotonghop(int mabcth, int mada, int matv, string tondong, string ngayht, string dexuat)
        {
            this.mabcth = mabcth;
            this.mada = mada;
            this.matv = matv;
            this.tondong = tondong;
            this.ngayht = ngayht;
            this.dexuat = dexuat;
        }
    }
}
