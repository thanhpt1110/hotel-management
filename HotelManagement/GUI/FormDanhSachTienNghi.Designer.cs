namespace HotelManagement.GUI
{
    partial class FormDanhSachTienNghi
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
            this.MaTienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTienNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.ButtonXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTButtonThemTienNghi = new HotelManagement.CTControls.CTButton();
            this.CTTextBoxTimTenTienNghi = new HotelManagement.CTControls.CTTextBox();
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
            this.MaTienNghi,
            this.TenTienNghi,
            this.ButtonSua,
            this.ButtonXoa});
            this.DataGridViewKhachHang.Location = new System.Drawing.Point(66, 91);
            this.DataGridViewKhachHang.Name = "DataGridViewKhachHang";
            this.DataGridViewKhachHang.RowHeadersVisible = false;
            this.DataGridViewKhachHang.Size = new System.Drawing.Size(1115, 655);
            this.DataGridViewKhachHang.TabIndex = 19;
            // 
            // MaTienNghi
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.MaTienNghi.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaTienNghi.HeaderText = "Mã tiện nghi";
            this.MaTienNghi.Name = "MaTienNghi";
            // 
            // TenTienNghi
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTienNghi.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // CTButtonThemTienNghi
            // 
            this.CTButtonThemTienNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemTienNghi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemTienNghi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemTienNghi.BorderRadius = 10;
            this.CTButtonThemTienNghi.BorderSize = 0;
            this.CTButtonThemTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemTienNghi.FlatAppearance.BorderSize = 0;
            this.CTButtonThemTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemTienNghi.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemTienNghi.Location = new System.Drawing.Point(1020, 26);
            this.CTButtonThemTienNghi.Name = "CTButtonThemTienNghi";
            this.CTButtonThemTienNghi.Size = new System.Drawing.Size(161, 36);
            this.CTButtonThemTienNghi.TabIndex = 18;
            this.CTButtonThemTienNghi.Text = "Thêm tiện nghi";
            this.CTButtonThemTienNghi.TextColor = System.Drawing.Color.White;
            this.CTButtonThemTienNghi.UseVisualStyleBackColor = false;
            this.CTButtonThemTienNghi.Click += new System.EventHandler(this.CTButtonThemTienNghi_Click);
            // 
            // CTTextBoxTimTenTienNghi
            // 
            this.CTTextBoxTimTenTienNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimTenTienNghi.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimTenTienNghi.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimTenTienNghi.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimTenTienNghi.BorderRadius = 5;
            this.CTTextBoxTimTenTienNghi.BorderSize = 1;
            this.CTTextBoxTimTenTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimTenTienNghi.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimTenTienNghi.IsFocused = false;
            this.CTTextBoxTimTenTienNghi.Location = new System.Drawing.Point(66, 26);
            this.CTTextBoxTimTenTienNghi.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimTenTienNghi.Multiline = false;
            this.CTTextBoxTimTenTienNghi.Name = "CTTextBoxTimTenTienNghi";
            this.CTTextBoxTimTenTienNghi.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimTenTienNghi.PasswordChar = false;
            this.CTTextBoxTimTenTienNghi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTenTienNghi.PlaceholderText = "Tìm theo tên tiện nghi";
            this.CTTextBoxTimTenTienNghi.ReadOnly = false;
            this.CTTextBoxTimTenTienNghi.Size = new System.Drawing.Size(244, 36);
            this.CTTextBoxTimTenTienNghi.TabIndex = 16;
            this.CTTextBoxTimTenTienNghi.TabStop = false;
            this.CTTextBoxTimTenTienNghi.Texts = "";
            this.CTTextBoxTimTenTienNghi.UnderlineedStyle = false;
            // 
            // FormDanhSachTienNghi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.DataGridViewKhachHang);
            this.Controls.Add(this.CTButtonThemTienNghi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimTenTienNghi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachTienNghi";
            this.Text = "FormDanhSachTienNghi";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewKhachHang;
        private CTControls.CTButton CTButtonThemTienNghi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimTenTienNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTienNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTienNghi;
        private System.Windows.Forms.DataGridViewImageColumn ButtonSua;
        private System.Windows.Forms.DataGridViewImageColumn ButtonXoa;
    }
}