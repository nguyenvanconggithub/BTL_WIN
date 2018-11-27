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
    public partial class Tin : UserControl
    {
        public Tin()
        {
            InitializeComponent();
        }
        BLL.TinTimViec tin = new BLL.TinTimViec();
        DTO.TinTimViec tinDTO = new DTO.TinTimViec();

        private void Tin_Load(object sender, EventArgs e)
        {
            try
            {
                tinDTO = tin.getTinByMaTin(this.Name);
                lblMaTin.Text = this.Name;
                lblNganhNghe.Text = tinDTO.NganhNghe;
                lblLoaiHinhCongViec.Text = tinDTO.LoaiHinhCongViec;
                lblViTri.Text = tinDTO.ViTri;
                if (tinDTO.GioiTinh == "M")
                    lblGioiTinh.Text = "Nam";
                if (tinDTO.GioiTinh == "F")
                    lblGioiTinh.Text = "Nữ";
                if (tinDTO.GioiTinh == "O")
                    lblGioiTinh.Text = "GT Khác";
                lblTuoi.Text = (DateTime.Now.Year - Convert.ToDateTime(tinDTO.NgaySinh).Year).ToString() + " Tuổi";
                lblTrinhDo.Text = tinDTO.TrinhDo;
                lblKinhNghiem.Text = tinDTO.NamKinhNghiem;
                lblLuong.Text = tinDTO.Luong;
                lblNoiLamViec.Text = tinDTO.NoiLamViec;
            }
            catch(Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
        }

        private void Tin_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(226, 226, 226);
        }

        private void Tin_MouseLeave(object sender, EventArgs e)
        {
            //Trỏ vào Items bên trong Tin ko bị mất Mouse_Enter()
            if (this.GetChildAtPoint(this.PointToClient(Cursor.Position)) == null)
            {
                this.BackColor = Color.White;
            }
        }
    }
}
