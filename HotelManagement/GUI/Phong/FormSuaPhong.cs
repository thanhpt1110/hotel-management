using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DTO;
using HotelManagement.BUS;
using HotelManagement.CTControls;

namespace HotelManagement.GUI
{
    public partial class FormSuaPhong : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        Phong phong;
        //Constructor
        public FormSuaPhong()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormSuaPhong(Phong phong)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.phong = phong;
            InitializeComponent();
            LoadForm();
        }
        //Control Box

        //Form Move

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        //Private Methods
        //Private Methods

        private void LoadForm()
        {
            if(phong.GhiChu!="")
            {
                this.ctTextBoxGhiChu.RemovePlaceholder();
            }    
            this.comboBoxDonDep.Texts = phong.TTDD;
            this.comboBoxLoaiPhong.Texts = phong.LoaiPhong.TenLPH;
            this.comboBoxTinhTrangPhong.Texts = phong.TTPH;
            this.ctTextBoxGhiChu.Texts = phong.GhiChu;
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
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
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetSameDark()
        {
            FormBoundsColors colors = new FormBoundsColors();
            colors.TopLeftColor = Color.FromArgb(67, 73, 73);
            colors.TopRightColor = Color.FromArgb(67, 73, 73);
            colors.BottomLeftColor = Color.FromArgb(67, 73, 73);
            colors.BottomRightColor = Color.FromArgb(67, 73, 73);
            return colors;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        //Event Methods
        private void FormSuaPhong_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetSameDark();
            //Top Left
            DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor);
            //Top Right
            Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Bottom Left
            Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Bottom Right
            Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
            //-> SET ROUNDED REGION AND BORDER
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        private void FormSuaPhong_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaPhong_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaPhong_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PanelBackground_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ControlRegionAndBorder(PanelBackground, borderRadius - (borderSize / 2), g, borderColor);
        }

        private void PanelBackground_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CTButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            string TinhTrang = comboBoxTinhTrangPhong.Texts; 
            string DonDep = comboBoxDonDep.Texts;
            string LoaiPhong = comboBoxLoaiPhong.Texts;
            string GhiChu = ctTextBoxGhiChu.Texts;
            if (TinhTrang == "Tình trạng phòng" || DonDep == "Tình trạng dọn dẹp" || LoaiPhong == "Loại phòng" || GhiChu == "")
            {
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                phong.TTDD = DonDep;
                phong.GhiChu = GhiChu;
                if (LoaiPhong == "Thường đơn")
                    phong.MaLPH = "NOR01";
                else if (LoaiPhong == "Thường đôi")
                    phong.MaLPH = "NOR02";
                else if (LoaiPhong == "Vip đơn")
                    phong.MaLPH = "VIP01";
                else
                    phong.MaLPH = "VIP02";
                phong.TTPH = TinhTrang;
                PhongBUS.Instance.UpdateOrAdd(phong);

                CTMessageBox.Show("Cập nhật thông tin thành công.", "Thông báo",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
            }
        }

        private void FormSuaPhong_Load(object sender, EventArgs e)
        {
            this.ActiveControl = LabelSuaPhong;
        }
    }
}
