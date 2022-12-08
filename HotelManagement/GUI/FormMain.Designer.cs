namespace HotelManagement
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.panelMainChildForm = new System.Windows.Forms.Panel();
            this.panelInfomation = new System.Windows.Forms.Panel();
            this.labelPhienBan = new System.Windows.Forms.Label();
            this.labelBanQuyen = new System.Windows.Forms.Label();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.PanelTienNghi = new System.Windows.Forms.Panel();
            this.PanelPhong = new System.Windows.Forms.Panel();
            this.panelName = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.labelTenKhachSan = new System.Windows.Forms.Label();
            this.ButtonThongKe = new System.Windows.Forms.Button();
            this.ButtonQuanLyNhanVien = new System.Windows.Forms.Button();
            this.ButtonQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.ButtonChiTietTienNghi = new System.Windows.Forms.Button();
            this.ButtonTienNghi = new System.Windows.Forms.Button();
            this.ButtonQuanLyTienNghi = new System.Windows.Forms.Button();
            this.ButtonQuanLyDichVu = new System.Windows.Forms.Button();
            this.ButtonLoaiPhong = new System.Windows.Forms.Button();
            this.ButtonPhong = new System.Windows.Forms.Button();
            this.ButtonQuanLyPhong = new System.Windows.Forms.Button();
            this.ButtonQuanLyKhachHang = new System.Windows.Forms.Button();
            this.ButtonDanhSachHoaDon = new System.Windows.Forms.Button();
            this.ButtonDatPhong = new System.Windows.Forms.Button();
            this.ButtonSoDoPhong = new System.Windows.Forms.Button();
            this.ButtonTrangChu = new System.Windows.Forms.Button();
            this.PictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.ctMaximize1 = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize1 = new HotelManagement.CTControls.CTMinimize();
            this.ctClose1 = new HotelManagement.CTControls.CTClose();
            this.PanelBackground.SuspendLayout();
            this.panelInfomation.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.PanelTienNghi.SuspendLayout();
            this.PanelPhong.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.Controls.Add(this.panelMainChildForm);
            this.PanelBackground.Controls.Add(this.panelInfomation);
            this.PanelBackground.Controls.Add(this.Sidebar);
            this.PanelBackground.Controls.Add(this.panelName);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(1522, 934);
            this.PanelBackground.TabIndex = 0;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            // 
            // panelMainChildForm
            // 
            this.panelMainChildForm.AutoScroll = true;
            this.panelMainChildForm.BackColor = System.Drawing.Color.White;
            this.panelMainChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainChildForm.Location = new System.Drawing.Point(262, 60);
            this.panelMainChildForm.Name = "panelMainChildForm";
            this.panelMainChildForm.Size = new System.Drawing.Size(1260, 833);
            this.panelMainChildForm.TabIndex = 7;
            // 
            // panelInfomation
            // 
            this.panelInfomation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.panelInfomation.Controls.Add(this.labelPhienBan);
            this.panelInfomation.Controls.Add(this.labelBanQuyen);
            this.panelInfomation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfomation.Location = new System.Drawing.Point(262, 893);
            this.panelInfomation.Name = "panelInfomation";
            this.panelInfomation.Size = new System.Drawing.Size(1260, 41);
            this.panelInfomation.TabIndex = 6;
            // 
            // labelPhienBan
            // 
            this.labelPhienBan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhienBan.AutoSize = true;
            this.labelPhienBan.Location = new System.Drawing.Point(1156, 11);
            this.labelPhienBan.Name = "labelPhienBan";
            this.labelPhienBan.Size = new System.Drawing.Size(92, 17);
            this.labelPhienBan.TabIndex = 1;
            this.labelPhienBan.Text = "Version 1.0.0";
            // 
            // labelBanQuyen
            // 
            this.labelBanQuyen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBanQuyen.AutoSize = true;
            this.labelBanQuyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanQuyen.Location = new System.Drawing.Point(6, 11);
            this.labelBanQuyen.Name = "labelBanQuyen";
            this.labelBanQuyen.Size = new System.Drawing.Size(398, 21);
            this.labelBanQuyen.TabIndex = 0;
            this.labelBanQuyen.Text = "Copyright © 2022 TBT Coorporation. All rights reserved.";
            // 
            // Sidebar
            // 
            this.Sidebar.AutoScroll = true;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
            this.Sidebar.Controls.Add(this.ButtonThongKe);
            this.Sidebar.Controls.Add(this.ButtonQuanLyNhanVien);
            this.Sidebar.Controls.Add(this.ButtonQuanLyTaiKhoan);
            this.Sidebar.Controls.Add(this.PanelTienNghi);
            this.Sidebar.Controls.Add(this.ButtonQuanLyTienNghi);
            this.Sidebar.Controls.Add(this.ButtonQuanLyDichVu);
            this.Sidebar.Controls.Add(this.PanelPhong);
            this.Sidebar.Controls.Add(this.ButtonQuanLyPhong);
            this.Sidebar.Controls.Add(this.ButtonQuanLyKhachHang);
            this.Sidebar.Controls.Add(this.ButtonDanhSachHoaDon);
            this.Sidebar.Controls.Add(this.ButtonDatPhong);
            this.Sidebar.Controls.Add(this.ButtonSoDoPhong);
            this.Sidebar.Controls.Add(this.ButtonTrangChu);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 60);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(262, 874);
            this.Sidebar.TabIndex = 5;
            // 
            // PanelTienNghi
            // 
            this.PanelTienNghi.Controls.Add(this.ButtonChiTietTienNghi);
            this.PanelTienNghi.Controls.Add(this.ButtonTienNghi);
            this.PanelTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTienNghi.Location = new System.Drawing.Point(0, 483);
            this.PanelTienNghi.Name = "PanelTienNghi";
            this.PanelTienNghi.Size = new System.Drawing.Size(262, 100);
            this.PanelTienNghi.TabIndex = 17;
            // 
            // PanelPhong
            // 
            this.PanelPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(189)))), ((int)(((byte)(197)))));
            this.PanelPhong.Controls.Add(this.ButtonLoaiPhong);
            this.PanelPhong.Controls.Add(this.ButtonPhong);
            this.PanelPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPhong.Location = new System.Drawing.Point(0, 288);
            this.PanelPhong.Name = "PanelPhong";
            this.PanelPhong.Size = new System.Drawing.Size(262, 99);
            this.PanelPhong.TabIndex = 6;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
            this.panelName.Controls.Add(this.PictureBoxMenu);
            this.panelName.Controls.Add(this.panelControlBox);
            this.panelName.Controls.Add(this.labelTenKhachSan);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(1522, 60);
            this.panelName.TabIndex = 4;
            this.panelName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelName_MouseDown);
            // 
            // panelControlBox
            // 
            this.panelControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
            this.panelControlBox.Controls.Add(this.ctMaximize1);
            this.panelControlBox.Controls.Add(this.ctMinimize1);
            this.panelControlBox.Controls.Add(this.ctClose1);
            this.panelControlBox.Location = new System.Drawing.Point(1424, 3);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(95, 30);
            this.panelControlBox.TabIndex = 6;
            this.panelControlBox.MouseLeave += new System.EventHandler(this.panelControlBox_MouseLeave);
            this.panelControlBox.MouseHover += new System.EventHandler(this.panelControlBox_MouseHover);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseMove);
            // 
            // labelTenKhachSan
            // 
            this.labelTenKhachSan.AutoSize = true;
            this.labelTenKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.labelTenKhachSan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKhachSan.ForeColor = System.Drawing.Color.White;
            this.labelTenKhachSan.Location = new System.Drawing.Point(83, 21);
            this.labelTenKhachSan.Name = "labelTenKhachSan";
            this.labelTenKhachSan.Size = new System.Drawing.Size(132, 21);
            this.labelTenKhachSan.TabIndex = 2;
            this.labelTenKhachSan.Text = "Khách sạn IT008";
            // 
            // ButtonThongKe
            // 
            this.ButtonThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonThongKe.FlatAppearance.BorderSize = 0;
            this.ButtonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThongKe.Image = global::HotelManagement.Properties.Resources.MenuThongKe;
            this.ButtonThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonThongKe.Location = new System.Drawing.Point(0, 679);
            this.ButtonThongKe.Name = "ButtonThongKe";
            this.ButtonThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonThongKe.Size = new System.Drawing.Size(262, 48);
            this.ButtonThongKe.TabIndex = 20;
            this.ButtonThongKe.TabStop = false;
            this.ButtonThongKe.Text = "    Thống kê";
            this.ButtonThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonThongKe.UseVisualStyleBackColor = true;
            this.ButtonThongKe.Click += new System.EventHandler(this.ButtonThongKe_Click);
            // 
            // ButtonQuanLyNhanVien
            // 
            this.ButtonQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonQuanLyNhanVien.FlatAppearance.BorderSize = 0;
            this.ButtonQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuanLyNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuanLyNhanVien.Image = global::HotelManagement.Properties.Resources.MenuQuanLyNhanVien;
            this.ButtonQuanLyNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyNhanVien.Location = new System.Drawing.Point(0, 631);
            this.ButtonQuanLyNhanVien.Name = "ButtonQuanLyNhanVien";
            this.ButtonQuanLyNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonQuanLyNhanVien.Size = new System.Drawing.Size(262, 48);
            this.ButtonQuanLyNhanVien.TabIndex = 19;
            this.ButtonQuanLyNhanVien.TabStop = false;
            this.ButtonQuanLyNhanVien.Text = "    Quản lý nhân viên";
            this.ButtonQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.ButtonQuanLyNhanVien.Click += new System.EventHandler(this.ButtonQuanLyNhanVien_Click);
            // 
            // ButtonQuanLyTaiKhoan
            // 
            this.ButtonQuanLyTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonQuanLyTaiKhoan.FlatAppearance.BorderSize = 0;
            this.ButtonQuanLyTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuanLyTaiKhoan.Image = global::HotelManagement.Properties.Resources.MenuQuanLyTaiKhoan;
            this.ButtonQuanLyTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyTaiKhoan.Location = new System.Drawing.Point(0, 583);
            this.ButtonQuanLyTaiKhoan.Name = "ButtonQuanLyTaiKhoan";
            this.ButtonQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonQuanLyTaiKhoan.Size = new System.Drawing.Size(262, 48);
            this.ButtonQuanLyTaiKhoan.TabIndex = 18;
            this.ButtonQuanLyTaiKhoan.TabStop = false;
            this.ButtonQuanLyTaiKhoan.Text = "    Quản lý tài khoản";
            this.ButtonQuanLyTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.ButtonQuanLyTaiKhoan.Click += new System.EventHandler(this.ButtonQuanLyTaiKhoan_Click);
            // 
            // ButtonChiTietTienNghi
            // 
            this.ButtonChiTietTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(189)))), ((int)(((byte)(197)))));
            this.ButtonChiTietTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonChiTietTienNghi.FlatAppearance.BorderSize = 0;
            this.ButtonChiTietTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChiTietTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonChiTietTienNghi.Image = global::HotelManagement.Properties.Resources.MenuChiTietTienNghi;
            this.ButtonChiTietTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonChiTietTienNghi.Location = new System.Drawing.Point(0, 48);
            this.ButtonChiTietTienNghi.Name = "ButtonChiTietTienNghi";
            this.ButtonChiTietTienNghi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonChiTietTienNghi.Size = new System.Drawing.Size(262, 48);
            this.ButtonChiTietTienNghi.TabIndex = 9;
            this.ButtonChiTietTienNghi.TabStop = false;
            this.ButtonChiTietTienNghi.Text = "    Chi tiết tiện nghi";
            this.ButtonChiTietTienNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonChiTietTienNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonChiTietTienNghi.UseVisualStyleBackColor = false;
            this.ButtonChiTietTienNghi.Click += new System.EventHandler(this.ButtonChiTietTienNghi_Click);
            // 
            // ButtonTienNghi
            // 
            this.ButtonTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(189)))), ((int)(((byte)(197)))));
            this.ButtonTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonTienNghi.FlatAppearance.BorderSize = 0;
            this.ButtonTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTienNghi.Image = global::HotelManagement.Properties.Resources.MenuTienNghi;
            this.ButtonTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTienNghi.Location = new System.Drawing.Point(0, 0);
            this.ButtonTienNghi.Name = "ButtonTienNghi";
            this.ButtonTienNghi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonTienNghi.Size = new System.Drawing.Size(262, 48);
            this.ButtonTienNghi.TabIndex = 8;
            this.ButtonTienNghi.TabStop = false;
            this.ButtonTienNghi.Text = "    Tiện nghi";
            this.ButtonTienNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTienNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonTienNghi.UseVisualStyleBackColor = false;
            this.ButtonTienNghi.Click += new System.EventHandler(this.ButtonTienNghi_Click);
            // 
            // ButtonQuanLyTienNghi
            // 
            this.ButtonQuanLyTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonQuanLyTienNghi.FlatAppearance.BorderSize = 0;
            this.ButtonQuanLyTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuanLyTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuanLyTienNghi.Image = global::HotelManagement.Properties.Resources.MenuQuanLy;
            this.ButtonQuanLyTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyTienNghi.Location = new System.Drawing.Point(0, 435);
            this.ButtonQuanLyTienNghi.Name = "ButtonQuanLyTienNghi";
            this.ButtonQuanLyTienNghi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonQuanLyTienNghi.Size = new System.Drawing.Size(262, 48);
            this.ButtonQuanLyTienNghi.TabIndex = 9;
            this.ButtonQuanLyTienNghi.TabStop = false;
            this.ButtonQuanLyTienNghi.Text = "    Quản lý tiện nghi";
            this.ButtonQuanLyTienNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyTienNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonQuanLyTienNghi.UseVisualStyleBackColor = true;
            this.ButtonQuanLyTienNghi.Click += new System.EventHandler(this.ButtonQuanLyTienNghi_Click);
            // 
            // ButtonQuanLyDichVu
            // 
            this.ButtonQuanLyDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonQuanLyDichVu.FlatAppearance.BorderSize = 0;
            this.ButtonQuanLyDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuanLyDichVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuanLyDichVu.Image = global::HotelManagement.Properties.Resources.MenuQuanLyDichVu;
            this.ButtonQuanLyDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyDichVu.Location = new System.Drawing.Point(0, 387);
            this.ButtonQuanLyDichVu.Name = "ButtonQuanLyDichVu";
            this.ButtonQuanLyDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonQuanLyDichVu.Size = new System.Drawing.Size(262, 48);
            this.ButtonQuanLyDichVu.TabIndex = 7;
            this.ButtonQuanLyDichVu.TabStop = false;
            this.ButtonQuanLyDichVu.Text = "    Quản lý dịch vụ";
            this.ButtonQuanLyDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonQuanLyDichVu.UseVisualStyleBackColor = true;
            this.ButtonQuanLyDichVu.Click += new System.EventHandler(this.ButtonQuanLyDichVu_Click);
            // 
            // ButtonLoaiPhong
            // 
            this.ButtonLoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLoaiPhong.FlatAppearance.BorderSize = 0;
            this.ButtonLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoaiPhong.Image = global::HotelManagement.Properties.Resources.MenuLoaiPhong;
            this.ButtonLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLoaiPhong.Location = new System.Drawing.Point(0, 48);
            this.ButtonLoaiPhong.Name = "ButtonLoaiPhong";
            this.ButtonLoaiPhong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonLoaiPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonLoaiPhong.TabIndex = 7;
            this.ButtonLoaiPhong.TabStop = false;
            this.ButtonLoaiPhong.Text = "    Loại phòng";
            this.ButtonLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLoaiPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLoaiPhong.UseVisualStyleBackColor = true;
            this.ButtonLoaiPhong.Click += new System.EventHandler(this.ButtonLoaiPhong_Click);
            // 
            // ButtonPhong
            // 
            this.ButtonPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPhong.FlatAppearance.BorderSize = 0;
            this.ButtonPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPhong.Image = global::HotelManagement.Properties.Resources.MenuPhong;
            this.ButtonPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPhong.Location = new System.Drawing.Point(0, 0);
            this.ButtonPhong.Name = "ButtonPhong";
            this.ButtonPhong.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ButtonPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonPhong.TabIndex = 6;
            this.ButtonPhong.TabStop = false;
            this.ButtonPhong.Text = "    Phòng";
            this.ButtonPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonPhong.UseVisualStyleBackColor = true;
            this.ButtonPhong.Click += new System.EventHandler(this.ButtonPhong_Click);
            // 
            // ButtonQuanLyPhong
            // 
            this.ButtonQuanLyPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonQuanLyPhong.FlatAppearance.BorderSize = 0;
            this.ButtonQuanLyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuanLyPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuanLyPhong.Image = global::HotelManagement.Properties.Resources.MenuQuanLy;
            this.ButtonQuanLyPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyPhong.Location = new System.Drawing.Point(0, 240);
            this.ButtonQuanLyPhong.Name = "ButtonQuanLyPhong";
            this.ButtonQuanLyPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonQuanLyPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonQuanLyPhong.TabIndex = 5;
            this.ButtonQuanLyPhong.TabStop = false;
            this.ButtonQuanLyPhong.Text = "    Quản lý phòng";
            this.ButtonQuanLyPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonQuanLyPhong.UseVisualStyleBackColor = true;
            this.ButtonQuanLyPhong.Click += new System.EventHandler(this.ButtonQuanLyPhong_Click);
            // 
            // ButtonQuanLyKhachHang
            // 
            this.ButtonQuanLyKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonQuanLyKhachHang.FlatAppearance.BorderSize = 0;
            this.ButtonQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuanLyKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuanLyKhachHang.Image = global::HotelManagement.Properties.Resources.MenuQuanLyKhachHang;
            this.ButtonQuanLyKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyKhachHang.Location = new System.Drawing.Point(0, 192);
            this.ButtonQuanLyKhachHang.Name = "ButtonQuanLyKhachHang";
            this.ButtonQuanLyKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonQuanLyKhachHang.Size = new System.Drawing.Size(262, 48);
            this.ButtonQuanLyKhachHang.TabIndex = 4;
            this.ButtonQuanLyKhachHang.TabStop = false;
            this.ButtonQuanLyKhachHang.Text = "    Quản lý khách hàng";
            this.ButtonQuanLyKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonQuanLyKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonQuanLyKhachHang.UseVisualStyleBackColor = true;
            this.ButtonQuanLyKhachHang.Click += new System.EventHandler(this.ButtonQuanLyKhachHang_Click);
            // 
            // ButtonDanhSachHoaDon
            // 
            this.ButtonDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachHoaDon.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachHoaDon.Image = global::HotelManagement.Properties.Resources.MenuDanhSachHoaDon;
            this.ButtonDanhSachHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachHoaDon.Location = new System.Drawing.Point(0, 144);
            this.ButtonDanhSachHoaDon.Name = "ButtonDanhSachHoaDon";
            this.ButtonDanhSachHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachHoaDon.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachHoaDon.TabIndex = 3;
            this.ButtonDanhSachHoaDon.TabStop = false;
            this.ButtonDanhSachHoaDon.Text = "    Danh sách hóa đơn";
            this.ButtonDanhSachHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachHoaDon.UseVisualStyleBackColor = true;
            this.ButtonDanhSachHoaDon.Click += new System.EventHandler(this.ButtonDanhSachHoaDon_Click);
            // 
            // ButtonDatPhong
            // 
            this.ButtonDatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDatPhong.FlatAppearance.BorderSize = 0;
            this.ButtonDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDatPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDatPhong.Image = global::HotelManagement.Properties.Resources.MenuDatPhong;
            this.ButtonDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDatPhong.Location = new System.Drawing.Point(0, 96);
            this.ButtonDatPhong.Name = "ButtonDatPhong";
            this.ButtonDatPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDatPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonDatPhong.TabIndex = 2;
            this.ButtonDatPhong.TabStop = false;
            this.ButtonDatPhong.Text = "    Đặt phòng";
            this.ButtonDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDatPhong.UseVisualStyleBackColor = true;
            this.ButtonDatPhong.Click += new System.EventHandler(this.ButtonDatPhong_Click);
            // 
            // ButtonSoDoPhong
            // 
            this.ButtonSoDoPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSoDoPhong.FlatAppearance.BorderSize = 0;
            this.ButtonSoDoPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSoDoPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSoDoPhong.Image = global::HotelManagement.Properties.Resources.MenuSoDoPhong;
            this.ButtonSoDoPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSoDoPhong.Location = new System.Drawing.Point(0, 48);
            this.ButtonSoDoPhong.Name = "ButtonSoDoPhong";
            this.ButtonSoDoPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonSoDoPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonSoDoPhong.TabIndex = 1;
            this.ButtonSoDoPhong.TabStop = false;
            this.ButtonSoDoPhong.Text = "    Sơ đồ phòng";
            this.ButtonSoDoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSoDoPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSoDoPhong.UseVisualStyleBackColor = true;
            this.ButtonSoDoPhong.Click += new System.EventHandler(this.ButtonSoDoPhong_Click);
            // 
            // ButtonTrangChu
            // 
            this.ButtonTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonTrangChu.FlatAppearance.BorderSize = 0;
            this.ButtonTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTrangChu.Image = global::HotelManagement.Properties.Resources.MenuTrangChu;
            this.ButtonTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTrangChu.Location = new System.Drawing.Point(0, 0);
            this.ButtonTrangChu.Name = "ButtonTrangChu";
            this.ButtonTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonTrangChu.Size = new System.Drawing.Size(262, 48);
            this.ButtonTrangChu.TabIndex = 0;
            this.ButtonTrangChu.TabStop = false;
            this.ButtonTrangChu.Text = "    Trang chủ";
            this.ButtonTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonTrangChu.UseVisualStyleBackColor = true;
            this.ButtonTrangChu.Click += new System.EventHandler(this.ButtonTrangChu_Click);
            // 
            // PictureBoxMenu
            // 
            this.PictureBoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxMenu.Image = global::HotelManagement.Properties.Resources.Menu;
            this.PictureBoxMenu.Location = new System.Drawing.Point(12, 4);
            this.PictureBoxMenu.Name = "PictureBoxMenu";
            this.PictureBoxMenu.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxMenu.TabIndex = 21;
            this.PictureBoxMenu.TabStop = false;
            this.PictureBoxMenu.Click += new System.EventHandler(this.PictureBoxMenu_Click);
            // 
            // ctMaximize1
            // 
            this.ctMaximize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMaximize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMaximize1.BackgroundImage")));
            this.ctMaximize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMaximize1.Location = new System.Drawing.Point(10, 6);
            this.ctMaximize1.Name = "ctMaximize1";
            this.ctMaximize1.Size = new System.Drawing.Size(15, 15);
            this.ctMaximize1.TabIndex = 2;
            this.ctMaximize1.Click += new System.EventHandler(this.ctMaximize1_Click);
            // 
            // ctMinimize1
            // 
            this.ctMinimize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMinimize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMinimize1.BackgroundImage")));
            this.ctMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMinimize1.Location = new System.Drawing.Point(40, 6);
            this.ctMinimize1.Name = "ctMinimize1";
            this.ctMinimize1.Size = new System.Drawing.Size(15, 15);
            this.ctMinimize1.TabIndex = 1;
            this.ctMinimize1.Click += new System.EventHandler(this.ctMinimize1_Click);
            // 
            // ctClose1
            // 
            this.ctClose1.BackColor = System.Drawing.Color.Transparent;
            this.ctClose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctClose1.BackgroundImage")));
            this.ctClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctClose1.Location = new System.Drawing.Point(71, 6);
            this.ctClose1.Name = "ctClose1";
            this.ctClose1.Size = new System.Drawing.Size(15, 15);
            this.ctClose1.TabIndex = 0;
            this.ctClose1.Click += new System.EventHandler(this.ctClose1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1522, 934);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.panelInfomation.ResumeLayout(false);
            this.panelInfomation.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.PanelTienNghi.ResumeLayout(false);
            this.PanelPhong.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Panel panelMainChildForm;
        private System.Windows.Forms.Panel panelInfomation;
        private System.Windows.Forms.Label labelPhienBan;
        private System.Windows.Forms.Label labelBanQuyen;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelControlBox;
        private CTControls.CTMaximize ctMaximize1;
        private CTControls.CTMinimize ctMinimize1;
        private CTControls.CTClose ctClose1;
        private System.Windows.Forms.Label labelTenKhachSan;
        private System.Windows.Forms.Panel PanelPhong;
        private System.Windows.Forms.Button ButtonLoaiPhong;
        private System.Windows.Forms.Button ButtonPhong;
        private System.Windows.Forms.Button ButtonQuanLyPhong;
        private System.Windows.Forms.Button ButtonQuanLyKhachHang;
        private System.Windows.Forms.Button ButtonDanhSachHoaDon;
        private System.Windows.Forms.Button ButtonDatPhong;
        private System.Windows.Forms.Button ButtonSoDoPhong;
        private System.Windows.Forms.Button ButtonTrangChu;
        private System.Windows.Forms.Button ButtonQuanLyTienNghi;
        private System.Windows.Forms.Button ButtonQuanLyDichVu;
        private System.Windows.Forms.Button ButtonThongKe;
        private System.Windows.Forms.Button ButtonQuanLyNhanVien;
        private System.Windows.Forms.Button ButtonQuanLyTaiKhoan;
        private System.Windows.Forms.Panel PanelTienNghi;
        private System.Windows.Forms.Button ButtonChiTietTienNghi;
        private System.Windows.Forms.Button ButtonTienNghi;
        private System.Windows.Forms.PictureBox PictureBoxMenu;
    }
}