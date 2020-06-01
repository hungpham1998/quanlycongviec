using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class inbaocaotonghop_DOT
    {
        public inbaocaotonghop_DOT(string tennv, string chucvu, string tenda, string congviec, string tondong, string dexuat, DateTime ngayhoanthanh, DateTime ngaybd, DateTime thoihan)
        {
            this.tennv = tennv;
            this.chucvu = chucvu;
            this.tenda = tenda;
            this.congviec = congviec;
            this.tondong = tondong;
            this.dexuat = dexuat;
            this.ngayhoanthanh = ngayhoanthanh;
            this.ngaybd = ngaybd;
            this.thoihan = thoihan;
        }

        public string tennv { get; set; }
        public string chucvu { get; set; }
        public string tenda { get; set; }
        public string congviec { get; set; }
        public string tondong { get; set; }
        public string dexuat { get; set; }
        public DateTime ngayhoanthanh { get; set; }
        public DateTime ngaybd { get; set; }
        public DateTime thoihan { get; set; }
    }
}
