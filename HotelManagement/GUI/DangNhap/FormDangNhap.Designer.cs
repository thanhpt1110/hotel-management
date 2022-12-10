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
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new HotelManagement.CTControls.CTButton();
            this.textBoxPassword = new HotelManagement.CTControls.CTTextBox();
            this.textBoxUsername = new HotelManagement.CTControls.CTTextBox();
            this.SuspendLayout();
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgotPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotPassword.ForeColor = System.Drawing.Color.Gray;
            this.labelForgotPassword.Location = new System.Drawing.Point(193, 304);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(127, 20);
            this.labelForgotPassword.TabIndex = 8;
            this.labelForgotPassword.Text = "Forgot password?";
            this.labelForgotPassword.Click += new System.EventHandler(this.labelForgotPassword_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Brush Script MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.labelLogin.Location = new System.Drawing.Point(89, 69);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(160, 79);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "Login";
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
            this.buttonLogin.Location = new System.Drawing.Point(103, 356);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(146, 47);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOG IN";
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
            this.textBoxPassword.Location = new System.Drawing.Point(22, 255);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxPassword.PasswordChar = true;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "Enter your password";
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.Size = new System.Drawing.Size(286, 45);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlineedStyle = false;
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
            this.textBoxUsername.Location = new System.Drawing.Point(22, 184);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "Enter your username";
            this.textBoxUsername.ReadOnly = false;
            this.textBoxUsername.Size = new System.Drawing.Size(286, 45);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlineedStyle = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTControls.CTButton buttonLogin;
        private CTControls.CTTextBox textBoxPassword;
        private CTControls.CTTextBox textBoxUsername;
        private System.Windows.Forms.Label labelForgotPassword;
        private System.Windows.Forms.Label labelLogin;
    }
}