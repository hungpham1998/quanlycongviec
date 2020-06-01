using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class baocaotuan_DAL:DBconnect
    {
        public DataTable Get_baocaotuan()
        {
            using (SqlConnection conn = getConnect())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_select_baocaotuan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public int baocaotuan_them(DOT_baocaotuan bc)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_baocaotuan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manv", bc.manv));
                cmd.Parameters.Add(new SqlParameter("@macv", bc.macv));
                cmd.Parameters.Add(new SqlParameter("@ghichu",bc.ghichu));
                cmd.Parameters.Add(new SqlParameter("@ngay", bc.ngay));
                cmd.Parameters.Add(new SqlParameter("@tiendo", bc.tiendo));
                cmd.Parameters.Add(new SqlParameter("@dexuat", bc.dexuat));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public bool baocaotuan_sua(DOT_baocaotuan bc)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_update_baocaotuan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mabcn", bc.mabcn));
                cmd.Parameters.Add(new SqlParameter("@manv", bc.manv));
                cmd.Parameters.Add(new SqlParameter("@macv", bc.macv));
                cmd.Parameters.Add(new SqlParameter("@ghichu", bc.ghichu));
                cmd.Parameters.Add(new SqlParameter("@ngay", bc.ngay));
                cmd.Parameters.Add(new SqlParameter("@tiendo", bc.tiendo));
                cmd.Parameters.Add(new SqlParameter("@dexuat", bc.dexuat));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool baocaotuan_xoa(DOT_baocaotuan bc)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_baocaotuan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mabcn", bc.mabcn));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
    }
}
