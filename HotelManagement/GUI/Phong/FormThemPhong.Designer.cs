namespace HotelManagement.GUI
{
    partial class FormThemPhong
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
            this.LabelThemPhong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxLoaiPhong = new HotelManagement.CTControls.CTComboBox();
            this.comboBoxDonDep = new HotelManagement.CTControls.CTComboBox();
            this.comboBoxTinhTrangPhong = new HotelManagement.CTControls.CTComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ctTextBoxMaPH = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctTextBoxGhiChu = new HotelManagement.CTControls.CTTextBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.PanelBackground.Controls.Add(this.LabelThemPhong);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(533, 535);
            this.PanelBackground.TabIndex = 1;
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
            this.CTButtonThoat.TabIndex = 8;
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
            this.CTButtonCapNhat.Location = new System.Drawing.Point(193, 480);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 7;
            this.CTButtonCapNhat.Text = "Thêm";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // LabelThemPhong
            // 
            this.LabelThemPhong.AutoSize = true;
            this.LabelThemPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThemPhong.Location = new System.Drawing.Point(173, 9);
            this.LabelThemPhong.Name = "LabelThemPhong";
            this.LabelThemPhong.Size = new System.Drawing.Size(179, 37);
            this.LabelThemPhong.TabIndex = 0;
            this.LabelThemPhong.Text = "Thêm phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.comboBoxLoaiPhong);
            this.panel1.Controls.Add(this.comboBoxDonDep);
            this.panel1.Controls.Add(this.comboBoxTinhTrangPhong);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.ctTextBoxMaPH);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ctTextBoxGhiChu);
            this.panel1.Location = new System.Drawing.Point(53, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 404);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxLoaiPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxLoaiPhong.BorderSize = 2;
            this.comboBoxLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.comboBoxLoaiPhong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxLoaiPhong.Items.AddRange(new object[] {
            "Thường đơn",
            "Thường đôi",
            "VIP đơn",
            "VIP đôi"});
            this.comboBoxLoaiPhong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxLoaiPhong.ListTextColor = System.Drawing.Color.Black;
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(107, 253);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(250, 33);
            this.comboBoxLoaiPhong.TabIndex = 5;
            this.comboBoxLoaiPhong.Texts = "Loại phòng";
            // 
            // comboBoxDonDep
            // 
            this.comboBoxDonDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxDonDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxDonDep.BorderSize = 2;
            this.comboBoxDonDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDonDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDonDep.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDonDep.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxDonDep.Items.AddRange(new object[] {
            "Đã dọn dẹp",
            "Đang dọn dẹp"});
            this.comboBoxDonDep.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxDonDep.ListTextColor = System.Drawing.Color.Black;
            this.comboBoxDonDep.Location = new System.Drawing.Point(107, 173);
            this.comboBoxDonDep.Name = "comboBoxDonDep";
            this.comboBoxDonDep.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxDonDep.Size = new System.Drawing.Size(250, 33);
            this.comboBoxDonDep.TabIndex = 4;
            this.comboBoxDonDep.Texts = "Tình trạng dọn dẹp";
            // 
            // comboBoxTinhTrangPhong
            // 
            this.comboBoxTinhTrangPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxTinhTrangPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxTinhTrangPhong.BorderSize = 2;
            this.comboBoxTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTinhTrangPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTinhTrangPhong.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTinhTrangPhong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.comboBoxTinhTrangPhong.Items.AddRange(new object[] {
            "Bình thường",
            "Đang sửa chữa"});
            this.comboBoxTinhTrangPhong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxTinhTrangPhong.ListTextColor = System.Drawing.Color.Black;
            this.comboBoxTinhTrangPhong.Location = new System.Drawing.Point(107, 98);
            this.comboBoxTinhTrangPhong.Name = "comboBoxTinhTrangPhong";
            this.comboBoxTinhTrangPhong.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxTinhTrangPhong.Size = new System.Drawing.Size(250, 33);
            this.comboBoxTinhTrangPhong.TabIndex = 3;
            this.comboBoxTinhTrangPhong.Texts = "Tình trạng phòng";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HotelManagement.Properties.Resources.phong_icon;
            this.pictureBox5.Location = new System.Drawing.Point(69, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // ctTextBoxMaPH
            // 
            this.ctTextBoxMaPH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBoxMaPH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBoxMaPH.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxMaPH.BorderRadius = 0;
            this.ctTextBoxMaPH.BorderSize = 2;
            this.ctTextBoxMaPH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxMaPH.IsFocused = false;
            this.ctTextBoxMaPH.Location = new System.Drawing.Point(107, 28);
            this.ctTextBoxMaPH.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxMaPH.Multiline = false;
            this.ctTextBoxMaPH.Name = "ctTextBoxMaPH";
            this.ctTextBoxMaPH.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxMaPH.PasswordChar = false;
            this.ctTextBoxMaPH.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxMaPH.PlaceholderText = "Nhập mã phòng";
            this.ctTextBoxMaPH.ReadOnly = false;
            this.ctTextBoxMaPH.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxMaPH.TabIndex = 2;
            this.ctTextBoxMaPH.Texts = "";
            this.ctTextBoxMaPH.UnderlineedStyle = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.note;
            this.pictureBox4.Location = new System.Drawing.Point(71, 329);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources._3people;
            this.pictureBox3.Location = new System.Drawing.Point(71, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.clean;
            this.pictureBox2.Location = new System.Drawing.Point(69, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.pictureBox1.Location = new System.Drawing.Point(69, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.ctTextBoxGhiChu.Location = new System.Drawing.Point(107, 324);
            this.ctTextBoxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxGhiChu.Multiline = false;
            this.ctTextBoxGhiChu.Name = "ctTextBoxGhiChu";
            this.ctTextBoxGhiChu.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxGhiChu.PasswordChar = false;
            this.ctTextBoxGhiChu.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBoxGhiChu.PlaceholderText = "Ghi chú";
            this.ctTextBoxGhiChu.ReadOnly = false;
            this.ctTextBoxGhiChu.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxGhiChu.TabIndex = 6;
            this.ctTextBoxGhiChu.Texts = "";
            this.ctTextBoxGhiChu.UnderlineedStyle = true;
            this.ctTextBoxGhiChu._TextChanged += new System.EventHandler(this.ctTextBox4__TextChanged);
            // 
            // FormThemPhong
            // 
            this.AcceptButton = this.CTButtonCapNhat;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 535);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormThemPhong";
            this.Activated += new System.EventHandler(this.FormThemPhong_Activated);
            this.Load += new System.EventHandler(this.FormThemPhong_Load);
            this.SizeChanged += new System.EventHandler(this.FormThemPhong_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormThemPhong_Paint);
            this.Resize += new System.EventHandler(this.FormThemPhong_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.Label LabelThemPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox ctTextBoxGhiChu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CTControls.CTTextBox ctTextBoxMaPH;
        private CTControls.CTComboBox comboBoxLoaiPhong;
        private CTControls.CTComboBox comboBoxDonDep;
        private CTControls.CTComboBox comboBoxTinhTrangPhong;
    }
}