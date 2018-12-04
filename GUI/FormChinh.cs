using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormChinh : Form
    {
        DTO.TaiKhoan tk = new DTO.TaiKhoan();
        bool lockStatus = false;

        public FormChinh()
        {
            InitializeComponent();
        }

        public FormChinh(DTO.TaiKhoan taiKhoan)
        {
            tk = taiKhoan;
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            //hide scrollbar
            pnlNavigation.VerticalScroll.Maximum = 0;
            pnlNavigation.AutoScroll = true;

            foreach(UserControl uc in pnlContent.Controls)
            {
                uc.Hide();
            }
            lblTaiKhoan.Text = tk.Acc;
            
            if (tk.IsAdmin)
            {
                lblQuyenTruyCap.Text = "ADMIN";
                
            }
            else
            {
                lblQuyenTruyCap.Text = "Nhân Viên";
                pnlThemXoaTaiKhoan.Hide();
                themXoaTaiKhoan.Hide();
            }
            if (tk.Avatar != null)
                ptbAvatar_TaiKhoan.Image = Image.FromStream(new MemoryStream(tk.Avatar));
            txtMatKhau.Hide();
        }

        //set all ForeColor of Button to RGB(233,213,213)
        private void clearButtonColor()
        {
            Button cpyBtn = new Button();
            foreach (object obj in pnlQuanLyNguoiTimViec.Controls)
            {
                if (obj.GetType() == cpyBtn.GetType())
                {
                    cpyBtn = obj as Button;
                }
                if (cpyBtn.ForeColor == Color.White)
                {
                    cpyBtn.ForeColor = Color.FromArgb(233, 213, 213);
                }
            }
            foreach (object obj in pnlQuanLyTuyenDung.Controls)
            {
                if (obj.GetType() == cpyBtn.GetType())
                {
                    cpyBtn = obj as Button;
                }
                if (cpyBtn.ForeColor == Color.White)
                {
                    cpyBtn.ForeColor = Color.FromArgb(233, 213, 213);
                }
            }
        }
        //set sender as button is Holderbutton 
        private void setHolderButton(object sender)
        {
            Button holderButton = sender as Button;
            clearButtonColor();
            holderButton.ForeColor = Color.White;

        }
        
        private void btnThemNguoiTimViec_Click(object sender, EventArgs e)
        {
            
            themNguoiTimViec.Show();
            themNguoiTimViec.BringToFront();
            pnlContent.Select();
            setHolderButton(sender);
            //themNguoiTimViec.Update();
        }

        private void btnDuyetTinMoi_TimViec_Click(object sender, EventArgs e)
        {
            duyetTinMoi_TimViec.Show();
            duyetTinMoi_TimViec.BringToFront();
            setHolderButton(sender);
            duyetTinMoi_TimViec.Active();

        }

        private void btnQuanLyTinDaDuyet_TimViec_Click(object sender, EventArgs e)
        {
            quanLyTinDaDuyet_TimViec.Show();
            quanLyTinDaDuyet_TimViec.BringToFront();
            setHolderButton(sender);
            quanLyTinDaDuyet_TimViec.Active(sender, e);
        }

        private void btnThemTinTuyenDung_Click(object sender, EventArgs e)
        {
            themTinTuyenDung.Show();
            themTinTuyenDung.BringToFront();
            setHolderButton(sender);

        }

        private void btnDuyetTinMoi_TuyenDung_Click(object sender, EventArgs e)
        {
            duyetTinMoi_TuyenDung.Show();
            duyetTinMoi_TuyenDung.Active();
            duyetTinMoi_TuyenDung.BringToFront();
            setHolderButton(sender);

        }

        private void btnQuanLyTinDaDuyet_TuyenDung_Click(object sender, EventArgs e)
        {
            quanLyTinDaDuyet_TuyenDung.Show();
            quanLyTinDaDuyet_TuyenDung.Active(sender,e);
            quanLyTinDaDuyet_TuyenDung.BringToFront();
            setHolderButton(sender);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem.Active();
            timKiem.Show();
            timKiem.BringToFront();
            clearButtonColor();
        }

        private void btnThemXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            themXoaTaiKhoan.Show();
            themXoaTaiKhoan.BringToFront();
            clearButtonColor();
        }
        
        private void ptbLock_Click(object sender, EventArgs e)
        {
            //lock all content when pictureBox Lock(ptbLock) is clicked
            if(lockStatus == false)
            {
                ptbLock.Image = Properties.Resources._lock;
                lockStatus = true;
                pnlContent.Enabled = false;
                pnlQuanLyNguoiTimViec.Enabled = false;
                pnlQuanLyTuyenDung.Enabled = false;
                pnlThemXoaTaiKhoan.Enabled = false;
                pnlTimKiem.Enabled = false;
                txtMatKhau.Text = "Nhập mật khẩu cho: " + lblTaiKhoan.Text;
                txtMatKhau.ForeColor = Color.LightGray;
                txtMatKhau.Show();
            }
           
            if (lockStatus == true && txtMatKhau.Text != tk.Pass && txtMatKhau.Text != "Nhập mật khẩu cho: " + lblTaiKhoan.Text)
                txtMatKhau.ForeColor = Color.Red;
            //enable all content when password is correct
            if(lockStatus == true && txtMatKhau.Text == tk.Pass)
            {
                ptbLock.Image = Properties.Resources.unlock;
                lockStatus = false;
                pnlContent.Enabled = true;
                pnlQuanLyNguoiTimViec.Enabled = true;
                pnlQuanLyTuyenDung.Enabled = true;
                pnlThemXoaTaiKhoan.Enabled = true;
                pnlTimKiem.Enabled = true;
                txtMatKhau.Hide();
            }
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FormChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
            txtMatKhau.ForeColor = Color.Black;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.ForeColor = Color.Black;
        }

        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ptbLock_Click(sender, e);
            }
        }

        //dropdown function
        private void btnQuanLyNguoiTimViec_Click(object sender, EventArgs e)
        {
            Int32 maxHeight = 0;
            foreach (Control crl in pnlQuanLyNguoiTimViec.Controls)
                maxHeight += crl.Height;
            if (pnlQuanLyNguoiTimViec.Height >= maxHeight)
            {
                while(pnlQuanLyNguoiTimViec.Height != btnQuanLyNguoiTimViec.Height)
                    pnlQuanLyNguoiTimViec.Height--;
            }
            else
            {
                while(pnlQuanLyNguoiTimViec.Height != maxHeight)
                    pnlQuanLyNguoiTimViec.Height++;
            }
        }
        //dropdown function
        private void btnQuanLyTuyenDung_Click(object sender, EventArgs e)
        {

            Int32 maxHeight = 0;
            foreach (Control crl in pnlQuanLyTuyenDung.Controls)
                maxHeight += crl.Height;
            if (pnlQuanLyTuyenDung.Height >= maxHeight)
            {
                while (pnlQuanLyTuyenDung.Height != btnQuanLyTuyenDung.Height)
                    pnlQuanLyTuyenDung.Height--;
            }
            else
            {
                while (pnlQuanLyTuyenDung.Height != maxHeight)
                    pnlQuanLyTuyenDung.Height++;
            }
        }
    }
}
