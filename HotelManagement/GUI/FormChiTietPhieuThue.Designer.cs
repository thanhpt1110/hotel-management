namespace HotelManagement.GUI
{
    partial class FormChiTietPhieuThue
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelChiTietPhieuThueTieuDe = new System.Windows.Forms.Label();
            this.PanelChuaThongTin = new System.Windows.Forms.Panel();
            this.LabelNhanVienLapPhieu = new System.Windows.Forms.Label();
            this.LabelThoiGianLapPhieu = new System.Windows.Forms.Label();
            this.LabelTen = new System.Windows.Forms.Label();
            this.PictureBoxSoNguoi = new System.Windows.Forms.PictureBox();
            this.PictureBoxNgayCheckin = new System.Windows.Forms.PictureBox();
            this.PictureBoxTen = new System.Windows.Forms.PictureBox();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.CTButtonThanhToan = new HotelManagement.CTControls.CTButton();
            this.CTButtonLuu = new HotelManagement.CTControls.CTButton();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelChuaThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).BeginInit();
            this.PanelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelChiTietPhieuThueTieuDe
            // 
            this.LabelChiTietPhieuThueTieuDe.AutoSize = true;
            this.LabelChiTietPhieuThueTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.LabelChiTietPhieuThueTieuDe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChiTietPhieuThueTieuDe.Location = new System.Drawing.Point(294, 9);
            this.LabelChiTietPhieuThueTieuDe.Name = "LabelChiTietPhieuThueTieuDe";
            this.LabelChiTietPhieuThueTieuDe.Size = new System.Drawing.Size(389, 37);
            this.LabelChiTietPhieuThueTieuDe.TabIndex = 5;
            this.LabelChiTietPhieuThueTieuDe.Text = "Chi tiết phiếu thuê {số phiếu}";
            // 
            // PanelChuaThongTin
            // 
            this.PanelChuaThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.PanelChuaThongTin.Controls.Add(this.dataGridView1);
            this.PanelChuaThongTin.Controls.Add(this.LabelNhanVienLapPhieu);
            this.PanelChuaThongTin.Controls.Add(this.LabelThoiGianLapPhieu);
            this.PanelChuaThongTin.Controls.Add(this.LabelTen);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxSoNguoi);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxNgayCheckin);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxTen);
            this.PanelChuaThongTin.Location = new System.Drawing.Point(48, 58);
            this.PanelChuaThongTin.Name = "PanelChuaThongTin";
            this.PanelChuaThongTin.Size = new System.Drawing.Size(883, 435);
            this.PanelChuaThongTin.TabIndex = 11;
            this.PanelChuaThongTin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // LabelNhanVienLapPhieu
            // 
            this.LabelNhanVienLapPhieu.AutoSize = true;
            this.LabelNhanVienLapPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhanVienLapPhieu.Location = new System.Drawing.Point(750, 42);
            this.LabelNhanVienLapPhieu.Name = "LabelNhanVienLapPhieu";
            this.LabelNhanVienLapPhieu.Size = new System.Drawing.Size(73, 21);
            this.LabelNhanVienLapPhieu.TabIndex = 3;
            this.LabelNhanVienLapPhieu.Text = "Số người";
            // 
            // LabelThoiGianLapPhieu
            // 
            this.LabelThoiGianLapPhieu.AutoSize = true;
            this.LabelThoiGianLapPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThoiGianLapPhieu.Location = new System.Drawing.Point(395, 37);
            this.LabelThoiGianLapPhieu.Name = "LabelThoiGianLapPhieu";
            this.LabelThoiGianLapPhieu.Size = new System.Drawing.Size(143, 21);
            this.LabelThoiGianLapPhieu.TabIndex = 3;
            this.LabelThoiGianLapPhieu.Text = "Thời gian lập phiếu";
            // 
            // LabelTen
            // 
            this.LabelTen.AutoSize = true;
            this.LabelTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTen.Location = new System.Drawing.Point(66, 37);
            this.LabelTen.Name = "LabelTen";
            this.LabelTen.Size = new System.Drawing.Size(140, 21);
            this.LabelTen.TabIndex = 3;
            this.LabelTen.Text = "Họ tên khách hàng";
            // 
            // PictureBoxSoNguoi
            // 
            this.PictureBoxSoNguoi.Image = global::HotelManagement.Properties.Resources.SoNguoi;
            this.PictureBoxSoNguoi.Location = new System.Drawing.Point(714, 33);
            this.PictureBoxSoNguoi.Name = "PictureBoxSoNguoi";
            this.PictureBoxSoNguoi.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxSoNguoi.TabIndex = 0;
            this.PictureBoxSoNguoi.TabStop = false;
            // 
            // PictureBoxNgayCheckin
            // 
            this.PictureBoxNgayCheckin.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.PictureBoxNgayCheckin.Location = new System.Drawing.Point(360, 33);
            this.PictureBoxNgayCheckin.Name = "PictureBoxNgayCheckin";
            this.PictureBoxNgayCheckin.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxNgayCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxNgayCheckin.TabIndex = 0;
            this.PictureBoxNgayCheckin.TabStop = false;
            // 
            // PictureBoxTen
            // 
            this.PictureBoxTen.Image = global::HotelManagement.Properties.Resources.NameKH;
            this.PictureBoxTen.Location = new System.Drawing.Point(31, 33);
            this.PictureBoxTen.Name = "PictureBoxTen";
            this.PictureBoxTen.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxTen.TabIndex = 0;
            this.PictureBoxTen.TabStop = false;
            // 
            // PanelBackground
            // 
            this.PanelBackground.Controls.Add(this.LabelChiTietPhieuThueTieuDe);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(979, 550);
            this.PanelBackground.TabIndex = 15;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // CTButtonThanhToan
            // 
            this.CTButtonThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.CTButtonThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.CTButtonThanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.CTButtonThanhToan.BorderRadius = 10;
            this.CTButtonThanhToan.BorderSize = 0;
            this.CTButtonThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThanhToan.FlatAppearance.BorderSize = 0;
            this.CTButtonThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThanhToan.ForeColor = System.Drawing.Color.White;
            this.CTButtonThanhToan.Location = new System.Drawing.Point(425, 499);
            this.CTButtonThanhToan.Name = "CTButtonThanhToan";
            this.CTButtonThanhToan.Size = new System.Drawing.Size(150, 40);
            this.CTButtonThanhToan.TabIndex = 14;
            this.CTButtonThanhToan.Text = "Thêm phòng thuê";
            this.CTButtonThanhToan.TextColor = System.Drawing.Color.White;
            this.CTButtonThanhToan.UseVisualStyleBackColor = false;
            // 
            // CTButtonLuu
            // 
            this.CTButtonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonLuu.BorderRadius = 10;
            this.CTButtonLuu.BorderSize = 0;
            this.CTButtonLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonLuu.FlatAppearance.BorderSize = 0;
            this.CTButtonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonLuu.ForeColor = System.Drawing.Color.White;
            this.CTButtonLuu.Location = new System.Drawing.Point(621, 499);
            this.CTButtonLuu.Name = "CTButtonLuu";
            this.CTButtonLuu.Size = new System.Drawing.Size(150, 40);
            this.CTButtonLuu.TabIndex = 13;
            this.CTButtonLuu.Text = "Lưu";
            this.CTButtonLuu.TextColor = System.Drawing.Color.White;
            this.CTButtonLuu.UseVisualStyleBackColor = false;
            // 
            // CTButtonThoat
            // 
            this.CTButtonThoat.BackColor = System.Drawing.Color.Gray;
            this.CTButtonThoat.BackgroundColor = System.Drawing.Color.Gray;
            this.CTButtonThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.CTButtonThoat.BorderRadius = 10;
            this.CTButtonThoat.BorderSize = 0;
            this.CTButtonThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThoat.FlatAppearance.BorderSize = 0;
            this.CTButtonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThoat.ForeColor = System.Drawing.Color.White;
            this.CTButtonThoat.Location = new System.Drawing.Point(817, 499);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(150, 40);
            this.CTButtonThoat.TabIndex = 12;
            this.CTButtonThoat.Text = "Thoát";
            this.CTButtonThoat.TextColor = System.Drawing.Color.White;
            this.CTButtonThoat.UseVisualStyleBackColor = false;
            this.CTButtonThoat.Click += new System.EventHandler(this.CTButtonThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhong,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.SoNguoi});
            this.dataGridView1.Location = new System.Drawing.Point(31, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(828, 325);
            this.dataGridView1.TabIndex = 5;
            // 
            // SoPhong
            // 
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.Name = "SoPhong";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // SoNguoi
            // 
            this.SoNguoi.HeaderText = "Số người";
            this.SoNguoi.Name = "SoNguoi";
            // 
            // FormCTPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 550);
            this.Controls.Add(this.CTButtonThanhToan);
            this.Controls.Add(this.CTButtonLuu);
            this.Controls.Add(this.CTButtonThoat);
            this.Controls.Add(this.PanelChuaThongTin);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCTPhieuThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCTPhieuThue";
            this.Activated += new System.EventHandler(this.FormCTPhieuThue_Activated);
            this.SizeChanged += new System.EventHandler(this.FormCTPhieuThue_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCTPhieuThue_Paint);
            this.Resize += new System.EventHandler(this.FormCTPhieuThue_Resize);
            this.PanelChuaThongTin.ResumeLayout(false);
            this.PanelChuaThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).EndInit();
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelChiTietPhieuThueTieuDe;
        private System.Windows.Forms.Panel PanelChuaThongTin;
        private System.Windows.Forms.Label LabelNhanVienLapPhieu;
        private System.Windows.Forms.Label LabelThoiGianLapPhieu;
        private System.Windows.Forms.Label LabelTen;
        private System.Windows.Forms.PictureBox PictureBoxSoNguoi;
        private System.Windows.Forms.PictureBox PictureBoxNgayCheckin;
        private System.Windows.Forms.PictureBox PictureBoxTen;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonLuu;
        private CTControls.CTButton CTButtonThanhToan;
        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoi;
    }
}