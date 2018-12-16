using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DataTaiKhoan
    {
        private static DataTaiKhoan instance;
        public static DataTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataTaiKhoan();
                return instance;
            }
            private set
            {
                DataTaiKhoan.instance = value;
            }

        }

        public DataTaiKhoan() { }

        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NguoiTimViec_ViecTimNguoi;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=NguoiTimViec_ViecTimNguoi;Integrated Security=True");
        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            conn.Close();

            return dt;
        }

        public DataTable ExcuteQuery(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            conn.Open();
            cmd.Connection = conn;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            conn.Close();

            return dt;
        }


        public void ExcuteNonQuery(string query)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public void ExcuteNonQuery(SqlCommand sql)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            sql.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable getAccount()
        {
            string query = "SELECT * FROM Account WHERE isAdmin='false'";
            return DataTaiKhoan.Instance.ExcuteQuery(query);
        }

        public void addAccount(TaiKhoan tk)
        {
            string query = "INSERT INTO Account (UserName, Pass, isAdmin, Avatar) VALUES ('" + tk.Acc + "', '" + tk.Pass + "', 'False',@avatar)";
            SqlCommand sql = new SqlCommand(query, conn);
            sql.Parameters.AddWithValue("@avatar", tk.Avatar);
            ExcuteNonQuery(sql);
        }

        public void delAccount(TaiKhoan tk)
        {
            string query = "DELETE FROM Account WHERE UserName = '" + tk.Acc + "'";
            DataTaiKhoan.Instance.ExcuteNonQuery(query);
        }

        public TaiKhoan getInfoByID(string id)
        {
            TaiKhoan tk = new TaiKhoan();
            string query = "SELECT * FROM Account WHERE UserName = '" +id+ "'";
            DataTable dt = new DataTable();
            dt = ExcuteQuery(query);
            tk.Acc = dt.Rows[0]["UserName"].ToString();
            tk.Pass = dt.Rows[0]["Pass"].ToString();
            if (!DBNull.Value.Equals(dt.Rows[0]["Avatar"]))
            {
                tk.Avatar = (Byte[])dt.Rows[0]["Avatar"];
            }
            else
                tk.Avatar = null;
               
            tk.IsAdmin = (bool)dt.Rows[0]["isAdmin"];

            return tk;

        }
        public bool checkAcc(string username, string pass)
        {
            string query = "select * From  Account where UserName = @id and Pass = @pw";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", username);
            cmd.Parameters.AddWithValue("@pw", pass);
            DataTable result = DataTaiKhoan.Instance.ExcuteQuery(cmd);
            return result.Rows.Count > 0;
        }
    }
}
