using HotelManagement.BUS;
using HotelManagement.CTControls;
using HotelManagement.DTO;
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

namespace HotelManagement.GUI
{
    public partial class FormThemDichVuVaoPhong : Form
    {
        private Image Del = Properties.Resources.delete1; // Image for Button Hủy
        private Image Add = Properties.Resources.Add; // Image for Button Thêm
        private List<DichVu> dichVus ;
        private List<CTDV> dichVusDaDat;
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        private DichVu dichVu;
        FormDanhSachDichVu formDanhSachDichVu;
        private CTDP ctdp;
        //Constructor
        public FormThemDichVuVaoPhong()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormThemDichVuVaoPhong(CTDP cTDP)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
          //  this.dichVu = dichVu;
            this.ctdp = cTDP;
           // this.formDanhSachDichVu = formDanhSachDichVu;
            InitializeComponent();
            LoadGridDaChon();
            LoadGridDichVu();
        }
        private void LoadLanDau()
        {
        }
        private void LoadGridDaChon()
        {
            dgvDVDaChon.Rows.Clear();
            HoaDon hoaDon = ctdp.HoaDons.Single();
            List<CTDV> ctdv = CTDV_BUS.Instance.FindCTDV(hoaDon.MaHD);

            foreach(CTDV v in ctdv)
            {
                DichVu dichVu = DichVuBUS.Instance.FindDichVu(v.MaDV);

                dgvDVDaChon.Rows.Add(dichVu.TenDV, v.SL, v.DonGia.ToString("#,#"), Del);
            }    
        }
        private void LoadGridDichVu()
        {
          this.dichVus = DichVuBUS.Instance.GetDichVus();
            gridDichVu.Rows.Clear();
            foreach(DichVu v in dichVus)
            {
                if(v.SLConLai==-1)
                {
                    gridDichVu.Rows.Add(v.TenDV, v.DonGia.ToString("#,#"), "", Add);

                }
                else
                gridDichVu.Rows.Add(v.TenDV, v.DonGia.ToString("#,#"), v.SLConLai, Add);
                dichVus.Add(dichVu);
            }    
        }
        
        //Control Box

        //Form Move
        #region Draw Form
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
        private FormBoundsColors GetSameDark()
        {
            FormBoundsColors colors = new FormBoundsColors();
            colors.TopLeftColor = Color.FromArgb(67, 73, 73);
            colors.TopRightColor = Color.FromArgb(67, 73, 73);
            colors.BottomLeftColor = Color.FromArgb(67, 73, 73);
            colors.BottomRightColor = Color.FromArgb(67, 73, 73);
            return colors;
        }
        //Event Methods
        private void FormThemDichVuVaoPhong_Paint(object sender, PaintEventArgs e)
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
        private void FormThemDichVuVaoPhong_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThemDichVuVaoPhong_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThemDichVuVaoPhong_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void PanelBackground_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PanelBackground_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(PanelBackground, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }
        #endregion
        private void CTButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0 && x == 3)
            {
                DichVu dichVu = DichVuBUS.Instance.FindDichVu(gridDichVu.Rows[y].Cells[1].Value.ToString());
                if (dichVu.SLConLai > 0)
                {
                    dichVu.SLConLai--;
                }
                else if (dichVu.SLConLai == 0)
                {
                    CTMessageBox.Show("Sản phẩm này đã hết ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
