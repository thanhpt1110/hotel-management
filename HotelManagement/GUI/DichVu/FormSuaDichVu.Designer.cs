namespace HotelManagement.GUI
{
    partial class FormSuaDichVu
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
            this.LabelSuaDichVu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctTextBoxTenDV = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxDonGia = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxSoLuong = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxMoTa = new HotelManagement.CTControls.CTTextBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.White;
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.LabelSuaDichVu);
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
            this.CTButtonCapNhat.Location = new System.Drawing.Point(180, 480);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 8;
            this.CTButtonCapNhat.Text = "Cập nhật";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // LabelSuaDichVu
            // 
            this.LabelSuaDichVu.AutoSize = true;
            this.LabelSuaDichVu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSuaDichVu.Location = new System.Drawing.Point(173, 9);
            this.LabelSuaDichVu.Name = "LabelSuaDichVu";
            this.LabelSuaDichVu.Size = new System.Drawing.Size(164, 37);
            this.LabelSuaDichVu.TabIndex = 0;
            this.LabelSuaDichVu.Text = "Sửa dịch vụ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ctTextBoxTenDV);
            this.panel1.Controls.Add(this.CTTextBoxDonGia);
            this.panel1.Controls.Add(this.CTTextBoxSoLuong);
            this.panel1.Controls.Add(this.ctTextBoxMoTa);
            this.panel1.Location = new System.Drawing.Point(53, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 404);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.note;
            this.pictureBox4.Location = new System.Drawing.Point(69, 304);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.SoLuong;
            this.pictureBox3.Location = new System.Drawing.Point(69, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(69, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.DichVu;
            this.pictureBox1.Location = new System.Drawing.Point(69, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ctTextBoxTenDV
            // 
            this.ctTextBoxTenDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxTenDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxTenDV.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxTenDV.BorderRadius = 0;
            this.ctTextBoxTenDV.BorderSize = 2;
            this.ctTextBoxTenDV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxTenDV.IsFocused = false;
            this.ctTextBoxTenDV.Location = new System.Drawing.Point(107, 41);
            this.ctTextBoxTenDV.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxTenDV.Multiline = false;
            this.ctTextBoxTenDV.Name = "ctTextBoxTenDV";
            this.ctTextBoxTenDV.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxTenDV.PasswordChar = false;
            this.ctTextBoxTenDV.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxTenDV.PlaceholderText = "Tên dịch vụ";
            this.ctTextBoxTenDV.ReadOnly = false;
            this.ctTextBoxTenDV.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxTenDV.TabIndex = 4;
            this.ctTextBoxTenDV.Texts = "";
            this.ctTextBoxTenDV.UnderlineedStyle = true;
            this.ctTextBoxTenDV._TextChanged += new System.EventHandler(this.ctTextBoxTenDV__TextChanged);
            // 
            // CTTextBoxDonGia
            // 
            this.CTTextBoxDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.CTTextBoxDonGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.CTTextBoxDonGia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.CTTextBoxDonGia.BorderRadius = 0;
            this.CTTextBoxDonGia.BorderSize = 2;
            this.CTTextBoxDonGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxDonGia.IsFocused = false;
            this.CTTextBoxDonGia.Location = new System.Drawing.Point(107, 123);
            this.CTTextBoxDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxDonGia.Multiline = false;
            this.CTTextBoxDonGia.Name = "CTTextBoxDonGia";
            this.CTTextBoxDonGia.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxDonGia.PasswordChar = false;
            this.CTTextBoxDonGia.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxDonGia.PlaceholderText = "Đơn giá";
            this.CTTextBoxDonGia.ReadOnly = false;
            this.CTTextBoxDonGia.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxDonGia.TabIndex = 5;
            this.CTTextBoxDonGia.Texts = "";
            this.CTTextBoxDonGia.UnderlineedStyle = true;
            this.CTTextBoxDonGia._TextChanged += new System.EventHandler(this.CTTextBoxDonGia__TextChanged);
            this.CTTextBoxDonGia.Load += new System.EventHandler(this.CTTextBoxDonGia_Load);
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
            this.CTTextBoxSoLuong.Location = new System.Drawing.Point(107, 212);
            this.CTTextBoxSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxSoLuong.Multiline = false;
            this.CTTextBoxSoLuong.Name = "CTTextBoxSoLuong";
            this.CTTextBoxSoLuong.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxSoLuong.PasswordChar = false;
            this.CTTextBoxSoLuong.PlaceholderColor = System.Drawing.Color.DimGray;
            this.CTTextBoxSoLuong.PlaceholderText = "Số lượng còn lại";
            this.CTTextBoxSoLuong.ReadOnly = false;
            this.CTTextBoxSoLuong.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxSoLuong.TabIndex = 6;
            this.CTTextBoxSoLuong.Texts = "";
            this.CTTextBoxSoLuong.UnderlineedStyle = true;
            this.CTTextBoxSoLuong._TextChanged += new System.EventHandler(this.CTTextBoxSoLuong__TextChanged);
            // 
            // ctTextBoxMoTa
            // 
            this.ctTextBoxMoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxMoTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxMoTa.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxMoTa.BorderRadius = 0;
            this.ctTextBoxMoTa.BorderSize = 2;
            this.ctTextBoxMoTa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxMoTa.IsFocused = false;
            this.ctTextBoxMoTa.Location = new System.Drawing.Point(107, 304);
            this.ctTextBoxMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxMoTa.Multiline = false;
            this.ctTextBoxMoTa.Name = "ctTextBoxMoTa";
            this.ctTextBoxMoTa.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxMoTa.PasswordChar = false;
            this.ctTextBoxMoTa.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxMoTa.PlaceholderText = "Mô tả";
            this.ctTextBoxMoTa.ReadOnly = false;
            this.ctTextBoxMoTa.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxMoTa.TabIndex = 7;
            this.ctTextBoxMoTa.Texts = "";
            this.ctTextBoxMoTa.UnderlineedStyle = true;
            this.ctTextBoxMoTa._TextChanged += new System.EventHandler(this.ctTextBoxMoTa__TextChanged);
            this.ctTextBoxMoTa.Load += new System.EventHandler(this.ctTextBoxMoTa_Load);
            // 
            // FormSuaDichVu
            // 
            this.AcceptButton = this.CTButtonCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 535);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaDichVu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaDichVu";
            this.Activated += new System.EventHandler(this.FormSuaDichVu_Activated);
            this.Load += new System.EventHandler(this.FormSuaDichVu_Load);
            this.SizeChanged += new System.EventHandler(this.FormSuaDichVu_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSuaDichVu_Paint);
            this.Resize += new System.EventHandler(this.FormSuaDichVu_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Label LabelSuaDichVu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox ctTextBoxTenDV;
        private CTControls.CTTextBox CTTextBoxDonGia;
        private CTControls.CTTextBox CTTextBoxSoLuong;
        private CTControls.CTTextBox ctTextBoxMoTa;
    }
}