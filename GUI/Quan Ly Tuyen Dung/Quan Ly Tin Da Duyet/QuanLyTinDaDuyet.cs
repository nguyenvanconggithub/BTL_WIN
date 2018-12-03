using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Quan_Ly_Tuyen_Dung.Quan_Ly_Tin_Da_Duyet
{
    public partial class QuanLyTinDaDuyet : UserControl
    {
        public QuanLyTinDaDuyet()
        {
            InitializeComponent();
        }
        
        DTO.TinTuyenDung tinDTO = new DTO.TinTuyenDung();
        DataTable dt = new DataTable();
        Int32 tinHienTai = 0;
        Int32 soTinTrenMotTrang = 10;

        private void LoadData()
        {
            Int32 tinMin = tinHienTai;
            Int32 tinMax = tinHienTai + soTinTrenMotTrang;

            dt.Clear();
            dt = BLL.TinTuyenDung.Tin.updateTinDaDuyet();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (Int32 i = tinMin; i < tinMax; i++)
                {
                    if (i > dt.Rows.Count - 1)
                        break;
                    Tin tinUC = new Tin();
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
            thongTinChiTiet.Validated += Active;
            //hide the scroll bar
            flpConten.VerticalScroll.Maximum = 0;
            flpConten.HorizontalScroll.Maximum = 0;
            flpConten.AutoScroll = true;
        }
        private void showDetail(object sender, EventArgs e)
        {
            Tin shortTin = sender as Tin;
            tinDTO = BLL.TinTuyenDung.Tin.getTinByMaTin(shortTin.Name);
            thongTinChiTiet.loadTin(tinDTO);
            thongTinChiTiet.Show();
            thongTinChiTiet.BringToFront();

        }

        private void btnPrePage_Click(object sender, EventArgs e)
        {
            Tin[] controlsToRemove = flpConten.Controls.OfType<Tin>().ToArray();

            if (tinHienTai > soTinTrenMotTrang)
            {
                tinHienTai -= (controlsToRemove.Count() + soTinTrenMotTrang);

                foreach (Tin tin in controlsToRemove)
                {
                    flpConten.Controls.Remove(tin);
                    tin.Dispose();
                }
                LoadData();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            Tin[] controlsToRemove = flpConten.Controls.OfType<Tin>().ToArray();

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
            thongTinChiTiet.Width = this.Width;
            thongTinChiTiet.Height = this.Height;

            foreach(Control crl in flpConten.Controls)
            {
                if (crl is Tin)
                    crl.Width = this.Width - 7;
            }
        }
        public void Active(object sender, EventArgs e)
        {
            Tin[] controlsToRemove = flpConten.Controls.OfType<Tin>().ToArray();

            tinHienTai -= (controlsToRemove.Count());

            foreach (Tin tin in controlsToRemove)
            {
                flpConten.Controls.Remove(tin);
                tin.Dispose();
            }
            
            LoadData();
            flpConten.Select();
        }
    }
}
