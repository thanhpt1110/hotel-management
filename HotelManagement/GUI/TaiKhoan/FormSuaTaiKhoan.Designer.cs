namespace HotelManagement.GUI
{
    partial class FormSuaTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuaTaiKhoan));
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.LabelSuaTaiKhoan = new System.Windows.Forms.Label();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.CTButtonCapNhat = new HotelManagement.CTControls.CTButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctTextBox1 = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CTTextBoxNhapMatKhau = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxNhapTenTaiKhoan = new HotelManagement.CTControls.CTTextBox();
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
            this.PanelBackground.Controls.Add(this.LabelSuaTaiKhoan);
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(533, 498);
            this.PanelBackground.TabIndex = 3;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // LabelSuaTaiKhoan
            // 
            this.LabelSuaTaiKhoan.AutoSize = true;
            this.LabelSuaTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.LabelSuaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSuaTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.LabelSuaTaiKhoan.Location = new System.Drawing.Point(152, 9);
            this.LabelSuaTaiKhoan.Name = "LabelSuaTaiKhoan";
            this.LabelSuaTaiKhoan.Size = new System.Drawing.Size(192, 37);
            this.LabelSuaTaiKhoan.TabIndex = 0;
            this.LabelSuaTaiKhoan.Text = "Sửa tài khoản";
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
            this.CTButtonThoat.Location = new System.Drawing.Point(342, 445);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 9;
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
            this.CTButtonCapNhat.Location = new System.Drawing.Point(195, 445);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 8;
            this.CTButtonCapNhat.Text = "Cập nhật";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.ctTextBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.CTTextBoxNhapMatKhau);
            this.panel1.Controls.Add(this.CTTextBoxNhapTenTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(56, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 370);
            this.panel1.TabIndex = 0;
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.ctTextBox1.BorderRadius = 0;
            this.ctTextBox1.BorderSize = 1;
            this.ctTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.IsFocused = false;
            this.ctTextBox1.Location = new System.Drawing.Point(106, 45);
            this.ctTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox1.Multiline = false;
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBox1.PasswordChar = false;
            this.ctTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBox1.PlaceholderText = "Mã nhân viên";
            this.ctTextBox1.ReadOnly = true;
            this.ctTextBox1.Size = new System.Drawing.Size(250, 36);
            this.ctTextBox1.TabIndex = 4;
            this.ctTextBox1.Texts = "";
            this.ctTextBox1.UnderlineedStyle = true;
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
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "  Cấp độ quyền";
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
            this.CTTextBoxNhapMatKhau.ReadOnly = false;
            this.CTTextBoxNhapMatKhau.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxNhapMatKhau.TabIndex = 6;
            this.CTTextBoxNhapMatKhau.Texts = "";
            this.CTTextBoxNhapMatKhau.UnderlineedStyle = true;
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
            this.CTTextBoxNhapTenTaiKhoan.ReadOnly = false;
            this.CTTextBoxNhapTenTaiKhoan.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxNhapTenTaiKhoan.TabIndex = 5;
            this.CTTextBoxNhapTenTaiKhoan.Texts = "";
            this.CTTextBoxNhapTenTaiKhoan.UnderlineedStyle = true;
            // 
            // FormSuaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 498);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaTaiKhoan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaTaiKhoan";
            this.Activated += new System.EventHandler(this.FormSuaTaiKhoan_Activated);
            this.Load += new System.EventHandler(this.FormSuaTaiKhoan_Load);
            this.SizeChanged += new System.EventHandler(this.FormSuaTaiKhoan_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSuaTaiKhoan_Paint);
            this.Resize += new System.EventHandler(this.FormSuaTaiKhoan_Resize);
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
        private System.Windows.Forms.Label LabelSuaTaiKhoan;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CTControls.CTTextBox CTTextBoxNhapMatKhau;
        private CTControls.CTTextBox CTTextBoxNhapTenTaiKhoan;
        private CTControls.CTTextBox ctTextBox1;
    }
}