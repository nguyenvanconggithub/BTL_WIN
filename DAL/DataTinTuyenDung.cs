using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    
    public class DataTinTuyenDung
    {
        private static DataTinTuyenDung data;
        public static DataTinTuyenDung DaTa
        {
            get
            {
                if(data ==  null)
                {
                    data = new DataTinTuyenDung();
                }
                return data;
            }
                
        }
        public SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NguoiTimViec_ViecTimNguoi;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=NguoiTimViec_ViecTimNguoi;Integrated Security=True");
            return conn;
        }
        public DataTable getTable()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TinTuyenDung", getConnect());
            da.Fill(dt);
            return dt;
        }

        public DataTable getTinDaDuyet()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TinTuyenDung WHERE DaDuyet='true'", getConnect());
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TinTuyenDung WHERE DaDuyet='false'", getConnect());
            DataTable dt = new DataTable();
            DataView dv = new DataView();
            da.Fill(dt);
            dv = dt.DefaultView;
            dv.Sort = "ThoiGianDuyet ASC"; // Xem Tin Cu Nhat Truoc
            dt = dv.ToTable();
            return dt;
        }
        public bool ExecuteNonQuery(SqlCommand cmd)
        {
            SqlConnection conn = getConnect();
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            return true;
            /*
            try
            {
                
            }
            catch(Exception)
            {
                return false;
            }*/
            
        }
        public DataTable getTinByMaTin(string maTin)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TinTuyenDung where MaTin = '"+maTin+"' and DaDuyet = 'true'", getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable TimKiemTinTuyenDung(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
