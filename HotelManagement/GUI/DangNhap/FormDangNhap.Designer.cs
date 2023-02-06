namespace HotelManagement.GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.buttonLogin = new HotelManagement.CTControls.CTButton();
            this.textBoxPassword = new HotelManagement.CTControls.CTTextBox();
            this.textBoxUsername = new HotelManagement.CTControls.CTTextBox();
            this.labelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctEyePassword1 = new HotelManagement.CTControls.CTEyePassword();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.buttonLogin.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.BorderRadius = 25;
            this.buttonLogin.BorderSize = 0;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(93, 356);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(146, 47);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.TextColor = System.Drawing.Color.White;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxPassword.BorderRadius = 20;
            this.textBoxPassword.BorderSize = 1;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBoxPassword.IsFocused = false;
            this.textBoxPassword.Location = new System.Drawing.Point(23, 252);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.textBoxPassword.PasswordChar = true;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "Mật khẩu";
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.Size = new System.Drawing.Size(285, 45);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlineedStyle = false;
            this.textBoxPassword._TextChanged += new System.EventHandler(this.textBoxPassword__TextChanged);
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
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "Tên tài khoản";
            this.textBoxUsername.ReadOnly = false;
            this.textBoxUsername.Size = new System.Drawing.Size(285, 45);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlineedStyle = false;
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelForgotPassword.Location = new System.Drawing.Point(182, 310);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(126, 21);
            this.labelForgotPassword.TabIndex = 9;
            this.labelForgotPassword.TabStop = true;
            this.labelForgotPassword.Text = "Quên mật khẩu?";
            this.labelForgotPassword.Click += new System.EventHandler(this.labelForgotPassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.DangNhap;
            this.pictureBox1.Location = new System.Drawing.Point(50, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ctEyePassword1
            // 
            this.ctEyePassword1.BackColor = System.Drawing.Color.Transparent;
            this.ctEyePassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctEyePassword1.BackgroundImage")));
            this.ctEyePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctEyePassword1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctEyePassword1.IsShow = false;
            this.ctEyePassword1.Location = new System.Drawing.Point(265, 262);
            this.ctEyePassword1.Name = "ctEyePassword1";
            this.ctEyePassword1.Size = new System.Drawing.Size(30, 26);
            this.ctEyePassword1.TabIndex = 14;
            this.ctEyePassword1.Click += new System.EventHandler(this.ctEyePassword1_Click);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.ctEyePassword1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTControls.CTButton buttonLogin;
        private CTControls.CTTextBox textBoxPassword;
        private CTControls.CTTextBox textBoxUsername;
        private System.Windows.Forms.LinkLabel labelForgotPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTEyePassword ctEyePassword1;
    }
}