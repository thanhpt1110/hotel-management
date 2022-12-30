namespace HotelManagement.GUI
{
    partial class FormThongTinPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.PanelChuaButtonCoc = new System.Windows.Forms.Panel();
            this.CTButtonCoc = new HotelManagement.CTControls.CTButton();
            this.PanelChuaButtonThemDichVu = new System.Windows.Forms.Panel();
            this.CTButtonThemDichVu = new HotelManagement.CTControls.CTButton();
            this.PanelChuaButtonThanhToan = new System.Windows.Forms.Panel();
            this.CTButtonThanhToan = new HotelManagement.CTControls.CTButton();
            this.PanelChuaButtonDatPhongNay = new System.Windows.Forms.Panel();
            this.CTButtonDatPhongNay = new HotelManagement.CTControls.CTButton();
            this.PanelChuaButtonNhanPhong = new System.Windows.Forms.Panel();
            this.CTButtonNhanPhong = new HotelManagement.CTControls.CTButton();
            this.PanelChuaButtonLuu = new System.Windows.Forms.Panel();
            this.CTButtonLuu = new HotelManagement.CTControls.CTButton();
            this.PanelChuaButtonThoat = new System.Windows.Forms.Panel();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.PanelChuaThongTin = new System.Windows.Forms.Panel();
            this.TextBoxGhiChu = new System.Windows.Forms.TextBox();
            this.LabelGhiChu = new System.Windows.Forms.Label();
            this.ComboBoxTinhTrangDonDep = new System.Windows.Forms.ComboBox();
            this.ComboBoxTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.gridDichVu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelCapNhatTinhTrangDonDep = new System.Windows.Forms.Label();
            this.ctPanel1 = new CTPanel.CTPanel();
            this.LabelCapNhatTinhTrangPhong = new System.Windows.Forms.Label();
            this.LabelSoNguoi = new System.Windows.Forms.Label();
            this.LabelThoiGianThue = new System.Windows.Forms.Label();
            this.LabelNgayCheckin = new System.Windows.Forms.Label();
            this.LabelTen = new System.Windows.Forms.Label();
            this.PictureBoxSoNguoi = new System.Windows.Forms.PictureBox();
            this.PictureBoxThoiGianThue = new System.Windows.Forms.PictureBox();
            this.PictureBoxNgayCheckin = new System.Windows.Forms.PictureBox();
            this.PictureBoxTen = new System.Windows.Forms.PictureBox();
            this.ctPanel2 = new CTPanel.CTPanel();
            this.ctPanel3 = new CTPanel.CTPanel();
            this.PanelBackgroundTop = new System.Windows.Forms.Panel();
            this.LabelMaPhong = new System.Windows.Forms.Label();
            this.PanelBackground.SuspendLayout();
            this.PanelChuaButtonCoc.SuspendLayout();
            this.PanelChuaButtonThemDichVu.SuspendLayout();
            this.PanelChuaButtonThanhToan.SuspendLayout();
            this.PanelChuaButtonDatPhongNay.SuspendLayout();
            this.PanelChuaButtonNhanPhong.SuspendLayout();
            this.PanelChuaButtonLuu.SuspendLayout();
            this.PanelChuaButtonThoat.SuspendLayout();
            this.PanelChuaThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxThoiGianThue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).BeginInit();
            this.PanelBackgroundTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.Controls.Add(this.PanelChuaButtonCoc);
            this.PanelBackground.Controls.Add(this.PanelChuaButtonThemDichVu);
            this.PanelBackground.Controls.Add(this.PanelChuaButtonThanhToan);
            this.PanelBackground.Controls.Add(this.PanelChuaButtonDatPhongNay);
            this.PanelBackground.Controls.Add(this.PanelChuaButtonNhanPhong);
            this.PanelBackground.Controls.Add(this.PanelChuaButtonLuu);
            this.PanelBackground.Controls.Add(this.PanelChuaButtonThoat);
            this.PanelBackground.Controls.Add(this.PanelChuaThongTin);
            this.PanelBackground.Controls.Add(this.PanelBackgroundTop);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(979, 550);
            this.PanelBackground.TabIndex = 0;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // PanelChuaButtonCoc
            // 
            this.PanelChuaButtonCoc.Controls.Add(this.CTButtonCoc);
            this.PanelChuaButtonCoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelChuaButtonCoc.Location = new System.Drawing.Point(-337, 488);
            this.PanelChuaButtonCoc.Name = "PanelChuaButtonCoc";
            this.PanelChuaButtonCoc.Size = new System.Drawing.Size(188, 62);
            this.PanelChuaButtonCoc.TabIndex = 36;
            // 
            // CTButtonCoc
            // 
            this.CTButtonCoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.CTButtonCoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.CTButtonCoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.CTButtonCoc.BorderRadius = 10;
            this.CTButtonCoc.BorderSize = 0;
            this.CTButtonCoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonCoc.FlatAppearance.BorderSize = 0;
            this.CTButtonCoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonCoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonCoc.ForeColor = System.Drawing.Color.White;
            this.CTButtonCoc.Location = new System.Drawing.Point(20, 9);
            this.CTButtonCoc.Name = "CTButtonCoc";
            this.CTButtonCoc.Size = new System.Drawing.Size(150, 40);
            this.CTButtonCoc.TabIndex = 0;
            this.CTButtonCoc.Text = "Đặt cọc";
            this.CTButtonCoc.TextColor = System.Drawing.Color.White;
            this.CTButtonCoc.UseVisualStyleBackColor = false;
            this.CTButtonCoc.Click += new System.EventHandler(this.CTButtonCoc_Click);
            // 
            // PanelChuaButtonThemDichVu
            // 
            this.PanelChuaButtonThemDichVu.Controls.Add(this.CTButtonThemDichVu);
            this.PanelChuaButtonThemDichVu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelChuaButtonThemDichVu.Location = new System.Drawing.Point(-149, 488);
            this.PanelChuaButtonThemDichVu.Name = "PanelChuaButtonThemDichVu";
            this.PanelChuaButtonThemDichVu.Size = new System.Drawing.Size(188, 62);
            this.PanelChuaButtonThemDichVu.TabIndex = 35;
            // 
            // CTButtonThemDichVu
            // 
            this.CTButtonThemDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.CTButtonThemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.CTButtonThemDichVu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.CTButtonThemDichVu.BorderRadius = 10;
            this.CTButtonThemDichVu.BorderSize = 0;
            this.CTButtonThemDichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemDichVu.FlatAppearance.BorderSize = 0;
            this.CTButtonThemDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemDichVu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemDichVu.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemDichVu.Location = new System.Drawing.Point(20, 9);
            this.CTButtonThemDichVu.Name = "CTButtonThemDichVu";
            this.CTButtonThemDichVu.Size = new System.Drawing.Size(150, 40);
            this.CTButtonThemDichVu.TabIndex = 0;
            this.CTButtonThemDichVu.Text = "Thêm dịch vụ";
            this.CTButtonThemDichVu.TextColor = System.Drawing.Color.White;
            this.CTButtonThemDichVu.UseVisualStyleBackColor = false;
            this.CTButtonThemDichVu.Click += new System.EventHandler(this.CTButtonThemDichVu_Click);
            // 
            // PanelChuaButtonThanhToan
            // 
            this.PanelChuaButtonThanhToan.Controls.Add(this.CTButtonThanhToan);
            this.PanelChuaButtonThanhToan.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelChuaButtonThanhToan.Location = new System.Drawing.Point(39, 488);
            this.PanelChuaButtonThanhToan.Name = "PanelChuaButtonThanhToan";
            this.PanelChuaButtonThanhToan.Size = new System.Drawing.Size(188, 62);
            this.PanelChuaButtonThanhToan.TabIndex = 22;
            // 
            // CTButtonThanhToan
            // 
            this.CTButtonThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.CTButtonThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.CTButtonThanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.CTButtonThanhToan.BorderRadius = 10;
            this.CTButtonThanhToan.BorderSize = 0;
            this.CTButtonThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThanhToan.FlatAppearance.BorderSize = 0;
            this.CTButtonThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThanhToan.ForeColor = System.Drawing.Color.White;
            this.CTButtonThanhToan.Location = new System.Drawing.Point(20, 9);
            this.CTButtonThanhToan.Name = "CTButtonThanhToan";
            this.CTButtonThanhToan.Size = new System.Drawing.Size(150, 40);
            this.CTButtonThanhToan.TabIndex = 0;
            this.CTButtonThanhToan.Text = "Thanh toán";
            this.CTButtonThanhToan.TextColor = System.Drawing.Color.White;
            this.CTButtonThanhToan.UseVisualStyleBackColor = false;
            this.CTButtonThanhToan.Click += new System.EventHandler(this.CTButtonThanhToan_Click);
            // 
            // PanelChuaButtonDatPhongNay
            // 
            this.PanelChuaButtonDatPhongNay.Controls.Add(this.CTButtonDatPhongNay);
            this.PanelChuaButtonDatPhongNay.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelChuaButtonDatPhongNay.Location = new System.Drawing.Point(227, 488);
            this.PanelChuaButtonDatPhongNay.Name = "PanelChuaButtonDatPhongNay";
            this.PanelChuaButtonDatPhongNay.Size = new System.Drawing.Size(188, 62);
            this.PanelChuaButtonDatPhongNay.TabIndex = 21;
            // 
            // CTButtonDatPhongNay
            // 
            this.CTButtonDatPhongNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.CTButtonDatPhongNay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.CTButtonDatPhongNay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.CTButtonDatPhongNay.BorderRadius = 10;
            this.CTButtonDatPhongNay.BorderSize = 0;
            this.CTButtonDatPhongNay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonDatPhongNay.FlatAppearance.BorderSize = 0;
            this.CTButtonDatPhongNay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonDatPhongNay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonDatPhongNay.ForeColor = System.Drawing.Color.White;
            this.CTButtonDatPhongNay.Location = new System.Drawing.Point(20, 9);
            this.CTButtonDatPhongNay.Name = "CTButtonDatPhongNay";
            this.CTButtonDatPhongNay.Size = new System.Drawing.Size(150, 40);
            this.CTButtonDatPhongNay.TabIndex = 0;
            this.CTButtonDatPhongNay.Text = "Đặt phòng";
            this.CTButtonDatPhongNay.TextColor = System.Drawing.Color.White;
            this.CTButtonDatPhongNay.UseVisualStyleBackColor = false;
            this.CTButtonDatPhongNay.Click += new System.EventHandler(this.CTButtonDatPhongNay_Click);
            // 
            // PanelChuaButtonNhanPhong
            // 
            this.PanelChuaButtonNhanPhong.Controls.Add(this.CTButtonNhanPhong);
            this.PanelChuaButtonNhanPhong.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelChuaButtonNhanPhong.Location = new System.Drawing.Point(415, 488);
            this.PanelChuaButtonNhanPhong.Name = "PanelChuaButtonNhanPhong";
            this.PanelChuaButtonNhanPhong.Size = new System.Drawing.Size(188, 62);
            this.PanelChuaButtonNhanPhong.TabIndex = 20;
            // 
            // CTButtonNhanPhong
            // 
            this.CTButtonNhanPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.CTButtonNhanPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.CTButtonNhanPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.CTButtonNhanPhong.BorderRadius = 10;
            this.CTButtonNhanPhong.BorderSize = 0;
            this.CTButtonNhanPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonNhanPhong.FlatAppearance.BorderSize = 0;
            this.CTButtonNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonNhanPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonNhanPhong.ForeColor = System.Drawing.Color.White;
            this.CTButtonNhanPhong.Location = new System.Drawing.Point(21, 9);
            this.CTButtonNhanPhong.Name = "CTButtonNhanPhong";
            this.CTButtonNhanPhong.Size = new System.Drawing.Size(150, 40);
            this.CTButtonNhanPhong.TabIndex = 0;
            this.CTButtonNhanPhong.Text = "Nhận phòng";
            this.CTButtonNhanPhong.TextColor = System.Drawing.Color.White;
            this.CTButtonNhanPhong.UseVisualStyleBackColor = false;
            this.CTButtonNhanPhong.Click += new System.EventHandler(this.CTButtonNhanPhong_Click);
            // 
            // PanelChuaButtonLuu
            // 
            this.PanelChuaButtonLuu.Controls.Add(this.CTButtonLuu);
            this.PanelChuaButtonLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelChuaButtonLuu.Location = new System.Drawing.Point(603, 488);
            this.PanelChuaButtonLuu.Name = "PanelChuaButtonLuu";
            this.PanelChuaButtonLuu.Size = new System.Drawing.Size(188, 62);
            this.PanelChuaButtonLuu.TabIndex = 19;
            // 
            // CTButtonLuu
            // 
            this.CTButtonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonLuu.BorderRadius = 10;
            this.CTButtonLuu.BorderSize = 0;
            this.CTButtonLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonLuu.FlatAppearance.BorderSize = 0;
            this.CTButtonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonLuu.ForeColor = System.Drawing.Color.White;
            this.CTButtonLuu.Location = new System.Drawing.Point(19, 9);
            this.CTButtonLuu.Name = "CTButtonLuu";
            this.CTButtonLuu.Size = new System.Drawing.Size(150, 40);
            this.CTButtonLuu.TabIndex = 0;
            this.CTButtonLuu.Text = "Lưu";
            this.CTButtonLuu.TextColor = System.Drawing.Color.White;
            this.CTButtonLuu.UseVisualStyleBackColor = false;
            this.CTButtonLuu.Click += new System.EventHandler(this.CTButtonLuu_Click);
            // 
            // PanelChuaButtonThoat
            // 
            this.PanelChuaButtonThoat.Controls.Add(this.CTButtonThoat);
            this.PanelChuaButtonThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelChuaButtonThoat.Location = new System.Drawing.Point(791, 488);
            this.PanelChuaButtonThoat.Name = "PanelChuaButtonThoat";
            this.PanelChuaButtonThoat.Size = new System.Drawing.Size(188, 62);
            this.PanelChuaButtonThoat.TabIndex = 18;
            // 
            // CTButtonThoat
            // 
            this.CTButtonThoat.BackColor = System.Drawing.Color.Gray;
            this.CTButtonThoat.BackgroundColor = System.Drawing.Color.Gray;
            this.CTButtonThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.CTButtonThoat.BorderRadius = 10;
            this.CTButtonThoat.BorderSize = 0;
            this.CTButtonThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThoat.FlatAppearance.BorderSize = 0;
            this.CTButtonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThoat.ForeColor = System.Drawing.Color.White;
            this.CTButtonThoat.Location = new System.Drawing.Point(26, 9);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(150, 40);
            this.CTButtonThoat.TabIndex = 0;
            this.CTButtonThoat.Text = "Thoát";
            this.CTButtonThoat.TextColor = System.Drawing.Color.White;
            this.CTButtonThoat.UseVisualStyleBackColor = false;
            this.CTButtonThoat.Click += new System.EventHandler(this.CTButtonThoat_Click);
            // 
            // PanelChuaThongTin
            // 
            this.PanelChuaThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.PanelChuaThongTin.Controls.Add(this.TextBoxGhiChu);
            this.PanelChuaThongTin.Controls.Add(this.LabelGhiChu);
            this.PanelChuaThongTin.Controls.Add(this.ComboBoxTinhTrangDonDep);
            this.PanelChuaThongTin.Controls.Add(this.ComboBoxTinhTrangPhong);
            this.PanelChuaThongTin.Controls.Add(this.gridDichVu);
            this.PanelChuaThongTin.Controls.Add(this.LabelCapNhatTinhTrangDonDep);
            this.PanelChuaThongTin.Controls.Add(this.ctPanel1);
            this.PanelChuaThongTin.Controls.Add(this.LabelCapNhatTinhTrangPhong);
            this.PanelChuaThongTin.Controls.Add(this.LabelSoNguoi);
            this.PanelChuaThongTin.Controls.Add(this.LabelThoiGianThue);
            this.PanelChuaThongTin.Controls.Add(this.LabelNgayCheckin);
            this.PanelChuaThongTin.Controls.Add(this.LabelTen);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxSoNguoi);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxThoiGianThue);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxNgayCheckin);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxTen);
            this.PanelChuaThongTin.Controls.Add(this.ctPanel2);
            this.PanelChuaThongTin.Controls.Add(this.ctPanel3);
            this.PanelChuaThongTin.Location = new System.Drawing.Point(43, 53);
            this.PanelChuaThongTin.Name = "PanelChuaThongTin";
            this.PanelChuaThongTin.Size = new System.Drawing.Size(883, 435);
            this.PanelChuaThongTin.TabIndex = 10;
            this.PanelChuaThongTin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // TextBoxGhiChu
            // 
            this.TextBoxGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBoxGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxGhiChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGhiChu.Location = new System.Drawing.Point(560, 293);
            this.TextBoxGhiChu.Multiline = true;
            this.TextBoxGhiChu.Name = "TextBoxGhiChu";
            this.TextBoxGhiChu.Size = new System.Drawing.Size(281, 80);
            this.TextBoxGhiChu.TabIndex = 1;
            this.TextBoxGhiChu.Text = "Ghi chú nha cả nhà";
            // 
            // LabelGhiChu
            // 
            this.LabelGhiChu.AutoSize = true;
            this.LabelGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelGhiChu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGhiChu.Location = new System.Drawing.Point(492, 293);
            this.LabelGhiChu.Name = "LabelGhiChu";
            this.LabelGhiChu.Size = new System.Drawing.Size(68, 21);
            this.LabelGhiChu.TabIndex = 0;
            this.LabelGhiChu.Text = "Ghi chú:";
            // 
            // ComboBoxTinhTrangDonDep
            // 
            this.ComboBoxTinhTrangDonDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTinhTrangDonDep.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxTinhTrangDonDep.FormattingEnabled = true;
            this.ComboBoxTinhTrangDonDep.Items.AddRange(new object[] {
            "Đã dọn dẹp",
            "Đang dọn dẹp"});
            this.ComboBoxTinhTrangDonDep.Location = new System.Drawing.Point(616, 237);
            this.ComboBoxTinhTrangDonDep.Name = "ComboBoxTinhTrangDonDep";
            this.ComboBoxTinhTrangDonDep.Size = new System.Drawing.Size(192, 29);
            this.ComboBoxTinhTrangDonDep.TabIndex = 4;
            this.ComboBoxTinhTrangDonDep.Text = "  Tình trạng dọn dẹp";
            // 
            // ComboBoxTinhTrangPhong
            // 
            this.ComboBoxTinhTrangPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTinhTrangPhong.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxTinhTrangPhong.FormattingEnabled = true;
            this.ComboBoxTinhTrangPhong.Location = new System.Drawing.Point(616, 155);
            this.ComboBoxTinhTrangPhong.Name = "ComboBoxTinhTrangPhong";
            this.ComboBoxTinhTrangPhong.Size = new System.Drawing.Size(192, 29);
            this.ComboBoxTinhTrangPhong.TabIndex = 4;
            this.ComboBoxTinhTrangPhong.Text = "  Tình trạng phòng";
            // 
            // gridDichVu
            // 
            this.gridDichVu.AllowUserToAddRows = false;
            this.gridDichVu.AllowUserToDeleteRows = false;
            this.gridDichVu.AllowUserToResizeColumns = false;
            this.gridDichVu.AllowUserToResizeRows = false;
            this.gridDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gridDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDichVu.ColumnHeadersHeight = 50;
            this.gridDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridDichVu.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDichVu.EnableHeadersVisualStyles = false;
            this.gridDichVu.Location = new System.Drawing.Point(38, 105);
            this.gridDichVu.MultiSelect = false;
            this.gridDichVu.Name = "gridDichVu";
            this.gridDichVu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDichVu.RowHeadersVisible = false;
            this.gridDichVu.RowHeadersWidth = 40;
            this.gridDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDichVu.RowTemplate.Height = 40;
            this.gridDichVu.RowTemplate.ReadOnly = true;
            this.gridDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDichVu.Size = new System.Drawing.Size(383, 263);
            this.gridDichVu.TabIndex = 31;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 125F;
            this.Column1.HeaderText = "Dịch vụ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 125F;
            this.Column3.HeaderText = "Thành tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LabelCapNhatTinhTrangDonDep
            // 
            this.LabelCapNhatTinhTrangDonDep.AutoSize = true;
            this.LabelCapNhatTinhTrangDonDep.BackColor = System.Drawing.Color.White;
            this.LabelCapNhatTinhTrangDonDep.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCapNhatTinhTrangDonDep.Location = new System.Drawing.Point(505, 200);
            this.LabelCapNhatTinhTrangDonDep.Name = "LabelCapNhatTinhTrangDonDep";
            this.LabelCapNhatTinhTrangDonDep.Size = new System.Drawing.Size(254, 25);
            this.LabelCapNhatTinhTrangDonDep.TabIndex = 3;
            this.LabelCapNhatTinhTrangDonDep.Text = "Cập nhật tình trạng dọn dẹp";
            // 
            // ctPanel1
            // 
            this.ctPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctPanel1.BackColor = System.Drawing.Color.White;
            this.ctPanel1.BorderRadius = 50;
            this.ctPanel1.ForeColor = System.Drawing.Color.Black;
            this.ctPanel1.GradientAngle = 90F;
            this.ctPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ctPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.ctPanel1.Location = new System.Drawing.Point(23, 100);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(413, 289);
            this.ctPanel1.TabIndex = 30;
            // 
            // LabelCapNhatTinhTrangPhong
            // 
            this.LabelCapNhatTinhTrangPhong.AutoSize = true;
            this.LabelCapNhatTinhTrangPhong.BackColor = System.Drawing.Color.White;
            this.LabelCapNhatTinhTrangPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCapNhatTinhTrangPhong.Location = new System.Drawing.Point(509, 117);
            this.LabelCapNhatTinhTrangPhong.Name = "LabelCapNhatTinhTrangPhong";
            this.LabelCapNhatTinhTrangPhong.Size = new System.Drawing.Size(239, 25);
            this.LabelCapNhatTinhTrangPhong.TabIndex = 3;
            this.LabelCapNhatTinhTrangPhong.Text = "Cập nhật tình trạng phòng";
            // 
            // LabelSoNguoi
            // 
            this.LabelSoNguoi.AutoSize = true;
            this.LabelSoNguoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSoNguoi.Location = new System.Drawing.Point(750, 37);
            this.LabelSoNguoi.Name = "LabelSoNguoi";
            this.LabelSoNguoi.Size = new System.Drawing.Size(73, 21);
            this.LabelSoNguoi.TabIndex = 3;
            this.LabelSoNguoi.Text = "Số người";
            // 
            // LabelThoiGianThue
            // 
            this.LabelThoiGianThue.AutoSize = true;
            this.LabelThoiGianThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThoiGianThue.Location = new System.Drawing.Point(526, 37);
            this.LabelThoiGianThue.Name = "LabelThoiGianThue";
            this.LabelThoiGianThue.Size = new System.Drawing.Size(110, 21);
            this.LabelThoiGianThue.TabIndex = 3;
            this.LabelThoiGianThue.Text = "Thời gian thuê";
            this.LabelThoiGianThue.Click += new System.EventHandler(this.LabelThoiGianThue_Click);
            // 
            // LabelNgayCheckin
            // 
            this.LabelNgayCheckin.AutoSize = true;
            this.LabelNgayCheckin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNgayCheckin.Location = new System.Drawing.Point(318, 37);
            this.LabelNgayCheckin.Name = "LabelNgayCheckin";
            this.LabelNgayCheckin.Size = new System.Drawing.Size(103, 21);
            this.LabelNgayCheckin.TabIndex = 3;
            this.LabelNgayCheckin.Text = "Ngày checkin";
            // 
            // LabelTen
            // 
            this.LabelTen.AutoSize = true;
            this.LabelTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTen.Location = new System.Drawing.Point(66, 37);
            this.LabelTen.Name = "LabelTen";
            this.LabelTen.Size = new System.Drawing.Size(140, 21);
            this.LabelTen.TabIndex = 3;
            this.LabelTen.Text = "Họ tên khách hàng";
            // 
            // PictureBoxSoNguoi
            // 
            this.PictureBoxSoNguoi.Image = global::HotelManagement.Properties.Resources.SoNguoi;
            this.PictureBoxSoNguoi.Location = new System.Drawing.Point(718, 33);
            this.PictureBoxSoNguoi.Name = "PictureBoxSoNguoi";
            this.PictureBoxSoNguoi.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxSoNguoi.TabIndex = 0;
            this.PictureBoxSoNguoi.TabStop = false;
            // 
            // PictureBoxThoiGianThue
            // 
            this.PictureBoxThoiGianThue.Image = global::HotelManagement.Properties.Resources.ClockPick;
            this.PictureBoxThoiGianThue.Location = new System.Drawing.Point(491, 33);
            this.PictureBoxThoiGianThue.Name = "PictureBoxThoiGianThue";
            this.PictureBoxThoiGianThue.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxThoiGianThue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxThoiGianThue.TabIndex = 0;
            this.PictureBoxThoiGianThue.TabStop = false;
            // 
            // PictureBoxNgayCheckin
            // 
            this.PictureBoxNgayCheckin.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.PictureBoxNgayCheckin.Location = new System.Drawing.Point(283, 33);
            this.PictureBoxNgayCheckin.Name = "PictureBoxNgayCheckin";
            this.PictureBoxNgayCheckin.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxNgayCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxNgayCheckin.TabIndex = 0;
            this.PictureBoxNgayCheckin.TabStop = false;
            // 
            // PictureBoxTen
            // 
            this.PictureBoxTen.Image = global::HotelManagement.Properties.Resources.NameKH;
            this.PictureBoxTen.Location = new System.Drawing.Point(31, 33);
            this.PictureBoxTen.Name = "PictureBoxTen";
            this.PictureBoxTen.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxTen.TabIndex = 0;
            this.PictureBoxTen.TabStop = false;
            // 
            // ctPanel2
            // 
            this.ctPanel2.BackColor = System.Drawing.Color.White;
            this.ctPanel2.BorderRadius = 30;
            this.ctPanel2.ForeColor = System.Drawing.Color.Black;
            this.ctPanel2.GradientAngle = 0F;
            this.ctPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.ctPanel2.GradientTopColor = System.Drawing.Color.White;
            this.ctPanel2.Location = new System.Drawing.Point(477, 100);
            this.ctPanel2.Name = "ctPanel2";
            this.ctPanel2.Size = new System.Drawing.Size(370, 177);
            this.ctPanel2.TabIndex = 32;
            // 
            // ctPanel3
            // 
            this.ctPanel3.BackColor = System.Drawing.Color.White;
            this.ctPanel3.BorderRadius = 30;
            this.ctPanel3.ForeColor = System.Drawing.Color.Black;
            this.ctPanel3.GradientAngle = 0F;
            this.ctPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ctPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ctPanel3.Location = new System.Drawing.Point(477, 283);
            this.ctPanel3.Name = "ctPanel3";
            this.ctPanel3.Size = new System.Drawing.Size(370, 106);
            this.ctPanel3.TabIndex = 33;
            // 
            // PanelBackgroundTop
            // 
            this.PanelBackgroundTop.Controls.Add(this.LabelMaPhong);
            this.PanelBackgroundTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBackgroundTop.Location = new System.Drawing.Point(0, 0);
            this.PanelBackgroundTop.Name = "PanelBackgroundTop";
            this.PanelBackgroundTop.Size = new System.Drawing.Size(979, 488);
            this.PanelBackgroundTop.TabIndex = 11;
            this.PanelBackgroundTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // LabelMaPhong
            // 
            this.LabelMaPhong.AutoSize = true;
            this.LabelMaPhong.BackColor = System.Drawing.Color.Transparent;
            this.LabelMaPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaPhong.Location = new System.Drawing.Point(408, 9);
            this.LabelMaPhong.Name = "LabelMaPhong";
            this.LabelMaPhong.Size = new System.Drawing.Size(148, 37);
            this.LabelMaPhong.TabIndex = 4;
            this.LabelMaPhong.Text = "Mã Phòng";
            // 
            // FormThongTinPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 550);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongTinPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThongTinPhong";
            this.Activated += new System.EventHandler(this.FormThongTinPhong_Activated);
            this.Load += new System.EventHandler(this.FormThongTinPhong_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormThongTinPhong_Paint);
            this.Resize += new System.EventHandler(this.FormThongTinPhong_Resize);
            this.StyleChanged += new System.EventHandler(this.FormThongTinPhong_SizeChanged);
            this.PanelBackground.ResumeLayout(false);
            this.PanelChuaButtonCoc.ResumeLayout(false);
            this.PanelChuaButtonThemDichVu.ResumeLayout(false);
            this.PanelChuaButtonThanhToan.ResumeLayout(false);
            this.PanelChuaButtonDatPhongNay.ResumeLayout(false);
            this.PanelChuaButtonNhanPhong.ResumeLayout(false);
            this.PanelChuaButtonLuu.ResumeLayout(false);
            this.PanelChuaButtonThoat.ResumeLayout(false);
            this.PanelChuaThongTin.ResumeLayout(false);
            this.PanelChuaThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxThoiGianThue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).EndInit();
            this.PanelBackgroundTop.ResumeLayout(false);
            this.PanelBackgroundTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Panel PanelChuaThongTin;
        private System.Windows.Forms.Label LabelSoNguoi;
        private System.Windows.Forms.Label LabelThoiGianThue;
        private System.Windows.Forms.Label LabelNgayCheckin;
        private System.Windows.Forms.Label LabelTen;
        private System.Windows.Forms.PictureBox PictureBoxSoNguoi;
        private System.Windows.Forms.PictureBox PictureBoxThoiGianThue;
        private System.Windows.Forms.PictureBox PictureBoxNgayCheckin;
        private System.Windows.Forms.PictureBox PictureBoxTen;
        private System.Windows.Forms.Panel PanelBackgroundTop;
        private System.Windows.Forms.Label LabelMaPhong;
        private System.Windows.Forms.Label LabelGhiChu;
        private CTPanel.CTPanel ctPanel1;
        private System.Windows.Forms.DataGridView gridDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox ComboBoxTinhTrangDonDep;
        private System.Windows.Forms.ComboBox ComboBoxTinhTrangPhong;
        private System.Windows.Forms.Label LabelCapNhatTinhTrangDonDep;
        private System.Windows.Forms.Label LabelCapNhatTinhTrangPhong;
        private CTPanel.CTPanel ctPanel2;
        private System.Windows.Forms.TextBox TextBoxGhiChu;
        private CTPanel.CTPanel ctPanel3;
        private System.Windows.Forms.Panel PanelChuaButtonCoc;
        private CTControls.CTButton CTButtonCoc;
        private System.Windows.Forms.Panel PanelChuaButtonThemDichVu;
        private CTControls.CTButton CTButtonThemDichVu;
        private System.Windows.Forms.Panel PanelChuaButtonThanhToan;
        private CTControls.CTButton CTButtonThanhToan;
        private System.Windows.Forms.Panel PanelChuaButtonDatPhongNay;
        private CTControls.CTButton CTButtonDatPhongNay;
        private System.Windows.Forms.Panel PanelChuaButtonNhanPhong;
        private CTControls.CTButton CTButtonNhanPhong;
        private System.Windows.Forms.Panel PanelChuaButtonLuu;
        private CTControls.CTButton CTButtonLuu;
        private System.Windows.Forms.Panel PanelChuaButtonThoat;
        private CTControls.CTButton CTButtonThoat;
    }
}