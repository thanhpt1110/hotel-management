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
using System.Windows.Forms.VisualStyles;
using ApplicationSettings;
using HotelManagement.BUS;
using HotelManagement.CTControls;
using HotelManagement.DTO;
using HotelManagement.CTControls;

namespace HotelManagement.GUI
{
    public partial class FormSuaKhachHang : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        KhachHang khachHang;
        FormDanhSachKhachHang formDanhSachKhachHang;
        //Constructor
        public FormSuaKhachHang()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormSuaKhachHang(KhachHang khachHang,FormDanhSachKhachHang formDanhSachKhachHang)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.khachHang = khachHang;
            this.formDanhSachKhachHang = formDanhSachKhachHang;
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            this.ctTextBoxName.RemovePlaceholder();
            this.ctTextBoxQuocTich.RemovePlaceholder();
            this.ctTextBoxCCCD.RemovePlaceholder();
            this.ctTextBoxSDT.RemovePlaceholder();

            this.ctTextBoxName.Texts = this.khachHang.TenKH;
            this.ctTextBoxQuocTich.Texts = this.khachHang.QuocTich;
            this.ctTextBoxCCCD.Texts = this.khachHang.CCCD_Passport;
            this.comboBoxGioiTinh.Texts = "  " + this.khachHang.GioiTinh;
            this.ctTextBoxSDT.Texts = this.khachHang.SDT;
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
        private void FormSuaKhachHang_Paint(object sender, PaintEventArgs e)
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
        private void FormSuaKhachHang_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaKhachHang_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormSuaKhachHang_Activated(object sender, EventArgs e)
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

        private void ctTextBox1__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxName = sender as TextBox;
            textBoxName.KeyPress += TextBoxName_KeyPress; ;
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }

        private void ctTextBox2__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxCCCD = sender as TextBox;
            textBoxCCCD.MaxLength = 12;
            textBoxCCCD.KeyPress += TextBoxCCCD_KeyPress;
        }

        private void TextBoxCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);
        }

        private void CTButtonCapNhat_Click(object sender, EventArgs e)
        {
            if (this.ctTextBoxName.Texts != "" && this.ctTextBoxQuocTich.Texts != "" && this.ctTextBoxCCCD.Texts != "" && this.comboBoxGioiTinh.Texts != "  Giới tính")
            {
                if (ctTextBoxCCCD.Texts.Length != 12 && ctTextBoxCCCD.Texts.Length != 7)
                {
                    CTMessageBox.Show("Vui lòng nhập đầy đủ số CCCD/Passport.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ctTextBoxSDT.Texts.Length != 10)
                {
                    CTMessageBox.Show("Vui lòng nhập đầy đủ SĐT.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                List<KhachHang> khachHangs = KhachHangBUS.Instance.GetKhachHangs();
                foreach (KhachHang khachHang in khachHangs)
                {
                    if (khachHang.CCCD_Passport == this.ctTextBoxCCCD.Texts && this.khachHang.CCCD_Passport != this.ctTextBoxCCCD.Texts)
                    {
                        CTMessageBox.Show("Đã tồn tại số CCCD/Passport này trong danh sách khách hàng! Vui lòng kiểm tra lại thông tin.", "Thông báo", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                try
                {
                    khachHang.TenKH = this.ctTextBoxName.Texts;
                    khachHang.QuocTich = this.ctTextBoxQuocTich.Texts;
                    khachHang.CCCD_Passport = this.ctTextBoxCCCD.Texts;
                    khachHang.SDT = this.ctTextBoxSDT.Texts;
                    khachHang.GioiTinh = this.comboBoxGioiTinh.Texts.Trim(' ');
                    KhachHangBUS.Instance.UpdateOrAdd(khachHang);

                    CTMessageBox.Show("Cập nhật thông tin thành công.", "Thông báo",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.formDanhSachKhachHang.LoadAllGrid();
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
            else
                CTMessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctTextBoxSDT__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxSDT = sender as TextBox;
            textBoxSDT.MaxLength = 10;
            textBoxSDT.KeyPress += TextBoxSDT_KeyPress;
        }

        private void TextBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxOnlyNumber(e);
        }

        private void ctTextBoxQuocTich__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxQuocTich = sender as TextBox;
            textBoxQuocTich.KeyPress += TextBoxQuocTich_KeyPress;
        }

        private void TextBoxQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }

        private void FormSuaKhachHang_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelSuaKhachHang;
        }
    }
}
