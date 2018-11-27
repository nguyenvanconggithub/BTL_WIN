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
        DAL.DataTinTimViec data = new DataTinTimViec();
        DataTable dt = new DataTable();
        public string Insert(DTO.TinTimViec tin)
        {
            try
            {
                string cmdString =
                    "INSERT INTO TinTimViec(Avatar,HoTen,GioiTinh,NgaySinh,Sdt,Email,DiaChi,NganhNghe,TrinhDo,NamKinhNghiem,ViTri,NoiLamViec,LoaiHinhCongViec,Luong,DaDuyet,ThoiGianDuyet)" +
                    "VALUES(@avt,@hoTen,@gt,@ngaySinh,@sdt,@email,@diaChi,@nganhNghe,@trinhDo,@namKinhNghiem,@viTri,@noiLamViec,@loaiHinhCongViec,@Luong,'true',@thoiGianDuyet)";
                SqlCommand command = new SqlCommand(cmdString);
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
                data.ExcuteNonQuery(command);
                return "Lưu Thành Công";
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
                string cmdString = "SELECT * FROM TinTimViec"
                              + "WHERE NganhNghe = '" + search.NganhNghe + "'"
                              + "AND NoiLamViec = '" + search.NoiLamViec + "'"
                              + "AND LoaiHinhCongViec = '" + search.LoaiHinhCongViec + "'"
                              + "AND TrinhDo = '" + search.TrinhDo + "'"
                              + "AND NamKinhNghiem = '" + search.NamKinhNghiem + "'"
                              + "AND GioiTinh = '" + search.GioiTinh + "'"
                              + "AND NgaySinh > '" + search.NamSinhMin + "'"
                              + "AND NgaySinh < '" + search.NamSinhMax + "'"
                              + "AND Luong = '" + search.Luong + "'";
                SqlCommand cmd = new SqlCommand(cmdString);
                DataTable table = new DataTable();
                table = data.timKiem(cmdString);

                return table;
            }
            catch(Exception)
            {
                return null;
            }
            
            
        }
        public void UpdateTableChuaDuyet()
        {
            dt.Clear();
            dt = data.getTinChuaDuyet();
        }
        public DataTable UpdateTableDaDuyet()
        {
            dt.Clear();
            dt = data.getTinDaDuyet();

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
            table = data.getTinByMaTin(maTin);
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
                if (dt != null && dt.Rows.Count > 0)
                {
                    SqlCommand command = new SqlCommand("UPDATE TinTimViec SET DaDuyet='true' WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    data.ExcuteNonQuery(command);
                    UpdateTableChuaDuyet();
                    return "";
                }
                else
                    return "Hết Tin Tiếp Theo";
                
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
                if (dt != null && dt.Rows.Count > 0)
                {
                    SqlCommand command = new SqlCommand("DELETE TinTimViec WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    data.ExcuteNonQuery(command);
                    UpdateTableChuaDuyet();
                    return "";
                }
                else
                    return "Hết Tin Tiếp Theo";
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
                SqlCommand command = new SqlCommand("DELETE TinTimViec WHERE MaTin='" + maTin + "'");
                data.ExcuteNonQuery(command);
                UpdateTableChuaDuyet();
                return "Đã Xóa";
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
                data.ExcuteNonQuery(command);
                return "Lưu Thành Công";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }


    }
}
