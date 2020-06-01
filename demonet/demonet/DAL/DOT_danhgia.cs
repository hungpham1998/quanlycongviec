using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DOT_danhgia
    {
        public int madg { get; set; }
        public int manv { get; set; }
        public int manhiemv { get; set; }
        public string tiendo { get; set; }
        public DOT_danhgia(int madg, int manv, int manhiemv, string tiendo)
        {
            this.madg = madg;
            this.manv = manv;
            this.manhiemv = manhiemv;
            this.tiendo = tiendo;
        }
    }
}
