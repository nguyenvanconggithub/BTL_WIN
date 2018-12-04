using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Tim_Kiem
{
    public partial class TimKiem : UserControl
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(rdoViec.Checked)
            {
                //load tim viec
                DTO.TinTimViec tin = new DTO.TinTimViec();

                tin.NganhNghe = cmbNganhNghe.Text == "" || cmbNganhNghe.Text == "Tất Cả Ngành Nghề" ? "%" : cmbNganhNghe.Text;
                tin.LoaiHinhCongViec = cmbLoaiHinhCongViec.Text == "" || cmbLoaiHinhCongViec.Text == "Tất cả" ? "%" : cmbLoaiHinhCongViec.Text;
                tin.NoiLamViec = cmbNoiLamViec.Text == "" || cmbNoiLamViec.Text == "Tất Cả" ? "%" : cmbNoiLamViec.Text;
                tin.TrinhDo = cmbTrinhDo.Text == "" || cmbTrinhDo.Text == "Tất Cả Trình Độ" ? "%" : cmbTrinhDo.Text;
                tin.NamKinhNghiem = cmbNamKinhNghiem.Text == ""  || cmbNamKinhNghiem.Text == "Tất Cả" ? "%" : cmbNamKinhNghiem.Text;
                tin.GioiTinh = cmbGioiTinh.Text == "" || cmbGioiTinh.Text == "Không yêu cầu giới tính" ? "%" : (cmbGioiTinh.Text == "Nam"? "M" : "F");
                tin.Luong = cmbLuong.Text == "" || cmbLuong.Text == "Tất cả" ? "%" : cmbLuong.Text;

                ketQuaTimKiem_TimViec.sendData(tin);
                ketQuaTimKiem_TimViec.Active(sender, e);
                ketQuaTimKiem_TimViec.BringToFront();
                
            }

            if (rdoNguoi.Checked)
            {
                //load tuyen dung
                DTO.TinTuyenDung tin = new DTO.TinTuyenDung();

                tin.NganhNghe = cmbNganhNghe.Text == "" || cmbNganhNghe.Text == "Tất Cả Ngành Nghề" ? "%" : cmbNganhNghe.Text;
                tin.LoaiHinhCongViec = cmbLoaiHinhCongViec.Text == "" || cmbLoaiHinhCongViec.Text == "Tất cả" ? "%" : cmbLoaiHinhCongViec.Text;
                tin.NoiLamViec = cmbNoiLamViec.Text == "" || cmbNoiLamViec.Text == "Tất Cả" ? "%" : cmbNoiLamViec.Text;
                tin.TrinhDo = cmbTrinhDo.Text == "" || cmbTrinhDo.Text == "Tất Cả Trình Độ" ? "%" : cmbTrinhDo.Text;
                tin.NamKinhNghiem = cmbNamKinhNghiem.Text == "" || cmbNamKinhNghiem.Text == "Tất Cả" ? "%" : cmbNamKinhNghiem.Text;
                tin.YeuCauGioiTinh = cmbGioiTinh.Text == "" || cmbGioiTinh.Text == "Không yêu cầu giới tính" ? "%" : cmbGioiTinh.Text;
                tin.Luong = cmbLuong.Text == "" || cmbLuong.Text == "Tất cả" ? "%" : cmbLuong.Text;

                ketQuaTimKiem_TuyenDung.sendData(tin);
                ketQuaTimKiem_TuyenDung.Active(sender, e);
                ketQuaTimKiem_TuyenDung.BringToFront();
                
            }

        }

        public void Active()
        {
            ketQuaTimKiem_TimViec.SendToBack();
            ketQuaTimKiem_TuyenDung.SendToBack();

            cmbNganhNghe.SelectedIndex = -1;
            cmbLoaiHinhCongViec.SelectedIndex = -1;
            cmbNoiLamViec.SelectedIndex = -1;
            cmbTrinhDo.SelectedIndex = -1;
            cmbNamKinhNghiem.SelectedIndex = -1;
            cmbGioiTinh.SelectedIndex = -1;
            cmbLuong.SelectedIndex = -1;
        }

        private void cmbNganhNghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNganhNghe.Text != "")
            {
                if (cmbNganhNghe.Text[0] == '*')
                    this.BeginInvoke((MethodInvoker)delegate { cmbNganhNghe.Text = ""; });
                else
                    this.BeginInvoke((MethodInvoker)delegate { cmbNganhNghe.Text = cmbNganhNghe.Text.Trim(); });
            }
            
        }
    }
}
