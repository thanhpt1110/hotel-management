﻿using System;
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

namespace HotelManagement
{
    public partial class FormMain : Form
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(72, 145, 153);

        //Constructor
        public FormMain()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
            customDesign();
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
        private void FormMain_Paint(object sender, PaintEventArgs e)
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
        }

        private void customDesign()
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

        private void ctMinimize1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ctMaximize1_Click(object sender, EventArgs e)
        {
            if(this.WindowState!=FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState=FormWindowState.Normal;
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

        private void ctRoomPhongTrong1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click OK!");
        }

    }
}
