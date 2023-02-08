using HotelManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationSettings;
using HotelManagement.GUI.ThongKe;
using HotelManagement.DTO;
using System.IO;
using HotelManagement.CTControls;
namespace HotelManagement
{
    public partial class FormMain : Form
    {
        //Fields
        int LoaiTK;
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(72, 145, 153);
        private TaiKhoan taiKhoan;
        //Constructor
        public FormMain(TaiKhoan taiKhoan)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.taiKhoan = taiKhoan;
            this.LoaiTK = taiKhoan.CapDoQuyen;
            InitializeComponent();
            if (this.LoaiTK == 1)
                LoadFormForNhanVien();
            else if (this.LoaiTK == 2)
                LoadFormQuanLy();
            //customDesign();
        }
        private void LoadFormForNhanVien()
        {
            this.ButtonDanhSachTienNghi.Hide();
            this.ButtonDanhSachTaiKhoan.Hide();
            this.ButtonDanhSachNhanVien.Hide();
            this.ButtonThongKe.Hide();
        }
        private void LoadFormQuanLy()
        {
            this.ButtonDanhSachTaiKhoan.Hide();
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

        private FormBoundsColors SameColor()
        {
            var fbColor = new FormBoundsColors();
            fbColor.TopLeftColor = Color.FromArgb(72, 145, 153);
            fbColor.TopRightColor = Color.FromArgb(72, 145, 153);
            fbColor.BottomLeftColor = Color.FromArgb(72, 145, 153);
            fbColor.BottomRightColor = Color.FromArgb(72, 145, 153);
            return fbColor;
        }

        //Event Methods
        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            //var fbColors = SameColor();
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

        private void FormMain_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void PanelBackground_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(PanelBackground, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
            openChildForm(new FormTrangChu());
            int time = 300;
            WinAPI.AnimateWindow(this.Handle, time, WinAPI.CENTER);
            this.LabelTenNguoiDung.Text = taiKhoan.NhanVien.TenNV;
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainChildForm.Controls.Add(childForm);
            panelMainChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /*private void customDesign()
        {
            this.panelThuChiSubmenu.Visible = false;
            this.panelThongKeSubmenu.Visible = false;
            this.panelNhanSuSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (this.panelThuChiSubmenu.Visible == true)
                this.panelThuChiSubmenu.Visible = false;
            if (this.panelThongKeSubmenu.Visible == true)
                this.panelThongKeSubmenu.Visible = false;
            if (this.panelNhanSuSubmenu.Visible == true)
                this.panelNhanSuSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Parent button menu
        private void buttonQuanLyThuChi_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            disableAllSubmenuColor();
            activateButtonSidebar(sender);
            showSubmenu(panelThuChiSubmenu);
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            disableAllSubmenuColor();
            activateButtonSidebar(sender);
            showSubmenu(panelThongKeSubmenu);
        }

        private void buttonNhanSu_Click(object sender, EventArgs e)
        {
            disableButtonSidebar();
            disableAllSubmenuColor();
            activateButtonSidebar(sender);
            showSubmenu(panelNhanSuSubmenu);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainChildForm.Controls.Add(childForm);
            panelMainChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Settings button
        private void buttonSoDoPhong_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            disableButtonSidebar();
            openChildForm(new FormSoDoPhong());
            activateButtonSidebar(sender);
        }

        private void buttonLoaiPhong_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            disableButtonSidebar();
            openChildForm(new FormLoaiPhong());
            activateButtonSidebar(sender);
        }

        private void buttonKho_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            disableButtonSidebar();
            openChildForm(new FormKho());
            activateButtonSidebar(sender);
        }  

        private void buttonDoanhThu_Click(object sender, EventArgs e)
        {
            disableButtonSubmenu(this.panelThuChiSubmenu);
            openChildForm(new FormDoanhThu());
            activateButtonSubmenu(sender);
        }

        private void buttonCongNo_Click(object sender, EventArgs e)
        {
            disableButtonSubmenu(this.panelThuChiSubmenu);
            openChildForm(new FormCongNo());
            activateButtonSubmenu(sender);
        }

        private void buttonSoLuongKhach_Click(object sender, EventArgs e)
        {
            disableButtonSubmenu(this.panelThongKeSubmenu);
            openChildForm(new FormSoLuongKhach());
            activateButtonSubmenu(sender);
        }

        private void buttonThoiGian_Click(object sender, EventArgs e)
        {
            disableButtonSubmenu(this.panelThongKeSubmenu);
            openChildForm(new FormThoiGian());
            activateButtonSubmenu(sender);
        }

        private void buttonChinhSuaNhanSu_Click(object sender, EventArgs e)
        {
            disableButtonSubmenu(this.panelNhanSuSubmenu);
            openChildForm(new FormChinhSuaNhanSu());
            activateButtonSubmenu(sender);
        }

        private void buttonChamCong_Click(object sender, EventArgs e)
        {
            disableButtonSubmenu(this.panelNhanSuSubmenu);
            openChildForm(new FormChamCong());
            activateButtonSubmenu(sender);
        }

        private void activateButtonSidebar(object btnSender)
        {
            if (btnSender != null)
            {
                Button currentButton = (Button)btnSender;
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.FromArgb(153, 179, 208);
            }
        }

        private void activateButtonSubmenu(object btnSender)
        {
            if (btnSender != null)
            {
                Button currentButton = (Button)btnSender;
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.FromArgb(199, 215, 224);
            }
        }

        private void disableButtonSidebar()
        {
            foreach(Control prevButton in Sidebar.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                    prevButton.BackColor = Color.FromArgb(171, 200, 232);
            }
        }

        private void disableButtonSubmenu(Panel subMenu)
        {
            foreach (Control prevButton in subMenu.Controls)
            {
                if (prevButton.GetType() == typeof(Button))
                    prevButton.BackColor = Color.FromArgb(222, 240, 250);
            }
        }
        
        private void disableAllSubmenuColor()
        {
            disableButtonSubmenu(this.panelThuChiSubmenu);
            disableButtonSubmenu(this.panelThongKeSubmenu);
            disableButtonSubmenu(this.panelNhanSuSubmenu);
        }
*/

        private void ctMinimize1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ctMaximize1_Click(object sender, EventArgs e)
        {
            CTMessageBox.Show("Ứng dụng chưa hỗ trợ kích thước toàn màn hình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void panelControlBox_MouseHover(object sender, EventArgs e)
        {
            ctClose1.turnOn();
            ctMinimize1.turnOn();
            ctMaximize1.turnOn();
        }

        private void panelControlBox_MouseLeave(object sender, EventArgs e)
        {
            ctClose1.turnOff();
            ctMinimize1.turnOff();
            ctMaximize1.turnOff();
        }

        private void panelControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            ctClose1.turnOn();
            ctMinimize1.turnOn();
            ctMaximize1.turnOn();   
        }

        private void panelName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //Button color change
        private void SetAllButtonNormalColor()
        {
            ButtonTrangChu.BackColor = Color.FromArgb(72, 145, 153);
            ButtonSoDoPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachDatPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachHoaDon.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachKhachHang.BackColor = Color.FromArgb(72, 145, 153);
            ButtonPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonLoaiPhong.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachDichVu.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachTienNghi.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachTaiKhoan.BackColor = Color.FromArgb(72, 145, 153);
            ButtonDanhSachNhanVien.BackColor = Color.FromArgb(72, 145, 153);
            ButtonThongKe.BackColor = Color.FromArgb(72, 145, 153);

            ButtonTrangChu.ForeColor
                = ButtonSoDoPhong.ForeColor
                = ButtonDanhSachDatPhong.ForeColor
                = ButtonDanhSachHoaDon.ForeColor
                = ButtonDanhSachKhachHang.ForeColor
                = ButtonPhong.ForeColor
                = ButtonLoaiPhong.ForeColor
                = ButtonDanhSachDichVu.ForeColor
                = ButtonDanhSachTienNghi.ForeColor
                = ButtonDanhSachTaiKhoan.ForeColor
                = ButtonDanhSachNhanVien.ForeColor
                = ButtonThongKe.ForeColor = Color.Black;
        }

        private void ButtonDanhSachDatPhong_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonDanhSachDatPhong.BackColor = Color.FromArgb(233, 117, 32);
            ButtonDanhSachDatPhong.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachPhieuThue(this,taiKhoan));
        }

        private void ButtonSoDoPhong_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonSoDoPhong.BackColor = Color.FromArgb(233, 117, 32);
            ButtonSoDoPhong.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormSoDoPhong(this,taiKhoan));
        }


        private void ButtonDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonDanhSachHoaDon.BackColor = Color.FromArgb(233, 117, 32);
            ButtonDanhSachHoaDon.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachHoaDon(this));
        }

        private void ButtonTrangChu_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonTrangChu.BackColor = Color.FromArgb(233, 117, 32);
            ButtonTrangChu.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormTrangChu(this));
        }

        private void ButtonDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonDanhSachKhachHang.BackColor = Color.FromArgb(233, 117, 32);
            ButtonDanhSachKhachHang.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachKhachHang(this,this.taiKhoan));
        }

        private void ButtonPhong_Click(object sender, EventArgs e)
        {   //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonPhong.BackColor = Color.FromArgb(233, 117, 32);
            ButtonPhong.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachPhong(this,this.taiKhoan));
        }

        private void ButtonLoaiPhong_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonLoaiPhong.BackColor = Color.FromArgb(233, 117, 32);
            ButtonLoaiPhong.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachLoaiPhong(this,this.taiKhoan));
        }
        private void ButtonDanhSachDichVu_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonDanhSachDichVu.BackColor = Color.FromArgb(233, 117, 32);
            ButtonDanhSachDichVu.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachDichVu(this,this.taiKhoan));
        }

        private void ButtonDanhSachTienNghi_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonDanhSachTienNghi.BackColor = Color.FromArgb(233, 117, 32);
            ButtonDanhSachTienNghi.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachTienNghi(this,this.taiKhoan));
            
        }

        private void ButtonDanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonDanhSachTaiKhoan.BackColor = Color.FromArgb(233, 117, 32);
            ButtonDanhSachTaiKhoan.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachTaiKhoan(this));
        }

        private void ButtonDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonDanhSachNhanVien.BackColor = Color.FromArgb(233, 117, 32);
            ButtonDanhSachNhanVien.ForeColor = Color.White;
            //Open Child Form
            openChildForm(new FormDanhSachNhanVien(this,this.taiKhoan));
        }

        private void ctClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            //Change color button on side bar
            SetAllButtonNormalColor();
            ButtonThongKe.BackColor = Color.FromArgb(233, 117, 32);
            
            //Open Child Form
            openChildForm(new FormThongKe(this));
        }
        private void DisplayTextMenu()
        {
            ButtonTrangChu.Text = "    Trang chủ";
            ButtonSoDoPhong.Text = "    Sơ đồ phòng";
            ButtonDanhSachDatPhong.Text = "    Danh sách đặt phòng";
            ButtonDanhSachHoaDon.Text = "    Danh sách hóa đơn";
            ButtonDanhSachKhachHang.Text = "    Danh sách khách hàng";
            ButtonPhong.Text = "    Phòng";
            ButtonLoaiPhong.Text = "    Loại phòng";
            ButtonDanhSachDichVu.Text = "    Danh sách dịch vụ";
            ButtonDanhSachTienNghi.Text = "    Danh sách tiện nghi";
            ButtonDanhSachTaiKhoan.Text = "    Danh sách tài khoản";
            ButtonDanhSachNhanVien.Text = "    Danh sách nhân viên";
            ButtonThongKe.Text = "    Thống kê";
            PanelUser.Visible = true;
        }
        private void NotDisplayTextMenu()
        {
            ButtonTrangChu.Text = "";
            ButtonSoDoPhong.Text = "";
            ButtonDanhSachDatPhong.Text = "";
            ButtonDanhSachHoaDon.Text = "";
            ButtonDanhSachKhachHang.Text = "";
            ButtonPhong.Text = "";
            ButtonLoaiPhong.Text = "";
            ButtonDanhSachDichVu.Text = "";
            ButtonDanhSachTienNghi.Text = "";
            ButtonDanhSachTaiKhoan.Text = "";
            ButtonDanhSachNhanVien.Text = "";
            ButtonThongKe.Text = "";
            PanelUser.Visible = false;
        }
        private bool isDisplayed = true;
        private void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (isDisplayed == true)
            {
                isDisplayed = false;
                Size size = new Size(65, Sidebar.Height);
                NotDisplayTextMenu();
                Sidebar.Size = size;
            }
            else
            {
                isDisplayed = true;
                Size size = new Size(262, Sidebar.Height);
                DisplayTextMenu();
                Sidebar.Size = size;
            }
        }

        private void linkLabelDangXuat_Click(object sender, EventArgs e)
        {
            using (FormLogin formLogin = new FormLogin())
            {
                this.Hide();
                formLogin.ShowDialog();
                this.Close();
            }
        }

        private void PictureBoxMenu_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBoxMenu.BackColor = Color.FromArgb(58, 130, 137);
        }

        private void PictureBoxMenu_MouseLeave(object sender, EventArgs e)
        {
            PictureBoxMenu.BackColor = Color.Transparent;
        }
    }
}
