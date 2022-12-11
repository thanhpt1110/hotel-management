namespace HotelManagement.CTControls
{
    partial class FormMessageBoxCanhBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBoxCanhBao));
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.ctMaximize1 = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize1 = new HotelManagement.CTControls.CTMinimize();
            this.ctClose1 = new HotelManagement.CTControls.CTClose();
            this.LabelCaption = new System.Windows.Forms.Label();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CTButtonOK = new HotelManagement.CTControls.CTButton();
            this.PanelTitleBar.SuspendLayout();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(163)))));
            this.PanelTitleBar.Controls.Add(this.ctMaximize1);
            this.PanelTitleBar.Controls.Add(this.ctMinimize1);
            this.PanelTitleBar.Controls.Add(this.ctClose1);
            this.PanelTitleBar.Controls.Add(this.LabelCaption);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(380, 35);
            this.PanelTitleBar.TabIndex = 1;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // ctMaximize1
            // 
            this.ctMaximize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMaximize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMaximize1.BackgroundImage")));
            this.ctMaximize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMaximize1.Location = new System.Drawing.Point(293, 8);
            this.ctMaximize1.Name = "ctMaximize1";
            this.ctMaximize1.Size = new System.Drawing.Size(15, 15);
            this.ctMaximize1.TabIndex = 7;
            // 
            // ctMinimize1
            // 
            this.ctMinimize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMinimize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMinimize1.BackgroundImage")));
            this.ctMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMinimize1.Location = new System.Drawing.Point(324, 8);
            this.ctMinimize1.Name = "ctMinimize1";
            this.ctMinimize1.Size = new System.Drawing.Size(15, 15);
            this.ctMinimize1.TabIndex = 6;
            // 
            // ctClose1
            // 
            this.ctClose1.BackColor = System.Drawing.Color.Transparent;
            this.ctClose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctClose1.BackgroundImage")));
            this.ctClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctClose1.Location = new System.Drawing.Point(353, 8);
            this.ctClose1.Name = "ctClose1";
            this.ctClose1.Size = new System.Drawing.Size(15, 15);
            this.ctClose1.TabIndex = 5;
            // 
            // LabelCaption
            // 
            this.LabelCaption.AutoSize = true;
            this.LabelCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCaption.ForeColor = System.Drawing.Color.White;
            this.LabelCaption.Location = new System.Drawing.Point(9, 8);
            this.LabelCaption.Name = "LabelCaption";
            this.LabelCaption.Size = new System.Drawing.Size(74, 20);
            this.LabelCaption.TabIndex = 4;
            this.LabelCaption.Text = "Cảnh báo";
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(163)))));
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Controls.Add(this.panel2);
            this.PanelBackground.Controls.Add(this.PanelTitleBar);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(380, 150);
            this.PanelBackground.TabIndex = 5;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LabelMessage);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 67);
            this.panel1.TabIndex = 0;
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.BackColor = System.Drawing.SystemColors.Control;
            this.LabelMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.ForeColor = System.Drawing.Color.Black;
            this.LabelMessage.Location = new System.Drawing.Point(105, 26);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(169, 20);
            this.LabelMessage.TabIndex = 6;
            this.LabelMessage.Text = "Đừng có phá nữa má oi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(51, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.CTButtonOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 48);
            this.panel2.TabIndex = 2;
            // 
            // CTButtonOK
            // 
            this.CTButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.CTButtonOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.CTButtonOK.BorderColor = System.Drawing.SystemColors.Control;
            this.CTButtonOK.BorderRadius = 10;
            this.CTButtonOK.BorderSize = 0;
            this.CTButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonOK.FlatAppearance.BorderSize = 0;
            this.CTButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonOK.ForeColor = System.Drawing.Color.White;
            this.CTButtonOK.Location = new System.Drawing.Point(140, 6);
            this.CTButtonOK.Name = "CTButtonOK";
            this.CTButtonOK.Size = new System.Drawing.Size(100, 35);
            this.CTButtonOK.TabIndex = 0;
            this.CTButtonOK.Text = "Pít gùi";
            this.CTButtonOK.TextColor = System.Drawing.Color.White;
            this.CTButtonOK.UseVisualStyleBackColor = false;
            this.CTButtonOK.Click += new System.EventHandler(this.CTButtonOK_Click);
            // 
            // FormMessageBoxCanhBao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(380, 150);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMessageBoxCanhBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMessageBoxCanhBao";
            this.Activated += new System.EventHandler(this.FormMessageBoxCanhBao_Activated);
            this.SizeChanged += new System.EventHandler(this.FormMessageBoxCanhBao_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMessageBoxCanhBao_Paint);
            this.Resize += new System.EventHandler(this.FormMessageBoxCanhBao_Resize);
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            this.PanelBackground.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitleBar;
        private CTMaximize ctMaximize1;
        private CTMinimize ctMinimize1;
        private CTClose ctClose1;
        private System.Windows.Forms.Label LabelCaption;
        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Panel panel2;
        private CTButton CTButtonOK;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}