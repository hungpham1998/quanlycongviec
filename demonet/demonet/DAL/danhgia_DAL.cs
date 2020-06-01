using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class danhgia_DAL:DBconnect
    {
        public DataTable Get_danhgia()
        {
            using (SqlConnection conn = getConnect())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_select_danhgia", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }

        public int danhgia_them(DOT_danhgia dg)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_insert_danhgia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@manhiemv", dg.manhiemv));
                cmd.Parameters.Add(new SqlParameter("@manv", dg.manv));
                cmd.Parameters.Add(new SqlParameter("@tiendo", dg.tiendo));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

        }
        public bool danhgia_sua(DOT_danhgia dg)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_update_danhgia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@madg", dg.madg));
                cmd.Parameters.Add(new SqlParameter("@manhiemv", dg.manhiemv));
                cmd.Parameters.Add(new SqlParameter("@manv", dg.manv));
                cmd.Parameters.Add(new SqlParameter("@tiendo", dg.tiendo));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        public bool danhgia_xoa(DOT_danhgia da)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("sp_delete_danhgia", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@madg", da.madg));
                cmd.ExecuteNonQuery();
            }
            return true;
        }
        /*public DataTable duan_tim(DOT_duan dan)
        {
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("duan_tendu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tenda", dan.tenda));
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }*/
    }
}
