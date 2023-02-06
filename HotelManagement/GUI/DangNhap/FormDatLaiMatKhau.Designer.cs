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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatLaiMatKhau));
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.ButtonOK = new HotelManagement.CTControls.CTButton();
            this.textBoxPassConfirm = new HotelManagement.CTControls.CTTextBox();
            this.textBoxPassword = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctEyePassword1 = new HotelManagement.CTControls.CTEyePassword();
            this.ctEyePassword2 = new HotelManagement.CTControls.CTEyePassword();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.ButtonOK.Location = new System.Drawing.Point(118, 356);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(94, 47);
            this.ButtonOK.TabIndex = 3;
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
            this.textBoxPassConfirm.Location = new System.Drawing.Point(23, 252);
            this.textBoxPassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassConfirm.Multiline = false;
            this.textBoxPassConfirm.Name = "textBoxPassConfirm";
            this.textBoxPassConfirm.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxPassConfirm.PasswordChar = false;
            this.textBoxPassConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassConfirm.PlaceholderText = "Xác nhận lại mật khẩu";
            this.textBoxPassConfirm.ReadOnly = false;
            this.textBoxPassConfirm.Size = new System.Drawing.Size(286, 45);
            this.textBoxPassConfirm.TabIndex = 2;
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
            this.textBoxPassword.Location = new System.Drawing.Point(23, 177);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxPassword.PasswordChar = false;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "Mật khẩu mới";
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.Size = new System.Drawing.Size(286, 45);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlineedStyle = false;
            this.textBoxPassword._TextChanged += new System.EventHandler(this.textBoxPassword__TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.QuenMatKhau;
            this.pictureBox1.Location = new System.Drawing.Point(20, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ctEyePassword1
            // 
            this.ctEyePassword1.BackColor = System.Drawing.Color.Transparent;
            this.ctEyePassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctEyePassword1.BackgroundImage")));
            this.ctEyePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctEyePassword1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctEyePassword1.IsShow = false;
            this.ctEyePassword1.Location = new System.Drawing.Point(266, 186);
            this.ctEyePassword1.Name = "ctEyePassword1";
            this.ctEyePassword1.Size = new System.Drawing.Size(30, 26);
            this.ctEyePassword1.TabIndex = 17;
            this.ctEyePassword1.Click += new System.EventHandler(this.ctEyePassword1_Click);
            // 
            // ctEyePassword2
            // 
            this.ctEyePassword2.BackColor = System.Drawing.Color.Transparent;
            this.ctEyePassword2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctEyePassword2.BackgroundImage")));
            this.ctEyePassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctEyePassword2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctEyePassword2.IsShow = false;
            this.ctEyePassword2.Location = new System.Drawing.Point(266, 263);
            this.ctEyePassword2.Name = "ctEyePassword2";
            this.ctEyePassword2.Size = new System.Drawing.Size(30, 26);
            this.ctEyePassword2.TabIndex = 18;
            this.ctEyePassword2.Click += new System.EventHandler(this.ctEyePassword2_Click);
            // 
            // FormDatLaiMatKhau
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 466);
            this.Controls.Add(this.ctEyePassword2);
            this.Controls.Add(this.ctEyePassword1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.textBoxPassConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatLaiMatKhau";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormDatLaiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTControls.CTButton ButtonOK;
        private CTControls.CTTextBox textBoxPassword;
        private CTControls.CTTextBox textBoxPassConfirm;
        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTEyePassword ctEyePassword1;
        private CTControls.CTEyePassword ctEyePassword2;
    }
}