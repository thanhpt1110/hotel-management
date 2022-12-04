namespace HotelManagement.GUI
{
    partial class FormDanhSachChiTietTienNghi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTButtonThemChiTietTienNghi = new HotelManagement.CTControls.CTButton();
            this.CTTextBoxTimTenLoaiPhong = new HotelManagement.CTControls.CTTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewKhachHang
            // 
            this.DataGridViewKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.DataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiPhong,
            this.TenLoaiPhong,
            this.MaTienNghi,
            this.TenTienNghi,
            this.ButtonSua,
            this.ButtonXoa});
            this.DataGridViewKhachHang.Location = new System.Drawing.Point(66, 91);
            this.DataGridViewKhachHang.Name = "DataGridViewKhachHang";
            this.DataGridViewKhachHang.RowHeadersVisible = false;
            this.DataGridViewKhachHang.Size = new System.Drawing.Size(1115, 655);
            this.DataGridViewKhachHang.TabIndex = 23;
            // 
            // MaLoaiPhong
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.MaLoaiPhong.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaLoaiPhong.HeaderText = "Mã loại phòng";
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // TenLoaiPhong
            // 
            this.TenLoaiPhong.HeaderText = "Tên loại phòng";
            this.TenLoaiPhong.Name = "TenLoaiPhong";
            // 
            // MaTienNghi
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTienNghi.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaTienNghi.HeaderText = "Mã tiện nghi";
            this.MaTienNghi.Name = "MaTienNghi";
            // 
            // TenTienNghi
            // 
            this.TenTienNghi.HeaderText = "Tên tiện nghi";
            this.TenTienNghi.Name = "TenTienNghi";
            // 
            // ButtonSua
            // 
            this.ButtonSua.HeaderText = "Sửa";
            this.ButtonSua.Name = "ButtonSua";
            // 
            // ButtonXoa
            // 
            this.ButtonXoa.HeaderText = "Xóa";
            this.ButtonXoa.Name = "ButtonXoa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(71, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // CTButtonThemChiTietTienNghi
            // 
            this.CTButtonThemChiTietTienNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemChiTietTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemChiTietTienNghi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemChiTietTienNghi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemChiTietTienNghi.BorderRadius = 10;
            this.CTButtonThemChiTietTienNghi.BorderSize = 0;
            this.CTButtonThemChiTietTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemChiTietTienNghi.FlatAppearance.BorderSize = 0;
            this.CTButtonThemChiTietTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemChiTietTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemChiTietTienNghi.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemChiTietTienNghi.Location = new System.Drawing.Point(987, 26);
            this.CTButtonThemChiTietTienNghi.Name = "CTButtonThemChiTietTienNghi";
            this.CTButtonThemChiTietTienNghi.Size = new System.Drawing.Size(197, 36);
            this.CTButtonThemChiTietTienNghi.TabIndex = 22;
            this.CTButtonThemChiTietTienNghi.Text = "Thêm chi tiết tiện nghi";
            this.CTButtonThemChiTietTienNghi.TextColor = System.Drawing.Color.White;
            this.CTButtonThemChiTietTienNghi.UseVisualStyleBackColor = false;
            this.CTButtonThemChiTietTienNghi.Click += new System.EventHandler(this.CTButtonThemChiTietTienNghi_Click);
            // 
            // CTTextBoxTimTenLoaiPhong
            // 
            this.CTTextBoxTimTenLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimTenLoaiPhong.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimTenLoaiPhong.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimTenLoaiPhong.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimTenLoaiPhong.BorderRadius = 5;
            this.CTTextBoxTimTenLoaiPhong.BorderSize = 1;
            this.CTTextBoxTimTenLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimTenLoaiPhong.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimTenLoaiPhong.IsFocused = false;
            this.CTTextBoxTimTenLoaiPhong.Location = new System.Drawing.Point(66, 26);
            this.CTTextBoxTimTenLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimTenLoaiPhong.Multiline = false;
            this.CTTextBoxTimTenLoaiPhong.Name = "CTTextBoxTimTenLoaiPhong";
            this.CTTextBoxTimTenLoaiPhong.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimTenLoaiPhong.PasswordChar = false;
            this.CTTextBoxTimTenLoaiPhong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTenLoaiPhong.PlaceholderText = "Nhập theo tên loại phòng";
            this.CTTextBoxTimTenLoaiPhong.Size = new System.Drawing.Size(244, 36);
            this.CTTextBoxTimTenLoaiPhong.TabIndex = 20;
            this.CTTextBoxTimTenLoaiPhong.TabStop = false;
            this.CTTextBoxTimTenLoaiPhong.Texts = "";
            this.CTTextBoxTimTenLoaiPhong.UnderlineedStyle = false;
            // 
            // FormDanhSachChiTietTienNghi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.DataGridViewKhachHang);
            this.Controls.Add(this.CTButtonThemChiTietTienNghi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimTenLoaiPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachChiTietTienNghi";
            this.Text = "FormDanhSachChiTietTienNghi";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewKhachHang;
        private CTControls.CTButton CTButtonThemChiTietTienNghi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimTenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTienNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTienNghi;
        private System.Windows.Forms.DataGridViewImageColumn ButtonSua;
        private System.Windows.Forms.DataGridViewImageColumn ButtonXoa;
    }
}