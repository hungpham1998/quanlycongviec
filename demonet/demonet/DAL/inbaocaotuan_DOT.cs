using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class inbaocaotuan_DOT
    {
        public inbaocaotuan_DOT(string tennv, DateTime ngay, string tencv, string tiendo, string ghichu, string dexuat, string noidung, DateTime ngaybd, DateTime thoihan)
        {
            this.tennv = tennv;
            this.ngay = ngay;
            this.tencv = tencv;
            this.tiendo = tiendo;
            this.ghichu = ghichu;
            this.dexuat = dexuat;
            this.noidung = noidung;
            this.ngaybd = ngaybd;
            this.thoihan = thoihan;
        }

        public string tennv { get; set; }
        public DateTime ngay { get; set; }
        public string tencv { get; set; }
        public string tiendo { get; set; }
        public string ghichu { get; set; }
        public string dexuat { get; set; }
        public string noidung { get; set; }
        public DateTime ngaybd { get; set; }
        public DateTime thoihan { get; set; }
    }
}
