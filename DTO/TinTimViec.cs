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
        private string namSinhMin;
        private string namSinhMax;
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

        public string MaTin { get =>maTin; set => maTin = value; }
        public Byte[] Img { get => img; set => img = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NganhNghe { get => nganhNghe; set => nganhNghe = value; }
        public string TrinhDo { get => trinhDo; set => trinhDo = value; }
        public string NamKinhNghiem { get => namKinhNghiem; set => namKinhNghiem = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public string NoiLamViec { get => noiLamViec; set => noiLamViec = value; }
        public string LoaiHinhCongViec { get => loaiHinhCongViec; set => loaiHinhCongViec = value; }
        public string Luong { get => luong; set => luong = value; }
        public bool DaDuyet { get => daDuyet; set => daDuyet = value; }
        public string NamSinhMin { get => namSinhMin; set => namSinhMin = value; }
        public string NamSinhMax { get => namSinhMax; set => namSinhMax = value; }
    }
}
