namespace HotelManagement.GUI
{
    partial class FormSuaKhachHang
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
            this.ctTextBoxName = new HotelManagement.CTControls.CTTextBox();
            this.labelSuaKhachHang = new System.Windows.Forms.Label();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.CTButtonCapNhat = new HotelManagement.CTControls.CTButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctTextBoxQuocTich = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxSDT = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxCCCD = new HotelManagement.CTControls.CTTextBox();
            this.comboBoxGioiTinh = new HotelManagement.CTControls.CTComboBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctTextBoxName
            // 
            this.ctTextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxName.BorderRadius = 0;
            this.ctTextBoxName.BorderSize = 2;
            this.ctTextBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxName.IsFocused = false;
            this.ctTextBoxName.Location = new System.Drawing.Point(106, 53);
            this.ctTextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxName.Multiline = false;
            this.ctTextBoxName.Name = "ctTextBoxName";
            this.ctTextBoxName.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxName.PasswordChar = false;
            this.ctTextBoxName.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxName.PlaceholderText = "Nhập họ tên khách hàng";
            this.ctTextBoxName.ReadOnly = false;
            this.ctTextBoxName.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxName.TabIndex = 1;
            this.ctTextBoxName.Texts = "";
            this.ctTextBoxName.UnderlineedStyle = true;
            this.ctTextBoxName._TextChanged += new System.EventHandler(this.ctTextBox1__TextChanged);
            // 
            // labelSuaKhachHang
            // 
            this.labelSuaKhachHang.AutoSize = true;
            this.labelSuaKhachHang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuaKhachHang.Location = new System.Drawing.Point(153, 9);
            this.labelSuaKhachHang.Name = "labelSuaKhachHang";
            this.labelSuaKhachHang.Size = new System.Drawing.Size(218, 37);
            this.labelSuaKhachHang.TabIndex = 0;
            this.labelSuaKhachHang.Text = "Sửa khách hàng";
            // 
            // PanelBackground
            // 
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.labelSuaKhachHang);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(538, 615);
            this.PanelBackground.TabIndex = 2;
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
            this.CTButtonThoat.Location = new System.Drawing.Point(349, 563);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 7;
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
            this.CTButtonCapNhat.Location = new System.Drawing.Point(192, 563);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 6;
            this.CTButtonCapNhat.Text = "Cập nhật";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.comboBoxGioiTinh);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ctTextBoxQuocTich);
            this.panel1.Controls.Add(this.ctTextBoxSDT);
            this.panel1.Controls.Add(this.ctTextBoxCCCD);
            this.panel1.Controls.Add(this.ctTextBoxName);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(53, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 483);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HotelManagement.Properties.Resources.Gender;
            this.pictureBox5.Location = new System.Drawing.Point(69, 398);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.Address;
            this.pictureBox4.Location = new System.Drawing.Point(69, 316);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.Phone;
            this.pictureBox3.Location = new System.Drawing.Point(69, 228);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.CCCD;
            this.pictureBox2.Location = new System.Drawing.Point(57, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.NameKH;
            this.pictureBox1.Location = new System.Drawing.Point(69, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ctTextBoxQuocTich
            // 
            this.ctTextBoxQuocTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxQuocTich.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxQuocTich.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxQuocTich.BorderRadius = 0;
            this.ctTextBoxQuocTich.BorderSize = 2;
            this.ctTextBoxQuocTich.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxQuocTich.IsFocused = false;
            this.ctTextBoxQuocTich.Location = new System.Drawing.Point(106, 311);
            this.ctTextBoxQuocTich.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxQuocTich.Multiline = false;
            this.ctTextBoxQuocTich.Name = "ctTextBoxQuocTich";
            this.ctTextBoxQuocTich.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxQuocTich.PasswordChar = false;
            this.ctTextBoxQuocTich.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxQuocTich.PlaceholderText = "Nhập quốc tịch";
            this.ctTextBoxQuocTich.ReadOnly = false;
            this.ctTextBoxQuocTich.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxQuocTich.TabIndex = 4;
            this.ctTextBoxQuocTich.Texts = "";
            this.ctTextBoxQuocTich.UnderlineedStyle = true;
            this.ctTextBoxQuocTich._TextChanged += new System.EventHandler(this.ctTextBoxQuocTich__TextChanged);
            // 
            // ctTextBoxSDT
            // 
            this.ctTextBoxSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxSDT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxSDT.BorderRadius = 0;
            this.ctTextBoxSDT.BorderSize = 2;
            this.ctTextBoxSDT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxSDT.IsFocused = false;
            this.ctTextBoxSDT.Location = new System.Drawing.Point(106, 223);
            this.ctTextBoxSDT.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxSDT.Multiline = false;
            this.ctTextBoxSDT.Name = "ctTextBoxSDT";
            this.ctTextBoxSDT.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxSDT.PasswordChar = false;
            this.ctTextBoxSDT.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxSDT.PlaceholderText = "Nhập số điện thoại";
            this.ctTextBoxSDT.ReadOnly = false;
            this.ctTextBoxSDT.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxSDT.TabIndex = 3;
            this.ctTextBoxSDT.Texts = "";
            this.ctTextBoxSDT.UnderlineedStyle = true;
            this.ctTextBoxSDT._TextChanged += new System.EventHandler(this.ctTextBoxSDT__TextChanged);
            // 
            // ctTextBoxCCCD
            // 
            this.ctTextBoxCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxCCCD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxCCCD.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxCCCD.BorderRadius = 0;
            this.ctTextBoxCCCD.BorderSize = 2;
            this.ctTextBoxCCCD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxCCCD.IsFocused = false;
            this.ctTextBoxCCCD.Location = new System.Drawing.Point(106, 135);
            this.ctTextBoxCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxCCCD.Multiline = false;
            this.ctTextBoxCCCD.Name = "ctTextBoxCCCD";
            this.ctTextBoxCCCD.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxCCCD.PasswordChar = false;
            this.ctTextBoxCCCD.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxCCCD.PlaceholderText = "Nhập số căn cước công dân";
            this.ctTextBoxCCCD.ReadOnly = false;
            this.ctTextBoxCCCD.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxCCCD.TabIndex = 2;
            this.ctTextBoxCCCD.Texts = "";
            this.ctTextBoxCCCD.UnderlineedStyle = true;
            this.ctTextBoxCCCD._TextChanged += new System.EventHandler(this.ctTextBox2__TextChanged);
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxGioiTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxGioiTinh.BorderSize = 2;
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGioiTinh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "  Nam",
            "  Nữ"});
            this.comboBoxGioiTinh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxGioiTinh.ListTextColor = System.Drawing.Color.Black;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(107, 395);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(153, 33);
            this.comboBoxGioiTinh.TabIndex = 5;
            this.comboBoxGioiTinh.Texts = "  Giới tính";
            // 
            // FormSuaKhachHang
            // 
            this.AcceptButton = this.CTButtonCapNhat;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 615);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaKhachHang";
            this.Activated += new System.EventHandler(this.FormSuaKhachHang_Activated);
            this.Load += new System.EventHandler(this.FormSuaKhachHang_Load);
            this.SizeChanged += new System.EventHandler(this.FormSuaKhachHang_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSuaKhachHang_Paint);
            this.Resize += new System.EventHandler(this.FormSuaKhachHang_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTControls.CTTextBox ctTextBoxName;
        private System.Windows.Forms.Label labelSuaKhachHang;
        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox ctTextBoxQuocTich;
        private CTControls.CTTextBox ctTextBoxSDT;
        private CTControls.CTTextBox ctTextBoxCCCD;
        private CTControls.CTComboBox comboBoxGioiTinh;
    }
}