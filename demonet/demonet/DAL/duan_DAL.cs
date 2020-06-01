using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class duan_DAL:DBconnect
    {
        public DataTable Get_duan()
        {
            using (SqlConnection conn = getConnect())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_select_duan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public int duan_them(DOT_duan da)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_duan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenda", da.tenda));
                cmd.Parameters.Add(new SqlParameter("@ngaybd", da.ngaybd));
                cmd.Parameters.Add(new SqlParameter("@noidung", da.noidung));
                cmd.Parameters.Add(new SqlParameter("@thoihan",da.thoihan));
                cmd.Parameters.Add(new SqlParameter("@hoanthanh", da.hoanthanh));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public bool duan_sua(DOT_duan da)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_update_duan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mada", da.mada));
                cmd.Parameters.Add(new SqlParameter("@tenda", da.tenda));
                cmd.Parameters.Add(new SqlParameter("@ngaybd", da.ngaybd));
                cmd.Parameters.Add(new SqlParameter("@noidung", da.noidung));
                cmd.Parameters.Add(new SqlParameter("@thoihan", da.thoihan));
                cmd.Parameters.Add(new SqlParameter("@hoanthanh", da.hoanthanh));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool duan_xoa(DOT_duan da)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_duan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@mada", da.mada));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public DataTable duan_tim(DOT_duan dan)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("duan_tim", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenda", dan.tenda));
                cmd.Parameters.Add(new SqlParameter("@noidung", dan.noidung));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
