namespace HotelManagement.GUI
{
    partial class FormQLDatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctTextBox1 = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTButtonDatPhong = new HotelManagement.CTControls.CTButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoPhieuThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewImageColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctTextBox1.BackColor = System.Drawing.Color.White;
            this.ctTextBox1.BorderColor = System.Drawing.Color.Gray;
            this.ctTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.ctTextBox1.BorderRadius = 5;
            this.ctTextBox1.BorderSize = 1;
            this.ctTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.ctTextBox1.IsFocused = false;
            this.ctTextBox1.Location = new System.Drawing.Point(66, 26);
            this.ctTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox1.Multiline = false;
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.ctTextBox1.PasswordChar = false;
            this.ctTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctTextBox1.PlaceholderText = "Tìm khách hàng theo tên";
            this.ctTextBox1.Size = new System.Drawing.Size(244, 36);
            this.ctTextBox1.TabIndex = 0;
            this.ctTextBox1.TabStop = false;
            this.ctTextBox1.Texts = "";
            this.ctTextBox1.UnderlineedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(69, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CTButtonDatPhong
            // 
            this.CTButtonDatPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonDatPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonDatPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonDatPhong.BorderRadius = 10;
            this.CTButtonDatPhong.BorderSize = 0;
            this.CTButtonDatPhong.FlatAppearance.BorderSize = 0;
            this.CTButtonDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonDatPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonDatPhong.ForeColor = System.Drawing.Color.White;
            this.CTButtonDatPhong.Location = new System.Drawing.Point(1031, 26);
            this.CTButtonDatPhong.Name = "CTButtonDatPhong";
            this.CTButtonDatPhong.Size = new System.Drawing.Size(150, 36);
            this.CTButtonDatPhong.TabIndex = 2;
            this.CTButtonDatPhong.Text = "Đặt phòng";
            this.CTButtonDatPhong.TextColor = System.Drawing.Color.White;
            this.CTButtonDatPhong.UseVisualStyleBackColor = false;
            this.CTButtonDatPhong.Click += new System.EventHandler(this.CTButtonDatPhong_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuThue,
            this.TenKH,
            this.NgayLapPhieu,
            this.TenNhanVien,
            this.ChiTiet,
            this.Xoa});
            this.dataGridView1.Location = new System.Drawing.Point(66, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 655);
            this.dataGridView1.TabIndex = 3;
            // 
            // SoPhieuThue
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            this.SoPhieuThue.DefaultCellStyle = dataGridViewCellStyle9;
            this.SoPhieuThue.HeaderText = "Số phiếu thuê";
            this.SoPhieuThue.Name = "SoPhieuThue";
            // 
            // TenKH
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKH.DefaultCellStyle = dataGridViewCellStyle10;
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            // 
            // NgayLapPhieu
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLapPhieu.DefaultCellStyle = dataGridViewCellStyle11;
            this.NgayLapPhieu.HeaderText = "Ngày lập phiếu";
            this.NgayLapPhieu.Name = "NgayLapPhieu";
            // 
            // TenNhanVien
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.DefaultCellStyle = dataGridViewCellStyle12;
            this.TenNhanVien.HeaderText = "Tên nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "Chi tiết";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            // 
            // FormQLDatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CTButtonDatPhong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLDatPhong";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTControls.CTTextBox ctTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTButton CTButtonDatPhong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewImageColumn ChiTiet;
        private System.Windows.Forms.DataGridViewImageColumn Xoa;
    }
}