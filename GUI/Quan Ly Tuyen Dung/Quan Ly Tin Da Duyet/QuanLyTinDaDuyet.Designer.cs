namespace GUI.Quan_Ly_Tuyen_Dung.Quan_Ly_Tin_Da_Duyet
{
    partial class QuanLyTinDaDuyet
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
            this.flpConten = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuanLyTinDaDuyet = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.thongTinChiTiet = new GUI.Quan_Ly_Tuyen_Dung.Quan_Ly_Tin_Da_Duyet.ThongTinChiTiet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpConten
            // 
            this.flpConten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpConten.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpConten.Location = new System.Drawing.Point(0, 30);
            this.flpConten.Margin = new System.Windows.Forms.Padding(0);
            this.flpConten.Name = "flpConten";
            this.flpConten.Size = new System.Drawing.Size(738, 501);
            this.flpConten.TabIndex = 2;
            this.flpConten.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.lblQuanLyTinDaDuyet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 30);
            this.panel1.TabIndex = 3;
            // 
            // lblQuanLyTinDaDuyet
            // 
            this.lblQuanLyTinDaDuyet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuanLyTinDaDuyet.AutoSize = true;
            this.lblQuanLyTinDaDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyTinDaDuyet.ForeColor = System.Drawing.Color.White;
            this.lblQuanLyTinDaDuyet.Location = new System.Drawing.Point(272, 3);
            this.lblQuanLyTinDaDuyet.Name = "lblQuanLyTinDaDuyet";
            this.lblQuanLyTinDaDuyet.Size = new System.Drawing.Size(194, 24);
            this.lblQuanLyTinDaDuyet.TabIndex = 1;
            this.lblQuanLyTinDaDuyet.Text = "Quản Lý Tin Đã Duyệt";
            this.lblQuanLyTinDaDuyet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnNextPage);
            this.panel2.Controls.Add(this.btnPrePage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 30);
            this.panel2.TabIndex = 2;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNextPage.Location = new System.Drawing.Point(624, 0);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(114, 30);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = ">";
            this.btnNextPage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrePage
            // 
            this.btnPrePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrePage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrePage.FlatAppearance.BorderSize = 0;
            this.btnPrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrePage.Location = new System.Drawing.Point(0, 0);
            this.btnPrePage.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(114, 30);
            this.btnPrePage.TabIndex = 1;
            this.btnPrePage.Text = "<";
            this.btnPrePage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrePage.UseVisualStyleBackColor = true;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // thongTinChiTiet
            // 
            this.thongTinChiTiet.BackColor = System.Drawing.Color.White;
            this.thongTinChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thongTinChiTiet.Location = new System.Drawing.Point(0, 0);
            this.thongTinChiTiet.Name = "thongTinChiTiet";
            this.thongTinChiTiet.Size = new System.Drawing.Size(738, 531);
            this.thongTinChiTiet.TabIndex = 0;
            // 
            // QuanLyTinDaDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpConten);
            this.Controls.Add(this.thongTinChiTiet);
            this.Name = "QuanLyTinDaDuyet";
            this.Size = new System.Drawing.Size(738, 561);
            this.Load += new System.EventHandler(this.QuanLyTinDaDuyet_Load);
            this.Resize += new System.EventHandler(this.QuanLyTinDaDuyet_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpConten;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuanLyTinDaDuyet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrePage;
        private ThongTinChiTiet thongTinChiTiet;
    }
}
