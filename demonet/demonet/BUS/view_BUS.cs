using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
   public class view_BUS
    {
        view_DAL ma = new view_DAL();
        public DataTable Get_viewduan(int id)
        {
            return ma.Get_viewduan(id);
        }
        public DataTable Get_viewcongviec(int id)
        {
            return ma.Get_viewcongviec(id);
        }
        public DataTable Get_viewthanhvien(int id)
        {
            return ma.Get_viewthanhvien(id);
        }
    }
}
