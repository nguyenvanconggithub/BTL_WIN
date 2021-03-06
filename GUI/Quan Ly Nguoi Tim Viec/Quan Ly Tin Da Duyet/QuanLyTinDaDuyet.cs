﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI.Quan_Ly_Nguoi_Tim_Viec.Quan_Ly_Tin_Da_Duyet
{
    public partial class QuanLyTinDaDuyet : UserControl
    {
        public QuanLyTinDaDuyet()
        {
            InitializeComponent();
        }
        DTO.TinTimViec tinDTO = new DTO.TinTimViec();
        DataTable dt = new DataTable();
        Int32 tinHienTai = 0;
        Int32 soTinTrenMotTrang = 10;
        
        private void LoadData()
        {
            Int32 tinMin = tinHienTai;
            Int32 tinMax = tinHienTai + soTinTrenMotTrang;
            dt.Clear();
            dt = BLL.TinTimViec.Instance.UpdateTableDaDuyet();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (Int32 i = tinMin; i < tinMax; i++)
                {
                    if (i > dt.Rows.Count - 1)
                        break;
                    Tin tinUC = new Tin();
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
            thongTinChiTiet.Validated += Active;

            //hide the scroll bar
            ftpContainer.VerticalScroll.Maximum = 0;
            ftpContainer.HorizontalScroll.Maximum = 0;
            ftpContainer.AutoScroll = true;
        }
        //hàm Click Event cho Mỗi Tin
        private void showDetail(object sender, EventArgs e)
        {
            thongTinChiTiet.Show();
            thongTinChiTiet.BringToFront();
            Tin shortTin = sender as Tin;
            tinDTO = BLL.TinTimViec.Instance.getTinByMaTin(shortTin.Name);

            thongTinChiTiet.LoadData(tinDTO);


        }

        private void ftpContainer_Resize(object sender, EventArgs e)
        {
            foreach(Control crl in ftpContainer.Controls)
            {
                crl.Width = ftpContainer.Width -7;
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            Tin[] controlsToRemove = ftpContainer.Controls.OfType<Tin>().ToArray();

            if (tinHienTai > soTinTrenMotTrang)
            { 
                tinHienTai -= (controlsToRemove.Count() + soTinTrenMotTrang);

                foreach (Tin tin in controlsToRemove)
                {
                    ftpContainer.Controls.Remove(tin);
                    tin.Dispose();
                }
                LoadData();
            }

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            var controlsToRemove = ftpContainer.Controls.OfType<Tin>().ToArray();
            
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
            Tin[] controlsToRemove = ftpContainer.Controls.OfType<Tin>().ToArray();

            tinHienTai -= (controlsToRemove.Count());

            foreach (Tin tin in controlsToRemove)
            {
                ftpContainer.Controls.Remove(tin);
                tin.Dispose();
            }
            
            if (BLL.TinTimViec.Instance.KiemTraKetNoi() != "")
                MessageBox.Show(BLL.TinTimViec.Instance.KiemTraKetNoi());
            else
                LoadData();


            ftpContainer.Select();
        }

    }
}
