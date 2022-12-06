namespace HotelManagement.GUI
{
    partial class FormDanhSachTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.CTButtonThemTaiKhoan = new HotelManagement.CTControls.CTButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTTextBoxTimTheoTenTaiKhoan = new HotelManagement.CTControls.CTTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewKhachHang
            // 
            this.DataGridViewKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.TinhTrang,
            this.LoaiPhong,
            this.ButtonSua,
            this.ButtonXoa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewKhachHang.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewKhachHang.Location = new System.Drawing.Point(66, 91);
            this.DataGridViewKhachHang.Name = "DataGridViewKhachHang";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewKhachHang.RowHeadersVisible = false;
            this.DataGridViewKhachHang.Size = new System.Drawing.Size(1115, 655);
            this.DataGridViewKhachHang.TabIndex = 15;
            // 
            // TenTaiKhoan
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.TenTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            // 
            // TinhTrang
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrang.DefaultCellStyle = dataGridViewCellStyle3;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // LoaiPhong
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiPhong.DefaultCellStyle = dataGridViewCellStyle4;
            this.LoaiPhong.HeaderText = "Loại phòng";
            this.LoaiPhong.Name = "LoaiPhong";
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
            // CTButtonThemTaiKhoan
            // 
            this.CTButtonThemTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemTaiKhoan.BorderRadius = 10;
            this.CTButtonThemTaiKhoan.BorderSize = 0;
            this.CTButtonThemTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemTaiKhoan.FlatAppearance.BorderSize = 0;
            this.CTButtonThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemTaiKhoan.Location = new System.Drawing.Point(1023, 26);
            this.CTButtonThemTaiKhoan.Name = "CTButtonThemTaiKhoan";
            this.CTButtonThemTaiKhoan.Size = new System.Drawing.Size(161, 36);
            this.CTButtonThemTaiKhoan.TabIndex = 14;
            this.CTButtonThemTaiKhoan.Text = "Thêm tài khoản";
            this.CTButtonThemTaiKhoan.TextColor = System.Drawing.Color.White;
            this.CTButtonThemTaiKhoan.UseVisualStyleBackColor = false;
            this.CTButtonThemTaiKhoan.Click += new System.EventHandler(this.CTButtonThemTaiKhoan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(71, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // CTTextBoxTimTheoTenTaiKhoan
            // 
            this.CTTextBoxTimTheoTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimTheoTenTaiKhoan.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimTheoTenTaiKhoan.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimTheoTenTaiKhoan.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimTheoTenTaiKhoan.BorderRadius = 5;
            this.CTTextBoxTimTheoTenTaiKhoan.BorderSize = 1;
            this.CTTextBoxTimTheoTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimTheoTenTaiKhoan.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimTheoTenTaiKhoan.IsFocused = false;
            this.CTTextBoxTimTheoTenTaiKhoan.Location = new System.Drawing.Point(66, 26);
            this.CTTextBoxTimTheoTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimTheoTenTaiKhoan.Multiline = false;
            this.CTTextBoxTimTheoTenTaiKhoan.Name = "CTTextBoxTimTheoTenTaiKhoan";
            this.CTTextBoxTimTheoTenTaiKhoan.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimTheoTenTaiKhoan.PasswordChar = false;
            this.CTTextBoxTimTheoTenTaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTheoTenTaiKhoan.PlaceholderText = "Tìm theo tên tài khoản";
            this.CTTextBoxTimTheoTenTaiKhoan.Size = new System.Drawing.Size(244, 36);
            this.CTTextBoxTimTheoTenTaiKhoan.TabIndex = 12;
            this.CTTextBoxTimTheoTenTaiKhoan.TabStop = false;
            this.CTTextBoxTimTheoTenTaiKhoan.Texts = "";
            this.CTTextBoxTimTheoTenTaiKhoan.UnderlineedStyle = false;
            // 
            // FormDanhSachTaiKhoan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.DataGridViewKhachHang);
            this.Controls.Add(this.CTButtonThemTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimTheoTenTaiKhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachTaiKhoan";
            this.Text = "FormDanhSachTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewKhachHang;
        private CTControls.CTButton CTButtonThemTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimTheoTenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhong;
        private System.Windows.Forms.DataGridViewImageColumn ButtonSua;
        private System.Windows.Forms.DataGridViewImageColumn ButtonXoa;
    }
}