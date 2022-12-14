namespace HotelManagement.GUI
{
    partial class FormDatLaiMatKhau
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
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.ButtonOK = new HotelManagement.CTControls.CTButton();
            this.textBoxPassConfirm = new HotelManagement.CTControls.CTTextBox();
            this.textBoxPassword = new HotelManagement.CTControls.CTTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelForgotPassword
            // 
            this.LabelForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelForgotPassword.AutoSize = true;
            this.LabelForgotPassword.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(119)))), ((int)(((byte)(34)))));
            this.LabelForgotPassword.Location = new System.Drawing.Point(13, 45);
            this.LabelForgotPassword.Name = "LabelForgotPassword";
            this.LabelForgotPassword.Size = new System.Drawing.Size(295, 59);
            this.LabelForgotPassword.TabIndex = 11;
            this.LabelForgotPassword.Text = "Forgot password";
            // 
            // PictureBoxBack
            // 
            this.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBack.Image = global::HotelManagement.Properties.Resources.back;
            this.PictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBack.Name = "PictureBoxBack";
            this.PictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBack.TabIndex = 15;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ButtonOK.BorderColor = System.Drawing.Color.White;
            this.ButtonOK.BorderRadius = 15;
            this.ButtonOK.BorderSize = 0;
            this.ButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOK.ForeColor = System.Drawing.Color.White;
            this.ButtonOK.Location = new System.Drawing.Point(110, 360);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(94, 47);
            this.ButtonOK.TabIndex = 14;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.TextColor = System.Drawing.Color.White;
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // textBoxPassConfirm
            // 
            this.textBoxPassConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxPassConfirm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxPassConfirm.BorderRadius = 20;
            this.textBoxPassConfirm.BorderSize = 1;
            this.textBoxPassConfirm.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.textBoxPassConfirm.IsFocused = false;
            this.textBoxPassConfirm.Location = new System.Drawing.Point(20, 240);
            this.textBoxPassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassConfirm.Multiline = false;
            this.textBoxPassConfirm.Name = "textBoxPassConfirm";
            this.textBoxPassConfirm.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxPassConfirm.PasswordChar = false;
            this.textBoxPassConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassConfirm.PlaceholderText = "Xác nhận lại mật khẩu";
            this.textBoxPassConfirm.ReadOnly = false;
            this.textBoxPassConfirm.Size = new System.Drawing.Size(286, 45);
            this.textBoxPassConfirm.TabIndex = 12;
            this.textBoxPassConfirm.Texts = "";
            this.textBoxPassConfirm.UnderlineedStyle = false;
            this.textBoxPassConfirm._TextChanged += new System.EventHandler(this.textBoxPassConfirm__TextChanged);
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
            this.textBoxPassword.Location = new System.Drawing.Point(20, 165);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxPassword.PasswordChar = false;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "Mật khẩu mới";
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.Size = new System.Drawing.Size(286, 45);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlineedStyle = false;
            this.textBoxPassword._TextChanged += new System.EventHandler(this.textBoxPassword__TextChanged);
            // 
            // FormDatLaiMatKhau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.textBoxPassConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.LabelForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatLaiMatKhau";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormDatLaiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTControls.CTButton ButtonOK;
        private CTControls.CTTextBox textBoxPassword;
        private System.Windows.Forms.Label LabelForgotPassword;
        private CTControls.CTTextBox textBoxPassConfirm;
        private System.Windows.Forms.PictureBox PictureBoxBack;
    }
}