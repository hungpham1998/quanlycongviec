using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class congviec_DAL:DBconnect
    {
        public DataTable Get_congviec()
        {
            using (SqlConnection conn = getConnect())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_select_congviec", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public int congviec_them(DOT_congviec cv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_congviec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mada", cv.mada));
                cmd.Parameters.Add(new SqlParameter("@tencv", cv.tencv));
                cmd.Parameters.Add(new SqlParameter("@thoihan", cv.thoihan));
                cmd.Parameters.Add(new SqlParameter("@noidung", cv.noidung));
                cmd.Parameters.Add(new SqlParameter("@ngaybd", cv.ngaybd));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public bool congviec_sua(DOT_congviec cv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_update_congviec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@macv", cv.macv));
                cmd.Parameters.Add(new SqlParameter("@mada", cv.mada));
                cmd.Parameters.Add(new SqlParameter("@tencv", cv.tencv));
                cmd.Parameters.Add(new SqlParameter("@thoihan", cv.thoihan));
                cmd.Parameters.Add(new SqlParameter("@noidung", cv.noidung));
                cmd.Parameters.Add(new SqlParameter("@ngaybd", cv.ngaybd));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool congviec_xoa(DOT_congviec cv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_congviec", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@macv", cv.macv));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public DataTable congviec_tim(DOT_congviec cv)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("congviec_tim", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tencv", cv.tencv));
                cmd.Parameters.Add(new SqlParameter("@noidung", cv.noidung));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
