namespace HotelManagement.GUI
{
    partial class FormQuenMatKhauNhapOTP
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
            this.components = new System.ComponentModel.Container();
            this.ButtonContinue = new HotelManagement.CTControls.CTButton();
            this.textBoxOTP = new HotelManagement.CTControls.CTTextBox();
            this.ButtonResend = new HotelManagement.CTControls.CTButton();
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonContinue.BorderColor = System.Drawing.Color.White;
            this.ButtonContinue.BorderRadius = 20;
            this.ButtonContinue.BorderSize = 0;
            this.ButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContinue.FlatAppearance.BorderSize = 0;
            this.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonContinue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonContinue.ForeColor = System.Drawing.Color.White;
            this.ButtonContinue.Location = new System.Drawing.Point(180, 277);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(130, 47);
            this.ButtonContinue.TabIndex = 10;
            this.ButtonContinue.Text = "Tiếp tục";
            this.ButtonContinue.TextColor = System.Drawing.Color.White;
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxOTP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxOTP.BorderRadius = 20;
            this.textBoxOTP.BorderSize = 1;
            this.textBoxOTP.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBoxOTP.IsFocused = false;
            this.textBoxOTP.Location = new System.Drawing.Point(24, 189);
            this.textBoxOTP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTP.Multiline = false;
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxOTP.PasswordChar = false;
            this.textBoxOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOTP.PlaceholderText = "Nhập mã OTP";
            this.textBoxOTP.ReadOnly = false;
            this.textBoxOTP.Size = new System.Drawing.Size(286, 45);
            this.textBoxOTP.TabIndex = 8;
            this.textBoxOTP.Texts = "";
            this.textBoxOTP.UnderlineedStyle = false;
            // 
            // ButtonResend
            // 
            this.ButtonResend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonResend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonResend.BorderColor = System.Drawing.Color.White;
            this.ButtonResend.BorderRadius = 20;
            this.ButtonResend.BorderSize = 0;
            this.ButtonResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonResend.FlatAppearance.BorderSize = 0;
            this.ButtonResend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResend.ForeColor = System.Drawing.Color.White;
            this.ButtonResend.Location = new System.Drawing.Point(24, 277);
            this.ButtonResend.Name = "ButtonResend";
            this.ButtonResend.Size = new System.Drawing.Size(130, 47);
            this.ButtonResend.TabIndex = 10;
            this.ButtonResend.Text = "Gửi lại";
            this.ButtonResend.TextColor = System.Drawing.Color.White;
            this.ButtonResend.UseVisualStyleBackColor = false;
            this.ButtonResend.Click += new System.EventHandler(this.ButtonResend_Click);
            // 
            // PictureBoxBack
            // 
            this.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBack.Image = global::HotelManagement.Properties.Resources.back;
            this.PictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBack.Name = "PictureBoxBack";
            this.PictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBack.TabIndex = 11;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.QuenMatKhau;
            this.pictureBox1.Location = new System.Drawing.Point(22, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FormQuenMatKhauNhapOTP
            // 
            this.AcceptButton = this.ButtonContinue;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonResend);
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.textBoxOTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhauNhapOTP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormQuenMatKhauNhapOTP";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTControls.CTButton ButtonContinue;
        private CTControls.CTTextBox textBoxOTP;
        private CTControls.CTButton ButtonResend;
        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}