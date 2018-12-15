using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Tim_Kiem.Tim_Viec
{
    public partial class KetQuaTimKiem_TimViec : UserControl
    {
        public KetQuaTimKiem_TimViec()
        {
            InitializeComponent();
        }
        DTO.TinTimViec searchInfo = new DTO.TinTimViec();
        DTO.TinTimViec tinDTO = new DTO.TinTimViec();
        DataTable dt = new DataTable();
        Int32 tinHienTai = 0;
        Int32 soTinTrenMotTrang = 10;

        private void LoadData()
        {
            Int32 tinMin = tinHienTai;
            Int32 tinMax = tinHienTai + soTinTrenMotTrang;
            dt.Clear();
            dt = BLL.TinTimViec.Instance.getTableFollowSearch(searchInfo);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (Int32 i = tinMin; i < tinMax; i++)
                {
                    if (i > dt.Rows.Count - 1)
                        break;
                    Tin_TimViec tinUC = new Tin_TimViec();
                    tinUC.Click += showDetail;
                    tinUC.Width = ftpContainer.Width - 7;
                    tinUC.Name = dt.Rows[i]["MaTin"].ToString();
                    ftpContainer.Controls.Add(tinUC);
                    tinHienTai++;
                }
            }
        }
        private void QuanLyTinDaDuyet_Load(object sender, EventArgs e)
        {
            thongTinChiTiet_TimViec.Validated += Active;

            //hide the scroll bar
            ftpContainer.VerticalScroll.Maximum = 0;
            ftpContainer.HorizontalScroll.Maximum = 0;
            ftpContainer.AutoScroll = true;
        }
        //hàm Click Event cho Mỗi Tin
        private void showDetail(object sender, EventArgs e)
        {
            thongTinChiTiet_TimViec.Show();
            thongTinChiTiet_TimViec.BringToFront();
            Tin_TimViec shortTin = sender as Tin_TimViec;
            tinDTO = BLL.TinTimViec.Instance.getTinByMaTin(shortTin.Name);

            thongTinChiTiet_TimViec.LoadData(tinDTO);


        }

        private void ftpContainer_Resize(object sender, EventArgs e)
        {
            foreach (Control crl in ftpContainer.Controls)
            {
                crl.Width = ftpContainer.Width - 7;
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            Tin_TimViec[] controlsToRemove = ftpContainer.Controls.OfType<Tin_TimViec>().ToArray();

            if (tinHienTai > soTinTrenMotTrang)
            {
                tinHienTai -= (controlsToRemove.Count() + soTinTrenMotTrang);

                foreach (Tin_TimViec tin in controlsToRemove)
                {
                    ftpContainer.Controls.Remove(tin);
                    tin.Dispose();
                }
                LoadData();
            }

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            var controlsToRemove = ftpContainer.Controls.OfType<Tin_TimViec>().ToArray();

            if (controlsToRemove.Count() == soTinTrenMotTrang)
            {
                foreach (var crl in controlsToRemove)
                {
                    ftpContainer.Controls.Remove(crl);
                    crl.Dispose();
                }
                LoadData();

            }
        }
        //Call Active at FormChinh to UpdateData
        public void Active(object sender, EventArgs e)
        {
            Tin_TimViec[] controlsToRemove = ftpContainer.Controls.OfType<Tin_TimViec>().ToArray();

            tinHienTai -= (controlsToRemove.Count());

            foreach (Tin_TimViec tin in controlsToRemove)
            {
                ftpContainer.Controls.Remove(tin);
                tin.Dispose();
            }

            if (BLL.TinTimViec.Instance.KiemTraKetNoi() != "")
                MessageBox.Show(BLL.TinTimViec.Instance.KiemTraKetNoi());
            else
                LoadData();

            thongTinChiTiet_TimViec.SendToBack();
            ftpContainer.Select();
        }

        public void sendData(DTO.TinTimViec search)
        {
            searchInfo = search;
        }

    }
}
