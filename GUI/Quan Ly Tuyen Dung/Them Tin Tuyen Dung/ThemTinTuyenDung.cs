using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using BLL;
using DTO;
namespace GUI.Quan_Ly_Tuyen_Dung.Them_Tin_Tuyen_Dung
{
    public partial class ThemTinTuyenDung : UserControl
    {
       
        public ThemTinTuyenDung()
        {
            InitializeComponent();
        }
        DTO.TinTuyenDung tinDTO = new DTO.TinTuyenDung();
        

        //ten cong ty chi duoc nhap chu 
        private void txtTenCongTy_TextChanged(object sender, EventArgs e)
        {
            if (txtTenCongTy.Text.Length > 0 && System.Text.RegularExpressions.Regex.IsMatch(txtTenCongTy.Text.ToString(), "[^a-zA-ZáàảãạâấầẩẵậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựÁÀẢÃẠÂẤẦẨẴẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰ ]+$"))
            {
                txtTenCongTy.Text = txtTenCongTy.Text.Remove(txtTenCongTy.TextLength - 1, 1);
                txtTenCongTy.Select(txtTenCongTy.TextLength, 0);
            }
        }
        
        //thay doi kich thuoc cua cac RichTextBox khi nhap nhieu dong
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



        private void ThemTinTuyenDung_Load(object sender, EventArgs e)
        {
            //hide scrollbar
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnNhapLai.Enabled = false;
            bool error = false;
            string addtin = "";
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
            if(!error)
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
                addtin = BLL.TinTuyenDung.Tin.themtintuyendung(tinDTO);
                btnThem.Enabled = true;
                btnNhapLai.Enabled = true;
                MessageBox.Show(addtin);

                btnNhapLai_Click(sender, e);
            }
            else
            {
                btnThem.Enabled = true;
                btnNhapLai.Enabled = true;
                MessageBox.Show("Nhập đầy đủ và chính xác thông tin trước khi Thêm !");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            foreach (Control crl in this.Controls) //get all Panel Controls
            {
                foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                {
                    if (child is TextBox)
                        child.ResetText();
                    if (child is RichTextBox)
                        child.ResetText();
                    if (child is ComboBox)
                    {
                        child.ResetText();
                        (child as ComboBox).SelectedIndex = -1;
                    }
                }
            }
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
