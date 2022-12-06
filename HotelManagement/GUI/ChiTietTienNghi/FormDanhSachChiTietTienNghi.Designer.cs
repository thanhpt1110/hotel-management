namespace HotelManagement.GUI
{
    partial class FormDanhSachChiTietTienNghi
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
            this.CTButtonThemChiTietTienNghi = new HotelManagement.CTControls.CTButton();
            this.CTTextBoxTimTenLoaiPhong = new HotelManagement.CTControls.CTTextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.buttonExport = new HotelManagement.CTControls.CTButton();
            this.ctPanel1 = new CTPanel.CTPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CTButtonThemChiTietTienNghi
            // 
            this.CTButtonThemChiTietTienNghi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemChiTietTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemChiTietTienNghi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemChiTietTienNghi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemChiTietTienNghi.BorderRadius = 10;
            this.CTButtonThemChiTietTienNghi.BorderSize = 0;
            this.CTButtonThemChiTietTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemChiTietTienNghi.FlatAppearance.BorderSize = 0;
            this.CTButtonThemChiTietTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemChiTietTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemChiTietTienNghi.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemChiTietTienNghi.Location = new System.Drawing.Point(1008, 29);
            this.CTButtonThemChiTietTienNghi.Name = "CTButtonThemChiTietTienNghi";
            this.CTButtonThemChiTietTienNghi.Size = new System.Drawing.Size(200, 40);
            this.CTButtonThemChiTietTienNghi.TabIndex = 22;
            this.CTButtonThemChiTietTienNghi.Text = "Thêm chi tiết tiện nghi";
            this.CTButtonThemChiTietTienNghi.TextColor = System.Drawing.Color.White;
            this.CTButtonThemChiTietTienNghi.UseVisualStyleBackColor = false;
            this.CTButtonThemChiTietTienNghi.Click += new System.EventHandler(this.CTButtonThemChiTietTienNghi_Click);
            // 
            // CTTextBoxTimTenLoaiPhong
            // 
            this.CTTextBoxTimTenLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimTenLoaiPhong.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimTenLoaiPhong.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimTenLoaiPhong.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimTenLoaiPhong.BorderRadius = 5;
            this.CTTextBoxTimTenLoaiPhong.BorderSize = 1;
            this.CTTextBoxTimTenLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimTenLoaiPhong.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimTenLoaiPhong.IsFocused = false;
            this.CTTextBoxTimTenLoaiPhong.Location = new System.Drawing.Point(66, 26);
            this.CTTextBoxTimTenLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimTenLoaiPhong.Multiline = false;
            this.CTTextBoxTimTenLoaiPhong.Name = "CTTextBoxTimTenLoaiPhong";
            this.CTTextBoxTimTenLoaiPhong.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimTenLoaiPhong.PasswordChar = false;
            this.CTTextBoxTimTenLoaiPhong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTenLoaiPhong.PlaceholderText = "Nhập theo tên loại phòng";
            this.CTTextBoxTimTenLoaiPhong.ReadOnly = false;
            this.CTTextBoxTimTenLoaiPhong.Size = new System.Drawing.Size(244, 36);
            this.CTTextBoxTimTenLoaiPhong.TabIndex = 20;
            this.CTTextBoxTimTenLoaiPhong.TabStop = false;
            this.CTTextBoxTimTenLoaiPhong.Texts = "";
            this.CTTextBoxTimTenLoaiPhong.UnderlineedStyle = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(85, 103);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 40;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.RowTemplate.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1097, 659);
            this.grid.TabIndex = 25;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(192)))), ((int)(((byte)(47)))));
            this.buttonExport.BorderRadius = 10;
            this.buttonExport.BorderSize = 0;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.Black;
            this.buttonExport.Location = new System.Drawing.Point(834, 29);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(150, 40);
            this.buttonExport.TabIndex = 26;
            this.buttonExport.Text = "Xuất file Excel";
            this.buttonExport.TextColor = System.Drawing.Color.Black;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
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
            this.ctPanel1.Location = new System.Drawing.Point(66, 94);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(1142, 704);
            this.ctPanel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(71, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 175F;
            this.Column2.HeaderText = "Mã tiện nghi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 225F;
            this.Column3.HeaderText = "Tên tiện nghi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 250F;
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 50F;
            this.Column6.HeaderText = "Sửa";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "Xóa";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // FormDanhSachChiTietTienNghi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.ctPanel1);
            this.Controls.Add(this.CTButtonThemChiTietTienNghi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimTenLoaiPhong);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachChiTietTienNghi";
            this.Text = "FormDanhSachChiTietTienNghi";
            this.Load += new System.EventHandler(this.FormDanhSachChiTietTienNghi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CTControls.CTButton CTButtonThemChiTietTienNghi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimTenLoaiPhong;
        private System.Windows.Forms.DataGridView grid;
        private CTControls.CTButton buttonExport;
        private CTPanel.CTPanel ctPanel1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
    }
}