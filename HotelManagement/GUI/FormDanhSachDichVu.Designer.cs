namespace HotelManagement.GUI
{
    partial class FormDanhSachDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewKhachHang = new System.Windows.Forms.DataGridView();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.CTButtonThemDichVu = new HotelManagement.CTControls.CTButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTTextBoxTimPhongTheoMa = new HotelManagement.CTControls.CTTextBox();
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
            this.MaDichVu,
            this.TenDichVu,
            this.MoTa,
            this.DonGia,
            this.SoLuongConLai,
            this.ButtonSua,
            this.ButtonXoa});
            this.DataGridViewKhachHang.Location = new System.Drawing.Point(71, 92);
            this.DataGridViewKhachHang.Name = "DataGridViewKhachHang";
            this.DataGridViewKhachHang.RowHeadersVisible = false;
            this.DataGridViewKhachHang.Size = new System.Drawing.Size(1115, 655);
            this.DataGridViewKhachHang.TabIndex = 22;
            // 
            // MaDichVu
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.MaDichVu.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaDichVu.HeaderText = "Mã dịch vụ";
            this.MaDichVu.Name = "MaDichVu";
            // 
            // TenDichVu
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenDichVu.HeaderText = "Tên dịch vụ";
            this.TenDichVu.Name = "TenDichVu";
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuongConLai
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongConLai.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoLuongConLai.HeaderText = "Số lượng còn lại";
            this.SoLuongConLai.Name = "SoLuongConLai";
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
            // CTButtonThemDichVu
            // 
            this.CTButtonThemDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemDichVu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemDichVu.BorderRadius = 10;
            this.CTButtonThemDichVu.BorderSize = 0;
            this.CTButtonThemDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemDichVu.FlatAppearance.BorderSize = 0;
            this.CTButtonThemDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemDichVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemDichVu.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemDichVu.Location = new System.Drawing.Point(1025, 26);
            this.CTButtonThemDichVu.Name = "CTButtonThemDichVu";
            this.CTButtonThemDichVu.Size = new System.Drawing.Size(161, 36);
            this.CTButtonThemDichVu.TabIndex = 21;
            this.CTButtonThemDichVu.Text = "Thêm dịch vụ";
            this.CTButtonThemDichVu.TextColor = System.Drawing.Color.White;
            this.CTButtonThemDichVu.UseVisualStyleBackColor = false;
            this.CTButtonThemDichVu.Click += new System.EventHandler(this.CTButtonThemDichVu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(71, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // CTTextBoxTimPhongTheoMa
            // 
            this.CTTextBoxTimPhongTheoMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimPhongTheoMa.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimPhongTheoMa.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimPhongTheoMa.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimPhongTheoMa.BorderRadius = 5;
            this.CTTextBoxTimPhongTheoMa.BorderSize = 1;
            this.CTTextBoxTimPhongTheoMa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimPhongTheoMa.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimPhongTheoMa.IsFocused = false;
            this.CTTextBoxTimPhongTheoMa.Location = new System.Drawing.Point(66, 26);
            this.CTTextBoxTimPhongTheoMa.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimPhongTheoMa.Multiline = false;
            this.CTTextBoxTimPhongTheoMa.Name = "CTTextBoxTimPhongTheoMa";
            this.CTTextBoxTimPhongTheoMa.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimPhongTheoMa.PasswordChar = false;
            this.CTTextBoxTimPhongTheoMa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimPhongTheoMa.PlaceholderText = "Tìm theo tên dịch vụ";
            this.CTTextBoxTimPhongTheoMa.ReadOnly = false;
            this.CTTextBoxTimPhongTheoMa.Size = new System.Drawing.Size(244, 36);
            this.CTTextBoxTimPhongTheoMa.TabIndex = 19;
            this.CTTextBoxTimPhongTheoMa.TabStop = false;
            this.CTTextBoxTimPhongTheoMa.Texts = "";
            this.CTTextBoxTimPhongTheoMa.UnderlineedStyle = false;
            // 
            // FormDanhSachDichVu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.DataGridViewKhachHang);
            this.Controls.Add(this.CTButtonThemDichVu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimPhongTheoMa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachDichVu";
            this.Text = "FormDanhSachDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridViewKhachHang;
        private CTControls.CTButton CTButtonThemDichVu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimPhongTheoMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongConLai;
        private System.Windows.Forms.DataGridViewImageColumn ButtonSua;
        private System.Windows.Forms.DataGridViewImageColumn ButtonXoa;
    }
}