namespace HotelManagement.GUI
{
    partial class FormSuaLoaiPhong
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
            this.LabelSuaLoaiPhong = new System.Windows.Forms.Label();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.CTButtonCapNhat = new HotelManagement.CTControls.CTButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ctTextBoxSoNguoi = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxSoGiuong = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxTenLoaiPhong = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxGiaGio = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxGiaNgay = new HotelManagement.CTControls.CTTextBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSuaLoaiPhong
            // 
            this.LabelSuaLoaiPhong.AutoSize = true;
            this.LabelSuaLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSuaLoaiPhong.Location = new System.Drawing.Point(173, 9);
            this.LabelSuaLoaiPhong.Name = "LabelSuaLoaiPhong";
            this.LabelSuaLoaiPhong.Size = new System.Drawing.Size(210, 37);
            this.LabelSuaLoaiPhong.TabIndex = 0;
            this.LabelSuaLoaiPhong.Text = "Sửa loại phòng";
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.White;
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.LabelSuaLoaiPhong);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(533, 535);
            this.PanelBackground.TabIndex = 4;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // CTButtonThoat
            // 
            this.CTButtonThoat.BackColor = System.Drawing.Color.DarkGray;
            this.CTButtonThoat.BackgroundColor = System.Drawing.Color.DarkGray;
            this.CTButtonThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThoat.BorderRadius = 10;
            this.CTButtonThoat.BorderSize = 0;
            this.CTButtonThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThoat.FlatAppearance.BorderSize = 0;
            this.CTButtonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThoat.ForeColor = System.Drawing.Color.White;
            this.CTButtonThoat.Location = new System.Drawing.Point(345, 480);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 10;
            this.CTButtonThoat.Text = "Thoát";
            this.CTButtonThoat.TextColor = System.Drawing.Color.White;
            this.CTButtonThoat.UseVisualStyleBackColor = false;
            this.CTButtonThoat.Click += new System.EventHandler(this.CTButtonThoat_Click);
            // 
            // CTButtonCapNhat
            // 
            this.CTButtonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonCapNhat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonCapNhat.BorderRadius = 10;
            this.CTButtonCapNhat.BorderSize = 0;
            this.CTButtonCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonCapNhat.FlatAppearance.BorderSize = 0;
            this.CTButtonCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonCapNhat.ForeColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.Location = new System.Drawing.Point(180, 480);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 9;
            this.CTButtonCapNhat.Text = "Cập nhật";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ctTextBoxSoNguoi);
            this.panel1.Controls.Add(this.CTTextBoxSoGiuong);
            this.panel1.Controls.Add(this.CTTextBoxTenLoaiPhong);
            this.panel1.Controls.Add(this.ctTextBoxGiaGio);
            this.panel1.Controls.Add(this.ctTextBoxGiaNgay);
            this.panel1.Location = new System.Drawing.Point(53, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 404);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.note;
            this.pictureBox4.Location = new System.Drawing.Point(69, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HotelManagement.Properties.Resources.money;
            this.pictureBox5.Location = new System.Drawing.Point(69, 329);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(70, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources._3people;
            this.pictureBox3.Location = new System.Drawing.Point(70, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.clean;
            this.pictureBox2.Location = new System.Drawing.Point(69, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // ctTextBoxSoNguoi
            // 
            this.ctTextBoxSoNguoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxSoNguoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxSoNguoi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxSoNguoi.BorderRadius = 0;
            this.ctTextBoxSoNguoi.BorderSize = 2;
            this.ctTextBoxSoNguoi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxSoNguoi.IsFocused = false;
            this.ctTextBoxSoNguoi.Location = new System.Drawing.Point(107, 176);
            this.ctTextBoxSoNguoi.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxSoNguoi.Multiline = false;
            this.ctTextBoxSoNguoi.Name = "ctTextBoxSoNguoi";
            this.ctTextBoxSoNguoi.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxSoNguoi.PasswordChar = false;
            this.ctTextBoxSoNguoi.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxSoNguoi.PlaceholderText = "Số người tối đa";
            this.ctTextBoxSoNguoi.ReadOnly = true;
            this.ctTextBoxSoNguoi.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxSoNguoi.TabIndex = 6;
            this.ctTextBoxSoNguoi.Texts = "";
            this.ctTextBoxSoNguoi.UnderlineedStyle = true;
            // 
            // CTTextBoxSoGiuong
            // 
            this.CTTextBoxSoGiuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.CTTextBoxSoGiuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.CTTextBoxSoGiuong.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.CTTextBoxSoGiuong.BorderRadius = 0;
            this.CTTextBoxSoGiuong.BorderSize = 2;
            this.CTTextBoxSoGiuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxSoGiuong.IsFocused = false;
            this.CTTextBoxSoGiuong.Location = new System.Drawing.Point(108, 105);
            this.CTTextBoxSoGiuong.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxSoGiuong.Multiline = false;
            this.CTTextBoxSoGiuong.Name = "CTTextBoxSoGiuong";
            this.CTTextBoxSoGiuong.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxSoGiuong.PasswordChar = false;
            this.CTTextBoxSoGiuong.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxSoGiuong.PlaceholderText = "Số giường";
            this.CTTextBoxSoGiuong.ReadOnly = true;
            this.CTTextBoxSoGiuong.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxSoGiuong.TabIndex = 5;
            this.CTTextBoxSoGiuong.Texts = "";
            this.CTTextBoxSoGiuong.UnderlineedStyle = true;
            // 
            // CTTextBoxTenLoaiPhong
            // 
            this.CTTextBoxTenLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.CTTextBoxTenLoaiPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.CTTextBoxTenLoaiPhong.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.CTTextBoxTenLoaiPhong.BorderRadius = 0;
            this.CTTextBoxTenLoaiPhong.BorderSize = 2;
            this.CTTextBoxTenLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTenLoaiPhong.IsFocused = false;
            this.CTTextBoxTenLoaiPhong.Location = new System.Drawing.Point(107, 33);
            this.CTTextBoxTenLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTenLoaiPhong.Multiline = false;
            this.CTTextBoxTenLoaiPhong.Name = "CTTextBoxTenLoaiPhong";
            this.CTTextBoxTenLoaiPhong.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxTenLoaiPhong.PasswordChar = false;
            this.CTTextBoxTenLoaiPhong.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTenLoaiPhong.PlaceholderText = "Nhập tên loại phòng";
            this.CTTextBoxTenLoaiPhong.ReadOnly = true;
            this.CTTextBoxTenLoaiPhong.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxTenLoaiPhong.TabIndex = 4;
            this.CTTextBoxTenLoaiPhong.Texts = "";
            this.CTTextBoxTenLoaiPhong.UnderlineedStyle = true;
            // 
            // ctTextBoxGiaGio
            // 
            this.ctTextBoxGiaGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxGiaGio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxGiaGio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxGiaGio.BorderRadius = 0;
            this.ctTextBoxGiaGio.BorderSize = 2;
            this.ctTextBoxGiaGio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxGiaGio.IsFocused = false;
            this.ctTextBoxGiaGio.Location = new System.Drawing.Point(107, 329);
            this.ctTextBoxGiaGio.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxGiaGio.Multiline = false;
            this.ctTextBoxGiaGio.Name = "ctTextBoxGiaGio";
            this.ctTextBoxGiaGio.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxGiaGio.PasswordChar = false;
            this.ctTextBoxGiaGio.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxGiaGio.PlaceholderText = "Giá giờ";
            this.ctTextBoxGiaGio.ReadOnly = false;
            this.ctTextBoxGiaGio.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxGiaGio.TabIndex = 8;
            this.ctTextBoxGiaGio.Texts = "";
            this.ctTextBoxGiaGio.UnderlineedStyle = true;
            this.ctTextBoxGiaGio._TextChanged += new System.EventHandler(this.ctTextBoxGiaGio__TextChanged);
            this.ctTextBoxGiaGio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctTextBoxGiaGio_KeyPress);
            // 
            // ctTextBoxGiaNgay
            // 
            this.ctTextBoxGiaNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxGiaNgay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxGiaNgay.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxGiaNgay.BorderRadius = 0;
            this.ctTextBoxGiaNgay.BorderSize = 2;
            this.ctTextBoxGiaNgay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxGiaNgay.IsFocused = false;
            this.ctTextBoxGiaNgay.Location = new System.Drawing.Point(107, 252);
            this.ctTextBoxGiaNgay.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxGiaNgay.Multiline = false;
            this.ctTextBoxGiaNgay.Name = "ctTextBoxGiaNgay";
            this.ctTextBoxGiaNgay.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxGiaNgay.PasswordChar = false;
            this.ctTextBoxGiaNgay.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxGiaNgay.PlaceholderText = "Giá ngày";
            this.ctTextBoxGiaNgay.ReadOnly = false;
            this.ctTextBoxGiaNgay.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxGiaNgay.TabIndex = 7;
            this.ctTextBoxGiaNgay.Texts = "";
            this.ctTextBoxGiaNgay.UnderlineedStyle = true;
            this.ctTextBoxGiaNgay._TextChanged += new System.EventHandler(this.ctTextBoxGiaNgay__TextChanged);
            this.ctTextBoxGiaNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctTextBoxGiaNgay_KeyPress);
            // 
            // FormSuaLoaiPhong
            // 
            this.AcceptButton = this.CTButtonCapNhat;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 535);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaLoaiPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaLoaiPhong";
            this.Activated += new System.EventHandler(this.FormSuaLoaiPhong_Activated);
            this.Load += new System.EventHandler(this.FormSuaLoaiPhong_Load);
            this.SizeChanged += new System.EventHandler(this.FormSuaLoaiPhong_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSuaLoaiPhong_Paint);
            this.Resize += new System.EventHandler(this.FormSuaLoaiPhong_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelSuaLoaiPhong;
        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CTControls.CTTextBox ctTextBoxSoNguoi;
        private CTControls.CTTextBox CTTextBoxSoGiuong;
        private CTControls.CTTextBox CTTextBoxTenLoaiPhong;
        private CTControls.CTTextBox ctTextBoxGiaGio;
        private CTControls.CTTextBox ctTextBoxGiaNgay;
    }
}