using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GUI.Quan_Ly_Nguoi_Tim_Viec.Them_Nguoi_Tim_Viec
{
    public partial class ThemNguoiTimViec : UserControl
    {
        public ThemNguoiTimViec()
        {
            InitializeComponent();
        }
        BLL.TinTimViec tin = new BLL.TinTimViec();
        DTO.TinTimViec tinDTO = new DTO.TinTimViec();
        //txtDienThoai chi chap nhan so 0-9
        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txtDienThoai.Text.Length > 0
                && System.Text.RegularExpressions.Regex.IsMatch(txtDienThoai.Text.ElementAt(txtDienThoai.Text.Length - 1).ToString(), "[^0-9]"))
            {
                txtDienThoai.Text = txtDienThoai.Text.Remove(txtDienThoai.TextLength - 1, 1);
                txtDienThoai.Select(txtDienThoai.TextLength, 0);
            }
        }
        //txtEmail màu đỏ nếu sai định dạng
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0
                && !System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text.ToString(), @"[a-zA-Z0-9_\.]@[a-zA-Z0-9]{2,}(\.[a-zA-Z0-9]{2,4}){1,2}$"))
            {
                txtEmail.ForeColor = Color.Red;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
        }

        //Họ Tên KO chấp nhận ký tự hoặc số
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if(txtHoTen.Text.Length > 0
                && System.Text.RegularExpressions.Regex.IsMatch(txtHoTen.Text.ToString(), "[^a-zA-ZáàảãạâấầẩẵậăắằẳẵặđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợuúùủũụưứừửữựÁÀẢÃẠÂẤẦẨẴẬĂẮẰẲẴẶĐÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢUÚÙỦŨỤƯỨỪỬỮỰ ]+$"))
            {
                txtHoTen.Text = txtHoTen.Text.Remove(txtHoTen.TextLength - 1, 1);
                txtHoTen.Select(txtHoTen.TextLength, 0);
            }
        }
        //Thay đổi kích thướcc rtbĐịaChỉ khi nhập nhiều dòng
        private void rtbDiaChi_TextChanged(object sender, EventArgs e)
        {
            rtbDiaChi.Height = (rtbDiaChi.GetLineFromCharIndex(rtbDiaChi.Text.Length) + 2) *
                          rtbDiaChi.Font.Height + rtbDiaChi.Margin.Vertical + 5;
        }

        private void ThemNguoiTimViec_Load(object sender, EventArgs e)
        {
            //đặt ảnh mặc định (nếu ko chọn ảnh)
            Image img = new Bitmap(ptbAvatar.Image);
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            tinDTO.Img = memoryStream.ToArray();

            //hide the scrollbar
            this.VerticalScroll.Maximum = 0;
            this.AutoScroll = true;
        }

        
        //Chọn ảnh và lưu ảnh (Byte[]) vào DTO.TinTimViec
        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
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
            catch(Exception)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnNhapLai.Enabled = false;
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
                tinDTO.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                if (rboNam.Checked)
                    tinDTO.GioiTinh = "M";
                else if (rboNu.Checked)
                    tinDTO.GioiTinh = "F";
                else
                    tinDTO.GioiTinh = "O";
                tinDTO.SoDienThoai = txtDienThoai.Text;
                tinDTO.Email = txtEmail.Text;
                tinDTO.DiaChi = rtbDiaChi.Text;
                tinDTO.NganhNghe = cboNganhNghe.Text;
                tinDTO.NamKinhNghiem = cboNamKinhNghiem.Text;
                tinDTO.TrinhDo = cboTrinhDo.Text;
                tinDTO.NoiLamViec = cboNoiLamViec.Text;
                tinDTO.ViTri = cboViTri.Text;
                tinDTO.LoaiHinhCongViec = cboLoaiHinhCongViec.Text;
                tinDTO.Luong = cboLuong.Text;
                message = tin.Insert(tinDTO);
                btnThem.Enabled = true;
                btnNhapLai.Enabled = true;
                MessageBox.Show(message);
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
            foreach(Control crl in this.Controls) //get all Panel Controls
            {
                foreach(Control child in crl.Controls) //get all Controls in Panel Controls
                {
                    if (child is TextBox)
                        child.ResetText();
                    if (child is ComboBox)
                    {
                        child.ResetText();
                        (child as ComboBox).SelectedIndex = -1;
                    }
                }
            }
            rboNam.Checked = true;
            ptbAvatar.Image = Properties.Resources.image_PictureBox;
            Image img = new Bitmap(ptbAvatar.Image);
            MemoryStream memoryStream = new MemoryStream();
            img.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            tinDTO.Img = memoryStream.ToArray();
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
