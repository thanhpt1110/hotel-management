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
            this.LabelForgotPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBox1 = new HotelManagement.CTControls.CTTextBox();
            this.buttonLogin = new HotelManagement.CTControls.CTButton();
            this.SuspendLayout();
            // 
            // LabelForgotPassword
            // 
            this.LabelForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelForgotPassword.AutoSize = true;
            this.LabelForgotPassword.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.LabelForgotPassword.Location = new System.Drawing.Point(40, 77);
            this.LabelForgotPassword.Name = "LabelForgotPassword";
            this.LabelForgotPassword.Size = new System.Drawing.Size(295, 59);
            this.LabelForgotPassword.TabIndex = 2;
            this.LabelForgotPassword.Text = "Forgot password";
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
            this.textBoxUsername.Location = new System.Drawing.Point(48, 203);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "Enter your username";
            this.textBoxUsername.ReadOnly = false;
            this.textBoxUsername.Size = new System.Drawing.Size(286, 45);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlineedStyle = false;
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.ctTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.ctTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.ctTextBox1.BorderRadius = 20;
            this.ctTextBox1.BorderSize = 1;
            this.ctTextBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.ctTextBox1.IsFocused = false;
            this.ctTextBox1.Location = new System.Drawing.Point(48, 293);
            this.ctTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBox1.Multiline = false;
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.ctTextBox1.PasswordChar = false;
            this.ctTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ctTextBox1.PlaceholderText = "Enter your email";
            this.ctTextBox1.ReadOnly = false;
            this.ctTextBox1.Size = new System.Drawing.Size(286, 45);
            this.ctTextBox1.TabIndex = 4;
            this.ctTextBox1.Texts = "";
            this.ctTextBox1.UnderlineedStyle = false;
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
            this.buttonLogin.Location = new System.Drawing.Point(110, 393);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(146, 47);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "GET OTP";
            this.buttonLogin.TextColor = System.Drawing.Color.White;
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // FormQuenMatKhauLayOTP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 538);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.ctTextBox1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.LabelForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhauLayOTP";
            this.Text = "FormQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelForgotPassword;
        private CTControls.CTTextBox textBoxUsername;
        private CTControls.CTTextBox ctTextBox1;
        private CTControls.CTButton buttonLogin;
    }
}