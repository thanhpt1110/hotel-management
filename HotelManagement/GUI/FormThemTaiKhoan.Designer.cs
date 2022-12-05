namespace HotelManagement.GUI
{
    partial class FormThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemTaiKhoan));
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.LabelThemTaiKhoan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.CTButtonCapNhat = new HotelManagement.CTControls.CTButton();
            this.CTTextBoxNhapMatKhau = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxNhapMaNhanVien = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxNhapTenTaiKhoan = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.Controls.Add(this.LabelThemTaiKhoan);
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(533, 498);
            this.PanelBackground.TabIndex = 2;
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // LabelThemTaiKhoan
            // 
            this.LabelThemTaiKhoan.AutoSize = true;
            this.LabelThemTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.LabelThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThemTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.LabelThemTaiKhoan.Location = new System.Drawing.Point(152, 9);
            this.LabelThemTaiKhoan.Name = "LabelThemTaiKhoan";
            this.LabelThemTaiKhoan.Size = new System.Drawing.Size(216, 37);
            this.LabelThemTaiKhoan.TabIndex = 0;
            this.LabelThemTaiKhoan.Text = "Thêm tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.CTTextBoxNhapMatKhau);
            this.panel1.Controls.Add(this.CTTextBoxNhapMaNhanVien);
            this.panel1.Controls.Add(this.CTTextBoxNhapTenTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(56, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 370);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "  Admin",
            "  Quản lý",
            "  Lễ tân"});
            this.comboBox1.Location = new System.Drawing.Point(106, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "  Cấp độ quyền";
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
            this.CTButtonThoat.Location = new System.Drawing.Point(373, 445);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 0;
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
            this.CTButtonCapNhat.Location = new System.Drawing.Point(212, 445);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 6;
            this.CTButtonCapNhat.Text = "Cập nhật";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            // 
            // CTTextBoxNhapMatKhau
            // 
            this.CTTextBoxNhapMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.CTTextBoxNhapMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.CTTextBoxNhapMatKhau.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.CTTextBoxNhapMatKhau.BorderRadius = 0;
            this.CTTextBoxNhapMatKhau.BorderSize = 2;
            this.CTTextBoxNhapMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxNhapMatKhau.IsFocused = false;
            this.CTTextBoxNhapMatKhau.Location = new System.Drawing.Point(106, 204);
            this.CTTextBoxNhapMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxNhapMatKhau.Multiline = false;
            this.CTTextBoxNhapMatKhau.Name = "CTTextBoxNhapMatKhau";
            this.CTTextBoxNhapMatKhau.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxNhapMatKhau.PasswordChar = false;
            this.CTTextBoxNhapMatKhau.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxNhapMatKhau.PlaceholderText = "Nhập mật khẩu";
            this.CTTextBoxNhapMatKhau.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxNhapMatKhau.TabIndex = 3;
            this.CTTextBoxNhapMatKhau.Texts = "";
            this.CTTextBoxNhapMatKhau.UnderlineedStyle = true;
            // 
            // CTTextBoxNhapMaNhanVien
            // 
            this.CTTextBoxNhapMaNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.CTTextBoxNhapMaNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.CTTextBoxNhapMaNhanVien.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.CTTextBoxNhapMaNhanVien.BorderRadius = 0;
            this.CTTextBoxNhapMaNhanVien.BorderSize = 2;
            this.CTTextBoxNhapMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxNhapMaNhanVien.IsFocused = false;
            this.CTTextBoxNhapMaNhanVien.Location = new System.Drawing.Point(106, 42);
            this.CTTextBoxNhapMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxNhapMaNhanVien.Multiline = false;
            this.CTTextBoxNhapMaNhanVien.Name = "CTTextBoxNhapMaNhanVien";
            this.CTTextBoxNhapMaNhanVien.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxNhapMaNhanVien.PasswordChar = false;
            this.CTTextBoxNhapMaNhanVien.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxNhapMaNhanVien.PlaceholderText = "Nhập mã nhân viên";
            this.CTTextBoxNhapMaNhanVien.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxNhapMaNhanVien.TabIndex = 2;
            this.CTTextBoxNhapMaNhanVien.Texts = "";
            this.CTTextBoxNhapMaNhanVien.UnderlineedStyle = true;
            // 
            // CTTextBoxNhapTenTaiKhoan
            // 
            this.CTTextBoxNhapTenTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.CTTextBoxNhapTenTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.CTTextBoxNhapTenTaiKhoan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.CTTextBoxNhapTenTaiKhoan.BorderRadius = 0;
            this.CTTextBoxNhapTenTaiKhoan.BorderSize = 2;
            this.CTTextBoxNhapTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxNhapTenTaiKhoan.IsFocused = false;
            this.CTTextBoxNhapTenTaiKhoan.Location = new System.Drawing.Point(106, 118);
            this.CTTextBoxNhapTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxNhapTenTaiKhoan.Multiline = false;
            this.CTTextBoxNhapTenTaiKhoan.Name = "CTTextBoxNhapTenTaiKhoan";
            this.CTTextBoxNhapTenTaiKhoan.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxNhapTenTaiKhoan.PasswordChar = false;
            this.CTTextBoxNhapTenTaiKhoan.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxNhapTenTaiKhoan.PlaceholderText = "Nhập tên tài khoản";
            this.CTTextBoxNhapTenTaiKhoan.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxNhapTenTaiKhoan.TabIndex = 1;
            this.CTTextBoxNhapTenTaiKhoan.Texts = "";
            this.CTTextBoxNhapTenTaiKhoan.UnderlineedStyle = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.admin;
            this.pictureBox3.Location = new System.Drawing.Point(61, 294);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(61, 204);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.CCCD;
            this.pictureBox2.Location = new System.Drawing.Point(57, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.NameKH;
            this.pictureBox1.Location = new System.Drawing.Point(61, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 498);
            this.Controls.Add(this.PanelBackground);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormThemTaiKhoan";
            this.Activated += new System.EventHandler(this.FormThemTaiKhoan_Activated);
            this.SizeChanged += new System.EventHandler(this.FormThemTaiKhoan_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormThemTaiKhoan_Paint);
            this.Resize += new System.EventHandler(this.FormThemTaiKhoan_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Label LabelThemTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CTControls.CTTextBox CTTextBoxNhapMatKhau;
        private CTControls.CTTextBox CTTextBoxNhapMaNhanVien;
        private CTControls.CTTextBox CTTextBoxNhapTenTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}