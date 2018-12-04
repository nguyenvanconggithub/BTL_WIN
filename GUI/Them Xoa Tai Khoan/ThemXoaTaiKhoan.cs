using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BLL;
using System.IO;

namespace GUI.Them_Xoa_Tai_Khoan
{
    public partial class ThemXoaTaiKhoan : UserControl
    {
        public ThemXoaTaiKhoan()
        {
            InitializeComponent();

        }
        DTO.TaiKhoan tk = new TaiKhoan();
        DataTable dt = new DataTable();
        private void ThemXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            
            dt = TaiKhoanBLL.Instance.getAccount();
            dgvShow.DataSource = dt;
            
            dgvShow.Columns["isAdmin"].Visible = false;
            dgvShow.Columns["Avatar"].Visible = false;

        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            if (txtAcc.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
            }
            else
                try
                {
                    tk.Acc = txtAcc.Text;
                    tk.Pass = txtPass.Text;
                    Byte[] imgArr = new Byte[1000000];
                    Image img = new Bitmap(ptbAvatar.Image);
                    MemoryStream memStream = new MemoryStream();
                    img.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imgArr = memStream.ToArray();

                    tk.Avatar = imgArr;

                    TaiKhoanBLL.Instance.addAccount(tk);
                    ThemXoaTaiKhoan_Load(sender, e);

                    ptbAvatar.Image = Properties.Resources.image_PictureBox;
                    txtAcc.Text = "";
                    txtPass.Text = "";
                }
                catch (Exception er)
                {
                    MessageBox.Show("Trùng Tài Khoản");
                } 
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            if(vt > -1)
            {
                txtAcc.Text = dgvShow.Rows[vt].Cells[0].Value.ToString();
                txtPass.Text = dgvShow.Rows[vt].Cells[1].Value.ToString();
                if(!DBNull.Value.Equals(dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["Avatar"].Value))
                    ptbAvatar.Image = Image.FromStream(new MemoryStream((Byte[])dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["Avatar"].Value));
                else
                    ptbAvatar.Image = Properties.Resources.image_PictureBox;
            }
           
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAcc.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn tài khoản xóa");
                }
                else
                {

                    tk.Acc = txtAcc.Text;
                    tk.Pass = txtPass.Text;
                    TaiKhoanBLL.Instance.delAccount(tk);
                    MessageBox.Show("Xóa thành công");
                    ThemXoaTaiKhoan_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Error!!!");
            }
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
                    tk.Avatar = memoryStream.ToArray();
                    ptbAvatar.Image = img;
                    if (tk.Avatar.Length > 1000000) // >1MB = 1000 000 Bytes
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
    }
}
