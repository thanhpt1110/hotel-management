namespace HotelManagement.GUI
{
    partial class FormSoDoPhong
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
            this.PanelLocPhong = new System.Windows.Forms.Panel();
            this.LabelTrangThaiPhong = new System.Windows.Forms.Label();
            this.PanelSoDo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelLoaiPhong = new System.Windows.Forms.Label();
            this.CTRadioButtonTatCaLoaiPhong = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongVIPDoi = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongThuongDon = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongVIPDon = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongThuongDoi = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonTatCaPhong = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongDangSuaChua = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongTrong = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongDangThue = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonPhongDaDat = new HotelManagement.CTControls.CTRadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelTinhTrangDonDep = new System.Windows.Forms.Label();
            this.CTRadioButtonTatCa = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonDaDonDep = new HotelManagement.CTControls.CTRadioButton();
            this.CTRadioButtonChuaDonDep = new HotelManagement.CTControls.CTRadioButton();
            this.PanelLocPhong.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLocPhong
            // 
            this.PanelLocPhong.BackColor = System.Drawing.SystemColors.Control;
            this.PanelLocPhong.Controls.Add(this.panel3);
            this.PanelLocPhong.Controls.Add(this.panel2);
            this.PanelLocPhong.Controls.Add(this.panel1);
            this.PanelLocPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLocPhong.Location = new System.Drawing.Point(0, 0);
            this.PanelLocPhong.Name = "PanelLocPhong";
            this.PanelLocPhong.Size = new System.Drawing.Size(237, 794);
            this.PanelLocPhong.TabIndex = 2;
            // 
            // LabelTrangThaiPhong
            // 
            this.LabelTrangThaiPhong.AutoSize = true;
            this.LabelTrangThaiPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrangThaiPhong.Location = new System.Drawing.Point(7, 6);
            this.LabelTrangThaiPhong.Name = "LabelTrangThaiPhong";
            this.LabelTrangThaiPhong.Size = new System.Drawing.Size(166, 25);
            this.LabelTrangThaiPhong.TabIndex = 0;
            this.LabelTrangThaiPhong.Text = "Trạng thái phòng";
            // 
            // PanelSoDo
            // 
            this.PanelSoDo.AutoScroll = true;
            this.PanelSoDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSoDo.Location = new System.Drawing.Point(237, 0);
            this.PanelSoDo.Name = "PanelSoDo";
            this.PanelSoDo.Size = new System.Drawing.Size(1007, 794);
            this.PanelSoDo.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelTrangThaiPhong);
            this.panel1.Controls.Add(this.CTRadioButtonTatCaPhong);
            this.panel1.Controls.Add(this.CTRadioButtonPhongDangSuaChua);
            this.panel1.Controls.Add(this.CTRadioButtonPhongTrong);
            this.panel1.Controls.Add(this.CTRadioButtonPhongDangThue);
            this.panel1.Controls.Add(this.CTRadioButtonPhongDaDat);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 220);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelLoaiPhong);
            this.panel2.Controls.Add(this.CTRadioButtonTatCaLoaiPhong);
            this.panel2.Controls.Add(this.CTRadioButtonPhongVIPDoi);
            this.panel2.Controls.Add(this.CTRadioButtonPhongThuongDon);
            this.panel2.Controls.Add(this.CTRadioButtonPhongVIPDon);
            this.panel2.Controls.Add(this.CTRadioButtonPhongThuongDoi);
            this.panel2.Location = new System.Drawing.Point(13, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 213);
            this.panel2.TabIndex = 3;
            // 
            // LabelLoaiPhong
            // 
            this.LabelLoaiPhong.AutoSize = true;
            this.LabelLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoaiPhong.Location = new System.Drawing.Point(7, 6);
            this.LabelLoaiPhong.Name = "LabelLoaiPhong";
            this.LabelLoaiPhong.Size = new System.Drawing.Size(113, 25);
            this.LabelLoaiPhong.TabIndex = 0;
            this.LabelLoaiPhong.Text = "Loại phòng";
            // 
            // CTRadioButtonTatCaLoaiPhong
            // 
            this.CTRadioButtonTatCaLoaiPhong.AutoSize = true;
            this.CTRadioButtonTatCaLoaiPhong.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.CTRadioButtonTatCaLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonTatCaLoaiPhong.Location = new System.Drawing.Point(12, 164);
            this.CTRadioButtonTatCaLoaiPhong.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonTatCaLoaiPhong.Name = "CTRadioButtonTatCaLoaiPhong";
            this.CTRadioButtonTatCaLoaiPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonTatCaLoaiPhong.Size = new System.Drawing.Size(156, 25);
            this.CTRadioButtonTatCaLoaiPhong.TabIndex = 1;
            this.CTRadioButtonTatCaLoaiPhong.TabStop = true;
            this.CTRadioButtonTatCaLoaiPhong.Text = "Tất cả loại phòng";
            this.CTRadioButtonTatCaLoaiPhong.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonTatCaLoaiPhong.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongVIPDoi
            // 
            this.CTRadioButtonPhongVIPDoi.AutoSize = true;
            this.CTRadioButtonPhongVIPDoi.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(185)))), ((int)(((byte)(37)))));
            this.CTRadioButtonPhongVIPDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongVIPDoi.Location = new System.Drawing.Point(12, 133);
            this.CTRadioButtonPhongVIPDoi.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongVIPDoi.Name = "CTRadioButtonPhongVIPDoi";
            this.CTRadioButtonPhongVIPDoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongVIPDoi.Size = new System.Drawing.Size(136, 25);
            this.CTRadioButtonPhongVIPDoi.TabIndex = 1;
            this.CTRadioButtonPhongVIPDoi.TabStop = true;
            this.CTRadioButtonPhongVIPDoi.Text = "Phòng VIP đôi";
            this.CTRadioButtonPhongVIPDoi.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongVIPDoi.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongThuongDon
            // 
            this.CTRadioButtonPhongThuongDon.AutoSize = true;
            this.CTRadioButtonPhongThuongDon.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(199)))), ((int)(((byte)(102)))));
            this.CTRadioButtonPhongThuongDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongThuongDon.Location = new System.Drawing.Point(12, 40);
            this.CTRadioButtonPhongThuongDon.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongThuongDon.Name = "CTRadioButtonPhongThuongDon";
            this.CTRadioButtonPhongThuongDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongThuongDon.Size = new System.Drawing.Size(170, 25);
            this.CTRadioButtonPhongThuongDon.TabIndex = 1;
            this.CTRadioButtonPhongThuongDon.TabStop = true;
            this.CTRadioButtonPhongThuongDon.Text = "Phòng thường đơn";
            this.CTRadioButtonPhongThuongDon.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongThuongDon.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongVIPDon
            // 
            this.CTRadioButtonPhongVIPDon.AutoSize = true;
            this.CTRadioButtonPhongVIPDon.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(195)))), ((int)(((byte)(68)))));
            this.CTRadioButtonPhongVIPDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongVIPDon.Location = new System.Drawing.Point(12, 102);
            this.CTRadioButtonPhongVIPDon.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongVIPDon.Name = "CTRadioButtonPhongVIPDon";
            this.CTRadioButtonPhongVIPDon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongVIPDon.Size = new System.Drawing.Size(142, 25);
            this.CTRadioButtonPhongVIPDon.TabIndex = 1;
            this.CTRadioButtonPhongVIPDon.TabStop = true;
            this.CTRadioButtonPhongVIPDon.Text = "Phòng VIP đơn";
            this.CTRadioButtonPhongVIPDon.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongVIPDon.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongThuongDoi
            // 
            this.CTRadioButtonPhongThuongDoi.AutoSize = true;
            this.CTRadioButtonPhongThuongDoi.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(201)))), ((int)(((byte)(144)))));
            this.CTRadioButtonPhongThuongDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongThuongDoi.Location = new System.Drawing.Point(12, 71);
            this.CTRadioButtonPhongThuongDoi.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongThuongDoi.Name = "CTRadioButtonPhongThuongDoi";
            this.CTRadioButtonPhongThuongDoi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongThuongDoi.Size = new System.Drawing.Size(164, 25);
            this.CTRadioButtonPhongThuongDoi.TabIndex = 1;
            this.CTRadioButtonPhongThuongDoi.TabStop = true;
            this.CTRadioButtonPhongThuongDoi.Text = "Phòng thường đôi";
            this.CTRadioButtonPhongThuongDoi.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongThuongDoi.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonTatCaPhong
            // 
            this.CTRadioButtonTatCaPhong.AutoSize = true;
            this.CTRadioButtonTatCaPhong.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.CTRadioButtonTatCaPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonTatCaPhong.Location = new System.Drawing.Point(12, 164);
            this.CTRadioButtonTatCaPhong.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonTatCaPhong.Name = "CTRadioButtonTatCaPhong";
            this.CTRadioButtonTatCaPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonTatCaPhong.Size = new System.Drawing.Size(127, 25);
            this.CTRadioButtonTatCaPhong.TabIndex = 1;
            this.CTRadioButtonTatCaPhong.TabStop = true;
            this.CTRadioButtonTatCaPhong.Text = "Tất cả phòng";
            this.CTRadioButtonTatCaPhong.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonTatCaPhong.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongDangSuaChua
            // 
            this.CTRadioButtonPhongDangSuaChua.AutoSize = true;
            this.CTRadioButtonPhongDangSuaChua.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(183)))), ((int)(((byte)(213)))));
            this.CTRadioButtonPhongDangSuaChua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongDangSuaChua.Location = new System.Drawing.Point(12, 133);
            this.CTRadioButtonPhongDangSuaChua.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongDangSuaChua.Name = "CTRadioButtonPhongDangSuaChua";
            this.CTRadioButtonPhongDangSuaChua.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongDangSuaChua.Size = new System.Drawing.Size(187, 25);
            this.CTRadioButtonPhongDangSuaChua.TabIndex = 1;
            this.CTRadioButtonPhongDangSuaChua.TabStop = true;
            this.CTRadioButtonPhongDangSuaChua.Text = "Phòng đang sửa chữa";
            this.CTRadioButtonPhongDangSuaChua.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongDangSuaChua.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongTrong
            // 
            this.CTRadioButtonPhongTrong.AutoSize = true;
            this.CTRadioButtonPhongTrong.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(199)))), ((int)(((byte)(102)))));
            this.CTRadioButtonPhongTrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongTrong.Location = new System.Drawing.Point(12, 40);
            this.CTRadioButtonPhongTrong.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongTrong.Name = "CTRadioButtonPhongTrong";
            this.CTRadioButtonPhongTrong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongTrong.Size = new System.Drawing.Size(125, 25);
            this.CTRadioButtonPhongTrong.TabIndex = 1;
            this.CTRadioButtonPhongTrong.TabStop = true;
            this.CTRadioButtonPhongTrong.Text = "Phòng trống";
            this.CTRadioButtonPhongTrong.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongTrong.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongDangThue
            // 
            this.CTRadioButtonPhongDangThue.AutoSize = true;
            this.CTRadioButtonPhongDangThue.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(96)))), ((int)(((byte)(93)))));
            this.CTRadioButtonPhongDangThue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongDangThue.Location = new System.Drawing.Point(12, 102);
            this.CTRadioButtonPhongDangThue.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongDangThue.Name = "CTRadioButtonPhongDangThue";
            this.CTRadioButtonPhongDangThue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongDangThue.Size = new System.Drawing.Size(157, 25);
            this.CTRadioButtonPhongDangThue.TabIndex = 1;
            this.CTRadioButtonPhongDangThue.TabStop = true;
            this.CTRadioButtonPhongDangThue.Text = "Phòng đang thuê";
            this.CTRadioButtonPhongDangThue.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongDangThue.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonPhongDaDat
            // 
            this.CTRadioButtonPhongDaDat.AutoSize = true;
            this.CTRadioButtonPhongDaDat.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(195)))), ((int)(((byte)(68)))));
            this.CTRadioButtonPhongDaDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonPhongDaDat.Location = new System.Drawing.Point(12, 71);
            this.CTRadioButtonPhongDaDat.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonPhongDaDat.Name = "CTRadioButtonPhongDaDat";
            this.CTRadioButtonPhongDaDat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonPhongDaDat.Size = new System.Drawing.Size(130, 25);
            this.CTRadioButtonPhongDaDat.TabIndex = 1;
            this.CTRadioButtonPhongDaDat.TabStop = true;
            this.CTRadioButtonPhongDaDat.Text = "Phòng đã đặt";
            this.CTRadioButtonPhongDaDat.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonPhongDaDat.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabelTinhTrangDonDep);
            this.panel3.Controls.Add(this.CTRadioButtonTatCa);
            this.panel3.Controls.Add(this.CTRadioButtonDaDonDep);
            this.panel3.Controls.Add(this.CTRadioButtonChuaDonDep);
            this.panel3.Location = new System.Drawing.Point(12, 529);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 153);
            this.panel3.TabIndex = 4;
            // 
            // LabelTinhTrangDonDep
            // 
            this.LabelTinhTrangDonDep.AutoSize = true;
            this.LabelTinhTrangDonDep.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTinhTrangDonDep.Location = new System.Drawing.Point(7, 6);
            this.LabelTinhTrangDonDep.Name = "LabelTinhTrangDonDep";
            this.LabelTinhTrangDonDep.Size = new System.Drawing.Size(185, 25);
            this.LabelTinhTrangDonDep.TabIndex = 0;
            this.LabelTinhTrangDonDep.Text = "Tình trạng dọn dẹp";
            // 
            // CTRadioButtonTatCa
            // 
            this.CTRadioButtonTatCa.AutoSize = true;
            this.CTRadioButtonTatCa.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.CTRadioButtonTatCa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonTatCa.Location = new System.Drawing.Point(12, 103);
            this.CTRadioButtonTatCa.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonTatCa.Name = "CTRadioButtonTatCa";
            this.CTRadioButtonTatCa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonTatCa.Size = new System.Drawing.Size(78, 25);
            this.CTRadioButtonTatCa.TabIndex = 1;
            this.CTRadioButtonTatCa.TabStop = true;
            this.CTRadioButtonTatCa.Text = "Tất cả";
            this.CTRadioButtonTatCa.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonTatCa.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonDaDonDep
            // 
            this.CTRadioButtonDaDonDep.AutoSize = true;
            this.CTRadioButtonDaDonDep.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(201)))), ((int)(((byte)(103)))));
            this.CTRadioButtonDaDonDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonDaDonDep.Location = new System.Drawing.Point(12, 41);
            this.CTRadioButtonDaDonDep.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonDaDonDep.Name = "CTRadioButtonDaDonDep";
            this.CTRadioButtonDaDonDep.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonDaDonDep.Size = new System.Drawing.Size(118, 25);
            this.CTRadioButtonDaDonDep.TabIndex = 1;
            this.CTRadioButtonDaDonDep.TabStop = true;
            this.CTRadioButtonDaDonDep.Text = "Đã dọn dẹp";
            this.CTRadioButtonDaDonDep.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonDaDonDep.UseVisualStyleBackColor = true;
            // 
            // CTRadioButtonChuaDonDep
            // 
            this.CTRadioButtonChuaDonDep.AutoSize = true;
            this.CTRadioButtonChuaDonDep.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.CTRadioButtonChuaDonDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTRadioButtonChuaDonDep.Location = new System.Drawing.Point(12, 72);
            this.CTRadioButtonChuaDonDep.MinimumSize = new System.Drawing.Size(0, 21);
            this.CTRadioButtonChuaDonDep.Name = "CTRadioButtonChuaDonDep";
            this.CTRadioButtonChuaDonDep.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CTRadioButtonChuaDonDep.Size = new System.Drawing.Size(135, 25);
            this.CTRadioButtonChuaDonDep.TabIndex = 1;
            this.CTRadioButtonChuaDonDep.TabStop = true;
            this.CTRadioButtonChuaDonDep.Text = "Chưa dọn dẹp";
            this.CTRadioButtonChuaDonDep.UnCheckedColor = System.Drawing.Color.Gray;
            this.CTRadioButtonChuaDonDep.UseVisualStyleBackColor = true;
            // 
            // FormSoDoPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 794);
            this.Controls.Add(this.PanelSoDo);
            this.Controls.Add(this.PanelLocPhong);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSoDoPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormSoDoPhong";
            this.PanelLocPhong.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelLocPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelLoaiPhong;
        private CTControls.CTRadioButton CTRadioButtonTatCaLoaiPhong;
        private CTControls.CTRadioButton CTRadioButtonPhongVIPDoi;
        private CTControls.CTRadioButton CTRadioButtonPhongThuongDon;
        private CTControls.CTRadioButton CTRadioButtonPhongVIPDon;
        private CTControls.CTRadioButton CTRadioButtonPhongThuongDoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTrangThaiPhong;
        private CTControls.CTRadioButton CTRadioButtonTatCaPhong;
        private CTControls.CTRadioButton CTRadioButtonPhongDangSuaChua;
        private CTControls.CTRadioButton CTRadioButtonPhongTrong;
        private CTControls.CTRadioButton CTRadioButtonPhongDangThue;
        private CTControls.CTRadioButton CTRadioButtonPhongDaDat;
        private System.Windows.Forms.Panel PanelSoDo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelTinhTrangDonDep;
        private CTControls.CTRadioButton CTRadioButtonTatCa;
        private CTControls.CTRadioButton CTRadioButtonDaDonDep;
        private CTControls.CTRadioButton CTRadioButtonChuaDonDep;
    }
}