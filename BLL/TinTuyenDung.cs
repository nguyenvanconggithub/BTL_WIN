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
    public class TinTuyenDung
    {
        DataTable dt = new DataTable();
        private static TinTuyenDung tin;
        public static TinTuyenDung Tin
        {
            get
            {
                if (tin == null)
                    tin = new TinTuyenDung();
                return tin;
            }
        }
       
        public string themtintuyendung(DTO.TinTuyenDung tin)
        {
            try
            {
                String cmdtext = "insert into TinTuyenDung(TenCT,SdtCT,DiaChiCT,NganhNghe,ViTri,NoiLamViec,Luong,SoLuong,LoaiHinhCongViec,TrinhDo,NamKinhNghiem,YeuCauGioiTinh,MoTaCongViec,YeuCauHoSo,DaDuyet,ThoiGianDuyet) " +
                    "values(@TenCT,@SdtCT,@DiaChiCT,@NganhNghe,@ViTri,@NoiLamViec,@Luong,@SoLuong,@LoaiHinhCongViec,@TrinhDo,@NamKinhNghiem,@YeuCauGioiTinh,@MoTaCongViec,@YeuCauHoSo,'1',@ThoiGianDuyet)";
                SqlCommand cmd = new SqlCommand(cmdtext);
                cmd.Parameters.AddWithValue("@TenCT", tin.TenCT);
                cmd.Parameters.AddWithValue("@SdtCT", tin.SdtCT);
                cmd.Parameters.AddWithValue("@DiaChiCT", tin.DiaChiCT);
                cmd.Parameters.AddWithValue("@NganhNghe", tin.NganhNghe);
                cmd.Parameters.AddWithValue("@ViTri", tin.ViTri);
                cmd.Parameters.AddWithValue("@NoiLamViec", tin.NoiLamViec);
                cmd.Parameters.AddWithValue("@Luong", tin.Luong);
                cmd.Parameters.AddWithValue("@SoLuong", tin.SoLuong);
                cmd.Parameters.AddWithValue("@LoaiHinhCongViec", tin.LoaiHinhCongViec);
                cmd.Parameters.AddWithValue("@TrinhDo", tin.TrinhDo);
                cmd.Parameters.AddWithValue("@NamKinhNghiem", tin.NamKinhNghiem);
                cmd.Parameters.AddWithValue("@YeuCauGioiTinh", tin.YeuCauGioiTinh);
                cmd.Parameters.AddWithValue("@MoTaCongViec", tin.MoTaCongViec);
                cmd.Parameters.AddWithValue("@YeuCauHoSo", tin.YeuCauHoSo);
                cmd.Parameters.AddWithValue("@ThoiGianDuyet", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                DAL.DataTinTuyenDung.DaTa.ExecuteNonQuery(cmd);

                return "lưu thành công";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public void updateTinChuaDuyet()
        {
            dt.Clear();
            dt = DAL.DataTinTuyenDung.DaTa.getTinChuaDuyet();
        }
        public DataTable updateTinDaDuyet()
        {
            dt.Clear();
            dt = DAL.DataTinTuyenDung.DaTa.getTinDaDuyet();
            return dt;
        }
        public DTO.TinTuyenDung getTinChuaDuyetCuNhat()
        {
            updateTinChuaDuyet();
            DTO.TinTuyenDung tin = new DTO.TinTuyenDung();

            if (dt != null && dt.Rows.Count > 0)
            {
                tin.MaTin = dt.Rows[0]["MaTin"].ToString();
                tin.TenCT = dt.Rows[0]["TenCT"].ToString();
                tin.SdtCT = dt.Rows[0]["SdtCT"].ToString();
                tin.DiaChiCT = dt.Rows[0]["DiaChiCT"].ToString();
                tin.NganhNghe = dt.Rows[0]["NganhNghe"].ToString();
                tin.ViTri = dt.Rows[0]["ViTri"].ToString();
                tin.NoiLamViec = dt.Rows[0]["NoiLamViec"].ToString();
                tin.Luong = dt.Rows[0]["Luong"].ToString();
                tin.SoLuong = Convert.ToInt32(dt.Rows[0]["SoLuong"]);
                tin.LoaiHinhCongViec = dt.Rows[0]["LoaiHinhCongViec"].ToString();
                tin.TrinhDo = dt.Rows[0]["TrinhDo"].ToString();
                tin.NamKinhNghiem = dt.Rows[0]["NamKinhNghiem"].ToString();
                tin.YeuCauGioiTinh = dt.Rows[0]["YeuCauGioiTinh"].ToString();
                tin.MoTaCongViec = dt.Rows[0]["MoTaCongViec"].ToString();
                tin.YeuCauHoSo = dt.Rows[0]["YeuCauHoSo"].ToString();
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
                    SqlCommand command = new SqlCommand("UPDATE TinTuyenDung SET DaDuyet='true' WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    DAL.DataTinTuyenDung.DaTa.ExecuteNonQuery(command);
                    updateTinChuaDuyet();
                    return "Duyệt tin thành công";
                }
                else
                    return "";

            }
            catch (Exception e)
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
                    SqlCommand command = new SqlCommand("DELETE TinTuyenDung WHERE MaTin=@matin");
                    command.Parameters.AddWithValue("@matin", dt.Rows[0]["MaTin"]);
                    DAL.DataTinTuyenDung.DaTa.ExecuteNonQuery(command);
                    updateTinChuaDuyet();
                    return "Xóa tin thành công";
                }
                else
                    return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        public DTO.TinTuyenDung getTinByMaTin(string maTin)
        {
            DataTable dt = new DataTable();
            dt = DAL.DataTinTuyenDung.DaTa.getTinByMaTin(maTin);
            DTO.TinTuyenDung tin = new DTO.TinTuyenDung();
            if (dt != null && dt.Rows.Count > 0)
            {
                tin.MaTin = dt.Rows[0]["MaTin"].ToString();
                tin.TenCT = dt.Rows[0]["TenCT"].ToString();
                tin.SdtCT = dt.Rows[0]["SdtCT"].ToString();
                tin.DiaChiCT = dt.Rows[0]["DiaChiCT"].ToString();
                tin.NganhNghe = dt.Rows[0]["NganhNghe"].ToString();
                tin.ViTri = dt.Rows[0]["ViTri"].ToString();
                tin.NoiLamViec = dt.Rows[0]["NoiLamViec"].ToString();
                tin.Luong = dt.Rows[0]["Luong"].ToString();
                tin.SoLuong = Convert.ToInt32(dt.Rows[0]["SoLuong"]);
                tin.LoaiHinhCongViec = dt.Rows[0]["LoaiHinhCongViec"].ToString();
                tin.TrinhDo = dt.Rows[0]["TrinhDo"].ToString();
                tin.NamKinhNghiem = dt.Rows[0]["NamKinhNghiem"].ToString();
                tin.YeuCauGioiTinh = dt.Rows[0]["YeuCauGioiTinh"].ToString();
                tin.MoTaCongViec = dt.Rows[0]["MoTaCongViec"].ToString();
                tin.YeuCauHoSo = dt.Rows[0]["YeuCauHoSo"].ToString();
                return tin;
            }
            return null;
        }
        public DTO.TinTuyenDung getTinDaDuyetMoiNhat()
        {
            updateTinDaDuyet();
            DTO.TinTuyenDung tin = new DTO.TinTuyenDung();
            if (dt != null && dt.Rows.Count > 0)
            {
                tin.MaTin = dt.Rows[0]["MaTin"].ToString();
                tin.TenCT = dt.Rows[0]["TenCT"].ToString();
                tin.SdtCT = dt.Rows[0]["SdtCT"].ToString();
                tin.DiaChiCT = dt.Rows[0]["DiaChiCT"].ToString();
                tin.NganhNghe = dt.Rows[0]["NganhNghe"].ToString();
                tin.ViTri = dt.Rows[0]["ViTri"].ToString();
                tin.NoiLamViec = dt.Rows[0]["NoiLamViec"].ToString();
                tin.Luong = dt.Rows[0]["Luong"].ToString();
                tin.SoLuong = Convert.ToInt32(dt.Rows[0]["SoLuong"]);
                tin.LoaiHinhCongViec = dt.Rows[0]["LoaiHinhCongViec"].ToString();
                tin.TrinhDo = dt.Rows[0]["TrinhDo"].ToString();
                tin.NamKinhNghiem = dt.Rows[0]["NamKinhNghiem"].ToString();
                tin.YeuCauGioiTinh = dt.Rows[0]["YeuCauGioiTinh"].ToString();
                tin.MoTaCongViec = dt.Rows[0]["MoTaCongViec"].ToString();
                tin.YeuCauHoSo = dt.Rows[0]["YeuCauHoSo"].ToString();
                return tin;
            }
            return null;
        }
        public string XoaTinByMaTin(string maTin)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete TinTuyenDung where MaTin ='" + maTin + "' ");
                DAL.DataTinTuyenDung.DaTa.ExecuteNonQuery(cmd);
                updateTinDaDuyet();
                return "Xóa tin Thành Công";
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
        public string Update(DTO.TinTuyenDung tin)
        {
            SqlCommand cmd = new SqlCommand("update TinTuyenDung set TenCT = @tenct, SdtCT = @sdtct, DiaChiCT = @DiaChi,NganhNghe = @nganhnghe,ViTri = @vitri, NoiLamViec = @noilamviec, Luong = @luong, SoLuong = @soluong,LoaiHinhCongViec = @loaihinhcongviec, TrinhDo = @trinhdo, NamkinhNghiem = @namkinhnghiem, YeuCauGioiTinh = @yeucaugioitinh, MoTaCongViec = @motacongviec,YeuCauHoSo = @yeucauhoso,ThoiGianDuyet=@thoigianduyet WHERE MaTin = @maTin");
            cmd.Parameters.Add("@maTin", tin.MaTin);
            cmd.Parameters.Add("@tenct", tin.TenCT);
            cmd.Parameters.Add("@sdtct", tin.SdtCT);
            cmd.Parameters.Add("@diachi", tin.DiaChiCT);
            cmd.Parameters.Add("@nganhnghe", tin.NganhNghe);
            cmd.Parameters.Add("@vitri", tin.ViTri);
            cmd.Parameters.Add("@noilamviec", tin.NoiLamViec);
            cmd.Parameters.Add("@luong", tin.Luong);
            cmd.Parameters.Add("@soluong", tin.SoLuong);
            cmd.Parameters.Add("@loaihinhcongviec", tin.LoaiHinhCongViec);
            cmd.Parameters.Add("@trinhdo", tin.TrinhDo);
            cmd.Parameters.Add("@namkinhnghiem", tin.NamKinhNghiem);
            cmd.Parameters.Add("@yeucaugioitinh", tin.YeuCauGioiTinh);
            cmd.Parameters.Add("@motacongviec", tin.MoTaCongViec);
            cmd.Parameters.Add("@yeucauhoso", tin.YeuCauHoSo);
            cmd.Parameters.Add("@thoigianduyet", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            bool success = DAL.DataTinTuyenDung.DaTa.ExecuteNonQuery(cmd);
            if (success == true)
                return "Lưu Thành Công";
            return "";
        }
        public DataTable TimKiem(DTO.TinTuyenDung search)
        {
            try
            {
                string cmdtext = "select * from TinTuyenDung where NganhNghe LIKE N'" + search.NganhNghe + "' AND NoiLamViec LIKE N'" + search.NoiLamViec + "' AND LoaiHinhCongViec LIKE N'" + search.LoaiHinhCongViec + "' AND TrinhDo LIKE N'" + search.TrinhDo + "' AND NamKinhNghiem LIKE N'" + search.NamKinhNghiem + "' AND Luong LIKE N'" + search.Luong + "'AND YeuCauGioiTinh LIKE N'" + search.YeuCauGioiTinh + "'AND DaDuyet = 'true' ";
                DataTable table = new DataTable();
                dt = DAL.DataTinTuyenDung.DaTa.TimKiemTinTuyenDung(cmdtext);
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
       
    }
}