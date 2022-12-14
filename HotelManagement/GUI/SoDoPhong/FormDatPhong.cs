using HotelManagement.CTControls;
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
using HotelManagement.DTO;
using ApplicationSettings;
using HotelManagement.DAO;

namespace HotelManagement.GUI
{
    public partial class FormDatPhong : Form
    {
        //Fields
        private int borderRadius = 15;
        private int borderSize = 2;
        private Color borderColor = Color.White;
        private List<CTDP> listPhongDaDat = new List<CTDP>();
        private Image Add = Properties.Resources.Add; // Image for Button Thêm
        private Image Del = Properties.Resources.delete1; // Image for Button Hủy
        private KhachHang khachHang = new KhachHang();
        private int flag = 0;
        private TaiKhoan taiKhoan;
        private PhieuThue phieuThue = new PhieuThue();
        //Constructor
        public FormDatPhong()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }
        public FormDatPhong(TaiKhoan taiKhoan)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.taiKhoan = taiKhoan;
            InitializeComponent();
            phieuThue.MaPT = PhieuThueBUS.Instance.GetMaPTNext();
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
        #region Draw Form
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
        private void FormDatPhong_Paint(object sender, PaintEventArgs e)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = this.ClientRectangle;
            int mWidht = rectForm.Width / 2;
            int mHeight = rectForm.Height / 2;
            var fbColors = GetSameDark();
            //fbColors = GetSame();
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
        private void FormDatPhong_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormDatPhong_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormDatPhong_Activated(object sender, EventArgs e)
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

        private void CTButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            // Custom Dgv when loading Form
            DataGridView grid1 = gridPhongTrong;
            DataGridView grid2 = gridPhongDaChon;
            grid1.ColumnHeadersDefaultCellStyle.Font = new Font(grid1.Font, FontStyle.Bold);
            grid2.ColumnHeadersDefaultCellStyle.Font = new Font(grid2.Font, FontStyle.Bold);
            this.ctTimePicker1.SetHour(DateTime.Now.Hour, DateTime.Now.Minute);
            this.ctTimePicker1.SetMin(DateTime.Now.Minute);
            this.ctTimePicker2.SetHour(DateTime.Now.Hour, DateTime.Now.Minute);
            this.ctTimePicker2.SetMin(DateTime.Now.Minute);

            grid1.Rows.Add(new object[] { "P101", "Phòng vip", this.Add });
            grid1.Rows.Add(new object[] { "P101", "Phòng vip", this.Add });
            LoadgridPhongTrong();
            grid2.Rows.Add(new object[] { "P101", "3", "11/10/2003 12:00:00", "11/10/2003 12:00:00", this.Del });
            grid2.Rows.Add(new object[] { "P101", "3", "11/10/2003 12:00:00", "11/10/2003 12:00:00", this.Del });
            grid2.Rows.Add(new object[] { "P101", "3", "11/10/2003 12:00:00", "11/10/2003 12:00:00", this.Del });
            grid2.Rows.Add(new object[] { "P101", "3", "11/10/2003 12:00:00", "11/10/2003 12:00:00", this.Del });
            LoadGridPhongDat();
            phieuThue.MaPT = PhieuThueBUS.Instance.GetMaPTNext();

        }
        private void LoadgridPhongTrong()
        {
            gridPhongTrong.Rows.Clear();
            List<Phong> phongs = PhongBUS.Instance.FindPhongTrong(CTDatePickerNgayBD.Value, CTDatePickerNgayKT.Value, listPhongDaDat);
            foreach (Phong phong in phongs)
            {
                gridPhongTrong.Rows.Add(new object[] { phong.MaPH, phong.LoaiPhong.TenLPH, this.Add });
            }    
        }
        private void LoadGridPhongDat()
        {
            gridPhongDaChon.Rows.Clear();
            if(this.listPhongDaDat!=null)
            {
                foreach(CTDP room in listPhongDaDat)
                {
                    gridPhongDaChon.Rows.Add(room.MaPH, room.SoNguoi, room.CheckIn.ToString("dd/MM/yyyy hh:mm:ss"), room.CheckOut.ToString("dd/MM/yyyy hh:mm:ss"), this.Del);
                }    
            }    
        }
        private void gridPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0 && x == 2)
            {
                CTDP cTDP = new CTDP();
                cTDP.MaCTDP = CTDP_BUS.Instance.getNextCTDPwithList(this.listPhongDaDat);
                cTDP.MaPT = this.phieuThue.MaPT;
                cTDP.DatCoc = 0;
                cTDP.CheckIn = CTDatePickerNgayBD.Value;
                cTDP.CheckOut = CTDatePickerNgayKT.Value;
                cTDP.MaPH = gridPhongTrong.Rows[y].Cells[0].Value.ToString();
                cTDP.Phong = PhongBUS.Instance.FindePhong(cTDP.MaPH);
                cTDP.SoNguoi = 0;
                cTDP.DonGia = cTDP.Phong.LoaiPhong.GiaNgay;
                cTDP.TrangThai = "Đã đặt";
                listPhongDaDat.Add(cTDP);
                LoadGridPhongDat();
                LoadgridPhongTrong();
            }
        }

        private void gridPhongDaChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0 && x == 4)
            {
                // If click Add new room
                DialogResult dialogResult = CTMessageBox.Show("Bạn có muốn xóa phòng không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                {
                    foreach (CTDP ctdp in this.listPhongDaDat)
                    {
                        if (ctdp.CheckIn.ToString("dd/MM/yyyy hh:mm:ss") == gridPhongDaChon.Rows[y].Cells[2].Value.ToString() && ctdp.MaPH == gridPhongDaChon.Rows[y].Cells[0].Value.ToString())
                        {
                            this.listPhongDaDat.Remove(ctdp);
                            LoadGridPhongDat();
                            LoadgridPhongTrong();
                            return;
                        }
                    }
                    CTMessageBox.Show("Xóa thất bại");
                }
            }         
        }

        private void gridPhongTrong_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = gridPhongTrong;
            int x = e.ColumnIndex, y = e.RowIndex;
            int[] arrX = { 0, 1 };
            bool isExists = false;

            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;

            if (y >= 0 && x == 2 || y == -1 && isExists)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void gridPhongTrong_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = gridPhongTrong;
            grid.Cursor = Cursors.Default;
        }

        private void gridPhongDaChon_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView grid = gridPhongDaChon;
            int x = e.ColumnIndex, y = e.RowIndex;
            int[] arrX = { 0 };
            bool isExists = false;

            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;

            if (y >= 0 && x == 4 || y == -1 && isExists)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void gridPhongDaChon_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = gridPhongDaChon;
            grid.Cursor = Cursors.Default;
        }

        private void CTDatePickerNgayBD_ValueChanged(object sender, EventArgs e)
        {
            LoadgridPhongTrong();
        }

        private void CTDatePickerNgayKT_ValueChanged(object sender, EventArgs e)
        {
            LoadgridPhongTrong();
        }

        private void CTButtonNhanPhong_Click(object sender, EventArgs e)
        {
        }

        private void CTButtonDatTruoc_Click(object sender, EventArgs e)
        {
            if (this.CTTextBoxNhapCCCD.Texts != "" && this.CTTextBoxNhapDiaChi.Texts != "" && this.CTTextBoxNhapHoTen.Texts != "" && this.ComboBoxGioiTinh.Text != "  Giới tính")
            {
                CreateKH();
                CreatePhieuThue();
                CreateCTDP();
                CreateHoaDon();
                this.Close();
            }
            else
            {
                CTMessageBox.Show("Vui lòng nhập thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void CreateKH()
        {
            khachHang.SDT = CTTextBoxNhapSDT.Texts;
            khachHang.QuocTich = CTTextBoxNhapDiaChi.Texts;
            if (flag == 0)
            {

                khachHang.MaKH = KhachHangBUS.Instance.GetMaKHNext();
                //CTMessageBox.Show("Thành cong");
            }
            khachHang.TenKH = CTTextBoxNhapHoTen.Texts;
            khachHang.CCCD_Passport = CTTextBoxNhapCCCD.Texts;
            khachHang.GioiTinh = this.ComboBoxGioiTinh.Text;
            KhachHangBUS.Instance.UpdateOrAdd(khachHang);
        }
        private void CreatePhieuThue()
        {
            
            phieuThue.MaNV = "NV001";
            phieuThue.DaXoa = false;
            phieuThue.MaKH = khachHang.MaKH;
            phieuThue.NgPT = DateTime.Now;
            PhieuThueBUS.Instance.AddOrUpdatePhieuThue(phieuThue);         
        }

        void CreateCTDP()
        {
            foreach(CTDP ctdp in listPhongDaDat)
            {
                ctdp.MaPT = phieuThue.MaPT;
                ctdp.TrangThai = "Đã đặt";
                ctdp.DaXoa = false;
                
                CTDP_BUS.Instance.UpdateOrAddCTDP(ctdp);
            }
        }

        private void CreateHoaDon()
        {
            foreach (CTDP ctdp in listPhongDaDat)
            {
                HoaDon hoadon = new HoaDon();
                hoadon.MaHD = HoaDonBUS.Instance.getMaHDNext();
                hoadon.MaCTDP = ctdp.MaCTDP;
                hoadon.MaNV = "NV001";
                hoadon.TriGia = 0;
                hoadon.NgHD = DateTime.Now;
                hoadon.TrangThai = "Chưa thanh toán";
                HoaDonBUS.Instance.Update_Inserthd(hoadon);
            }
        }

        private void CTTextBoxNhapHoTen__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxNotNumber = sender as TextBox;
            textBoxNotNumber.KeyPress += TextBoxNotNumber_KeyPress;
        }

        private void TextBoxNotNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }

        private void CTTextBoxNhapCCCD__TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.MaxLength = 12;
            textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (KhachHangBUS.Instance.FindKHWithCCCD(textBox.Text) != null)
            {
                DialogResult dialogresult = CTMessageBox.Show("Đã có số cccd hoặc passport này trong danh sách\r\n Bạn có muốn lấy lại thông tin đó?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.Yes)
                {
                    CTTextBoxNhapSDT.RemovePlaceholder();
                    CTTextBoxNhapDiaChi.RemovePlaceholder();
                    CTTextBoxNhapHoTen.RemovePlaceholder();
                   // CTTextBoxNhapCCCD.RemovePlaceholder();
                      

                    khachHang = KhachHangBUS.Instance.FindKHWithCCCD(textBox.Text);
                    CTTextBoxNhapSDT.Texts = khachHang.SDT;
                    CTTextBoxNhapDiaChi.Texts = khachHang.QuocTich;
                    ComboBoxGioiTinh.Text = khachHang.GioiTinh;
                    CTTextBoxNhapHoTen.Texts = khachHang.TenKH;
                    ComboBoxGioiTinh.Focus();
                    flag = 1;
                }          
            }    
        }
    }
}
