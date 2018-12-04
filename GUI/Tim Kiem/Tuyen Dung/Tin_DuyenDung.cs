using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Tim_Kiem.Tuyen_Dung
{
    public partial class Tin_TuyenDung : UserControl
    {
        public Tin_TuyenDung()
        {
            InitializeComponent();
        }

        DTO.TinTuyenDung tinDTO = new DTO.TinTuyenDung();
        private void Tin_Load(object sender, EventArgs e)
        {
            tinDTO = BLL.TinTuyenDung.Tin.getTinByMaTin(this.Name);
            lblMaTin.Text = this.Name;
            lblNganhNghe.Text = tinDTO.NganhNghe;
            lblLoaiHinhCongViec.Text = tinDTO.LoaiHinhCongViec;
            lblTenCT.Text = tinDTO.TenCT;
            lblViTri.Text = tinDTO.ViTri;
            lblSoLuong.Text = Convert.ToString(tinDTO.SoLuong);
            lblLuong.Text = tinDTO.Luong;
            lblNoiLamViec.Text = tinDTO.NoiLamViec;
        }

        private void Tin_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(226, 226, 226);
        }

        private void Tin_MouseLeave(object sender, EventArgs e)
        {
            if (this.GetChildAtPoint(this.PointToClient(Cursor.Position)) == null)
            {
                this.BackColor = Color.White;
            }
        }


    }
}
