using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DOT_thanhvien
    {        
        public int matv { get; set; }
        public int manv { get; set; }
        public int mada { get; set; }
        public string chucvu { get; set; }
        public string congviec { get; set; }
        public DOT_thanhvien(int matv, int manv, int mada,string congviec, string chucvu)
        {
            this.matv = matv;
            this.manv = manv;
            this.mada = mada;
            this.congviec = congviec;
            this.chucvu = chucvu;
        }

    }
}
