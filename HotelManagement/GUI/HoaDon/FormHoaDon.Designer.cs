namespace HotelManagement.GUI
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.Printer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxTenNV = new System.Windows.Forms.TextBox();
            this.TextBoxSoNgay = new System.Windows.Forms.TextBox();
            this.TextBoxLoaiPhong = new System.Windows.Forms.TextBox();
            this.TextBoxMaPhong = new System.Windows.Forms.TextBox();
            this.TextBoxSoHD = new System.Windows.Forms.TextBox();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.TextBoxNgayHD = new System.Windows.Forms.TextBox();
            this.TextBoxTenKH = new System.Windows.Forms.TextBox();
            this.LabelTongTien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelNgayHD = new System.Windows.Forms.Label();
            this.LabelTenKH = new System.Windows.Forms.Label();
            this.LabelHoaDon = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ctClose1 = new HotelManagement.CTControls.CTClose();
            this.ctMaximize1 = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize1 = new HotelManagement.CTControls.CTMinimize();
            this.PanelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.AutoScroll = true;
            this.PanelBackground.Controls.Add(this.ctClose1);
            this.PanelBackground.Controls.Add(this.Printer);
            this.PanelBackground.Controls.Add(this.ctMaximize1);
            this.PanelBackground.Controls.Add(this.ctMinimize1);
            this.PanelBackground.Controls.Add(this.pictureBox1);
            this.PanelBackground.Controls.Add(this.TextBoxTenNV);
            this.PanelBackground.Controls.Add(this.TextBoxSoNgay);
            this.PanelBackground.Controls.Add(this.TextBoxLoaiPhong);
            this.PanelBackground.Controls.Add(this.TextBoxMaPhong);
            this.PanelBackground.Controls.Add(this.TextBoxSoHD);
            this.PanelBackground.Controls.Add(this.PictureIcon);
            this.PanelBackground.Controls.Add(this.TextBoxNgayHD);
            this.PanelBackground.Controls.Add(this.TextBoxTenKH);
            this.PanelBackground.Controls.Add(this.LabelTongTien);
            this.PanelBackground.Controls.Add(this.label8);
            this.PanelBackground.Controls.Add(this.DataGridViewDichVu);
            this.PanelBackground.Controls.Add(this.label4);
            this.PanelBackground.Controls.Add(this.label3);
            this.PanelBackground.Controls.Add(this.label7);
            this.PanelBackground.Controls.Add(this.label6);
            this.PanelBackground.Controls.Add(this.label5);
            this.PanelBackground.Controls.Add(this.LabelNgayHD);
            this.PanelBackground.Controls.Add(this.LabelTenKH);
            this.PanelBackground.Controls.Add(this.LabelHoaDon);
            this.PanelBackground.Controls.Add(this.LabelTitle);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(563, 677);
            this.PanelBackground.TabIndex = 0;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // Printer
            // 
            this.Printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printer.Image = global::HotelManagement.Properties.Resources.printer;
            this.Printer.Location = new System.Drawing.Point(445, 61);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(40, 40);
            this.Printer.TabIndex = 37;
            this.Printer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.heart;
            this.pictureBox1.Location = new System.Drawing.Point(360, 626);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxTenNV
            // 
            this.TextBoxTenNV.BackColor = System.Drawing.Color.White;
            this.TextBoxTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTenNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTenNV.Location = new System.Drawing.Point(109, 268);
            this.TextBoxTenNV.Name = "TextBoxTenNV";
            this.TextBoxTenNV.ReadOnly = true;
            this.TextBoxTenNV.Size = new System.Drawing.Size(199, 18);
            this.TextBoxTenNV.TabIndex = 30;
            this.TextBoxTenNV.Text = "Họ tên nhân viên";
            // 
            // TextBoxSoNgay
            // 
            this.TextBoxSoNgay.BackColor = System.Drawing.Color.White;
            this.TextBoxSoNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSoNgay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSoNgay.Location = new System.Drawing.Point(426, 267);
            this.TextBoxSoNgay.Name = "TextBoxSoNgay";
            this.TextBoxSoNgay.ReadOnly = true;
            this.TextBoxSoNgay.Size = new System.Drawing.Size(72, 18);
            this.TextBoxSoNgay.TabIndex = 29;
            this.TextBoxSoNgay.Text = "0 ngày";
            // 
            // TextBoxLoaiPhong
            // 
            this.TextBoxLoaiPhong.BackColor = System.Drawing.Color.White;
            this.TextBoxLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoaiPhong.Location = new System.Drawing.Point(440, 225);
            this.TextBoxLoaiPhong.Name = "TextBoxLoaiPhong";
            this.TextBoxLoaiPhong.ReadOnly = true;
            this.TextBoxLoaiPhong.Size = new System.Drawing.Size(88, 18);
            this.TextBoxLoaiPhong.TabIndex = 28;
            this.TextBoxLoaiPhong.Text = "Phòng đơn";
            // 
            // TextBoxMaPhong
            // 
            this.TextBoxMaPhong.BackColor = System.Drawing.Color.White;
            this.TextBoxMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMaPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaPhong.Location = new System.Drawing.Point(440, 187);
            this.TextBoxMaPhong.Name = "TextBoxMaPhong";
            this.TextBoxMaPhong.ReadOnly = true;
            this.TextBoxMaPhong.Size = new System.Drawing.Size(72, 18);
            this.TextBoxMaPhong.TabIndex = 27;
            this.TextBoxMaPhong.Text = "P000";
            // 
            // TextBoxSoHD
            // 
            this.TextBoxSoHD.BackColor = System.Drawing.Color.White;
            this.TextBoxSoHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSoHD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSoHD.Location = new System.Drawing.Point(109, 227);
            this.TextBoxSoHD.Name = "TextBoxSoHD";
            this.TextBoxSoHD.ReadOnly = true;
            this.TextBoxSoHD.Size = new System.Drawing.Size(72, 18);
            this.TextBoxSoHD.TabIndex = 26;
            this.TextBoxSoHD.Text = "Số HD";
            // 
            // PictureIcon
            // 
            this.PictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.PictureIcon.Image = global::HotelManagement.Properties.Resources.pictureIconLogoHD;
            this.PictureIcon.Location = new System.Drawing.Point(70, 54);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(72, 50);
            this.PictureIcon.TabIndex = 32;
            this.PictureIcon.TabStop = false;
            // 
            // TextBoxNgayHD
            // 
            this.TextBoxNgayHD.BackColor = System.Drawing.Color.White;
            this.TextBoxNgayHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNgayHD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNgayHD.Location = new System.Drawing.Point(144, 186);
            this.TextBoxNgayHD.Name = "TextBoxNgayHD";
            this.TextBoxNgayHD.ReadOnly = true;
            this.TextBoxNgayHD.Size = new System.Drawing.Size(210, 18);
            this.TextBoxNgayHD.TabIndex = 31;
            this.TextBoxNgayHD.Text = "dd/MM/yyyy hh:mm:ss AM";
            // 
            // TextBoxTenKH
            // 
            this.TextBoxTenKH.BackColor = System.Drawing.Color.White;
            this.TextBoxTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTenKH.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTenKH.Location = new System.Drawing.Point(139, 130);
            this.TextBoxTenKH.Name = "TextBoxTenKH";
            this.TextBoxTenKH.ReadOnly = true;
            this.TextBoxTenKH.Size = new System.Drawing.Size(245, 28);
            this.TextBoxTenKH.TabIndex = 25;
            this.TextBoxTenKH.Text = "Tên khách hàng";
            // 
            // LabelTongTien
            // 
            this.LabelTongTien.AutoSize = true;
            this.LabelTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTongTien.Location = new System.Drawing.Point(226, 543);
            this.LabelTongTien.Name = "LabelTongTien";
            this.LabelTongTien.Size = new System.Drawing.Size(116, 30);
            this.LabelTongTien.TabIndex = 24;
            this.LabelTongTien.Text = "Tổng tiền: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cảm ơn quý khách!";
            // 
            // DataGridViewDichVu
            // 
            this.DataGridViewDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridViewDichVu.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DichVu,
            this.GiaTien,
            this.SoLuong,
            this.ThanhTien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDichVu.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDichVu.Location = new System.Drawing.Point(25, 340);
            this.DataGridViewDichVu.Name = "DataGridViewDichVu";
            this.DataGridViewDichVu.RowHeadersVisible = false;
            this.DataGridViewDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDichVu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewDichVu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridViewDichVu.Size = new System.Drawing.Size(503, 181);
            this.DataGridViewDichVu.TabIndex = 22;
            // 
            // DichVu
            // 
            this.DichVu.FillWeight = 119.1806F;
            this.DichVu.HeaderText = "Dịch vụ";
            this.DichVu.Name = "DichVu";
            this.DichVu.Width = 160;
            // 
            // GiaTien
            // 
            this.GiaTien.FillWeight = 88.25601F;
            this.GiaTien.HeaderText = "Giá tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Width = 110;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 94.03709F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 110;
            // 
            // ThanhTien
            // 
            this.ThanhTien.FillWeight = 98.5263F;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số hóa đơn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Số ngày:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Loại phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mã phòng:";
            // 
            // LabelNgayHD
            // 
            this.LabelNgayHD.AutoSize = true;
            this.LabelNgayHD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNgayHD.Location = new System.Drawing.Point(22, 187);
            this.LabelNgayHD.Name = "LabelNgayHD";
            this.LabelNgayHD.Size = new System.Drawing.Size(120, 17);
            this.LabelNgayHD.TabIndex = 16;
            this.LabelNgayHD.Text = "Ngày lập hóa đơn:";
            // 
            // LabelTenKH
            // 
            this.LabelTenKH.AutoSize = true;
            this.LabelTenKH.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTenKH.Location = new System.Drawing.Point(22, 140);
            this.LabelTenKH.Name = "LabelTenKH";
            this.LabelTenKH.Size = new System.Drawing.Size(111, 17);
            this.LabelTenKH.TabIndex = 15;
            this.LabelTenKH.Text = "Tên khách hàng: ";
            // 
            // LabelHoaDon
            // 
            this.LabelHoaDon.AutoSize = true;
            this.LabelHoaDon.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(176)))), ((int)(((byte)(32)))));
            this.LabelHoaDon.Location = new System.Drawing.Point(224, 64);
            this.LabelHoaDon.Name = "LabelHoaDon";
            this.LabelHoaDon.Size = new System.Drawing.Size(127, 37);
            this.LabelHoaDon.TabIndex = 14;
            this.LabelHoaDon.Text = "Hóa đơn";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(61, 17);
            this.LabelTitle.TabIndex = 13;
            this.LabelTitle.Text = "Hóa đơn";
            // 
            // ctClose1
            // 
            this.ctClose1.BackColor = System.Drawing.Color.Transparent;
            this.ctClose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctClose1.BackgroundImage")));
            this.ctClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctClose1.Location = new System.Drawing.Point(536, 10);
            this.ctClose1.Name = "ctClose1";
            this.ctClose1.Size = new System.Drawing.Size(15, 15);
            this.ctClose1.TabIndex = 38;
            this.ctClose1.Click += new System.EventHandler(this.ctClose1_Click);
            // 
            // ctMaximize1
            // 
            this.ctMaximize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMaximize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMaximize1.BackgroundImage")));
            this.ctMaximize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMaximize1.Location = new System.Drawing.Point(470, 10);
            this.ctMaximize1.Name = "ctMaximize1";
            this.ctMaximize1.Size = new System.Drawing.Size(15, 15);
            this.ctMaximize1.TabIndex = 36;
            // 
            // ctMinimize1
            // 
            this.ctMinimize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMinimize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMinimize1.BackgroundImage")));
            this.ctMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMinimize1.Location = new System.Drawing.Point(503, 10);
            this.ctMinimize1.Name = "ctMinimize1";
            this.ctMinimize1.Size = new System.Drawing.Size(15, 15);
            this.ctMinimize1.TabIndex = 35;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 677);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Activated += new System.EventHandler(this.FormHoaDon_Activated);
            this.SizeChanged += new System.EventHandler(this.FormHoaDon_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormHoaDon_Paint);
            this.Resize += new System.EventHandler(this.FormHoaDon_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTMaximize ctMaximize1;
        private CTControls.CTMinimize ctMinimize1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxTenNV;
        private System.Windows.Forms.TextBox TextBoxSoNgay;
        private System.Windows.Forms.TextBox TextBoxLoaiPhong;
        private System.Windows.Forms.TextBox TextBoxMaPhong;
        private System.Windows.Forms.TextBox TextBoxSoHD;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.TextBox TextBoxNgayHD;
        private System.Windows.Forms.TextBox TextBoxTenKH;
        private System.Windows.Forms.Label LabelTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DataGridViewDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelNgayHD;
        private System.Windows.Forms.Label LabelTenKH;
        private System.Windows.Forms.Label LabelHoaDon;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.PictureBox Printer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private CTControls.CTClose ctClose1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}