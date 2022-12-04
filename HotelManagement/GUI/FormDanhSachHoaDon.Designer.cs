namespace HotelManagement.GUI
{
    partial class FormDanhSachHoaDon
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
            this.CTDatePickerChonNgayHD = new HotelManagement.CTControls.CTDatePicker();
            this.LabelChonNgay = new System.Windows.Forms.Label();
            this.CTTextBoxTimTheoCCCD = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVienLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiTietPhieuThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CTDatePickerChonNgayHD
            // 
            this.CTDatePickerChonNgayHD.BorderColor = System.Drawing.Color.Silver;
            this.CTDatePickerChonNgayHD.BorderSize = 1;
            this.CTDatePickerChonNgayHD.CustomFormat = "dd MMMM, yyyy";
            this.CTDatePickerChonNgayHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.CTDatePickerChonNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CTDatePickerChonNgayHD.Location = new System.Drawing.Point(66, 26);
            this.CTDatePickerChonNgayHD.MinimumSize = new System.Drawing.Size(0, 35);
            this.CTDatePickerChonNgayHD.Name = "CTDatePickerChonNgayHD";
            this.CTDatePickerChonNgayHD.Size = new System.Drawing.Size(161, 35);
            this.CTDatePickerChonNgayHD.SkinColor = System.Drawing.Color.White;
            this.CTDatePickerChonNgayHD.TabIndex = 0;
            this.CTDatePickerChonNgayHD.TextColor = System.Drawing.Color.Black;
            // 
            // LabelChonNgay
            // 
            this.LabelChonNgay.AutoSize = true;
            this.LabelChonNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChonNgay.Location = new System.Drawing.Point(87, 13);
            this.LabelChonNgay.Name = "LabelChonNgay";
            this.LabelChonNgay.Size = new System.Drawing.Size(70, 17);
            this.LabelChonNgay.TabIndex = 1;
            this.LabelChonNgay.Text = "Chọn ngày";
            // 
            // CTTextBoxTimTheoCCCD
            // 
            this.CTTextBoxTimTheoCCCD.BackColor = System.Drawing.SystemColors.Window;
            this.CTTextBoxTimTheoCCCD.BorderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTheoCCCD.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimTheoCCCD.BorderRadius = 5;
            this.CTTextBoxTimTheoCCCD.BorderSize = 1;
            this.CTTextBoxTimTheoCCCD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimTheoCCCD.IsFocused = false;
            this.CTTextBoxTimTheoCCCD.Location = new System.Drawing.Point(872, 26);
            this.CTTextBoxTimTheoCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimTheoCCCD.Multiline = false;
            this.CTTextBoxTimTheoCCCD.Name = "CTTextBoxTimTheoCCCD";
            this.CTTextBoxTimTheoCCCD.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimTheoCCCD.PasswordChar = false;
            this.CTTextBoxTimTheoCCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTheoCCCD.PlaceholderText = "Tìm theo số CCCD khách hàng";
            this.CTTextBoxTimTheoCCCD.Size = new System.Drawing.Size(292, 35);
            this.CTTextBoxTimTheoCCCD.TabIndex = 2;
            this.CTTextBoxTimTheoCCCD.Texts = "";
            this.CTTextBoxTimTheoCCCD.UnderlineedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(878, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(189)))), ((int)(((byte)(197)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.NgayLap,
            this.TenNhanVienLap,
            this.TongTien,
            this.MaChiTietPhieuThue,
            this.ChiTiet});
            this.dataGridView1.Location = new System.Drawing.Point(66, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 610);
            this.dataGridView1.TabIndex = 4;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // TenNhanVienLap
            // 
            this.TenNhanVienLap.HeaderText = "Tên nhân viên lập";
            this.TenNhanVienLap.Name = "TenNhanVienLap";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // MaChiTietPhieuThue
            // 
            this.MaChiTietPhieuThue.HeaderText = "Mã chi tiết phiếu thuê";
            this.MaChiTietPhieuThue.Name = "MaChiTietPhieuThue";
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "Chi tiết";
            this.ChiTiet.Name = "ChiTiet";
            // 
            // FormDanhSachHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 794);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimTheoCCCD);
            this.Controls.Add(this.LabelChonNgay);
            this.Controls.Add(this.CTDatePickerChonNgayHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachHoaDon";
            this.Text = "FormDanhSachHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTControls.CTDatePicker CTDatePickerChonNgayHD;
        private System.Windows.Forms.Label LabelChonNgay;
        private CTControls.CTTextBox CTTextBoxTimTheoCCCD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVienLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTiet;
    }
}