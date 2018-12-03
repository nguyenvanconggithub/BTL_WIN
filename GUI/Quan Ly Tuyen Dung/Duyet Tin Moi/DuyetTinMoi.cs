using System.Windows.Forms;

namespace GUI.Quan_Ly_Tuyen_Dung.Duyet_Tin_Moi
{
    public partial class DuyetTinMoi : UserControl
    {
        public DuyetTinMoi()
        {
            InitializeComponent();
        }
        BLL.TinTuyenDung tin = new BLL.TinTuyenDung();
        public void  loadtin()
        {
            DTO.TinTuyenDung tinDTO = tin.getTinChuaDuyetCuNhat();
            if (tinDTO != null)
            {
                lblTenCongTy.Text = tinDTO.TenCT;
                lblSDT.Text = tinDTO.SdtCT;
                lblDiaChi.Text = tinDTO.DiaChiCT;
                lblTuyen.Text = tinDTO.NganhNghe;
                lblNoiLamViec.Text = tinDTO.NoiLamViec;
                lblViTri.Text = tinDTO.ViTri;
                lblLuong.Text = tinDTO.Luong;
                lblSoLuong.Text = tinDTO.SoLuong.ToString();
                lblHinhThucLamViec.Text = tinDTO.LoaiHinhCongViec;
                lblYeuCauBangCap.Text = tinDTO.TrinhDo;
                lblYeuCauKinhNghiem.Text = tinDTO.NamKinhNghiem;
                lblYeuCauGioiTinh.Text = tinDTO.YeuCauGioiTinh;
                lblMoTaCongViec.Text = tinDTO.MoTaCongViec;
                lblYeuCauHoSo.Text = tinDTO.YeuCauHoSo;

                khongCoTinChuaDuyet.SendToBack();
                khongCoTinChuaDuyet.Height = panelMot.Height + panelHai.Height + panelBa.Height + panelBon.Height + panelNam.Height + panelSau.Height;
            }
            else
            {
                khongCoTinChuaDuyet.BringToFront();
            }
        }

        private void DuyetTinMoi_Load(object sender, System.EventArgs e)
        {
            
            //hide scroll bar
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            string them = null;
            them = tin.DuyetTin();
            if (them != "")
                MessageBox.Show("Thêm tin thành công");
            loadtin();
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            string xoa;
            xoa = tin.XoaTin();
            if (xoa != "")
            {
                MessageBox.Show("Xóa tin thành công");
            }
            loadtin();
        }

        public void Active()
        {
            loadtin();
        }
       
    }
}
