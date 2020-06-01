using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public class baocaotuan_BUS
    {
        baocaotuan_DAL ma = new baocaotuan_DAL();
        public DataTable Get_baocaotuan()
        {
            return ma.Get_baocaotuan();
        }
        public int baocaotuan_them(DOT_baocaotuan nv)
        {
            return ma.baocaotuan_them(nv);

        }
        public bool baocaotuan_sua(DOT_baocaotuan baocaotuan)
        {
            return ma.baocaotuan_sua(baocaotuan);
        }
        public bool baocaotuan_xoa(DOT_baocaotuan baocaotuan)
        {
            return ma.baocaotuan_xoa(baocaotuan);
        }
        
    }
}
