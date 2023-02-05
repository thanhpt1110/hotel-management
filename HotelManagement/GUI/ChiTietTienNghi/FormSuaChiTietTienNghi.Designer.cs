namespace HotelManagement.GUI
{
    partial class FormSuaChiTietTienNghi
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
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.CTButtonCapNhat = new HotelManagement.CTControls.CTButton();
            this.LabelSuaChiTietTienNghi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CTTextBoxSoLuong = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxGhiChu = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxTenTienNghi = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.White;
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.LabelSuaChiTietTienNghi);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(500, 500);
            this.PanelBackground.TabIndex = 7;
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
            this.CTButtonThoat.Location = new System.Drawing.Point(322, 416);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 6;
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
            this.CTButtonCapNhat.Location = new System.Drawing.Point(160, 416);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 5;
            this.CTButtonCapNhat.Text = "Cập nhật";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // LabelSuaChiTietTienNghi
            // 
            this.LabelSuaChiTietTienNghi.AutoSize = true;
            this.LabelSuaChiTietTienNghi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSuaChiTietTienNghi.Location = new System.Drawing.Point(115, 20);
            this.LabelSuaChiTietTienNghi.Name = "LabelSuaChiTietTienNghi";
            this.LabelSuaChiTietTienNghi.Size = new System.Drawing.Size(282, 37);
            this.LabelSuaChiTietTienNghi.TabIndex = 0;
            this.LabelSuaChiTietTienNghi.Text = "Sửa chi tiết tiện nghi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.CTTextBoxSoLuong);
            this.panel1.Controls.Add(this.ctTextBoxGhiChu);
            this.panel1.Controls.Add(this.ctTextBoxTenTienNghi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(38, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 317);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.note;
            this.pictureBox4.Location = new System.Drawing.Point(84, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.SoLuong;
            this.pictureBox3.Location = new System.Drawing.Point(84, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // CTTextBoxSoLuong
            // 
            this.CTTextBoxSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.CTTextBoxSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.CTTextBoxSoLuong.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.CTTextBoxSoLuong.BorderRadius = 0;
            this.CTTextBoxSoLuong.BorderSize = 2;
            this.CTTextBoxSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxSoLuong.IsFocused = false;
            this.CTTextBoxSoLuong.Location = new System.Drawing.Point(121, 125);
            this.CTTextBoxSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxSoLuong.Multiline = false;
            this.CTTextBoxSoLuong.Name = "CTTextBoxSoLuong";
            this.CTTextBoxSoLuong.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxSoLuong.PasswordChar = false;
            this.CTTextBoxSoLuong.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxSoLuong.PlaceholderText = "Số lượng";
            this.CTTextBoxSoLuong.ReadOnly = false;
            this.CTTextBoxSoLuong.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxSoLuong.TabIndex = 3;
            this.CTTextBoxSoLuong.Texts = "";
            this.CTTextBoxSoLuong.UnderlineedStyle = true;
            this.CTTextBoxSoLuong._TextChanged += new System.EventHandler(this.CTTextBoxSoLuong__TextChanged);
            // 
            // ctTextBoxGhiChu
            // 
            this.ctTextBoxGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxGhiChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxGhiChu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxGhiChu.BorderRadius = 0;
            this.ctTextBoxGhiChu.BorderSize = 2;
            this.ctTextBoxGhiChu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxGhiChu.IsFocused = false;
            this.ctTextBoxGhiChu.Location = new System.Drawing.Point(121, 217);
            this.ctTextBoxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxGhiChu.Multiline = false;
            this.ctTextBoxGhiChu.Name = "ctTextBoxGhiChu";
            this.ctTextBoxGhiChu.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxGhiChu.PasswordChar = false;
            this.ctTextBoxGhiChu.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxGhiChu.PlaceholderText = "Mô tả";
            this.ctTextBoxGhiChu.ReadOnly = false;
            this.ctTextBoxGhiChu.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxGhiChu.TabIndex = 4;
            this.ctTextBoxGhiChu.Texts = "";
            this.ctTextBoxGhiChu.UnderlineedStyle = true;
            // 
            // ctTextBoxTenTienNghi
            // 
            this.ctTextBoxTenTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxTenTienNghi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxTenTienNghi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxTenTienNghi.BorderRadius = 0;
            this.ctTextBoxTenTienNghi.BorderSize = 2;
            this.ctTextBoxTenTienNghi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxTenTienNghi.IsFocused = false;
            this.ctTextBoxTenTienNghi.Location = new System.Drawing.Point(121, 39);
            this.ctTextBoxTenTienNghi.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxTenTienNghi.Multiline = false;
            this.ctTextBoxTenTienNghi.Name = "ctTextBoxTenTienNghi";
            this.ctTextBoxTenTienNghi.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxTenTienNghi.PasswordChar = false;
            this.ctTextBoxTenTienNghi.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxTenTienNghi.PlaceholderText = "Tên tiện nghi";
            this.ctTextBoxTenTienNghi.ReadOnly = true;
            this.ctTextBoxTenTienNghi.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxTenTienNghi.TabIndex = 2;
            this.ctTextBoxTenTienNghi.Texts = "";
            this.ctTextBoxTenTienNghi.UnderlineedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.DichVu;
            this.pictureBox1.Location = new System.Drawing.Point(84, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormSuaChiTietTienNghi
            // 
            this.AcceptButton = this.CTButtonCapNhat;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaChiTietTienNghi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaChiTietTienNghi";
            this.Activated += new System.EventHandler(this.FormSuaChiTietTienNghi_Activated);
            this.Load += new System.EventHandler(this.FormSuaChiTietTienNghi_Load);
            this.SizeChanged += new System.EventHandler(this.FormSuaChiTietTienNghi_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSuaChiTietTienNghi_Paint);
            this.Resize += new System.EventHandler(this.FormSuaChiTietTienNghi_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Label LabelSuaChiTietTienNghi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox ctTextBoxTenTienNghi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CTControls.CTTextBox CTTextBoxSoLuong;
        private CTControls.CTTextBox ctTextBoxGhiChu;
    }
}