using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI.Quan_Ly_Nguoi_Tim_Viec.Duyet_Tin_Moi
{
    public partial class DuyetTinMoi : UserControl
    {
        public DuyetTinMoi()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DTO.TinTimViec tinDTO = BLL.TinTimViec.Instance.getTinChuaDuyetCuNhat();
            if (tinDTO != null)
            {
                ptbAvatar.Image = Image.FromStream(new MemoryStream(tinDTO.Img));
                lblHoTen.Text = tinDTO.HoTen;
                if (tinDTO.GioiTinh == "M")
                    lblGioiTinh.Text = "Nam";
                if (tinDTO.GioiTinh == "F")
                    lblGioiTinh.Text = "Nữ";
                if (tinDTO.GioiTinh == "O")
                    lblGioiTinh.Text = "Khác";
                lblNgaySinh.Text = Convert.ToDateTime(tinDTO.NgaySinh).ToString("dd-MM-yyyy");
                lblSoDienThoai.Text = tinDTO.SoDienThoai;
                lblEmail.Text = tinDTO.Email;
                lblDiaChi.Text = tinDTO.DiaChi;
                lblNganhNghe.Text = tinDTO.NganhNghe;
                lblSoNamKinhNghiem.Text = tinDTO.NamKinhNghiem;
                lblTrinhDo.Text = tinDTO.TrinhDo;
                lblDiaDiemLamViec.Text = tinDTO.NoiLamViec;
                lblViTriMongMuon.Text = tinDTO.ViTri;
                lblLoaiHinhCongViec.Text = tinDTO.LoaiHinhCongViec;
                lblMucLuongMongMuon.Text = tinDTO.Luong;
                blankUserControl.SendToBack();
                blankUserControl.Height = panel1.Height + panel2.Height + panel3.Height;
            }
            else
            {
                blankUserControl.BringToFront();
            }
        }
        private void DuyetTinMoi_Load()
        {
            LoadData();

            //hide scroll bar
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string msg = "";
            //msg = tin.DuyetTin();
            msg = BLL.TinTimViec.Instance.DuyetTin();
            if (msg != "")
                MessageBox.Show(msg);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg = BLL.TinTimViec.Instance.XoaTin();
            if (msg != "")
                MessageBox.Show(msg);
            LoadData();
        }

        public void Active()
        {
            if (BLL.TinTimViec.Instance.KiemTraKetNoi() != "")
                MessageBox.Show(BLL.TinTimViec.Instance.KiemTraKetNoi());
            else
                DuyetTinMoi_Load();
        }

        private void DuyetTinMoi_Resize(object sender, EventArgs e)
        {
            foreach(Control crl in this.Controls)
            {
                crl.Width = this.Width;
            }
        }

    }
}
