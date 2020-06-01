using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DOT_nhanvien
    {
        public int manv { get; set; }
        public string tennv { get; set; }
        public string ngaysinh { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string chucvu { get; set; }
        public string taikhoan { get; set; }
        public string matkhau { get; set; }

        public DOT_nhanvien(int manv, string tennv, string ngaysinh, string diachi, string sdt, string chucvu, string taikhoan, string matkhau)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.chucvu = chucvu;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
        }

    }
}
