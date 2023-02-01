using HotelManagement.DTO;
using System;
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
// static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HotelManagement.GUI;
namespace HotelManagement.CTControls
{
    public partial class CTRoomTrong : CTRoom
    {
        //Methods Set Value
        Phong phong = new Phong();
        FormSoDoPhong formSoDoPhong;
        FormMain formMain;
        TaiKhoan taiKhoan;
        public override string getMaPhong()
        {
            return this.LabelMaPhong.Text;
        }
        public override void setLoaiPhong(string LoaiPhong)
        {
            this.LabelLoaiPhong.Text = LoaiPhong;
        }
        public override void setMaPhong(string maPhong)
        {
            this.LabelMaPhong.Text = maPhong;
        }
        public override void setTrangThai(string trangThai)
        {
            this.LabelLoaiPhong.Text = trangThai;
            this.LabelTrangThaiLon.Text = trangThai;
        }
        public override void setThoiGianNone()
        {
            LabelThoiGian.Text = "";
        }
        public override void setThoiGian(string thoiGian)
        {
            this.LabelThoiGian.Text = thoiGian;
        }
        public override void setPhongTrong()
        {
            setThoiGianNone();
            setTrangThai("Phòng trống");
            PictureBoxTrangThai.Image = Properties.Resources.Trong;
        }
        public override void setChuaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.ChuaDonDep;
            LabelTrangThaiDonDep.Text = "Chưa dọn dẹp";
        }
        public override void setDaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.DaDonDep;
            LabelTrangThaiDonDep.Text = "Đã dọn dẹp";
        }
        public override void setGhiChu(string ghiChu)
        {
        }
        //Fields
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.FromArgb(113, 201, 103);

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
        private Form activeForm = null;
        /*public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelTransparent.Controls.Add(childForm);
            PanelTransparent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/
        private bool touchMouse = false;
        public CTRoomTrong()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(113, 201, 103);
            this.ForeColor = Color.White;
            InitializeComponent();
        }
        public CTRoomTrong(Phong phong, FormSoDoPhong soDoPhong, FormMain formMain, TaiKhoan taiKhoan)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(113, 201, 103);
            this.ForeColor = Color.White;
            this.phong = phong;
            InitializeComponent();
            this.formSoDoPhong = soDoPhong;
            this.formMain = formMain;
            this.LoaiPhong = "PhongTrong";
            this.MaPhong = phong.MaPH;
            this.taiKhoan = taiKhoan;
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
            LabelMaPhong.BackColor = PanelTop.BackColor;
            LabelTrangThaiLon.BackColor = PanelTop.BackColor;
            PictureBoxTrangThai.BackColor = PanelTop.BackColor;
            LabelLoaiPhong.BackColor = PanelTop.BackColor;
            LabelTrangThaiDonDep.BackColor = this.BackColor;
            LabelThoiGian.BackColor = this.BackColor;
            PictureBoxThoiGian.BackColor = this.BackColor;
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

        private void CTRoomPhongTrong_Load(object sender, EventArgs e)
        {
            this.Invalidate();
            
        }


        private void CTRoomPhongTrong_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThongTinPhong formThongTinPhong = new FormThongTinPhong(formMain, this.LabelTrangThaiLon.Text, null, phong,taiKhoan))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThongTinPhong.Owner = formBackground;
                    formThongTinPhong.ShowDialog();
                    this.formSoDoPhong.LoadLanDau();
                    formBackground.Dispose();
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { formBackground.Dispose(); }
        }

        private void CTRoomTrong_MouseMove(object sender, MouseEventArgs e)
        {
            touchMouse = true;
            this.Invalidate();
        }
    }
}
