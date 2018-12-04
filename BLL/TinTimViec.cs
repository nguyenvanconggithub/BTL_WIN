using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BLL
{
    public class TinTimViec
    {
        private static TinTimViec instance;

        DataTable dt = new DataTable();

        public static TinTimViec Instance
        {
            get
            {
                if (instance == null)
                    instance = new TinTimViec();
                return instance;
            }
        }
        public string KiemTraKetNoi()
        {
            if (DAL.DataTinTimViec.Instance.getConnect() == null)
                return "Lỗi Kết Nối SQL Server, Kiểm Tra câu kết nối !";
            return "";
        }
        public string Insert(DTO.TinTimViec tin)
        {
            try
            {
                string error = "";
                string cmdString =
                    "INSERT INTO TinTimViec(Avatar,HoTen,GioiTinh,NgaySinh,Sdt,Email,DiaChi,NganhNghe,TrinhDo,NamKinhNghiem,ViTri,NoiLamViec,LoaiHinhCongViec,Luong,DaDuyet,ThoiGianDuyet)" +
                    "VALUES(@avt,@hoTen,@gt,@ngaySinh,@sdt,@email,@diaChi,@nganhNghe,@trinhDo,@namKinhNghiem,@viTri,@noiLamViec,@loaiHinhCongViec,@Luong,'true',@thoiGianDuyet)";
                SqlCommand command = new SqlCommand(cmdString);
                //command.Parameters.Add("@avt", SqlDbType.Image).Value = tin.Img;
                command.Parameters.AddWithValue("@avt", tin.Img);
                command.Parameters.AddWithValue("@hoTen", tin.HoTen);  
                command.Parameters.AddWithValue("@gt", tin.GioiTinh);
                command.Parameters.AddWithValue("@ngaySinh", tin.NgaySinh);
                command.Parameters.AddWithValue("@sdt", tin.SoDienThoai);
                command.Parameters.AddWithValue("@email", tin.Email);
                command.Parameters.AddWithValue("@diaChi", tin.DiaChi);
                command.Parameters.AddWithValue("@nganhNghe", tin.NganhNghe);
                command.Parameters.AddWithValue("@trinhDo", tin.TrinhDo);
                command.Parameters.AddWithValue("@namKinhNghiem", tin.NamKinhNghiem);
                command.Parameters.AddWithValue("@viTri", tin.ViTri);
                command.Parameters.AddWithValue("@noiLamViec", tin.NoiLamViec);
                command.Parameters.AddWithValue("@loaiHinhCongViec", tin.LoaiHinhCongViec);
                command.Parameters.AddWithValue("@Luong", tin.Luong);
                command.Parameters.AddWithValue("@thoiGianDuyet", DateTime.Now);
                error = DataTinTimViec.Instance.ExcuteNonQuery(command);
                if (error == "")
                    return "Thêm Thành Công";
                return error;
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
        //hàm tìm kiếm phục phụ cho package TìmKiếm
        public DataTable getTableFollowSearch(DTO.TinTimViec search)
        {
            try
            {
                string cmdString = "SELECT * FROM TinTimViec " +
                    "WHERE NganhNghe LIKE @NganhNghe " +
                    "AND NoiLamViec LIKE @NoiLamViec " +
                    "AND LoaiHinhCongViec LIKE @LoaiHinhCongViec " +
                    "AND TrinhDo LIKE @TrinhDo " +
                    "AND NamKinhNghiem LIKE @NamKinhNghiem " +
                    "AND GioiTinh LIKE @GioiTinh " +
                    "AND Luong LIKE @Luong " +
                    "AND DaDuyet = 'true'";
                SqlCommand cmd = new SqlCommand(cmdString);
                cmd.Parameters.AddWithValue("@NganhNghe", search.NganhNghe);
                cmd.Parameters.AddWithValue("@NoiLamViec", search.NoiLamViec);
                cmd.Parameters.AddWithValue("@LoaiHinhCongViec", search.LoaiHinhCongViec);
                cmd.Parameters.AddWithValue("@TrinhDo", search.TrinhDo);
                cmd.Parameters.AddWithValue("@NamKinhNghiem", search.NamKinhNghiem);
                cmd.Parameters.AddWithValue("@GioiTinh", search.GioiTinh);
                cmd.Parameters.AddWithValue("@Luong", search.Luong);
                DataTable table = new DataTable();
                table = DataTinTimViec.Instance.timKiem(cmd);

                return table;
            }
            catch(Exception)
            {
                return null;
            }
            
            
        }
        public void UpdateTableChuaDuyet()
        {
            if(dt != null)
                dt.Clear();
            dt = DataTinTimViec.Instance.getTinChuaDuyet();
        }
        public DataTable UpdateTableDaDuyet()
        {
            if(dt != null)
                dt.Clear();
            dt = DataTinTimViec.Instance.getTinDaDuyet();

            return dt;
        }

        public DTO.TinTimViec getTinChuaDuyetCuNhat()
        {
            UpdateTableChuaDuyet();
            DTO.TinTimViec tin = new DTO.TinTimViec();

            if(dt != null && dt.Rows.Count > 0)
            {
                tin.MaTin = dt.Rows[0]["MaTin"].ToString();
                tin.Img = (Byte[])dt.Rows[0]["Avatar"];
                tin.HoTen = dt.Rows[0]["HoTen"].ToString();
                tin.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
                tin.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
                tin.SoDienThoai = dt.Rows[0]["Sdt"].ToString();
                tin.Email = dt.Rows[0]["Email"].ToString();
                tin.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                tin.NganhNghe = dt.Rows[0]["NganhNghe"].ToString();
                tin.NamKinhNghiem = dt.Rows[0]["NamKinhNghiem"].ToString();
                tin.TrinhDo = dt.Rows[0]["TrinhDo"].ToString();
                tin.NoiLamViec = dt.Rows[0]["NoiLamViec"].ToString();
                tin.ViTri = dt.Rows[0]["ViTri"].ToString();
                tin.LoaiHinhCongViec = dt.Rows[0]["LoaiHinhCongViec"].ToString();
                tin.Luong = dt.Rows[0]["Luong"].ToString();

                return tin;
            }
            return null;

        }
        public DTO.TinTimViec getTinDaDuyetMoiNhat()
        {
            UpdateTableDaDuyet();
            DTO.TinTimViec tin = new DTO.TinTimViec();
            if(dt != null && dt.Rows.Count > 0)
            {
                tin.MaTin = dt.Rows[0]["MaTin"].ToString();
                tin.Img = (Byte[])dt.Rows[0]["Avatar"];
                tin.HoTen = dt.Rows[0]["HoTen"].ToString();
                tin.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
                tin.NgaySinh = dt.Rows[0]["NgaySinh"].ToString();
                tin.SoDienThoai = dt.Rows[0]["Sdt"].ToString();
                tin.Email = dt.Rows[0]["Email"].ToString();
                tin.DiaChi = dt.Rows[0]["DiaChi"].ToString();
                tin.NganhNghe = dt.Rows[0]["NganhNghe"].ToString();
                tin.NamKinhNghiem = dt.Rows[0]["NamKinhNghiem"].ToString();
                tin.TrinhDo = dt.Rows[0]["TrinhDo"].ToString();
                tin.NoiLamViec = dt.Rows[0]["NoiLamViec"].ToString();
                tin.ViTri = dt.Rows[0]["ViTri"].ToString();
                tin.LoaiHinhCongViec = dt.Rows[0]["LoaiHinhCongViec"].ToString();
                tin.Luong = dt.Rows[0]["Luong"].ToString();

                return tin;
            }
            return null;
            
        }
        public DTO.TinTimViec getTinByMaTin(string maTin)
        {
            DataTable table = new DataTable();
            table = DataTinTimViec.Instance.getTinByMaTin(maTin);
            DTO.TinTimViec tin = new DTO.TinTimViec();
            if(table != null && table.Rows.Count > 0)
            {
                tin.MaTin = table.Rows[0]["MaTin"].ToString();
                tin.Img = (Byte[])table.Rows[0]["Avatar"];
                tin.HoTen = table.Rows[0]["HoTen"].ToString();
                tin.GioiTinh = table.Rows[0]["GioiTinh"].ToString();
                tin.NgaySinh = table.Rows[0]["NgaySinh"].ToString();
                tin.SoDienThoai = table.Rows[0]["Sdt"].ToString();
                tin.Email = table.Rows[0]["Email"].ToString();
                tin.DiaChi = table.Rows[0]["DiaChi"].ToString();
                tin.NganhNghe = table.Rows[0]["NganhNghe"].ToString();
                tin.NamKinhNghiem = table.Rows[0]["NamKinhNghiem"].ToString();
                tin.TrinhDo = table.Rows[0]["TrinhDo"].ToString();
                tin.NoiLamViec = table.Rows[0]["NoiLamViec"].ToString();
                tin.ViTri = table.Rows[0]["ViTri"].ToString();
                tin.LoaiHinhCongViec = table.Rows[0]["LoaiHinhCongViec"].ToString();
                tin.Luong = table.Rows[0]["Luong"].ToString();

                return tin;
            }
            return null;
        }
        public string DuyetTin()
        {
            try
            {
                string err = "";
                if (dt != null && dt.Rows.Count > 0)
                {
                    SqlCommand command = new SqlCommand("UPDATE TinTimViec SET DaDuyet='true',ThoiGianDuyet=@timenow WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    command.Parameters.Add("@timenow", SqlDbType.DateTime).Value = DateTime.Now;
                    err = DataTinTimViec.Instance.ExcuteNonQuery(command);
                    UpdateTableChuaDuyet();
                    if (err != "")
                        return err;
                }

                if (dt != null && dt.Rows.Count == 1)
                {
                    SqlCommand command = new SqlCommand("UPDATE TinTimViec SET DaDuyet='true',ThoiGianDuyet=@timenow WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    command.Parameters.Add("@timenow", SqlDbType.DateTime).Value = DateTime.Now;
                    err = DataTinTimViec.Instance.ExcuteNonQuery(command);
                    UpdateTableChuaDuyet();
                    if(err == "")
                        return "Hết Tin Tiếp Theo";
                    return err;
                }
                return "";
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }

        public string XoaTin()
        {
            try
            {
                string err = "";
                if (dt != null && dt.Rows.Count > 0)
                {
                    
                    SqlCommand command = new SqlCommand("DELETE TinTimViec WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    err = DataTinTimViec.Instance.ExcuteNonQuery(command);
                    UpdateTableChuaDuyet();
                    if (err != "")
                        return err;
                }
                if (dt != null && dt.Rows.Count == 1)
                {

                    SqlCommand command = new SqlCommand("DELETE TinTimViec WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    err = DataTinTimViec.Instance.ExcuteNonQuery(command);
                    UpdateTableChuaDuyet();
                    if (err == "")
                        return "Hết Tin Tiếp Theo";
                }
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string XoaMaTin(string maTin)
        {
            try
            {
                UpdateTableChuaDuyet();
                string err = "";
                SqlCommand command = new SqlCommand("DELETE TinTimViec WHERE MaTin='" + maTin + "'");
                err = DataTinTimViec.Instance.ExcuteNonQuery(command);
                UpdateTableChuaDuyet();
                if(err == "")
                    return "Đã Xóa";
                return err;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string UpDate(DTO.TinTimViec tin)
        {
            try
            {
                string err = "";
                string cmdString =
                   "UPDATE TinTimViec " +
                   "SET Avatar=@avt,HoTen=@hoTen,GioiTinh=@gt,NgaySinh=@ngaySinh,Sdt=@sdt,Email=@email,DiaChi=@diachi" +
                   ",NganhNghe=@nganhNghe,TrinhDo=@trinhDo,NamKinhNghiem=@namKinhNghiem,ViTri=@viTri,NoiLamViec=@noiLamViec" +
                   ",LoaiHinhCongViec=@loaiHinhCongViec,Luong=@Luong,ThoiGianDuyet=@thoiGianDuyet" +
                   " WHERE MaTin=@maTin";
                SqlCommand command = new SqlCommand(cmdString);
                command.Parameters.AddWithValue("@maTin", tin.MaTin);
                command.Parameters.AddWithValue("@avt", tin.Img);
                command.Parameters.AddWithValue("@hoTen", tin.HoTen);
                command.Parameters.AddWithValue("@gt", tin.GioiTinh);
                command.Parameters.AddWithValue("@ngaySinh", tin.NgaySinh);
                command.Parameters.AddWithValue("@sdt", tin.SoDienThoai);
                command.Parameters.AddWithValue("@email", tin.Email);
                command.Parameters.AddWithValue("@diaChi", tin.DiaChi);
                command.Parameters.AddWithValue("@nganhNghe", tin.NganhNghe);
                command.Parameters.AddWithValue("@trinhDo", tin.TrinhDo);
                command.Parameters.AddWithValue("@namKinhNghiem", tin.NamKinhNghiem);
                command.Parameters.AddWithValue("@viTri", tin.ViTri);
                command.Parameters.AddWithValue("@noiLamViec", tin.NoiLamViec);
                command.Parameters.AddWithValue("@loaiHinhCongViec", tin.LoaiHinhCongViec);
                command.Parameters.AddWithValue("@Luong", tin.Luong);
                command.Parameters.AddWithValue("@thoiGianDuyet", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                err = DataTinTimViec.Instance.ExcuteNonQuery(command);
                UpdateTableChuaDuyet();
                if(err == "")
                    return "Lưu Thành Công";
                return err;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }


    }
}
