using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class thanhvien_DAL:DBconnect
    {
        public DataTable Get_thanhvien()
        {
            using (SqlConnection conn = getConnect())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_select_thanhvien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public int thanhvien_them(DOT_thanhvien tv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_thanhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manv", tv.manv));
                cmd.Parameters.Add(new SqlParameter("@mada", tv.mada));
                cmd.Parameters.Add(new SqlParameter("@chucvu", tv.chucvu));
                cmd.Parameters.Add(new SqlParameter("@congviec", tv.congviec));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public bool thanhvien_sua(DOT_thanhvien tv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_update_thanhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@matv", tv.matv));
                cmd.Parameters.Add(new SqlParameter("@manv", tv.manv));
                cmd.Parameters.Add(new SqlParameter("@mada", tv.mada));
                cmd.Parameters.Add(new SqlParameter("@chucvu", tv.chucvu));
                cmd.Parameters.Add(new SqlParameter("@congviec", tv.congviec));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool thanhvien_xoa(DOT_thanhvien tv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_thanhvien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@matv", tv.matv));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public DataTable thanhvien_tim(DOT_thanhvien nv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("thanhvien_tim", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@congviec", nv.congviec));
                cmd.Parameters.Add(new SqlParameter("@chucvu", nv.chucvu));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
