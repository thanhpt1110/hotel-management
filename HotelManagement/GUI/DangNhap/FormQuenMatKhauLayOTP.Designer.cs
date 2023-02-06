namespace HotelManagement.GUI
{
    partial class FormQuenMatKhauLayOTP
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
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.ButtonLayOTP = new HotelManagement.CTControls.CTButton();
            this.TextBoxEmail = new HotelManagement.CTControls.CTTextBox();
            this.textBoxUsername = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBack
            // 
            this.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBack.Image = global::HotelManagement.Properties.Resources.back;
            this.PictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBack.Name = "PictureBoxBack";
            this.PictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBack.TabIndex = 7;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // ButtonLayOTP
            // 
            this.ButtonLayOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonLayOTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonLayOTP.BorderColor = System.Drawing.Color.White;
            this.ButtonLayOTP.BorderRadius = 25;
            this.ButtonLayOTP.BorderSize = 0;
            this.ButtonLayOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLayOTP.FlatAppearance.BorderSize = 0;
            this.ButtonLayOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLayOTP.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.ButtonLayOTP.ForeColor = System.Drawing.Color.White;
            this.ButtonLayOTP.Location = new System.Drawing.Point(93, 356);
            this.ButtonLayOTP.Name = "ButtonLayOTP";
            this.ButtonLayOTP.Size = new System.Drawing.Size(140, 47);
            this.ButtonLayOTP.TabIndex = 6;
            this.ButtonLayOTP.Text = "Lấy mã OTP";
            this.ButtonLayOTP.TextColor = System.Drawing.Color.White;
            this.ButtonLayOTP.UseVisualStyleBackColor = false;
            this.ButtonLayOTP.Click += new System.EventHandler(this.ButtonLayOTP_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.TextBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.TextBoxEmail.BorderRadius = 20;
            this.TextBoxEmail.BorderSize = 1;
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.TextBoxEmail.IsFocused = false;
            this.TextBoxEmail.Location = new System.Drawing.Point(23, 252);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Multiline = false;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.TextBoxEmail.PasswordChar = false;
            this.TextBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxEmail.PlaceholderText = "Email";
            this.TextBoxEmail.ReadOnly = false;
            this.TextBoxEmail.Size = new System.Drawing.Size(286, 45);
            this.TextBoxEmail.TabIndex = 4;
            this.TextBoxEmail.Texts = "";
            this.TextBoxEmail.UnderlineedStyle = false;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxUsername.BorderRadius = 20;
            this.textBoxUsername.BorderSize = 1;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBoxUsername.IsFocused = false;
            this.textBoxUsername.Location = new System.Drawing.Point(23, 177);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "Tên tài khoản";
            this.textBoxUsername.ReadOnly = false;
            this.textBoxUsername.Size = new System.Drawing.Size(286, 45);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlineedStyle = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.QuenMatKhau;
            this.pictureBox3.Location = new System.Drawing.Point(23, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(286, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // FormQuenMatKhauLayOTP
            // 
            this.AcceptButton = this.ButtonLayOTP;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonLayOTP);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhauLayOTP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CTControls.CTTextBox textBoxUsername;
        private CTControls.CTTextBox TextBoxEmail;
        private CTControls.CTButton ButtonLayOTP;
        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}