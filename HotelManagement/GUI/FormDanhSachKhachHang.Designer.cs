namespace HotelManagement.GUI
{
    partial class FormDanhSachKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ButtonSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.CTButtonThemKhachHang = new HotelManagement.CTControls.CTButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTTextBoxTimKhachHangTheoTen = new HotelManagement.CTControls.CTTextBox();
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
            this.MaKhachHang,
            this.TenKH,
            this.SoCCCD,
            this.SoDT,
            this.DiaChi,
            this.GioiTinh,
            this.ButtonSua,
            this.ButtonXoa});
            this.DataGridViewKhachHang.Location = new System.Drawing.Point(66, 91);
            this.DataGridViewKhachHang.Name = "DataGridViewKhachHang";
            this.DataGridViewKhachHang.RowHeadersVisible = false;
            this.DataGridViewKhachHang.Size = new System.Drawing.Size(1115, 655);
            this.DataGridViewKhachHang.TabIndex = 7;
            // 
            // MaKhachHang
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            this.MaKhachHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // TenKH
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKH.DefaultCellStyle = dataGridViewCellStyle6;
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            // 
            // SoCCCD
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoCCCD.DefaultCellStyle = dataGridViewCellStyle7;
            this.SoCCCD.HeaderText = "Số CCCD";
            this.SoCCCD.Name = "SoCCCD";
            // 
            // SoDT
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDT.DefaultCellStyle = dataGridViewCellStyle8;
            this.SoDT.HeaderText = "Số điện thoại";
            this.SoDT.Name = "SoDT";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // CTButtonThemKhachHang
            // 
            this.CTButtonThemKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemKhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemKhachHang.BorderRadius = 10;
            this.CTButtonThemKhachHang.BorderSize = 0;
            this.CTButtonThemKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemKhachHang.FlatAppearance.BorderSize = 0;
            this.CTButtonThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemKhachHang.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemKhachHang.Location = new System.Drawing.Point(1028, 26);
            this.CTButtonThemKhachHang.Name = "CTButtonThemKhachHang";
            this.CTButtonThemKhachHang.Size = new System.Drawing.Size(161, 36);
            this.CTButtonThemKhachHang.TabIndex = 6;
            this.CTButtonThemKhachHang.Text = "Thêm khách hàng";
            this.CTButtonThemKhachHang.TextColor = System.Drawing.Color.White;
            this.CTButtonThemKhachHang.UseVisualStyleBackColor = false;
            this.CTButtonThemKhachHang.Click += new System.EventHandler(this.CTButtonThemKhachHang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(70, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CTTextBoxTimKhachHangTheoTen
            // 
            this.CTTextBoxTimKhachHangTheoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimKhachHangTheoTen.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimKhachHangTheoTen.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimKhachHangTheoTen.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimKhachHangTheoTen.BorderRadius = 5;
            this.CTTextBoxTimKhachHangTheoTen.BorderSize = 1;
            this.CTTextBoxTimKhachHangTheoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimKhachHangTheoTen.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimKhachHangTheoTen.IsFocused = false;
            this.CTTextBoxTimKhachHangTheoTen.Location = new System.Drawing.Point(66, 26);
            this.CTTextBoxTimKhachHangTheoTen.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimKhachHangTheoTen.Multiline = false;
            this.CTTextBoxTimKhachHangTheoTen.Name = "CTTextBoxTimKhachHangTheoTen";
            this.CTTextBoxTimKhachHangTheoTen.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimKhachHangTheoTen.PasswordChar = false;
            this.CTTextBoxTimKhachHangTheoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimKhachHangTheoTen.PlaceholderText = "Tìm khách hàng theo tên";
            this.CTTextBoxTimKhachHangTheoTen.Size = new System.Drawing.Size(244, 36);
            this.CTTextBoxTimKhachHangTheoTen.TabIndex = 4;
            this.CTTextBoxTimKhachHangTheoTen.TabStop = false;
            this.CTTextBoxTimKhachHangTheoTen.Texts = "";
            this.CTTextBoxTimKhachHangTheoTen.UnderlineedStyle = false;
            // 
            // FormQuanLyKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.DataGridViewKhachHang);
            this.Controls.Add(this.CTButtonThemKhachHang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimKhachHangTheoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyKhachHang";
            this.Text = "FormQuanLyKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewComboBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewImageColumn ButtonSua;
        private System.Windows.Forms.DataGridViewImageColumn ButtonXoa;
        private CTControls.CTButton CTButtonThemKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimKhachHangTheoTen;
    }
}