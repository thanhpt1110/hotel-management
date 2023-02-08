using System.Windows.Forms;

namespace HotelManagement.CTControls
{
    partial class CTRoomDangThue
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
        public class DoubleBufferPanel : Panel

        {

            public DoubleBufferPanel()

            {

                // Set the value of the double-buffering style bits to true.

                this.DoubleBuffered = true;

                this.SetStyle(ControlStyles.AllPaintingInWmPaint |

                ControlStyles.UserPaint |

                ControlStyles.OptimizedDoubleBuffer, true);

                UpdateStyles();

            }

        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelTop = new HotelManagement.CTControls.CTRoomDangThue.DoubleBufferPanel();
            this.PictureBoxTrangThai = new System.Windows.Forms.PictureBox();
            this.LabelTrangThaiLon = new System.Windows.Forms.Label();
            this.LabelLoaiPhong = new System.Windows.Forms.Label();
            this.LabelMaPhong = new System.Windows.Forms.Label();
            this.PictureBoxThoiGian = new System.Windows.Forms.PictureBox();
            this.LabelThoiGian = new System.Windows.Forms.Label();
            this.LabelTrangThaiDonDep = new System.Windows.Forms.Label();
            this.PictureBoxTrangThaiDonDep = new System.Windows.Forms.PictureBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxThoiGian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrangThaiDonDep)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.PanelTop.Controls.Add(this.PictureBoxTrangThai);
            this.PanelTop.Controls.Add(this.LabelTrangThaiLon);
            this.PanelTop.Controls.Add(this.LabelLoaiPhong);
            this.PanelTop.Controls.Add(this.LabelMaPhong);
            this.PanelTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTop.Location = new System.Drawing.Point(2, 1);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(277, 123);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.PanelTop.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // PictureBoxTrangThai
            // 
            this.PictureBoxTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.PictureBoxTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxTrangThai.Image = global::HotelManagement.Properties.Resources.DangThue;
            this.PictureBoxTrangThai.Location = new System.Drawing.Point(25, 63);
            this.PictureBoxTrangThai.Name = "PictureBoxTrangThai";
            this.PictureBoxTrangThai.Size = new System.Drawing.Size(50, 50);
            this.PictureBoxTrangThai.TabIndex = 8;
            this.PictureBoxTrangThai.TabStop = false;
            this.PictureBoxTrangThai.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.PictureBoxTrangThai.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.PictureBoxTrangThai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // LabelTrangThaiLon
            // 
            this.LabelTrangThaiLon.AutoSize = true;
            this.LabelTrangThaiLon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.LabelTrangThaiLon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTrangThaiLon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrangThaiLon.ForeColor = System.Drawing.Color.White;
            this.LabelTrangThaiLon.Location = new System.Drawing.Point(123, 47);
            this.LabelTrangThaiLon.Name = "LabelTrangThaiLon";
            this.LabelTrangThaiLon.Size = new System.Drawing.Size(130, 64);
            this.LabelTrangThaiLon.TabIndex = 7;
            this.LabelTrangThaiLon.Text = "   Phòng\r\nđang thuê";
            this.LabelTrangThaiLon.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.LabelTrangThaiLon.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.LabelTrangThaiLon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // LabelLoaiPhong
            // 
            this.LabelLoaiPhong.AutoSize = true;
            this.LabelLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.LabelLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelLoaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.LabelLoaiPhong.Location = new System.Drawing.Point(177, 13);
            this.LabelLoaiPhong.Name = "LabelLoaiPhong";
            this.LabelLoaiPhong.Size = new System.Drawing.Size(76, 17);
            this.LabelLoaiPhong.TabIndex = 6;
            this.LabelLoaiPhong.Text = "Loại phòng";
            this.LabelLoaiPhong.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.LabelLoaiPhong.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.LabelLoaiPhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // LabelMaPhong
            // 
            this.LabelMaPhong.AutoSize = true;
            this.LabelMaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(107)))), ((int)(((byte)(104)))));
            this.LabelMaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelMaPhong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaPhong.ForeColor = System.Drawing.Color.White;
            this.LabelMaPhong.Location = new System.Drawing.Point(17, 14);
            this.LabelMaPhong.Name = "LabelMaPhong";
            this.LabelMaPhong.Size = new System.Drawing.Size(57, 25);
            this.LabelMaPhong.TabIndex = 5;
            this.LabelMaPhong.Text = "P100";
            this.LabelMaPhong.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.LabelMaPhong.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.LabelMaPhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // PictureBoxThoiGian
            // 
            this.PictureBoxThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.PictureBoxThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxThoiGian.Image = global::HotelManagement.Properties.Resources.clock;
            this.PictureBoxThoiGian.Location = new System.Drawing.Point(28, 130);
            this.PictureBoxThoiGian.Name = "PictureBoxThoiGian";
            this.PictureBoxThoiGian.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxThoiGian.TabIndex = 8;
            this.PictureBoxThoiGian.TabStop = false;
            this.PictureBoxThoiGian.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.PictureBoxThoiGian.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.PictureBoxThoiGian.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // LabelThoiGian
            // 
            this.LabelThoiGian.AutoSize = true;
            this.LabelThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.LabelThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelThoiGian.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThoiGian.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LabelThoiGian.Location = new System.Drawing.Point(50, 132);
            this.LabelThoiGian.Name = "LabelThoiGian";
            this.LabelThoiGian.Size = new System.Drawing.Size(38, 17);
            this.LabelThoiGian.TabIndex = 13;
            this.LabelThoiGian.Text = "0 giờ";
            this.LabelThoiGian.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.LabelThoiGian.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.LabelThoiGian.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // LabelTrangThaiDonDep
            // 
            this.LabelTrangThaiDonDep.AutoSize = true;
            this.LabelTrangThaiDonDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.LabelTrangThaiDonDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTrangThaiDonDep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrangThaiDonDep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LabelTrangThaiDonDep.Location = new System.Drawing.Point(179, 132);
            this.LabelTrangThaiDonDep.Name = "LabelTrangThaiDonDep";
            this.LabelTrangThaiDonDep.Size = new System.Drawing.Size(79, 17);
            this.LabelTrangThaiDonDep.TabIndex = 16;
            this.LabelTrangThaiDonDep.Text = "Đã dọn dẹp";
            this.LabelTrangThaiDonDep.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.LabelTrangThaiDonDep.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.LabelTrangThaiDonDep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // PictureBoxTrangThaiDonDep
            // 
            this.PictureBoxTrangThaiDonDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.PictureBoxTrangThaiDonDep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxTrangThaiDonDep.Image = global::HotelManagement.Properties.Resources.DaDonDep;
            this.PictureBoxTrangThaiDonDep.Location = new System.Drawing.Point(155, 131);
            this.PictureBoxTrangThaiDonDep.Name = "PictureBoxTrangThaiDonDep";
            this.PictureBoxTrangThaiDonDep.Size = new System.Drawing.Size(20, 20);
            this.PictureBoxTrangThaiDonDep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxTrangThaiDonDep.TabIndex = 15;
            this.PictureBoxTrangThaiDonDep.TabStop = false;
            this.PictureBoxTrangThaiDonDep.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.PictureBoxTrangThaiDonDep.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.PictureBoxTrangThaiDonDep.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            // 
            // CTRoomDangThue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(222)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.LabelTrangThaiDonDep);
            this.Controls.Add(this.PictureBoxTrangThaiDonDep);
            this.Controls.Add(this.LabelThoiGian);
            this.Controls.Add(this.PictureBoxThoiGian);
            this.Controls.Add(this.PanelTop);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(15, 20, 0, 0);
            this.Name = "CTRoomDangThue";
            this.Size = new System.Drawing.Size(280, 155);
            this.Load += new System.EventHandler(this.CTRoomPhongDangThue_Load);
            this.VisibleChanged += new System.EventHandler(this.CTRoomPhongDangThue_VisibleChanged);
            this.Click += new System.EventHandler(this.CTRoomDangThue_Click);
            this.MouseLeave += new System.EventHandler(this.CTRoomDangThue_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CTRoomDangThue_MouseMove);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxThoiGian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrangThaiDonDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelMaPhong;
        private System.Windows.Forms.Label LabelLoaiPhong;
        private System.Windows.Forms.Label LabelTrangThaiLon;
        private System.Windows.Forms.PictureBox PictureBoxTrangThai;
        private System.Windows.Forms.PictureBox PictureBoxThoiGian;
        private System.Windows.Forms.Label LabelThoiGian;
        private System.Windows.Forms.Label LabelTrangThaiDonDep;
        private System.Windows.Forms.PictureBox PictureBoxTrangThaiDonDep;
        private DoubleBufferPanel PanelTop;
    }
}
