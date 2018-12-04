namespace GUI.Tim_Kiem
{
    partial class TimKiem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNguoi = new System.Windows.Forms.RadioButton();
            this.rdoViec = new System.Windows.Forms.RadioButton();
            this.cmbNamKinhNghiem = new System.Windows.Forms.ComboBox();
            this.cmbLuong = new System.Windows.Forms.ComboBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cmbNoiLamViec = new System.Windows.Forms.ComboBox();
            this.cmbTrinhDo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNganhNghe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLoaiHinhCongViec = new System.Windows.Forms.ComboBox();
            this.ketQuaTimKiem_TuyenDung = new GUI.Tim_Kiem.Tuyen_Dung.KetQuaTimKiem_TuyenDung();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ketQuaTimKiem_TimViec = new GUI.Tim_Kiem.Tim_Viec.KetQuaTimKiem_TimViec();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 30);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm Kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.BackColor = System.Drawing.Color.DimGray;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(320, 450);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 40);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rdoNguoi);
            this.groupBox1.Controls.Add(this.rdoViec);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(215, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm";
            // 
            // rdoNguoi
            // 
            this.rdoNguoi.AutoSize = true;
            this.rdoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNguoi.Location = new System.Drawing.Point(222, 32);
            this.rdoNguoi.Name = "rdoNguoi";
            this.rdoNguoi.Size = new System.Drawing.Size(63, 21);
            this.rdoNguoi.TabIndex = 0;
            this.rdoNguoi.TabStop = true;
            this.rdoNguoi.Text = "Người";
            this.rdoNguoi.UseVisualStyleBackColor = true;
            // 
            // rdoViec
            // 
            this.rdoViec.AutoSize = true;
            this.rdoViec.Checked = true;
            this.rdoViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoViec.Location = new System.Drawing.Point(91, 32);
            this.rdoViec.Name = "rdoViec";
            this.rdoViec.Size = new System.Drawing.Size(53, 21);
            this.rdoViec.TabIndex = 0;
            this.rdoViec.TabStop = true;
            this.rdoViec.Text = "Việc";
            this.rdoViec.UseVisualStyleBackColor = true;
            // 
            // cmbNamKinhNghiem
            // 
            this.cmbNamKinhNghiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbNamKinhNghiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamKinhNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamKinhNghiem.FormattingEnabled = true;
            this.cmbNamKinhNghiem.Items.AddRange(new object[] {
            "Tất Cả",
            "<1 năm",
            "1 năm",
            "2 năm",
            "3 năm",
            "4 năm",
            "5 năm",
            "6 năm",
            ">6 năm"});
            this.cmbNamKinhNghiem.Location = new System.Drawing.Point(341, 301);
            this.cmbNamKinhNghiem.Name = "cmbNamKinhNghiem";
            this.cmbNamKinhNghiem.Size = new System.Drawing.Size(192, 24);
            this.cmbNamKinhNghiem.TabIndex = 12;
            // 
            // cmbLuong
            // 
            this.cmbLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLuong.FormattingEnabled = true;
            this.cmbLuong.Items.AddRange(new object[] {
            "Tất cả",
            "Thương lượng",
            "Cạnh tranh",
            "Dưới 1 Triệu",
            "1 Triệu - 3 Triệu",
            "3 Triệu - 5 Triệu",
            "5 Triệu - 7 Triệu",
            "7 Triệu - 10 Triệu",
            "10 Triệu - 12 Triệu",
            "12 Triệu - 15 Triệu",
            "15 Triệu - 20 Triệu",
            "20 Triệu - 25 Triệu",
            "25 Triệu - 30 Triệu",
            "Trên 30 Triệu"});
            this.cmbLuong.Location = new System.Drawing.Point(341, 385);
            this.cmbLuong.Name = "cmbLuong";
            this.cmbLuong.Size = new System.Drawing.Size(192, 24);
            this.cmbLuong.TabIndex = 13;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không yêu cầu giới tính"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(341, 342);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(192, 24);
            this.cmbGioiTinh.TabIndex = 14;
            // 
            // cmbNoiLamViec
            // 
            this.cmbNoiLamViec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbNoiLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoiLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNoiLamViec.FormattingEnabled = true;
            this.cmbNoiLamViec.Items.AddRange(new object[] {
            "Tất Cả",
            "Hà Nội",
            "TP HCM",
            "Biên Hòa",
            "Buôn Ma Thuật",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Huế",
            "Nha Trang",
            "Vinh"});
            this.cmbNoiLamViec.Location = new System.Drawing.Point(341, 216);
            this.cmbNoiLamViec.Name = "cmbNoiLamViec";
            this.cmbNoiLamViec.Size = new System.Drawing.Size(192, 24);
            this.cmbNoiLamViec.TabIndex = 15;
            // 
            // cmbTrinhDo
            // 
            this.cmbTrinhDo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrinhDo.FormattingEnabled = true;
            this.cmbTrinhDo.Items.AddRange(new object[] {
            "Tất Cả Trình Độ",
            "Trên Đại Học",
            "Đại Học",
            "Cao Đẳng",
            "Trung Cấp",
            "Trung Học",
            "Khác"});
            this.cmbTrinhDo.Location = new System.Drawing.Point(341, 256);
            this.cmbTrinhDo.Name = "cmbTrinhDo";
            this.cmbTrinhDo.Size = new System.Drawing.Size(192, 24);
            this.cmbTrinhDo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lương";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Năm kinh nghiệm";
            // 
            // cmbNganhNghe
            // 
            this.cmbNganhNghe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbNganhNghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNganhNghe.FormattingEnabled = true;
            this.cmbNganhNghe.Items.AddRange(new object[] {
            "Tất Cả Ngành Nghề",
            "*IT - Phần Mềm",
            "                Lập Trình Viên .NET",
            "                Lập Trình Viên C/C++",
            "                Lập Trình Viên Frontend",
            "*IT - Phần Cứng",
            "                HelpDesk",
            "                Lắp Đặt",
            "*Hành Chính - Văn Phòng",
            "                Kế Toán",
            "                Tư Vấn Online",
            "                Marketing Online",
            "*Cơ Khí - Chế Tạo",
            "                Vận Hành Máy CNC",
            "                Lắp Ráp Cơ Khí",
            "                Thiết Kế Cơ Khí",
            "*Kiến Trúc",
            "                Thiết Kế Nội Thất",
            "                Giám Sát Công Trình",
            "*Phiên Dịch/Dịch Thuật",
            "                Phiên Dịch/Dịch Thuật Tiếng Trung",
            "                Phiên Dịch/Dịch Thuật Tiếng Anh",
            "                Phiên Dịch/Dịch Thuật Tiếng Hàn",
            "                Phiên Dịch/Dịch Thuật Tiếng Nhật"});
            this.cmbNganhNghe.Location = new System.Drawing.Point(341, 147);
            this.cmbNganhNghe.Name = "cmbNganhNghe";
            this.cmbNganhNghe.Size = new System.Drawing.Size(192, 24);
            this.cmbNganhNghe.TabIndex = 17;
            this.cmbNganhNghe.SelectedIndexChanged += new System.EventHandler(this.cmbNganhNghe_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bằng cấp";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Địa điểm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên công việc";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giới tính";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Loại Hình C. Việc";
            // 
            // cmbLoaiHinhCongViec
            // 
            this.cmbLoaiHinhCongViec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLoaiHinhCongViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHinhCongViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiHinhCongViec.FormattingEnabled = true;
            this.cmbLoaiHinhCongViec.Items.AddRange(new object[] {
            "Tất cả",
            "Fulltime",
            "Parttime",
            "Hợp đồng/Tư vấn",
            "Thực Tập",
            "Khác"});
            this.cmbLoaiHinhCongViec.Location = new System.Drawing.Point(341, 181);
            this.cmbLoaiHinhCongViec.Name = "cmbLoaiHinhCongViec";
            this.cmbLoaiHinhCongViec.Size = new System.Drawing.Size(192, 24);
            this.cmbLoaiHinhCongViec.TabIndex = 15;
            // 
            // ketQuaTimKiem_TuyenDung
            // 
            this.ketQuaTimKiem_TuyenDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ketQuaTimKiem_TuyenDung.BackColor = System.Drawing.Color.White;
            this.ketQuaTimKiem_TuyenDung.Location = new System.Drawing.Point(0, 0);
            this.ketQuaTimKiem_TuyenDung.Name = "ketQuaTimKiem_TuyenDung";
            this.ketQuaTimKiem_TuyenDung.Size = new System.Drawing.Size(738, 561);
            this.ketQuaTimKiem_TuyenDung.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cmbNamKinhNghiem);
            this.panel2.Controls.Add(this.cmbLoaiHinhCongViec);
            this.panel2.Controls.Add(this.cmbNganhNghe);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbNoiLamViec);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbTrinhDo);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.cmbGioiTinh);
            this.panel2.Controls.Add(this.cmbLuong);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 531);
            this.panel2.TabIndex = 22;
            // 
            // ketQuaTimKiem_TimViec
            // 
            this.ketQuaTimKiem_TimViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ketQuaTimKiem_TimViec.BackColor = System.Drawing.Color.White;
            this.ketQuaTimKiem_TimViec.Location = new System.Drawing.Point(0, 0);
            this.ketQuaTimKiem_TimViec.Margin = new System.Windows.Forms.Padding(0);
            this.ketQuaTimKiem_TimViec.Name = "ketQuaTimKiem_TimViec";
            this.ketQuaTimKiem_TimViec.Size = new System.Drawing.Size(738, 561);
            this.ketQuaTimKiem_TimViec.TabIndex = 20;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ketQuaTimKiem_TuyenDung);
            this.Controls.Add(this.ketQuaTimKiem_TimViec);
            this.Name = "TimKiem";
            this.Size = new System.Drawing.Size(738, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNguoi;
        private System.Windows.Forms.RadioButton rdoViec;
        private System.Windows.Forms.ComboBox cmbNamKinhNghiem;
        private System.Windows.Forms.ComboBox cmbLuong;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.ComboBox cmbNoiLamViec;
        private System.Windows.Forms.ComboBox cmbTrinhDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNganhNghe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLoaiHinhCongViec;
        private Tuyen_Dung.KetQuaTimKiem_TuyenDung ketQuaTimKiem_TuyenDung;
        private System.Windows.Forms.Panel panel2;
        private Tim_Viec.KetQuaTimKiem_TimViec ketQuaTimKiem_TimViec;
    }
}
