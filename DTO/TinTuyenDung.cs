using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TinTuyenDung
    {
        private string maTin;
        private string tenCT;
        private string sdtCT;
        private string diaChiCT;
        private string nganhNghe;
        private string viTri;
        private string noiLamViec;
        private string luong;
        private Int32 soLuong;
        private string loaiHinhCongViec;
        private string trinhDo;
        private string namkinhNghiem;
        private string yeuCauGioiTinh;
        private string moTaCongViec;
        private string yeuCauHoSo;
        private bool daDuyet;

        public string MaTin { get { return maTin; } set { maTin = value; } }
        public string TenCT { get { return tenCT; } set { tenCT = value; } }
        public string SdtCT { get { return sdtCT; } set { sdtCT = value; } }
        public string DiaChiCT { get { return diaChiCT; } set { diaChiCT = value; } }
        public string NganhNghe { get { return nganhNghe; } set { nganhNghe = value; } }
        public string ViTri { get { return viTri; } set { viTri = value; } }
        public string NoiLamViec { get { return noiLamViec; } set { noiLamViec = value; } }
        public string Luong { get { return luong; } set { luong = value; } }
        public Int32 SoLuong { get { return soLuong; } set { soLuong = value; } }
        public string LoaiHinhCongViec { get { return loaiHinhCongViec; } set { loaiHinhCongViec = value; } }
        public string TrinhDo { get { return trinhDo; } set { trinhDo = value; } }
        public string NamKinhNghiem { get { return namkinhNghiem; } set { namkinhNghiem = value; } }
        public string YeuCauGioiTinh { get { return yeuCauGioiTinh; } set { yeuCauGioiTinh = value; } }
        public string MoTaCongViec { get { return moTaCongViec; } set { moTaCongViec = value; } }
        public string YeuCauHoSo { get { return yeuCauHoSo; } set { yeuCauHoSo = value; } }
        public bool DaDuyet { get { return daDuyet; } set { daDuyet = value; } }
    }
}
