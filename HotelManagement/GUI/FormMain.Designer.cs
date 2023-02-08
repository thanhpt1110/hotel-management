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
            this.ButtonThongKe = new System.Windows.Forms.Button();
            this.ButtonDanhSachTaiKhoan = new System.Windows.Forms.Button();
            this.ButtonDanhSachNhanVien = new System.Windows.Forms.Button();
            this.ButtonDanhSachKhachHang = new System.Windows.Forms.Button();
            this.ButtonDanhSachTienNghi = new System.Windows.Forms.Button();
            this.ButtonDanhSachDichVu = new System.Windows.Forms.Button();
            this.ButtonDanhSachHoaDon = new System.Windows.Forms.Button();
            this.ButtonDanhSachDatPhong = new System.Windows.Forms.Button();
            this.ButtonLoaiPhong = new System.Windows.Forms.Button();
            this.ButtonPhong = new System.Windows.Forms.Button();
            this.ButtonSoDoPhong = new System.Windows.Forms.Button();
            this.ButtonTrangChu = new System.Windows.Forms.Button();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.linkLabelDangXuat = new System.Windows.Forms.LinkLabel();
            this.LabelTenNguoiDung = new System.Windows.Forms.Label();
            this.PictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelName = new System.Windows.Forms.Panel();
            this.PictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.ctMaximize1 = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize1 = new HotelManagement.CTControls.CTMinimize();
            this.ctClose1 = new HotelManagement.CTControls.CTClose();
            this.labelTenKhachSan = new System.Windows.Forms.Label();
            this.PanelBackground.SuspendLayout();
            this.panelInfomation.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.PanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).BeginInit();
            this.panelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).BeginInit();
            this.panelControlBox.SuspendLayout();
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
            this.panelMainChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panelMainChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainChildForm.Location = new System.Drawing.Point(262, 60);
            this.panelMainChildForm.Name = "panelMainChildForm";
            this.panelMainChildForm.Size = new System.Drawing.Size(1260, 833);
            this.panelMainChildForm.TabIndex = 7;
            // 
            // panelInfomation
            // 
            this.panelInfomation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
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
            this.Sidebar.Controls.Add(this.ButtonDanhSachTaiKhoan);
            this.Sidebar.Controls.Add(this.ButtonDanhSachNhanVien);
            this.Sidebar.Controls.Add(this.ButtonDanhSachKhachHang);
            this.Sidebar.Controls.Add(this.ButtonDanhSachTienNghi);
            this.Sidebar.Controls.Add(this.ButtonDanhSachDichVu);
            this.Sidebar.Controls.Add(this.ButtonDanhSachHoaDon);
            this.Sidebar.Controls.Add(this.ButtonDanhSachDatPhong);
            this.Sidebar.Controls.Add(this.ButtonLoaiPhong);
            this.Sidebar.Controls.Add(this.ButtonPhong);
            this.Sidebar.Controls.Add(this.ButtonSoDoPhong);
            this.Sidebar.Controls.Add(this.ButtonTrangChu);
            this.Sidebar.Controls.Add(this.PanelUser);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 60);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(262, 874);
            this.Sidebar.TabIndex = 5;
            // 
            // ButtonThongKe
            // 
            this.ButtonThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonThongKe.FlatAppearance.BorderSize = 0;
            this.ButtonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThongKe.ForeColor = System.Drawing.Color.Black;
            this.ButtonThongKe.Image = global::HotelManagement.Properties.Resources.MenuThongKe;
            this.ButtonThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonThongKe.Location = new System.Drawing.Point(0, 662);
            this.ButtonThongKe.Name = "ButtonThongKe";
            this.ButtonThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonThongKe.Size = new System.Drawing.Size(262, 48);
            this.ButtonThongKe.TabIndex = 36;
            this.ButtonThongKe.TabStop = false;
            this.ButtonThongKe.Text = "    Thống kê";
            this.ButtonThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonThongKe.UseVisualStyleBackColor = true;
            this.ButtonThongKe.Click += new System.EventHandler(this.ButtonThongKe_Click);
            // 
            // ButtonDanhSachTaiKhoan
            // 
            this.ButtonDanhSachTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDanhSachTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachTaiKhoan.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.ButtonDanhSachTaiKhoan.Image = global::HotelManagement.Properties.Resources.MenuQuanLyTaiKhoan;
            this.ButtonDanhSachTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachTaiKhoan.Location = new System.Drawing.Point(0, 614);
            this.ButtonDanhSachTaiKhoan.Name = "ButtonDanhSachTaiKhoan";
            this.ButtonDanhSachTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachTaiKhoan.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachTaiKhoan.TabIndex = 35;
            this.ButtonDanhSachTaiKhoan.TabStop = false;
            this.ButtonDanhSachTaiKhoan.Text = "    Danh sách tài khoản";
            this.ButtonDanhSachTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachTaiKhoan.UseVisualStyleBackColor = true;
            this.ButtonDanhSachTaiKhoan.Click += new System.EventHandler(this.ButtonDanhSachTaiKhoan_Click);
            // 
            // ButtonDanhSachNhanVien
            // 
            this.ButtonDanhSachNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachNhanVien.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachNhanVien.ForeColor = System.Drawing.Color.Black;
            this.ButtonDanhSachNhanVien.Image = global::HotelManagement.Properties.Resources.MenuQuanLyNhanVien;
            this.ButtonDanhSachNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachNhanVien.Location = new System.Drawing.Point(0, 566);
            this.ButtonDanhSachNhanVien.Name = "ButtonDanhSachNhanVien";
            this.ButtonDanhSachNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachNhanVien.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachNhanVien.TabIndex = 34;
            this.ButtonDanhSachNhanVien.TabStop = false;
            this.ButtonDanhSachNhanVien.Text = "    Danh sách nhân viên";
            this.ButtonDanhSachNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachNhanVien.UseVisualStyleBackColor = true;
            this.ButtonDanhSachNhanVien.Click += new System.EventHandler(this.ButtonDanhSachNhanVien_Click);
            // 
            // ButtonDanhSachKhachHang
            // 
            this.ButtonDanhSachKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDanhSachKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachKhachHang.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachKhachHang.ForeColor = System.Drawing.Color.Black;
            this.ButtonDanhSachKhachHang.Image = global::HotelManagement.Properties.Resources.MenuQuanLyKhachHang;
            this.ButtonDanhSachKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachKhachHang.Location = new System.Drawing.Point(0, 518);
            this.ButtonDanhSachKhachHang.Name = "ButtonDanhSachKhachHang";
            this.ButtonDanhSachKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachKhachHang.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachKhachHang.TabIndex = 33;
            this.ButtonDanhSachKhachHang.TabStop = false;
            this.ButtonDanhSachKhachHang.Text = "    Danh sách khách hàng";
            this.ButtonDanhSachKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachKhachHang.UseVisualStyleBackColor = true;
            this.ButtonDanhSachKhachHang.Click += new System.EventHandler(this.ButtonDanhSachKhachHang_Click);
            // 
            // ButtonDanhSachTienNghi
            // 
            this.ButtonDanhSachTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
            this.ButtonDanhSachTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDanhSachTienNghi.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachTienNghi.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachTienNghi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachTienNghi.ForeColor = System.Drawing.Color.Black;
            this.ButtonDanhSachTienNghi.Image = global::HotelManagement.Properties.Resources.MenuTienNghi;
            this.ButtonDanhSachTienNghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachTienNghi.Location = new System.Drawing.Point(0, 470);
            this.ButtonDanhSachTienNghi.Name = "ButtonDanhSachTienNghi";
            this.ButtonDanhSachTienNghi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachTienNghi.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachTienNghi.TabIndex = 32;
            this.ButtonDanhSachTienNghi.TabStop = false;
            this.ButtonDanhSachTienNghi.Text = "    Danh sách tiện nghi";
            this.ButtonDanhSachTienNghi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachTienNghi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachTienNghi.UseVisualStyleBackColor = false;
            this.ButtonDanhSachTienNghi.Click += new System.EventHandler(this.ButtonDanhSachTienNghi_Click);
            // 
            // ButtonDanhSachDichVu
            // 
            this.ButtonDanhSachDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDanhSachDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachDichVu.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachDichVu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachDichVu.ForeColor = System.Drawing.Color.Black;
            this.ButtonDanhSachDichVu.Image = global::HotelManagement.Properties.Resources.MenuQuanLyDichVu;
            this.ButtonDanhSachDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachDichVu.Location = new System.Drawing.Point(0, 422);
            this.ButtonDanhSachDichVu.Name = "ButtonDanhSachDichVu";
            this.ButtonDanhSachDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachDichVu.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachDichVu.TabIndex = 31;
            this.ButtonDanhSachDichVu.TabStop = false;
            this.ButtonDanhSachDichVu.Text = "    Danh sách dịch vụ";
            this.ButtonDanhSachDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachDichVu.UseVisualStyleBackColor = true;
            this.ButtonDanhSachDichVu.Click += new System.EventHandler(this.ButtonDanhSachDichVu_Click);
            // 
            // ButtonDanhSachHoaDon
            // 
            this.ButtonDanhSachHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDanhSachHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachHoaDon.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachHoaDon.ForeColor = System.Drawing.Color.Black;
            this.ButtonDanhSachHoaDon.Image = global::HotelManagement.Properties.Resources.MenuDanhSachHoaDon;
            this.ButtonDanhSachHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachHoaDon.Location = new System.Drawing.Point(0, 374);
            this.ButtonDanhSachHoaDon.Name = "ButtonDanhSachHoaDon";
            this.ButtonDanhSachHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachHoaDon.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachHoaDon.TabIndex = 30;
            this.ButtonDanhSachHoaDon.TabStop = false;
            this.ButtonDanhSachHoaDon.Text = "    Danh sách hóa đơn";
            this.ButtonDanhSachHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachHoaDon.UseVisualStyleBackColor = true;
            this.ButtonDanhSachHoaDon.Click += new System.EventHandler(this.ButtonDanhSachHoaDon_Click);
            // 
            // ButtonDanhSachDatPhong
            // 
            this.ButtonDanhSachDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDanhSachDatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDanhSachDatPhong.FlatAppearance.BorderSize = 0;
            this.ButtonDanhSachDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDanhSachDatPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDanhSachDatPhong.ForeColor = System.Drawing.Color.Black;
            this.ButtonDanhSachDatPhong.Image = global::HotelManagement.Properties.Resources.MenuDatPhong;
            this.ButtonDanhSachDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachDatPhong.Location = new System.Drawing.Point(0, 326);
            this.ButtonDanhSachDatPhong.Name = "ButtonDanhSachDatPhong";
            this.ButtonDanhSachDatPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonDanhSachDatPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonDanhSachDatPhong.TabIndex = 29;
            this.ButtonDanhSachDatPhong.TabStop = false;
            this.ButtonDanhSachDatPhong.Text = "    Danh sách đặt phòng";
            this.ButtonDanhSachDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDanhSachDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDanhSachDatPhong.UseVisualStyleBackColor = true;
            this.ButtonDanhSachDatPhong.Click += new System.EventHandler(this.ButtonDanhSachDatPhong_Click);
            // 
            // ButtonLoaiPhong
            // 
            this.ButtonLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLoaiPhong.FlatAppearance.BorderSize = 0;
            this.ButtonLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.ButtonLoaiPhong.Image = global::HotelManagement.Properties.Resources.MenuLoaiPhong;
            this.ButtonLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLoaiPhong.Location = new System.Drawing.Point(0, 278);
            this.ButtonLoaiPhong.Name = "ButtonLoaiPhong";
            this.ButtonLoaiPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonLoaiPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonLoaiPhong.TabIndex = 28;
            this.ButtonLoaiPhong.TabStop = false;
            this.ButtonLoaiPhong.Text = "    Loại phòng";
            this.ButtonLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLoaiPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLoaiPhong.UseVisualStyleBackColor = true;
            this.ButtonLoaiPhong.Click += new System.EventHandler(this.ButtonLoaiPhong_Click);
            // 
            // ButtonPhong
            // 
            this.ButtonPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPhong.FlatAppearance.BorderSize = 0;
            this.ButtonPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPhong.ForeColor = System.Drawing.Color.Black;
            this.ButtonPhong.Image = global::HotelManagement.Properties.Resources.MenuPhong;
            this.ButtonPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPhong.Location = new System.Drawing.Point(0, 230);
            this.ButtonPhong.Name = "ButtonPhong";
            this.ButtonPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonPhong.TabIndex = 27;
            this.ButtonPhong.TabStop = false;
            this.ButtonPhong.Text = "    Phòng";
            this.ButtonPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonPhong.UseVisualStyleBackColor = true;
            this.ButtonPhong.Click += new System.EventHandler(this.ButtonPhong_Click);
            // 
            // ButtonSoDoPhong
            // 
            this.ButtonSoDoPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSoDoPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSoDoPhong.FlatAppearance.BorderSize = 0;
            this.ButtonSoDoPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSoDoPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSoDoPhong.ForeColor = System.Drawing.Color.Black;
            this.ButtonSoDoPhong.Image = global::HotelManagement.Properties.Resources.MenuSoDoPhong;
            this.ButtonSoDoPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSoDoPhong.Location = new System.Drawing.Point(0, 182);
            this.ButtonSoDoPhong.Name = "ButtonSoDoPhong";
            this.ButtonSoDoPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonSoDoPhong.Size = new System.Drawing.Size(262, 48);
            this.ButtonSoDoPhong.TabIndex = 26;
            this.ButtonSoDoPhong.TabStop = false;
            this.ButtonSoDoPhong.Text = "    Sơ đồ phòng";
            this.ButtonSoDoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSoDoPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSoDoPhong.UseVisualStyleBackColor = true;
            this.ButtonSoDoPhong.Click += new System.EventHandler(this.ButtonSoDoPhong_Click);
            // 
            // ButtonTrangChu
            // 
            this.ButtonTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.ButtonTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonTrangChu.FlatAppearance.BorderSize = 0;
            this.ButtonTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrangChu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTrangChu.ForeColor = System.Drawing.Color.White;
            this.ButtonTrangChu.Image = global::HotelManagement.Properties.Resources.MenuTrangChu;
            this.ButtonTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTrangChu.Location = new System.Drawing.Point(0, 134);
            this.ButtonTrangChu.Name = "ButtonTrangChu";
            this.ButtonTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ButtonTrangChu.Size = new System.Drawing.Size(262, 48);
            this.ButtonTrangChu.TabIndex = 25;
            this.ButtonTrangChu.TabStop = false;
            this.ButtonTrangChu.Text = "    Trang chủ";
            this.ButtonTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonTrangChu.UseVisualStyleBackColor = false;
            this.ButtonTrangChu.Click += new System.EventHandler(this.ButtonTrangChu_Click);
            // 
            // PanelUser
            // 
            this.PanelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.PanelUser.Controls.Add(this.linkLabelDangXuat);
            this.PanelUser.Controls.Add(this.LabelTenNguoiDung);
            this.PanelUser.Controls.Add(this.PictureBoxUser);
            this.PanelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUser.Location = new System.Drawing.Point(0, 0);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(262, 134);
            this.PanelUser.TabIndex = 0;
            // 
            // linkLabelDangXuat
            // 
            this.linkLabelDangXuat.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.linkLabelDangXuat.AutoSize = true;
            this.linkLabelDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDangXuat.LinkColor = System.Drawing.Color.Black;
            this.linkLabelDangXuat.Location = new System.Drawing.Point(3, 10);
            this.linkLabelDangXuat.Name = "linkLabelDangXuat";
            this.linkLabelDangXuat.Size = new System.Drawing.Size(80, 21);
            this.linkLabelDangXuat.TabIndex = 2;
            this.linkLabelDangXuat.TabStop = true;
            this.linkLabelDangXuat.Text = "Đăng xuất";
            this.linkLabelDangXuat.Click += new System.EventHandler(this.linkLabelDangXuat_Click);
            // 
            // LabelTenNguoiDung
            // 
            this.LabelTenNguoiDung.AutoSize = true;
            this.LabelTenNguoiDung.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTenNguoiDung.Location = new System.Drawing.Point(46, 99);
            this.LabelTenNguoiDung.Name = "LabelTenNguoiDung";
            this.LabelTenNguoiDung.Size = new System.Drawing.Size(0, 25);
            this.LabelTenNguoiDung.TabIndex = 1;
            // 
            // PictureBoxUser
            // 
            this.PictureBoxUser.Image = global::HotelManagement.Properties.Resources.user;
            this.PictureBoxUser.Location = new System.Drawing.Point(87, 10);
            this.PictureBoxUser.Name = "PictureBoxUser";
            this.PictureBoxUser.Size = new System.Drawing.Size(80, 80);
            this.PictureBoxUser.TabIndex = 0;
            this.PictureBoxUser.TabStop = false;
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
            this.PictureBoxMenu.MouseLeave += new System.EventHandler(this.PictureBoxMenu_MouseLeave);
            this.PictureBoxMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMenu_MouseMove);
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
            // labelTenKhachSan
            // 
            this.labelTenKhachSan.AutoSize = true;
            this.labelTenKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.labelTenKhachSan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKhachSan.ForeColor = System.Drawing.Color.LightSalmon;
            this.labelTenKhachSan.Location = new System.Drawing.Point(68, 14);
            this.labelTenKhachSan.Name = "labelTenKhachSan";
            this.labelTenKhachSan.Size = new System.Drawing.Size(227, 32);
            this.labelTenKhachSan.TabIndex = 2;
            this.labelTenKhachSan.Text = "Hotel Management";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1522, 934);
            this.Controls.Add(this.PanelBackground);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1522, 934);
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
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUser)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).EndInit();
            this.panelControlBox.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox PictureBoxMenu;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.PictureBox PictureBoxUser;
        private System.Windows.Forms.Label LabelTenNguoiDung;
        private System.Windows.Forms.Button ButtonThongKe;
        private System.Windows.Forms.Button ButtonDanhSachTaiKhoan;
        private System.Windows.Forms.Button ButtonDanhSachNhanVien;
        private System.Windows.Forms.Button ButtonDanhSachKhachHang;
        private System.Windows.Forms.Button ButtonDanhSachTienNghi;
        private System.Windows.Forms.Button ButtonDanhSachDichVu;
        private System.Windows.Forms.Button ButtonDanhSachHoaDon;
        private System.Windows.Forms.Button ButtonDanhSachDatPhong;
        private System.Windows.Forms.Button ButtonLoaiPhong;
        private System.Windows.Forms.Button ButtonPhong;
        private System.Windows.Forms.Button ButtonSoDoPhong;
        private System.Windows.Forms.Button ButtonTrangChu;
        private System.Windows.Forms.LinkLabel linkLabelDangXuat;
    }
}