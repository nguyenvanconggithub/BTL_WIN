using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataTinTimViec
    {
        SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=NguoiTimViec_ViecTimNguoi;Integrated Security=True");
            return conn;
        }
        public DataTable getTinDaDuyet()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TinTimViec WHERE DaDuyet='true'", getConnect());
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            da.Fill(dt);
            dv = dt.DefaultView;
            dv.Sort = "ThoiGianDuyet DESC"; // Xem Tin Moi Nhat Truoc
            dt = dv.ToTable();
            return dt;
        }
        public DataTable getTinChuaDuyet()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TinTimViec WHERE DaDuyet='false'", getConnect());
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            da.Fill(dt);
            dv = dt.DefaultView;
            dv.Sort = "ThoiGianDuyet ASC"; // Xem Tin Cu Nhat Truoc
            dt = dv.ToTable(); 
            return dt;
        }

        public DataTable getTinByMaTin(string maTin)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TinTimViec WHERE MaTin = '"+maTin.ToString()+"' AND DaDuyet='true'", getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable timKiem(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql,getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(SqlCommand command)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
