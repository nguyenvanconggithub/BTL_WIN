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
    public partial class KetQuaTimKiem_TuyenDung : UserControl
    {
        public KetQuaTimKiem_TuyenDung()
        {
            InitializeComponent();
        }

        DTO.TinTuyenDung tinDTO = new DTO.TinTuyenDung();
        DTO.TinTuyenDung searchInfo = new DTO.TinTuyenDung();
        DataTable dt = new DataTable();
        Int32 tinHienTai = 0;
        Int32 soTinTrenMotTrang = 10;

        private void LoadData()
        {
            Int32 tinMin = tinHienTai;
            Int32 tinMax = tinHienTai + soTinTrenMotTrang;

            dt.Clear();
            dt = BLL.TinTuyenDung.Tin.TimKiem(searchInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (Int32 i = tinMin; i < tinMax; i++)
                {
                    if (i > dt.Rows.Count - 1)
                        break;
                    Tuyen_Dung.Tin_TuyenDung tinUC = new Tin_TuyenDung();
                    tinUC.Click += showDetail;
                    tinUC.Width = flpConten.Width - 7;
                    tinUC.Name = dt.Rows[i]["MaTin"].ToString();
                    flpConten.Controls.Add(tinUC);
                    tinHienTai++;
                }
            }
        }

        private void QuanLyTinDaDuyet_Load(object sender, EventArgs e)
        {
            thongTinChiTiet_TuyenDung.Validated += Active;
            //hide the scroll bar
            flpConten.VerticalScroll.Maximum = 0;
            flpConten.HorizontalScroll.Maximum = 0;
            flpConten.AutoScroll = true;
        }
        private void showDetail(object sender, EventArgs e)
        {
            Tin_TuyenDung shortTin = sender as Tin_TuyenDung;
            
            tinDTO = BLL.TinTuyenDung.Tin.getTinByMaTin(shortTin.Name);
            thongTinChiTiet_TuyenDung.loadTin(tinDTO);
            thongTinChiTiet_TuyenDung.Show();
            thongTinChiTiet_TuyenDung.BringToFront();

        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            Tin_TuyenDung[] controlsToRemove = flpConten.Controls.OfType<Tin_TuyenDung>().ToArray();

            if (tinHienTai > soTinTrenMotTrang)
            {
                tinHienTai -= (controlsToRemove.Count() + soTinTrenMotTrang);

                foreach (Tin_TuyenDung tin in controlsToRemove)
                {
                    flpConten.Controls.Remove(tin);
                    tin.Dispose();
                }
                LoadData();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Tin_TuyenDung[] controlsToRemove = flpConten.Controls.OfType<Tin_TuyenDung>().ToArray();

            if (controlsToRemove.Count() == soTinTrenMotTrang)
            {
                foreach (var crl in controlsToRemove)
                {
                    flpConten.Controls.Remove(crl);
                    crl.Dispose();
                }
                LoadData();
            }
        }

        private void QuanLyTinDaDuyet_Resize(object sender, EventArgs e)
        {
            thongTinChiTiet_TuyenDung.Width = this.Width;
            thongTinChiTiet_TuyenDung.Height = this.Height;

            foreach (Control crl in flpConten.Controls)
            {
                if (crl is Tin_TuyenDung)
                    crl.Width = this.Width - 7;
            }
        }
        public void Active(object sender, EventArgs e)
        {

            Tin_TuyenDung[] controlsToRemove = flpConten.Controls.OfType<Tin_TuyenDung>().ToArray();

            tinHienTai -= (controlsToRemove.Count());

            foreach (Tin_TuyenDung tin in controlsToRemove)
            {
                flpConten.Controls.Remove(tin);
                tin.Dispose();
            }

            thongTinChiTiet_TuyenDung.SendToBack();
            LoadData();
            flpConten.Select();
        }
        public void sendData(DTO.TinTuyenDung search)
        {
            searchInfo = search;
        }

    }
}
