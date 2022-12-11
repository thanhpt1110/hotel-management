namespace HotelManagement.GUI
{
    partial class FormThemTienNghi
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
            this.LabelThemTienNghi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctTextBox2 = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBox4 = new HotelManagement.CTControls.CTTextBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.White;
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.LabelThemTienNghi);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(533, 344);
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
            this.CTButtonThoat.Location = new System.Drawing.Point(337, 287);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 0;
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
            this.CTButtonCapNhat.Location = new System.Drawing.Point(180, 287);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 6;
            this.CTButtonCapNhat.Text = "Cập nhật";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.White;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            // 
            // LabelThemTienNghi
            // 
            this.LabelThemTienNghi.AutoSize = true;
            this.LabelThemTienNghi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThemTienNghi.Location = new System.Drawing.Point(173, 9);
            this.LabelThemTienNghi.Name = "LabelThemTienNghi";
            this.LabelThemTienNghi.Size = new System.Drawing.Size(210, 37);
            this.LabelThemTienNghi.TabIndex = 0;
            this.LabelThemTienNghi.Text = "Thêm tiện nghi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ctTextBox2);
            this.panel1.Controls.Add(this.ctTextBox4);
            this.panel1.Location = new System.Drawing.Point(53, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 212);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.note;
            this.pictureBox4.Location = new System.Drawing.Point(71, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.DichVu;
            this.pictureBox1.Location = new System.Drawing.Point(69, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ctTextBox2
            // 
            this.ctTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBox2.BorderRadius = 0;
            this.ctTextBox2.BorderSize = 2;
            this.ctTextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox2.IsFocused = false;
            this.ctTextBox2.Location = new System.Drawing.Point(107, 41);
            this.ctTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox2.Multiline = false;
            this.ctTextBox2.Name = "ctTextBox2";
            this.ctTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBox2.PasswordChar = false;
            this.ctTextBox2.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBox2.PlaceholderText = "Tên tiện nghi";
            this.ctTextBox2.ReadOnly = false;
            this.ctTextBox2.Size = new System.Drawing.Size(250, 35);
            this.ctTextBox2.TabIndex = 4;
            this.ctTextBox2.Texts = "";
            this.ctTextBox2.UnderlineedStyle = true;
            // 
            // ctTextBox4
            // 
            this.ctTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ctTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBox4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBox4.BorderRadius = 0;
            this.ctTextBox4.BorderSize = 2;
            this.ctTextBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox4.IsFocused = false;
            this.ctTextBox4.Location = new System.Drawing.Point(107, 122);
            this.ctTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox4.Multiline = false;
            this.ctTextBox4.Name = "ctTextBox4";
            this.ctTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBox4.PasswordChar = false;
            this.ctTextBox4.PlaceholderColor = System.Drawing.Color.DimGray;
            this.ctTextBox4.PlaceholderText = "Mô tả";
            this.ctTextBox4.ReadOnly = false;
            this.ctTextBox4.Size = new System.Drawing.Size(250, 35);
            this.ctTextBox4.TabIndex = 4;
            this.ctTextBox4.Texts = "";
            this.ctTextBox4.UnderlineedStyle = true;
            // 
            // FormThemTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 344);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemTienNghi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormThemTienNghi";
            this.Activated += new System.EventHandler(this.FormThemTienNghi_Activated);
            this.SizeChanged += new System.EventHandler(this.FormThemTienNghi_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormThemTienNghi_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            this.Resize += new System.EventHandler(this.FormThemTienNghi_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Label LabelThemTienNghi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox ctTextBox2;
        private CTControls.CTTextBox ctTextBox4;
    }
}