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
            this.panelName = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.ctMaximize1 = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize1 = new HotelManagement.CTControls.CTMinimize();
            this.ctClose1 = new HotelManagement.CTControls.CTClose();
            this.labelTenKhachSan = new System.Windows.Forms.Label();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.panelNhanSuSubmenu = new System.Windows.Forms.Panel();
            this.buttonChamCong = new System.Windows.Forms.Button();
            this.buttonChinhSuaNhanSu = new System.Windows.Forms.Button();
            this.buttonNhanSu = new System.Windows.Forms.Button();
            this.panelThongKeSubmenu = new System.Windows.Forms.Panel();
            this.buttonThoiGian = new System.Windows.Forms.Button();
            this.buttonSoLuongKhach = new System.Windows.Forms.Button();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.panelThuChiSubmenu = new System.Windows.Forms.Panel();
            this.buttonCongNo = new System.Windows.Forms.Button();
            this.buttonDoanhThu = new System.Windows.Forms.Button();
            this.buttonQuanLyThuChi = new System.Windows.Forms.Button();
            this.buttonKho = new System.Windows.Forms.Button();
            this.buttonLoaiPhong = new System.Windows.Forms.Button();
            this.buttonSoDoPhong = new System.Windows.Forms.Button();
            this.panelInfomation = new System.Windows.Forms.Panel();
            this.labelPhienBan = new System.Windows.Forms.Label();
            this.labelBanQuyen = new System.Windows.Forms.Label();
            this.panelMainChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctRoomDaDat1 = new HotelManagement.CTControls.CTRoomDaDat();
            this.ctRoomDangSuaChua1 = new HotelManagement.CTControls.CTRoomDangSuaChua();
            this.ctRoomDangThue1 = new HotelManagement.CTControls.CTRoomDangThue();
            this.ctRoomTrong1 = new HotelManagement.CTControls.CTRoomTrong();
            this.panelName.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.panelNhanSuSubmenu.SuspendLayout();
            this.panelThongKeSubmenu.SuspendLayout();
            this.panelThuChiSubmenu.SuspendLayout();
            this.panelInfomation.SuspendLayout();
            this.panelMainChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
            this.panelName.Controls.Add(this.panelControlBox);
            this.panelName.Controls.Add(this.labelTenKhachSan);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(1344, 60);
            this.panelName.TabIndex = 0;
            // 
            // panelControlBox
            // 
            this.panelControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
            this.panelControlBox.Controls.Add(this.ctMaximize1);
            this.panelControlBox.Controls.Add(this.ctMinimize1);
            this.panelControlBox.Controls.Add(this.ctClose1);
            this.panelControlBox.Location = new System.Drawing.Point(1246, 3);
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
            // 
            // labelTenKhachSan
            // 
            this.labelTenKhachSan.AutoSize = true;
            this.labelTenKhachSan.BackColor = System.Drawing.Color.Transparent;
            this.labelTenKhachSan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKhachSan.ForeColor = System.Drawing.Color.White;
            this.labelTenKhachSan.Location = new System.Drawing.Point(12, 24);
            this.labelTenKhachSan.Name = "labelTenKhachSan";
            this.labelTenKhachSan.Size = new System.Drawing.Size(123, 21);
            this.labelTenKhachSan.TabIndex = 2;
            this.labelTenKhachSan.Text = "Khách sạn IT008";
            // 
            // Sidebar
            // 
            this.Sidebar.AutoScroll = true;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(145)))), ((int)(((byte)(153)))));
            this.Sidebar.Controls.Add(this.panelNhanSuSubmenu);
            this.Sidebar.Controls.Add(this.buttonNhanSu);
            this.Sidebar.Controls.Add(this.panelThongKeSubmenu);
            this.Sidebar.Controls.Add(this.buttonThongKe);
            this.Sidebar.Controls.Add(this.panelThuChiSubmenu);
            this.Sidebar.Controls.Add(this.buttonQuanLyThuChi);
            this.Sidebar.Controls.Add(this.buttonKho);
            this.Sidebar.Controls.Add(this.buttonLoaiPhong);
            this.Sidebar.Controls.Add(this.buttonSoDoPhong);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 60);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(262, 669);
            this.Sidebar.TabIndex = 1;
            // 
            // panelNhanSuSubmenu
            // 
            this.panelNhanSuSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelNhanSuSubmenu.Controls.Add(this.buttonChamCong);
            this.panelNhanSuSubmenu.Controls.Add(this.buttonChinhSuaNhanSu);
            this.panelNhanSuSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhanSuSubmenu.Location = new System.Drawing.Point(0, 480);
            this.panelNhanSuSubmenu.Name = "panelNhanSuSubmenu";
            this.panelNhanSuSubmenu.Size = new System.Drawing.Size(262, 90);
            this.panelNhanSuSubmenu.TabIndex = 8;
            // 
            // buttonChamCong
            // 
            this.buttonChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.buttonChamCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChamCong.FlatAppearance.BorderSize = 0;
            this.buttonChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChamCong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChamCong.Location = new System.Drawing.Point(0, 45);
            this.buttonChamCong.Name = "buttonChamCong";
            this.buttonChamCong.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonChamCong.Size = new System.Drawing.Size(262, 45);
            this.buttonChamCong.TabIndex = 1;
            this.buttonChamCong.Text = "Chấm công";
            this.buttonChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChamCong.UseVisualStyleBackColor = false;
            this.buttonChamCong.Click += new System.EventHandler(this.buttonChamCong_Click);
            // 
            // buttonChinhSuaNhanSu
            // 
            this.buttonChinhSuaNhanSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.buttonChinhSuaNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChinhSuaNhanSu.FlatAppearance.BorderSize = 0;
            this.buttonChinhSuaNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChinhSuaNhanSu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChinhSuaNhanSu.Location = new System.Drawing.Point(0, 0);
            this.buttonChinhSuaNhanSu.Name = "buttonChinhSuaNhanSu";
            this.buttonChinhSuaNhanSu.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonChinhSuaNhanSu.Size = new System.Drawing.Size(262, 45);
            this.buttonChinhSuaNhanSu.TabIndex = 0;
            this.buttonChinhSuaNhanSu.Text = "Chỉnh sửa quyền";
            this.buttonChinhSuaNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChinhSuaNhanSu.UseVisualStyleBackColor = false;
            this.buttonChinhSuaNhanSu.Click += new System.EventHandler(this.buttonChinhSuaNhanSu_Click);
            // 
            // buttonNhanSu
            // 
            this.buttonNhanSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.buttonNhanSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNhanSu.FlatAppearance.BorderSize = 0;
            this.buttonNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhanSu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNhanSu.Image = ((System.Drawing.Image)(resources.GetObject("buttonNhanSu.Image")));
            this.buttonNhanSu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNhanSu.Location = new System.Drawing.Point(0, 430);
            this.buttonNhanSu.Name = "buttonNhanSu";
            this.buttonNhanSu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonNhanSu.Size = new System.Drawing.Size(262, 50);
            this.buttonNhanSu.TabIndex = 7;
            this.buttonNhanSu.Text = "       Quản lý nhân sự         ▼        ";
            this.buttonNhanSu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNhanSu.UseVisualStyleBackColor = false;
            this.buttonNhanSu.Click += new System.EventHandler(this.buttonNhanSu_Click);
            // 
            // panelThongKeSubmenu
            // 
            this.panelThongKeSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelThongKeSubmenu.Controls.Add(this.buttonThoiGian);
            this.panelThongKeSubmenu.Controls.Add(this.buttonSoLuongKhach);
            this.panelThongKeSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongKeSubmenu.Location = new System.Drawing.Point(0, 340);
            this.panelThongKeSubmenu.Name = "panelThongKeSubmenu";
            this.panelThongKeSubmenu.Size = new System.Drawing.Size(262, 90);
            this.panelThongKeSubmenu.TabIndex = 6;
            // 
            // buttonThoiGian
            // 
            this.buttonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.buttonThoiGian.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThoiGian.FlatAppearance.BorderSize = 0;
            this.buttonThoiGian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoiGian.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoiGian.Location = new System.Drawing.Point(0, 45);
            this.buttonThoiGian.Name = "buttonThoiGian";
            this.buttonThoiGian.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonThoiGian.Size = new System.Drawing.Size(262, 45);
            this.buttonThoiGian.TabIndex = 1;
            this.buttonThoiGian.Text = "Thời gian sử dụng";
            this.buttonThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThoiGian.UseVisualStyleBackColor = false;
            this.buttonThoiGian.Click += new System.EventHandler(this.buttonThoiGian_Click);
            // 
            // buttonSoLuongKhach
            // 
            this.buttonSoLuongKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.buttonSoLuongKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSoLuongKhach.FlatAppearance.BorderSize = 0;
            this.buttonSoLuongKhach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoLuongKhach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoLuongKhach.Location = new System.Drawing.Point(0, 0);
            this.buttonSoLuongKhach.Name = "buttonSoLuongKhach";
            this.buttonSoLuongKhach.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonSoLuongKhach.Size = new System.Drawing.Size(262, 45);
            this.buttonSoLuongKhach.TabIndex = 0;
            this.buttonSoLuongKhach.Text = "Số lượng khách";
            this.buttonSoLuongKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSoLuongKhach.UseVisualStyleBackColor = false;
            this.buttonSoLuongKhach.Click += new System.EventHandler(this.buttonSoLuongKhach_Click);
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.buttonThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThongKe.FlatAppearance.BorderSize = 0;
            this.buttonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.Image = ((System.Drawing.Image)(resources.GetObject("buttonThongKe.Image")));
            this.buttonThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongKe.Location = new System.Drawing.Point(0, 290);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonThongKe.Size = new System.Drawing.Size(262, 50);
            this.buttonThongKe.TabIndex = 5;
            this.buttonThongKe.Text = "          Thống kê                     ▼        ";
            this.buttonThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThongKe.UseVisualStyleBackColor = false;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // panelThuChiSubmenu
            // 
            this.panelThuChiSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelThuChiSubmenu.Controls.Add(this.buttonCongNo);
            this.panelThuChiSubmenu.Controls.Add(this.buttonDoanhThu);
            this.panelThuChiSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThuChiSubmenu.Location = new System.Drawing.Point(0, 200);
            this.panelThuChiSubmenu.Name = "panelThuChiSubmenu";
            this.panelThuChiSubmenu.Size = new System.Drawing.Size(262, 90);
            this.panelThuChiSubmenu.TabIndex = 4;
            // 
            // buttonCongNo
            // 
            this.buttonCongNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.buttonCongNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCongNo.FlatAppearance.BorderSize = 0;
            this.buttonCongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCongNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCongNo.Location = new System.Drawing.Point(0, 45);
            this.buttonCongNo.Name = "buttonCongNo";
            this.buttonCongNo.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonCongNo.Size = new System.Drawing.Size(262, 45);
            this.buttonCongNo.TabIndex = 1;
            this.buttonCongNo.Text = "Công nợ";
            this.buttonCongNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCongNo.UseVisualStyleBackColor = false;
            this.buttonCongNo.Click += new System.EventHandler(this.buttonCongNo_Click);
            // 
            // buttonDoanhThu
            // 
            this.buttonDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(206)))), ((int)(((byte)(211)))));
            this.buttonDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDoanhThu.FlatAppearance.BorderSize = 0;
            this.buttonDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.buttonDoanhThu.Name = "buttonDoanhThu";
            this.buttonDoanhThu.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.buttonDoanhThu.Size = new System.Drawing.Size(262, 45);
            this.buttonDoanhThu.TabIndex = 0;
            this.buttonDoanhThu.Text = "Doanh thu";
            this.buttonDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDoanhThu.UseVisualStyleBackColor = false;
            this.buttonDoanhThu.Click += new System.EventHandler(this.buttonDoanhThu_Click);
            // 
            // buttonQuanLyThuChi
            // 
            this.buttonQuanLyThuChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.buttonQuanLyThuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonQuanLyThuChi.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyThuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyThuChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyThuChi.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLyThuChi.Image")));
            this.buttonQuanLyThuChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLyThuChi.Location = new System.Drawing.Point(0, 150);
            this.buttonQuanLyThuChi.Name = "buttonQuanLyThuChi";
            this.buttonQuanLyThuChi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonQuanLyThuChi.Size = new System.Drawing.Size(262, 50);
            this.buttonQuanLyThuChi.TabIndex = 3;
            this.buttonQuanLyThuChi.Text = "       Quản lý thu chi           ▼        ";
            this.buttonQuanLyThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuanLyThuChi.UseVisualStyleBackColor = false;
            this.buttonQuanLyThuChi.Click += new System.EventHandler(this.buttonQuanLyThuChi_Click);
            // 
            // buttonKho
            // 
            this.buttonKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.buttonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKho.FlatAppearance.BorderSize = 0;
            this.buttonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKho.Image = ((System.Drawing.Image)(resources.GetObject("buttonKho.Image")));
            this.buttonKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKho.Location = new System.Drawing.Point(0, 100);
            this.buttonKho.Name = "buttonKho";
            this.buttonKho.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonKho.Size = new System.Drawing.Size(262, 50);
            this.buttonKho.TabIndex = 2;
            this.buttonKho.Text = "          Kho";
            this.buttonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKho.UseVisualStyleBackColor = false;
            this.buttonKho.Click += new System.EventHandler(this.buttonKho_Click);
            // 
            // buttonLoaiPhong
            // 
            this.buttonLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.buttonLoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoaiPhong.FlatAppearance.BorderSize = 0;
            this.buttonLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoaiPhong.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoaiPhong.Image")));
            this.buttonLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoaiPhong.Location = new System.Drawing.Point(0, 50);
            this.buttonLoaiPhong.Name = "buttonLoaiPhong";
            this.buttonLoaiPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLoaiPhong.Size = new System.Drawing.Size(262, 50);
            this.buttonLoaiPhong.TabIndex = 1;
            this.buttonLoaiPhong.Text = "          Loại phòng";
            this.buttonLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoaiPhong.UseVisualStyleBackColor = false;
            this.buttonLoaiPhong.Click += new System.EventHandler(this.buttonLoaiPhong_Click);
            // 
            // buttonSoDoPhong
            // 
            this.buttonSoDoPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.buttonSoDoPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSoDoPhong.FlatAppearance.BorderSize = 0;
            this.buttonSoDoPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoDoPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoDoPhong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSoDoPhong.Image = ((System.Drawing.Image)(resources.GetObject("buttonSoDoPhong.Image")));
            this.buttonSoDoPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSoDoPhong.Location = new System.Drawing.Point(0, 0);
            this.buttonSoDoPhong.Name = "buttonSoDoPhong";
            this.buttonSoDoPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSoDoPhong.Size = new System.Drawing.Size(262, 50);
            this.buttonSoDoPhong.TabIndex = 0;
            this.buttonSoDoPhong.Text = "          Sơ đồ phòng";
            this.buttonSoDoPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSoDoPhong.UseVisualStyleBackColor = false;
            this.buttonSoDoPhong.Click += new System.EventHandler(this.buttonSoDoPhong_Click);
            // 
            // panelInfomation
            // 
            this.panelInfomation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.panelInfomation.Controls.Add(this.labelPhienBan);
            this.panelInfomation.Controls.Add(this.labelBanQuyen);
            this.panelInfomation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfomation.Location = new System.Drawing.Point(262, 688);
            this.panelInfomation.Name = "panelInfomation";
            this.panelInfomation.Size = new System.Drawing.Size(1082, 41);
            this.panelInfomation.TabIndex = 2;
            // 
            // labelPhienBan
            // 
            this.labelPhienBan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPhienBan.AutoSize = true;
            this.labelPhienBan.Location = new System.Drawing.Point(978, 11);
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
            this.labelBanQuyen.Size = new System.Drawing.Size(358, 21);
            this.labelBanQuyen.TabIndex = 0;
            this.labelBanQuyen.Text = "Copyright © 2022 Super Team. All rights reserved.";
            // 
            // panelMainChildForm
            // 
            this.panelMainChildForm.BackColor = System.Drawing.Color.White;
            this.panelMainChildForm.Controls.Add(this.ctRoomTrong1);
            this.panelMainChildForm.Controls.Add(this.ctRoomDangThue1);
            this.panelMainChildForm.Controls.Add(this.ctRoomDangSuaChua1);
            this.panelMainChildForm.Controls.Add(this.ctRoomDaDat1);
            this.panelMainChildForm.Controls.Add(this.pictureBox1);
            this.panelMainChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainChildForm.Location = new System.Drawing.Point(262, 60);
            this.panelMainChildForm.Name = "panelMainChildForm";
            this.panelMainChildForm.Size = new System.Drawing.Size(1082, 628);
            this.panelMainChildForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.pictureIconNoneBackGroundResize;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ctRoomDaDat1
            // 
            this.ctRoomDaDat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomDaDat1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomDaDat1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.ctRoomDaDat1.BorderRadius = 20;
            this.ctRoomDaDat1.BorderSize = 0;
            this.ctRoomDaDat1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctRoomDaDat1.ForeColor = System.Drawing.Color.White;
            this.ctRoomDaDat1.Location = new System.Drawing.Point(170, 88);
            this.ctRoomDaDat1.Name = "ctRoomDaDat1";
            this.ctRoomDaDat1.Size = new System.Drawing.Size(280, 155);
            this.ctRoomDaDat1.TabIndex = 1;
            this.ctRoomDaDat1.TextColor = System.Drawing.Color.White;
            // 
            // ctRoomDangSuaChua1
            // 
            this.ctRoomDangSuaChua1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomDangSuaChua1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomDangSuaChua1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.ctRoomDangSuaChua1.BorderRadius = 20;
            this.ctRoomDangSuaChua1.BorderSize = 0;
            this.ctRoomDangSuaChua1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctRoomDangSuaChua1.ForeColor = System.Drawing.Color.White;
            this.ctRoomDangSuaChua1.Location = new System.Drawing.Point(690, 145);
            this.ctRoomDangSuaChua1.Name = "ctRoomDangSuaChua1";
            this.ctRoomDangSuaChua1.Size = new System.Drawing.Size(280, 155);
            this.ctRoomDangSuaChua1.TabIndex = 2;
            this.ctRoomDangSuaChua1.TextColor = System.Drawing.Color.White;
            // 
            // ctRoomDangThue1
            // 
            this.ctRoomDangThue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomDangThue1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomDangThue1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.ctRoomDangThue1.BorderRadius = 20;
            this.ctRoomDangThue1.BorderSize = 0;
            this.ctRoomDangThue1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctRoomDangThue1.ForeColor = System.Drawing.Color.White;
            this.ctRoomDangThue1.Location = new System.Drawing.Point(198, 351);
            this.ctRoomDangThue1.Name = "ctRoomDangThue1";
            this.ctRoomDangThue1.Size = new System.Drawing.Size(280, 155);
            this.ctRoomDangThue1.TabIndex = 3;
            this.ctRoomDangThue1.TextColor = System.Drawing.Color.White;
            // 
            // ctRoomTrong1
            // 
            this.ctRoomTrong1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomTrong1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.ctRoomTrong1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(103)))));
            this.ctRoomTrong1.BorderRadius = 20;
            this.ctRoomTrong1.BorderSize = 0;
            this.ctRoomTrong1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctRoomTrong1.ForeColor = System.Drawing.Color.White;
            this.ctRoomTrong1.Location = new System.Drawing.Point(580, 355);
            this.ctRoomTrong1.Name = "ctRoomTrong1";
            this.ctRoomTrong1.Size = new System.Drawing.Size(280, 155);
            this.ctRoomTrong1.TabIndex = 4;
            this.ctRoomTrong1.TextColor = System.Drawing.Color.White;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.panelMainChildForm);
            this.Controls.Add(this.panelInfomation);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panelName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelControlBox.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.panelNhanSuSubmenu.ResumeLayout(false);
            this.panelThongKeSubmenu.ResumeLayout(false);
            this.panelThuChiSubmenu.ResumeLayout(false);
            this.panelInfomation.ResumeLayout(false);
            this.panelInfomation.PerformLayout();
            this.panelMainChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button buttonKho;
        private System.Windows.Forms.Button buttonLoaiPhong;
        private System.Windows.Forms.Button buttonSoDoPhong;
        private System.Windows.Forms.Button buttonQuanLyThuChi;
        private System.Windows.Forms.Panel panelNhanSuSubmenu;
        private System.Windows.Forms.Button buttonChamCong;
        private System.Windows.Forms.Button buttonChinhSuaNhanSu;
        private System.Windows.Forms.Button buttonNhanSu;
        private System.Windows.Forms.Panel panelThongKeSubmenu;
        private System.Windows.Forms.Button buttonThoiGian;
        private System.Windows.Forms.Button buttonSoLuongKhach;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Panel panelThuChiSubmenu;
        private System.Windows.Forms.Button buttonCongNo;
        private System.Windows.Forms.Button buttonDoanhThu;
        private System.Windows.Forms.Label labelTenKhachSan;
        private System.Windows.Forms.Panel panelInfomation;
        private System.Windows.Forms.Label labelBanQuyen;
        private System.Windows.Forms.Label labelPhienBan;
        private System.Windows.Forms.Panel panelMainChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelControlBox;
        private CTControls.CTMaximize ctMaximize1;
        private CTControls.CTMinimize ctMinimize1;
        private CTControls.CTClose ctClose1;
        private CTControls.CTRoomTrong ctRoomTrong1;
        private CTControls.CTRoomDangThue ctRoomDangThue1;
        private CTControls.CTRoomDangSuaChua ctRoomDangSuaChua1;
        private CTControls.CTRoomDaDat ctRoomDaDat1;
    }
}