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
        BLL.TinTimViec tin = new BLL.TinTimViec();
        private void LoadData()
        {
            DTO.TinTimViec tinDTO = tin.getTinChuaDuyetCuNhat();
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
        private void DuyetTinMoi_Load(object sender,EventArgs e)
        {
            LoadData();

            //hide scroll bar
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg = tin.DuyetTin();
            if (msg != "")
                MessageBox.Show(msg);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg = tin.XoaTin();
            if (msg != "")
                MessageBox.Show(msg);
            LoadData();
        }

        public void Active()
        {
            LoadData();
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
