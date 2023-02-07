using HotelManagement.BUS;
using HotelManagement.CTControls;
using HotelManagement.DAO;
using HotelManagement.DTO;
using HotelManagement.GUI.SoDoPhong;
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
    public partial class FormThongTinPhong : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        private CTDP ctdp;
        private Phong phong;
        private TaiKhoan taiKhoan;
        private string TTPhong = "";
        private FormMain formMain;
        //Constructor
        public FormThongTinPhong()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormThongTinPhong(FormMain formMain, string Case, CTDP cTDP = null, Phong phong = null,TaiKhoan taiKhoan = null)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.ctdp = cTDP;
            this.TTPhong = Case;
            this.phong = phong; 
            this.taiKhoan = taiKhoan;
            this.formMain = formMain;
            InitializeComponent();
            LoadPage();
            this.CTButtonCoc.Hide();
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
        private void FormThongTinPhong_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetFormBoundsColors();
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
        private void FormThongTinPhong_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThongTinPhong_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormThongTinPhong_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void PanelBackground_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(PanelBackground, borderRadius - (borderSize / 2), e.Graphics, borderColor);
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
        #region Display room 
        private void LoadPhongDaDat()
        {
            try
            {
                gridDichVu.Rows.Clear();
                this.LabelMaPhong.Text = ctdp.MaPH;
                this.LabelTen.Text = this.ctdp.PhieuThue.KhachHang.TenKH;
                this.LabelNgayCheckin.Text = ctdp.CheckIn.ToString("dd/MM/yyyy");
                if(ctdp.TheoGio==false)
                    this.LabelThoiGianThue.Text = CTDP_BUS.Instance.getKhoangTGTheoNgay(ctdp.MaCTDP).ToString() + " ngày";
                else
                    this.LabelThoiGianThue.Text = CTDP_BUS.Instance.getKhoangTGTheoGio(ctdp.MaCTDP).ToString() + " giờ";
                this.LabelSoNguoi.Text = ctdp.SoNguoi.ToString();
                this.ComboBoxTinhTrangPhong.Text = "Phòng đã đặt";
                this.ComboBoxTinhTrangDonDep.Text = PhongBUS.Instance.FindePhong(ctdp.MaPH).TTDD;
                this.TextBoxGhiChu.Text = PhongBUS.Instance.FindePhong(ctdp.MaPH).GhiChu;
                this.PanelChuaButtonThemDichVu.Hide();
                this.PanelChuaButtonDatPhongNay.Hide();
                this.PanelChuaButtonThanhToan.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPhongDangThue()
        {
            try
            {
                this.LabelMaPhong.Text = ctdp.MaPH;
                this.LabelTen.Text = this.ctdp.PhieuThue.KhachHang.TenKH;
                this.LabelNgayCheckin.Text = ctdp.CheckIn.ToString("dd/MM/yyyy");
                if (ctdp.TheoGio == false)
                    this.LabelThoiGianThue.Text = CTDP_BUS.Instance.getKhoangTGTheoNgay(ctdp.MaCTDP).ToString() + " ngày";
                else
                    this.LabelThoiGianThue.Text = CTDP_BUS.Instance.getKhoangTGTheoGio(ctdp.MaCTDP).ToString() + " giờ";
                this.LabelSoNguoi.Text = ctdp.SoNguoi.ToString();
                this.ComboBoxTinhTrangDonDep.Text = PhongBUS.Instance.FindePhong(ctdp.MaPH).TTDD;
                this.TextBoxGhiChu.Text = PhongBUS.Instance.FindePhong(ctdp.MaPH).GhiChu;
                this.ComboBoxTinhTrangPhong.Text = "Phòng đang thuê";
                this.PanelChuaButtonDatPhongNay.Hide();
                this.PanelChuaButtonNhanPhong.Hide();
                List<CTDV> cTDVs = CTDV_BUS.Instance.FindCTDV(ctdp.MaCTDP);
                gridDichVu.Rows.Clear();
                if (cTDVs.Count > 0)
                {
                    foreach (CTDV v in cTDVs)
                    {
                        if (v.SL != 0)
                            gridDichVu.Rows.Add(DichVuBUS.Instance.FindDichVu(v.MaDV).TenDV, v.SL, v.ThanhTien.ToString("#,#"));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPhongDangSua()
        { 
            gridDichVu.Rows.Clear();
            this.LabelMaPhong.Text = phong.MaPH;
            this.LabelTen.Text = "";
            this.LabelNgayCheckin.Text = "";
            this.LabelThoiGianThue.Text = "";
            this.LabelSoNguoi.Text = "";
            this.ComboBoxTinhTrangDonDep.Text = phong.TTDD;
            this.TextBoxGhiChu.Text = phong.GhiChu;
            this.ComboBoxTinhTrangPhong.Text = "Đang sửa chữa";
            this.ComboBoxTinhTrangPhong.Items.Add("Đang sửa chữa");
            this.ComboBoxTinhTrangPhong.Items.Add("Phòng trống");
            this.PanelChuaButtonThemDichVu.Hide();
            this.PanelChuaButtonDatPhongNay.Hide();
            this.PanelChuaButtonThanhToan.Hide();
            this.PanelChuaButtonNhanPhong.Hide();
            this.PanelChuaButtonCoc.Hide();
        }

        private void LoadPhongTrong()
        {
            gridDichVu.Rows.Clear();
            this.LabelMaPhong.Text = phong.MaPH;
            this.LabelTen.Text = "";
            this.LabelNgayCheckin.Text = "";
            this.LabelThoiGianThue.Text = "";
            this.LabelSoNguoi.Text = "";
            this.TextBoxGhiChu.Text = phong.GhiChu;
            this.ComboBoxTinhTrangDonDep.Text = phong.TTDD;
            this.ComboBoxTinhTrangPhong.Text = "Phòng trống";
            this.ComboBoxTinhTrangPhong.Items.Add("Đang sửa chữa");
            this.ComboBoxTinhTrangPhong.Items.Add("Phòng trống");
            this.PanelChuaButtonThemDichVu.Hide();
            this.PanelChuaButtonThanhToan.Hide();
            this.PanelChuaButtonNhanPhong.Hide();
            this.PanelChuaButtonCoc.Hide();
        }
        private void LoadPage()
        {
            
            try 
            {
                switch (TTPhong)
                {
                    case "Phòng đã đặt": // Khách đã đặt phòng
                        this.LoadPhongDaDat();
                        break;
                    case "   Phòng\r\nđang thuê":
                        this.LoadPhongDangThue();
                        break;
                    case "Đang sửa chữa":
                        this.LoadPhongDangSua();
                        break;
                    case "Phòng trống":
                        this.LoadPhongTrong();
                        break;

                }
            }
            catch(Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void FormThongTinPhong_Load(object sender, EventArgs e)
        {
            DataGridView grid = gridDichVu;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            this.ActiveControl = LabelMaPhong;
        }

        private void LabelThoiGianThue_Click(object sender, EventArgs e)
        {

        }

        private void CTButtonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string TTPhong = this.ComboBoxTinhTrangPhong.Text;
                if (TTPhong == "Phòng trống")
                    phong.TTPH = "Bình thường";
                else if (TTPhong == "Đang sửa chữa")
                    phong.TTPH = TTPhong;
                if (TTPhong == "Đang sửa chữa" || TTPhong == "Phòng trống")
                {
                    phong.GhiChu = this.TextBoxGhiChu.Text;
                    phong.TTDD = this.ComboBoxTinhTrangDonDep.Text;
                
                    PhongBUS.Instance.UpdateOrAdd(phong);
                }
                else
                {
                    phong = PhongBUS.Instance.FindePhong(ctdp.MaPH);
                    phong.TTDD = this.ComboBoxTinhTrangDonDep.Text;
                    phong.GhiChu = this.TextBoxGhiChu.Text;
                    PhongBUS.Instance.UpdateOrAdd(phong);
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CTButtonThemDichVu_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThemDichVuVaoPhong frm = new FormThemDichVuVaoPhong(ctdp))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    frm.Owner = formBackground;
                    frm.ShowDialog();
                    this.LoadPage();
                    formBackground.Dispose();
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                formBackground.Dispose(); 
            } 
        }

        private void CTButtonNhanPhong_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan timeSpan = ctdp.CheckIn - DateTime.Now;
                if (timeSpan.Hours > 2 || timeSpan.Days > 0)
                {
                    CTMessageBox.Show("Không thể nhận phòng sớm hơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (phong.TTDD == "Chưa dọn dẹp")
                {
                    CTMessageBox.Show("Phòng chưa dọn dẹp xong.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ctdp.TrangThai = "Đang thuê";
                CTDP_BUS.Instance.UpdateOrAddCTDP(ctdp);
                this.Close();
            }
            catch(Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CTButtonDatPhongNay_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormDatPhong formDatPhong = new FormDatPhong(this.taiKhoan))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formDatPhong.Owner = formBackground;
                    formDatPhong.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                formBackground.Dispose();
                this.Close();
            }
        }

        private void CTButtonThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = CTMessageBox.Show("Bạn có chắc chắn muốn thanh toán phòng này không?", "Thông báo",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                HoaDon hd = new HoaDon();
                try
                {
                    phong.TTDD = "Chưa dọn dẹp";
                    hd.MaHD = HoaDonBUS.Instance.getMaHDNext();
                    hd.MaNV = taiKhoan.MaNV;
                    hd.MaCTDP = ctdp.MaCTDP;
                    ctdp.TrangThai = "Đã xong";
                    hd.TrangThai = "Đã thanh toán";
                    hd.NgHD = DateTime.Now;
                    HoaDonBUS.Instance.ThanhToanHD(hd);
                    CTDP_BUS.Instance.UpdateOrAddCTDP(ctdp);
                    PhongBUS.Instance.UpdateOrAdd(phong);
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormHoaDon formHoaDon = new FormHoaDon(HoaDonBUS.Instance.FindHD(hd.MaHD)))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formHoaDon.Owner = formBackground;
                            formHoaDon.ShowDialog();
                            formBackground.Dispose();
                        }
                        CTMessageBox.Show("Thanh toán thành công.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.phong = ctdp.Phong;
                        this.phong.TTDD = "Chưa dọn dẹp";
                        PhongBUS.Instance.UpdateOrAdd(phong);
                        this.LoadPhongTrong();
                        this.Close();
                    }
                    catch (Exception)
                    {
                        CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        }

        private void CTButtonCoc_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormDatCoc formDatCoc = new FormDatCoc())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formDatCoc.Owner = formBackground;
                    formDatCoc.ShowDialog();
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
    }
}
