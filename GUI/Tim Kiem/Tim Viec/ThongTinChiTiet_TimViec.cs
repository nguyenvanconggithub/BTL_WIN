﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI.Tim_Kiem.Tim_Viec
{
    public partial class ThongTinChiTiet_TimViec : UserControl
    {
        public ThongTinChiTiet_TimViec()
        {
            InitializeComponent();
        }
        DTO.TinTimViec tinDTO = new DTO.TinTimViec();
        Byte[] oldAvatar = null;
        public void LoadData(DTO.TinTimViec tinInfo)
        {
            tinDTO = tinInfo;
            ptbAvatar.Image = Image.FromStream(new MemoryStream(tinDTO.Img));
            oldAvatar = tinDTO.Img;
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

            txtHoTen.Text = tinDTO.HoTen;
            if (tinDTO.GioiTinh == "M")
                cboGioiTinh.Text = "Nam";
            if (tinDTO.GioiTinh == "F")
                cboGioiTinh.Text = "Nữ";
            if (tinDTO.GioiTinh == "O")
                cboGioiTinh.Text = "Khác";
            dtpNgaySinh.Text = tinDTO.NgaySinh;
            txtDienThoai.Text = tinDTO.SoDienThoai;
            txtEmail.Text = tinDTO.Email;
            rtbDiaChi.Text = tinDTO.DiaChi;
            cboNganhNghe.Text = tinDTO.NganhNghe;
            cboSoNamKinhNghiem.Text = tinDTO.NamKinhNghiem;
            cboTrinhDo.Text = tinDTO.TrinhDo;
            cboDiaDiemLamViec.Text = tinDTO.NoiLamViec;
            cboViTriMongMuon.Text = tinDTO.ViTri;
            cboLoaiHinhCongViec.Text = tinDTO.LoaiHinhCongViec;
            cboMucLuongMongMuon.Text = tinDTO.Luong;
        }
        private void ThongTinChiTiet_Load(object sender, EventArgs e)
        {
            //hide textbox & combobox & datetimePick
            foreach (Control crl in this.Controls) //get all Panel Controls
            {
                foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                {
                    if (child is TextBox || child is ComboBox || child is DateTimePicker || child is RichTextBox)
                        child.Hide();
                }
            }

            //hide scrollbar
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //hide textbox & combobox & datetimePick
            foreach (Control crl in this.Controls) //get all Panel Controls
            {
                foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                {
                    if (child is TextBox || child is ComboBox || child is DateTimePicker || child is RichTextBox)
                        child.Hide();
                }
            }
            btnSua.Text = "Sửa";
            btnXoa.Text = "Xóa";
            btnXoa.BackColor = Color.FromArgb(215, 35, 35);
            this.Hide();
            this.SendToBack();
        }
        //This Function is Xóa AND Nhập lại
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                string msg = "";
                msg = BLL.TinTimViec.Instance.XoaMaTin(tinDTO.MaTin);
                MessageBox.Show(msg);
                this.Hide();
                this.SendToBack();

            }//Else Button is Nhập Lại
            else
            {
                lblHoTen.Text = tinDTO.HoTen;
                ptbAvatar.Image = Image.FromStream(new MemoryStream(oldAvatar));
                lblGioiTinh.Text = tinDTO.GioiTinh;
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

                txtHoTen.Text = tinDTO.HoTen;
                if (tinDTO.GioiTinh == "M")
                    cboGioiTinh.Text = "Nam";
                else if (tinDTO.GioiTinh == "F")
                    cboGioiTinh.Text = "Nữ";
                else
                    cboGioiTinh.Text = "Khác";
                txtDienThoai.Text = tinDTO.SoDienThoai;
                txtEmail.Text = tinDTO.Email;
                rtbDiaChi.Text = tinDTO.DiaChi;
                cboNganhNghe.Text = tinDTO.NganhNghe;
                cboSoNamKinhNghiem.Text = tinDTO.NamKinhNghiem;
                cboTrinhDo.Text = tinDTO.TrinhDo;
                cboDiaDiemLamViec.Text = tinDTO.NoiLamViec;
                cboViTriMongMuon.Text = tinDTO.ViTri;
                cboLoaiHinhCongViec.Text = tinDTO.LoaiHinhCongViec;
                cboMucLuongMongMuon.Text = tinDTO.Luong;
            }

        }
        //This function for Sửa AND Lưu
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                //show all textbox, combo,datepick,richtext
                foreach (Control crl in this.Controls) //get all Panel Controls
                {
                    foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                    {
                        if (child is TextBox || child is ComboBox || child is DateTimePicker || child is RichTextBox)
                            child.Show();
                    }
                }
                btnSua.Text = "Lưu";
                btnXoa.Text = "Nhập lại";
                btnXoa.BackColor = Color.FromArgb(153, 153, 153);
            }
            else // Else Button is Lưu
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                bool error = false;
                string message = "";
                foreach (Control crl in this.Controls) //get all Panel Controls
                {
                    foreach (Control child in crl.Controls) //get all Controls in Panel Controls
                    {
                        if (child is TextBox && child.Text == "")
                            error = true;
                        if (child is ComboBox && child.Text == "")
                            error = true;
                    }
                }
                if (txtEmail.ForeColor == Color.Red)
                    error = true;
                if (!error)
                {
                    tinDTO.HoTen = txtHoTen.Text;
                    //tinDTO.Img is Updated at ptbAvatar_Click() Event;
                    tinDTO.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                    if (cboGioiTinh.Text == "Nam")
                        tinDTO.GioiTinh = "M";
                    else if (cboGioiTinh.Text == "Nữ")
                        tinDTO.GioiTinh = "F";
                    else
                        tinDTO.GioiTinh = "O";
                    tinDTO.SoDienThoai = txtDienThoai.Text;
                    tinDTO.Email = txtEmail.Text;
                    tinDTO.DiaChi = rtbDiaChi.Text;
                    tinDTO.NganhNghe = cboNganhNghe.Text;
                    tinDTO.NamKinhNghiem = cboSoNamKinhNghiem.Text;
                    tinDTO.TrinhDo = cboTrinhDo.Text;
                    tinDTO.NoiLamViec = cboDiaDiemLamViec.Text;
                    tinDTO.ViTri = cboViTriMongMuon.Text;
                    tinDTO.LoaiHinhCongViec = cboLoaiHinhCongViec.Text;
                    tinDTO.Luong = cboMucLuongMongMuon.Text;
                    message = BLL.TinTimViec.Instance.UpDate(tinDTO);
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    MessageBox.Show(message);
                    if (message == "Lưu Thành Công")
                    {
                        ThongTinChiTiet_Load(sender, e);
                        LoadData(tinDTO);
                    }
                    btnSua.Text = "Sửa";
                    btnXoa.Text = "Xóa";
                    btnXoa.BackColor = Color.FromArgb(210, 35, 35);

                }
                else
                {
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    MessageBox.Show("Nhập đầy đủ và chính xác thông tin trước khi Thêm !");
                }
            }

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 0
                && System.Text.RegularExpressions.Regex.IsMatch(txtHoTen.Text.ToString(), "[^a-zA-ZáàảãạâấầẩẵậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựÁÀẢÃẠÂẤẦẨẴẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰ ]+$"))
            {
                txtHoTen.Text = txtHoTen.Text.Remove(txtHoTen.TextLength - 1, 1);
                txtHoTen.Select(txtHoTen.TextLength, 0);
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoai.Text.Length > 0
                && System.Text.RegularExpressions.Regex.IsMatch(txtDienThoai.Text.ElementAt(txtDienThoai.Text.Length - 1).ToString(), "[^0-9]"))
            {
                txtDienThoai.Text = txtDienThoai.Text.Remove(txtDienThoai.TextLength - 1, 1);
                txtDienThoai.Select(txtDienThoai.TextLength, 0);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0
               && !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.ToString(), @"[a-zA-Z0-9_\.]@[a-zA-Z0-9]{2,}(\.[a-zA-Z0-9]{2,4}){1,2}$"))
            {
                txtEmail.ForeColor = Color.Red;
            }
        }

        private void rtbDiaChi_TextChanged(object sender, EventArgs e)
        {
            rtbDiaChi.Height = (rtbDiaChi.GetLineFromCharIndex(rtbDiaChi.Text.Length) + 2) *
                          rtbDiaChi.Font.Height + rtbDiaChi.Margin.Vertical + 5;
        }

        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            try
            {
                openFile.Filter = "Bitmap(*.bmp;*.dib) |*.bmp;*.dib " +
                                  "| JPEG(*.jpg;*.jpeg;*.jpe;*.jfif) | *.jpg;*.jpeg;*.jpe;*.jfif " +
                                  "| GIF(*.gif) | *.gif " +
                                  "| TIFF(*.tif;*.tiff) | *.tif;*.tiff" +
                                  "| PNG(*.png) | *.png" +
                                  "| ICO(*.ico) | *.ico" +
                                  "| All Picture Files |*.bmp;*.dib;*.jpg;*.jpeg;*.jpe;*.jfif;*.gif;*.tif;*.tiff;*.png;*.ico" +
                                  "| All Files | *.*";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Image img = new Bitmap(openFile.FileName);
                    MemoryStream memoryStream = new MemoryStream();
                    img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tinDTO.Img = memoryStream.ToArray();
                    ptbAvatar.Image = img;
                    if (tinDTO.Img.Length > 1000000) // >1MB = 1000 000 Bytes
                    {
                        ptbAvatar.Image = Properties.Resources.image_PictureBox;
                        MessageBox.Show("Chọn ảnh nhỏ hơn 1MB !");
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(openFile.FileName.ToString() + "\nFILE vừa chọn không phải là ảnh hoặc định dạng ảnh chưa được hỗ trợ.", "Error Box", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void cboNganhNghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNganhNghe.Text != "")
            {
                if (cboNganhNghe.Text[0] == '*')
                    this.BeginInvoke((MethodInvoker)delegate { cboNganhNghe.Text = ""; });
                else
                    this.BeginInvoke((MethodInvoker)delegate { cboNganhNghe.Text = cboNganhNghe.Text.Trim(); });
            }
        }
    }
}
