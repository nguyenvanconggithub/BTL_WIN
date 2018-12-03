using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Quan_Ly_Tuyen_Dung.Quan_Ly_Tin_Da_Duyet
{
    public partial class ThongTinChiTiet : UserControl
    {
        public ThongTinChiTiet()
        {
            InitializeComponent();
        }
        
        DTO.TinTuyenDung tinDTO = new DTO.TinTuyenDung();
        public void loadTin(DTO.TinTuyenDung tininfo)
        {
            tinDTO = tininfo;
            lblTenCongTy.Text = tinDTO.TenCT;
            lblSDT.Text = tinDTO.SdtCT;
            lblDiaChi.Text = tinDTO.DiaChiCT;
            lblTuyen.Text = tinDTO.NganhNghe;
            lblTai.Text = tinDTO.NoiLamViec;
            lblViTri.Text = tinDTO.ViTri;
            lblSoLuong.Text = tinDTO.SoLuong.ToString();
            lblLuong.Text = tinDTO.Luong;
            lblHinhThucLamViec.Text = tinDTO.LoaiHinhCongViec;
            lblYeuCauBangCap.Text = tinDTO.TrinhDo;
            lblYeuCauKinhNghiem.Text = tinDTO.NamKinhNghiem;
            lblYeuCauGioiTinh.Text = tinDTO.YeuCauGioiTinh;
            lblMoTaCongViec.Text = tinDTO.MoTaCongViec;
            lblYeuCauHoSo.Text = tinDTO.YeuCauHoSo;

            txtTenCongTy.Text = tinDTO.TenCT;
            rtbSDT.Text = tinDTO.SdtCT;
            rtbDiaChi.Text = tinDTO.DiaChiCT;
            cmbTuyen.Text = tinDTO.NganhNghe;
            cmbTai.Text = tinDTO.NoiLamViec;
            cmbViTri.Text = tinDTO.ViTri;
            cmbSoLuong.Text = tinDTO.SoLuong.ToString();
            cmbLuong.Text = tinDTO.Luong;
            cmbHinhThucLamViec.Text = tinDTO.LoaiHinhCongViec;
            cmbYeuCauBangCap.Text = tinDTO.TrinhDo;
            cmbYeuCauKinhNghiem.Text = tinDTO.NamKinhNghiem;
            cmbYeuCauGioiTinh.Text = tinDTO.YeuCauGioiTinh;
            rtbMoTaCongViec.Text = tinDTO.MoTaCongViec;
            rtbYeuCauHoSo.Text = tinDTO.YeuCauHoSo;
        }

        private void ThongTinChiTiet_Load(object sender, EventArgs e)
        {
            //hide textbox & combobox & richtextbox
            foreach (Control crl in this.Controls) //get all Panel Controls
            {
                foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                {
                    if (child is TextBox || child is ComboBox  || child is RichTextBox)
                        child.Hide();
                }
            }
            //hide scrollbar
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = true;
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach(Control crl in this.Controls)
            {
                foreach(Control child in crl.Controls)
                {
                    if (child is TextBox || child is ComboBox || child is RichTextBox)
                        child.Hide();
                }
            }
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
            btnXoa.BackColor = Color.FromArgb(215, 35, 35);
            this.Hide();
            this.SendToBack();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(btnXoa.Text == "Xóa")
            {
                string xoa = null;
                xoa = BLL.TinTuyenDung.Tin.XoaTinByMaTin(tinDTO.MaTin);
                if (xoa != null)
                {
                    MessageBox.Show(xoa);
                }
                BLL.TinTuyenDung.Tin.updateTinDaDuyet();
                this.Hide();
                this.SendToBack();
            }
            else if(btnXoa.Text == "Nhập Lại")
            {
                lblTenCongTy.Text = tinDTO.TenCT;
                lblSDT.Text = tinDTO.SdtCT;
                lblDiaChi.Text = tinDTO.DiaChiCT;
                lblTuyen.Text = tinDTO.NganhNghe;
                lblTai.Text = tinDTO.NoiLamViec;
                lblViTri.Text = tinDTO.ViTri;
                lblSoLuong.Text = tinDTO.SoLuong.ToString();
                lblLuong.Text = tinDTO.Luong;
                lblHinhThucLamViec.Text = tinDTO.LoaiHinhCongViec;
                lblYeuCauBangCap.Text = tinDTO.TrinhDo;
                lblYeuCauKinhNghiem.Text = tinDTO.NamKinhNghiem;
                lblYeuCauGioiTinh.Text = tinDTO.YeuCauGioiTinh;
                lblMoTaCongViec.Text = tinDTO.MoTaCongViec;
                lblYeuCauHoSo.Text = tinDTO.YeuCauHoSo;

                txtTenCongTy.Text = tinDTO.TenCT;
                rtbSDT.Text = tinDTO.SdtCT;
                rtbDiaChi.Text = tinDTO.DiaChiCT;
                cmbTuyen.Text = tinDTO.NganhNghe;
                cmbTai.Text = tinDTO.NoiLamViec;
                cmbViTri.Text = tinDTO.ViTri;
                cmbSoLuong.Text = tinDTO.SoLuong.ToString();
                cmbLuong.Text = tinDTO.Luong;
                cmbHinhThucLamViec.Text = tinDTO.LoaiHinhCongViec;
                cmbYeuCauBangCap.Text = tinDTO.TrinhDo;
                cmbYeuCauKinhNghiem.Text = tinDTO.NamKinhNghiem;
                cmbYeuCauGioiTinh.Text = tinDTO.YeuCauGioiTinh;
                rtbMoTaCongViec.Text = tinDTO.MoTaCongViec;
                rtbYeuCauHoSo.Text = tinDTO.YeuCauHoSo;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                //show all textbox, combo,richtext
                foreach (Control crl in this.Controls) //get all Panel Controls
                {
                    foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                    {
                        if (child is TextBox || child is ComboBox || child is RichTextBox)
                            child.Show();
                    }
                }
                btnSua.Text = "Lưu";
                btnXoa.Text = "Nhập Lại";
                btnXoa.BackColor = Color.FromArgb(153, 153, 153);
            }
            else if (btnSua.Text == "Lưu")
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                bool error = false;
                string tb = "";
                foreach (Control crl in this.Controls) //get all Panel Controls
                {
                    foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                    {
                        if (child is TextBox && child.Text == "")
                            error = true;
                        if (child is RichTextBox && child.Text == "")
                            error = true;
                        if (child is ComboBox && child.Text == "")
                            error = true;
                    }
                }
                if (!error)
                {
                    tinDTO.TenCT = txtTenCongTy.Text;
                    tinDTO.SdtCT = rtbSDT.Text;
                    tinDTO.DiaChiCT = rtbDiaChi.Text;
                    tinDTO.NganhNghe = cmbTuyen.Text;
                    tinDTO.ViTri = cmbViTri.Text;
                    tinDTO.NoiLamViec = cmbTai.Text;
                    tinDTO.Luong = cmbLuong.Text;
                    tinDTO.SoLuong = Convert.ToInt32(cmbSoLuong.Text);
                    tinDTO.LoaiHinhCongViec = cmbHinhThucLamViec.Text;
                    tinDTO.TrinhDo = cmbYeuCauBangCap.Text;
                    tinDTO.NamKinhNghiem = cmbYeuCauKinhNghiem.Text;
                    tinDTO.YeuCauGioiTinh = cmbYeuCauGioiTinh.Text;
                    tinDTO.MoTaCongViec = rtbMoTaCongViec.Text;
                    tinDTO.YeuCauHoSo = rtbYeuCauHoSo.Text;
                    tb = BLL.TinTuyenDung.Tin.Update(tinDTO);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    MessageBox.Show(tb);
                    if (tb == "Lưu Thành Công")
                    {
                        
                        ThongTinChiTiet_Load(sender, e);
                        loadTin(tinDTO);

                    }
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    btnXoa.BackColor = Color.FromArgb(210, 35, 35);
                }
                else
                    MessageBox.Show("Nhập đủ tt");
            }
        }

        private void rtbDiaChi_TextChanged(object sender, EventArgs e)
        {
            rtbDiaChi.Height = (rtbDiaChi.GetLineFromCharIndex(rtbDiaChi.Text.Length) + 2) * rtbDiaChi.Font.Height + rtbDiaChi.Margin.Vertical + 5;
        }
        private void rtbSDT_TextChanged(object sender, EventArgs e)
        {
            rtbSDT.Height = (rtbSDT.GetLineFromCharIndex(rtbSDT.Text.Length) + 2) * rtbSDT.Font.Height + rtbSDT.Margin.Vertical + 5;
        }
        private void rtbMoTaCongViec_TextChanged(object sender, EventArgs e)
        {
            rtbMoTaCongViec.Height = (rtbMoTaCongViec.GetLineFromCharIndex(rtbMoTaCongViec.Text.Length) + 2) * rtbMoTaCongViec.Font.Height + rtbMoTaCongViec.Margin.Vertical + 5;
        }

        private void rtbYeuCauHoSo_TextChanged(object sender, EventArgs e)
        {
            rtbYeuCauHoSo.Height = (rtbYeuCauHoSo.GetLineFromCharIndex(rtbYeuCauHoSo.Text.Length) + 2) * rtbYeuCauHoSo.Font.Height + rtbYeuCauHoSo.Margin.Vertical + 5;
        }

        private void cmbTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTuyen.Text != "")
            {
                if (cmbTuyen.Text[0] == '*')
                    this.BeginInvoke((MethodInvoker)delegate { cmbTuyen.Text = ""; });
                else
                    this.BeginInvoke((MethodInvoker)delegate { cmbTuyen.Text = cmbTuyen.Text.Trim(); });
            }
        }
        
    }
}
