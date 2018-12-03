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
        private static DataTinTimViec instance;
        public static DataTinTimViec Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataTinTimViec();
                return instance;
            }
        }
        public SqlConnection getConnect()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=NguoiTimViec_ViecTimNguoi;Integrated Security=True");
                conn.Open();
                return conn;
            }
            catch(Exception)
            {
                return null;
            }
        }
        public DataTable getTinDaDuyet()
        {
            if(getConnect() != null)
            {

                try
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
                catch (Exception)
                {
                    return null;
                }
            }
            return null;

        }
        public DataTable getTinChuaDuyet()
        {

            if (getConnect() != null)
            {

                try
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
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        public DataTable getTinByMaTin(string maTin)
        {

            if (getConnect() != null)
            {

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TinTimViec WHERE MaTin = '" + maTin.ToString() + "' AND DaDuyet='true'", getConnect());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }
        public DataTable timKiem(SqlCommand cmd)
        {

            if (getConnect() != null)
            {

                try
                {
                    cmd.Connection = getConnect();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataView dv = new DataView();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dv = dt.DefaultView;
                    dv.Sort = "ThoiGianDuyet DESC"; // Xem Tin Moi Nhat Truoc
                    dt = dv.ToTable();
                    return dt;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }
        public string ExcuteNonQuery(SqlCommand command)
        {
            if(getConnect() != null)
            {
                try
                {
                    SqlConnection conn = getConnect();
                    conn.Open();
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    conn.Close();
                    return "";
                }
                catch (SqlException e)
                {
                    return "Lỗi Thực Thi SQL !!\n" + e.ToString();
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
            return "Lỗi kết nối SQL Server\n Kiểm tra chuỗi kết nối!";
            
        }

    }
}
