namespace HotelManagement.CTControls
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button3 = new HotelManagement.CTControls.CTButton();
            this.button2 = new HotelManagement.CTControls.CTButton();
            this.button1 = new HotelManagement.CTControls.CTButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.ctMinimize1 = new HotelManagement.CTControls.CTMinimize();
            this.ctMaximize1 = new HotelManagement.CTControls.CTMaximize();
            this.btnClose = new HotelManagement.CTControls.CTClose();
            this.labelCaption = new System.Windows.Forms.Label();
            this.PanelBackground.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(163)))));
            this.PanelBackground.Controls.Add(this.panelBody);
            this.PanelBackground.Controls.Add(this.panelButtons);
            this.PanelBackground.Controls.Add(this.panelTitleBar);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(380, 150);
            this.PanelBackground.TabIndex = 6;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.Control;
            this.panelBody.Controls.Add(this.labelMessage);
            this.panelBody.Controls.Add(this.pictureBoxIcon);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 35);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(10, 10, 20, 17);
            this.panelBody.Size = new System.Drawing.Size(380, 67);
            this.panelBody.TabIndex = 0;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.SystemColors.Control;
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Black;
            this.labelMessage.Location = new System.Drawing.Point(50, 10);
            this.labelMessage.MinimumSize = new System.Drawing.Size(305, 56);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Padding = new System.Windows.Forms.Padding(5, 5, 10, 15);
            this.labelMessage.Size = new System.Drawing.Size(305, 56);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "UIT là truog dh top 1 mien nam";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = global::HotelManagement.Properties.Resources.selection;
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxIcon.MaximumSize = new System.Drawing.Size(40, 40);
            this.pictureBoxIcon.MinimumSize = new System.Drawing.Size(40, 40);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.Control;
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 102);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(380, 48);
            this.panelButtons.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.button3.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.BorderRadius = 10;
            this.button3.BorderSize = 0;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(266, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 0;
            this.button3.Text = "Hủy";
            this.button3.TextColor = System.Drawing.Color.White;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(87)))), ((int)(((byte)(83)))));
            this.button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(87)))), ((int)(((byte)(83)))));
            this.button2.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.BorderRadius = 10;
            this.button2.BorderSize = 0;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(139, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "Không";
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(141)))), ((int)(((byte)(44)))));
            this.button1.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.BorderRadius = 10;
            this.button1.BorderSize = 0;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Có";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(131)))), ((int)(((byte)(163)))));
            this.panelTitleBar.Controls.Add(this.panelControlBox);
            this.panelTitleBar.Controls.Add(this.labelCaption);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(380, 35);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // panelControlBox
            // 
            this.panelControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlBox.Controls.Add(this.ctMinimize1);
            this.panelControlBox.Controls.Add(this.ctMaximize1);
            this.panelControlBox.Controls.Add(this.btnClose);
            this.panelControlBox.Location = new System.Drawing.Point(284, 4);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(95, 23);
            this.panelControlBox.TabIndex = 8;
            // 
            // ctMinimize1
            // 
            this.ctMinimize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMinimize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMinimize1.BackgroundImage")));
            this.ctMinimize1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctMinimize1.Enabled = false;
            this.ctMinimize1.Location = new System.Drawing.Point(38, 4);
            this.ctMinimize1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctMinimize1.Name = "ctMinimize1";
            this.ctMinimize1.Size = new System.Drawing.Size(15, 15);
            this.ctMinimize1.TabIndex = 8;
            // 
            // ctMaximize1
            // 
            this.ctMaximize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMaximize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMaximize1.BackgroundImage")));
            this.ctMaximize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMaximize1.Enabled = false;
            this.ctMaximize1.Location = new System.Drawing.Point(9, 4);
            this.ctMaximize1.Name = "ctMaximize1";
            this.ctMaximize1.Size = new System.Drawing.Size(15, 15);
            this.ctMaximize1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(70, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.ctClose1_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.ForeColor = System.Drawing.Color.White;
            this.labelCaption.Location = new System.Drawing.Point(9, 8);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(137, 20);
            this.labelCaption.TabIndex = 4;
            this.labelCaption.Text = "Chọn đi bạn chẻ ơi";
            // 
            // FormMessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(380, 150);
            this.Controls.Add(this.PanelBackground);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(380, 150);
            this.Name = "FormMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormMessageBox";
            this.Activated += new System.EventHandler(this.FormMessageBox_Activated);
            this.SizeChanged += new System.EventHandler(this.FormMessageBox_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMessageBox_Paint);
            this.Resize += new System.EventHandler(this.FormMessageBox_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelButtons;
        private CTButton button3;
        private CTButton button2;
        private CTButton button1;
        private System.Windows.Forms.Panel panelTitleBar;
        private CTMaximize ctMaximize1;
        private CTClose btnClose;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Panel panelControlBox;
        private CTMinimize ctMinimize1;
    }
}