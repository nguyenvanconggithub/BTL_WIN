namespace GUI.Tim_Kiem.Tim_Viec
{
    partial class KetQuaTimKiem_TimViec
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
            this.pnlThongTinChiTiet = new System.Windows.Forms.Panel();
            this.lblQuanLyTinDaDuyet = new System.Windows.Forms.Label();
            this.ftpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPageControl = new System.Windows.Forms.Panel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.thongTinChiTiet_TimViec = new GUI.Tim_Kiem.Tim_Viec.ThongTinChiTiet_TimViec();
            this.pnlThongTinChiTiet.SuspendLayout();
            this.pnlPageControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTinChiTiet
            // 
            this.pnlThongTinChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pnlThongTinChiTiet.Controls.Add(this.lblQuanLyTinDaDuyet);
            this.pnlThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThongTinChiTiet.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTinChiTiet.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongTinChiTiet.Name = "pnlThongTinChiTiet";
            this.pnlThongTinChiTiet.Size = new System.Drawing.Size(738, 30);
            this.pnlThongTinChiTiet.TabIndex = 3;
            // 
            // lblQuanLyTinDaDuyet
            // 
            this.lblQuanLyTinDaDuyet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuanLyTinDaDuyet.AutoSize = true;
            this.lblQuanLyTinDaDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyTinDaDuyet.ForeColor = System.Drawing.Color.White;
            this.lblQuanLyTinDaDuyet.Location = new System.Drawing.Point(265, 4);
            this.lblQuanLyTinDaDuyet.Name = "lblQuanLyTinDaDuyet";
            this.lblQuanLyTinDaDuyet.Size = new System.Drawing.Size(163, 24);
            this.lblQuanLyTinDaDuyet.TabIndex = 0;
            this.lblQuanLyTinDaDuyet.Text = "Kết Quả Tìm Kiếm";
            this.lblQuanLyTinDaDuyet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ftpContainer
            // 
            this.ftpContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ftpContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ftpContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ftpContainer.Location = new System.Drawing.Point(0, 30);
            this.ftpContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ftpContainer.Name = "ftpContainer";
            this.ftpContainer.Size = new System.Drawing.Size(738, 501);
            this.ftpContainer.TabIndex = 5;
            this.ftpContainer.WrapContents = false;
            this.ftpContainer.Resize += new System.EventHandler(this.ftpContainer_Resize);
            // 
            // pnlPageControl
            // 
            this.pnlPageControl.Controls.Add(this.btnNextPage);
            this.pnlPageControl.Controls.Add(this.btnPreviousPage);
            this.pnlPageControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPageControl.Location = new System.Drawing.Point(0, 531);
            this.pnlPageControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPageControl.Name = "pnlPageControl";
            this.pnlPageControl.Size = new System.Drawing.Size(738, 30);
            this.pnlPageControl.TabIndex = 6;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNextPage.Location = new System.Drawing.Point(438, 0);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(300, 30);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Text = ">";
            this.btnNextPage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPreviousPage.Location = new System.Drawing.Point(0, 0);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(300, 30);
            this.btnPreviousPage.TabIndex = 0;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // thongTinChiTiet_TimViec
            // 
            this.thongTinChiTiet_TimViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thongTinChiTiet_TimViec.BackColor = System.Drawing.Color.White;
            this.thongTinChiTiet_TimViec.Location = new System.Drawing.Point(0, 0);
            this.thongTinChiTiet_TimViec.Margin = new System.Windows.Forms.Padding(0);
            this.thongTinChiTiet_TimViec.Name = "thongTinChiTiet_TimViec";
            this.thongTinChiTiet_TimViec.Size = new System.Drawing.Size(738, 561);
            this.thongTinChiTiet_TimViec.TabIndex = 0;
            this.thongTinChiTiet_TimViec.Load += new System.EventHandler(this.QuanLyTinDaDuyet_Load);
            // 
            // KetQuaTimKiem_TimViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlThongTinChiTiet);
            this.Controls.Add(this.ftpContainer);
            this.Controls.Add(this.pnlPageControl);
            this.Controls.Add(this.thongTinChiTiet_TimViec);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "KetQuaTimKiem_TimViec";
            this.Size = new System.Drawing.Size(738, 561);
            this.Load += new System.EventHandler(this.QuanLyTinDaDuyet_Load);
            this.pnlThongTinChiTiet.ResumeLayout(false);
            this.pnlThongTinChiTiet.PerformLayout();
            this.pnlPageControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTinChiTiet;
        private System.Windows.Forms.Label lblQuanLyTinDaDuyet;
        private System.Windows.Forms.FlowLayoutPanel ftpContainer;
        private System.Windows.Forms.Panel pnlPageControl;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private ThongTinChiTiet_TimViec thongTinChiTiet_TimViec;
    }
}
