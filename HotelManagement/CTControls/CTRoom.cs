﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement.CTControls
{
    public partial class CTRoom : UserControl
    {
        //Methods Set Value
        public void setMaPhong(string maPhong)
        {
            this.LabelMaPhong.Text = maPhong;
        }
        public void setTrangThai(string trangThai)
        {
            this.LabelTrangThaiNho.Text = trangThai;
            this.LabelTrangThaiLon.Text = trangThai;
        }
        public void setThoiGianNone()
        {
            LabelThoiGian.Text = "";
        }
        public void setThoiGian(string thoiGian)
        {
            this.LabelThoiGian.Text = thoiGian;
        }
        public void setPhongTrong()
        {
            setThoiGianNone();
            setTrangThai("Phòng trống");
            pictureBoxTrangThai.Image = Properties.Resources.tick;
        }
        public void setChuaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.x;
            LabelTrangThaiDonDep.Text = "Chưa dọn dẹp";
        }
        public void setDaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.tickBlack;
            LabelTrangThaiDonDep.Text = "Đã dọn dẹp";
        }
        public void setDangSuaChua()
        {
            setThoiGianNone();
            setTrangThai("Đang sửa chữa");
            pictureBoxTrangThai.Image= Properties.Resources.fix50;
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.fix;
            LabelTrangThaiDonDep.Text = "Đang sửa chữa";
        }
        //Fields
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.FromArgb(230, 222, 224);

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        //Constructor
        public CTRoom()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(230, 222, 224);
            this.ForeColor = Color.White;
            InitializeComponent();
        }

        //Methods
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

        }



        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            //this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        //Private methods




        //Touch Color Change
        private void setChildColorAsParent()
        {
            LabelMaPhong.BackColor = panelTop.BackColor;
            LabelTrangThaiLon.BackColor = panelTop.BackColor;
            pictureBoxTrangThai.BackColor = panelTop.BackColor;
            LabelTrangThaiNho.BackColor = panelTop.BackColor;
            LabelTrangThaiDonDep.BackColor = this.BackColor;
            LabelThoiGian.BackColor = this.BackColor;
            pictureBoxThoiGian.BackColor = this.BackColor;
            PictureBoxTrangThaiDonDep.BackColor = this.BackColor;
        }
        private void normal(object sender, EventArgs e)
        {

        }
        private void touch(object sender, EventArgs e)
        {

        }

        private void touch(object sender, MouseEventArgs e)
        {

        }

        private void CTRoom_VisibleChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void CTRoom_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void CTRoom_Click(object sender, EventArgs e)
        {

        }
    }
}