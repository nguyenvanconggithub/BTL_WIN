using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TinTimViec
    {
        private string maTin;
        private Byte[] img;
        private string hoTen;
        private string gioiTinh;
        private string ngaySinh;
        private string soDienThoai;
        private string email;
        private string diaChi;
        private string nganhNghe;
        private string trinhDo;
        private string namKinhNghiem;
        private string viTri;
        private string noiLamViec;
        private string loaiHinhCongViec;
        private string luong;
        private bool daDuyet;

        public string MaTin { get { return maTin; } set { maTin = value; } }
        public Byte[] Img { get { return img; } set { img = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public string GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        public string NgaySinh { get { return ngaySinh; } set { ngaySinh = value; } }
        public string SoDienThoai { get { return soDienThoai; } set { soDienThoai = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
        public string NganhNghe { get { return nganhNghe; } set { nganhNghe = value; } }
        public string TrinhDo { get { return trinhDo; } set { trinhDo = value; } }
        public string NamKinhNghiem { get { return namKinhNghiem; } set { namKinhNghiem = value; } }
        public string ViTri { get { return viTri; } set { viTri = value; } }
        public string NoiLamViec { get { return noiLamViec; } set { noiLamViec = value; } }
        public string LoaiHinhCongViec { get { return loaiHinhCongViec; } set { loaiHinhCongViec = value; } }
        public string Luong { get { return luong; } set { luong = value; } }
        public bool DaDuyet { get { return daDuyet; } set { daDuyet = value; } }
    }
}
