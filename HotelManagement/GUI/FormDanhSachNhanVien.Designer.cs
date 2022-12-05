namespace HotelManagement.GUI
{
    partial class FormDanhSachNhanVien
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
            this.CTButtonThemNhanVien = new HotelManagement.CTControls.CTButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTTextBoxTimTheoTenNhanVien = new HotelManagement.CTControls.CTTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CTButtonThemNhanVien
            // 
            this.CTButtonThemNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonThemNhanVien.BorderRadius = 10;
            this.CTButtonThemNhanVien.BorderSize = 0;
            this.CTButtonThemNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemNhanVien.FlatAppearance.BorderSize = 0;
            this.CTButtonThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemNhanVien.Location = new System.Drawing.Point(1023, 26);
            this.CTButtonThemNhanVien.Name = "CTButtonThemNhanVien";
            this.CTButtonThemNhanVien.Size = new System.Drawing.Size(161, 36);
            this.CTButtonThemNhanVien.TabIndex = 17;
            this.CTButtonThemNhanVien.Text = "Thêm nhân viên";
            this.CTButtonThemNhanVien.TextColor = System.Drawing.Color.White;
            this.CTButtonThemNhanVien.UseVisualStyleBackColor = false;
            this.CTButtonThemNhanVien.Click += new System.EventHandler(this.CTButtonThemNhanVien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(71, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CTTextBoxTimTheoTenNhanVien
            // 
            this.CTTextBoxTimTheoTenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimTheoTenNhanVien.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimTheoTenNhanVien.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimTheoTenNhanVien.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimTheoTenNhanVien.BorderRadius = 5;
            this.CTTextBoxTimTheoTenNhanVien.BorderSize = 1;
            this.CTTextBoxTimTheoTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimTheoTenNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimTheoTenNhanVien.IsFocused = false;
            this.CTTextBoxTimTheoTenNhanVien.Location = new System.Drawing.Point(66, 26);
            this.CTTextBoxTimTheoTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimTheoTenNhanVien.Multiline = false;
            this.CTTextBoxTimTheoTenNhanVien.Name = "CTTextBoxTimTheoTenNhanVien";
            this.CTTextBoxTimTheoTenNhanVien.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimTheoTenNhanVien.PasswordChar = false;
            this.CTTextBoxTimTheoTenNhanVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTheoTenNhanVien.PlaceholderText = "Tìm theo tên nhân viên";
            this.CTTextBoxTimTheoTenNhanVien.ReadOnly = false;
            this.CTTextBoxTimTheoTenNhanVien.Size = new System.Drawing.Size(244, 36);
            this.CTTextBoxTimTheoTenNhanVien.TabIndex = 15;
            this.CTTextBoxTimTheoTenNhanVien.TabStop = false;
            this.CTTextBoxTimTheoTenNhanVien.Texts = "";
            this.CTTextBoxTimTheoTenNhanVien.UnderlineedStyle = false;
            // 
            // FormDanhSachNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.CTButtonThemNhanVien);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimTheoTenNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachNhanVien";
            this.Text = "FormDanhSachNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTControls.CTButton CTButtonThemNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimTheoTenNhanVien;
    }
}