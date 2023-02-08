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
using HotelManagement.BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing.Printing;
using Button = System.Windows.Forms.Button;
using HotelManagement.CTControls;

namespace HotelManagement.GUI
{
    public partial class FormHoaDon : Form
    {
        //Fields
        HoaDon HD;
        private int borderRadius = 10;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        private string money = null;
        //Constructor
        public FormHoaDon()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormHoaDon(HoaDon HD)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.HD = HD;
            InitializeComponent();
            LoadHD();
        }
        void LoadHD()
        {
            try
            {
                DichVu dichvu;
                CTDP cTDP = CTDP_BUS.Instance.GetCTDPs().Where(p => p.MaCTDP == HD.MaCTDP).Single();

                //decimal TongTienHD = 0;
                this.TextBoxSoHD.Text = HD.MaHD;
                this.TextBoxTenKH.Text = CTDP_BUS.Instance.GetCTDPs().Where(p => p.MaCTDP == HD.MaCTDP).Single().PhieuThue.KhachHang.TenKH;
                this.TextBoxMaPhong.Text = CTDP_BUS.Instance.GetCTDPs().Where(p => p.MaCTDP == HD.MaCTDP).Single().MaPH;
                this.TextBoxTenNV.Text = NhanVienBUS.Instance.GetNhanVien(HD.MaNV).TenNV;
                this.TextBoxNgayHD.Text = HD.NgHD.ToString();
                Phong phong = PhongBUS.Instance.FindePhong(TextBoxMaPhong.Text);
                LoaiPhong loaiphong = LoaiPhongBUS.Instance.getLoaiPhong(phong.MaLPH);
                this.TextBoxLoaiPhong.Text = loaiphong.TenLPH;
                List<CTDV> ctdvs = CTDV_BUS.Instance.FindCTDV(HD.MaCTDP);
                foreach (CTDV ctdv in ctdvs)
                {
                    dichvu = DichVuBUS.Instance.FindDichVu(ctdv.MaDV);
                    DataGridViewDichVu.Rows.Add(dichvu.TenDV, ctdv.DonGia.ToString("#,#"), ctdv.SL, ctdv.ThanhTien.ToString("#,#"));
                }
                decimal Tongtienphong = cTDP.ThanhTien;
                string time = null;
                if (cTDP.TheoGio == false)
                {
                    time  = CTDP_BUS.Instance.getKhoangTGTheoNgay(HD.MaCTDP).ToString();
                    if (int.Parse(time) == 0)
                        time = "1";
                    this.TextBoxSoNgay.Text =  time + " ngày";
                }
                else
                {
                    time = CTDP_BUS.Instance.getKhoangTGTheoGio(HD.MaCTDP).ToString();
                    this.TextBoxSoNgay.Text = CTDP_BUS.Instance.getKhoangTGTheoGio(HD.MaCTDP).ToString() + " giờ";
                }
                DataGridViewDichVu.Rows.Add(loaiphong.TenLPH, cTDP.DonGia.ToString("#,#"), int.Parse(time), Tongtienphong.ToString("#,#"));

                //this.LabelTongTien.Text += HD.TriGia.ToString("#,#");
                money = HD.TriGia.ToString("#,#");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*
            
            decimal Tongtienphong =  loaiphong.GiaNgay * days;
            DataGridViewDichVu.Rows.Add(loaiphong.TenLPH, loaiphong.GiaNgay.ToString("#,#"), days, Tongtienphong.ToString("#,#"));
            money = (TongTienHD + Tongtienphong).ToString("#,#");*/
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
            colors.TopLeftColor = Color.FromArgb(77, 77, 77);
            colors.TopRightColor = Color.FromArgb(77, 77, 77);
            colors.BottomLeftColor = Color.FromArgb(77, 77, 77);
            colors.BottomRightColor = Color.FromArgb(77, 77, 77);
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
        private void FormHoaDon_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            //var fbColors = GetFormBoundsColors();
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
        private void FormHoaDon_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormHoaDon_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormHoaDon_Activated(object sender, EventArgs e)
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

        private void ctClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DataGridView grid = DataGridViewDichVu;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            int row, offset, x, y, len;
            row = grid.Rows.Count;
            offset = 25 * row;
            x = 350; y = 0; len = money.Length;
            if (row < 6)
                y = 400 + offset;
            else
                y = 370 + offset;
            LabelTongTien.Text += money;
            LabelTongTien.Location = new Point(x - 10 * len, y);
        }

        private void DataGridViewDichVu_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Graphics g = e.Graphics;
            DataGridView grid = DataGridViewDichVu;
            int topX_left = 0, topY_left = 35, topX_right = 515, topY_right = 35;
            int row = grid.Rows.Count; // Last row Index
            int offset = 25 * row + 10;
            int botX_left = 0, botY_left = 35 + offset, botX_right = 515, botY_right = 35 + offset;
            using (var pen = new Pen(Color.FromArgb(198, 197, 195), 2))
            {
                g.DrawLine(pen, topX_left, topY_left, topX_right, topY_right);
                g.DrawLine(pen, botX_left, botY_left, botX_right, botY_right);
            }
        }

        #region In Hoa Don
        private Bitmap memoryImage;
        private Size s;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            s = this.ClientSize;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, -10, s);
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void HideButton()
        {
            Printer.Visible = false;
            ctMaximize1.Visible = false;
            ctMinimize1.Visible = false;
            ctClose1.Visible = false;
        }

        private void ShowButton()
        {
            Printer.Visible = true;
            ctMaximize1.Visible = true;
            ctMinimize1.Visible = true;
            ctClose1.Visible = true;
        }

        private void Printer_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    HideButton();
                    this.Refresh();

                    CaptureScreen();
                    printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("In hóa đơn", s.Width + 23, s.Height + 17);
                    printDocument.Print();

                    ShowButton();
                    printDialog.Dispose();
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Thông báo");
            }
            finally
            {
                ShowButton();
                printDialog.Dispose();
            }
        }
        #endregion
    }
}
