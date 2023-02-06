using HotelManagement.ApplicationSettings;
using HotelManagement.CTControls;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class FormKetNoiCSDL : Form
    {
        #region Custom UI

        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.White;

        //Constructor
        public FormKetNoiCSDL()
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            InitializeComponent();
        }

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
        private void FormKetNoiCSDL_Paint(object sender, PaintEventArgs e)
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
        private void FormKetNoiCSDL_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormKetNoiCSDL_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FormKetNoiCSDL_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void panelBackground_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelBackground, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void panelControlBox_MouseHover(object sender, EventArgs e)
        {
            ctClose.turnOn();
            ctMinimize.turnOn();
            //ctMaximize.turnOn();
        }

        private void panelControlBox_MouseLeave(object sender, EventArgs e)
        {
            ctClose.turnOff();
            ctMinimize.turnOff();
            //ctMaximize.turnOff();
        }

        private void panelControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            ctClose.turnOn();
            ctMinimize.turnOn();
            //ctMaximize.turnOn();
        }
        #endregion

        #region Button mouse effect
        private void buttonDefault_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDefault.BackColor = Color.FromArgb(255, 205, 0);
            buttonDefault.BackgroundColor = Color.FromArgb(255, 205, 0);
            buttonDefault.BorderColor = Color.FromArgb(229, 184, 0);
        }

        private void buttonDefault_MouseLeave(object sender, EventArgs e)
        {
            buttonDefault.BackColor = Color.FromArgb(255, 222, 85);
            buttonDefault.BackgroundColor = Color.FromArgb(255, 222, 85);
            buttonDefault.BorderColor = Color.FromArgb(255, 222, 85);
        }

        private void buttonKetNoi_MouseMove(object sender, MouseEventArgs e)
        {
            buttonKetNoi.BorderColor = Color.FromArgb(32, 122, 229);
        }

        private void buttonKetNoi_MouseLeave(object sender, EventArgs e)
        {
            buttonKetNoi.BorderColor = Color.FromArgb(36, 136, 255);
        }

        #endregion
        
        #region Process events
        private void ctClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKetNoiCSDL_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelTitle;

            #region Check DB file exists or not to load textbox
            try
            {
                if (File.Exists("DBConnection.txt"))
                {
                    string[] lines = File.ReadAllLines("DBConnection.txt");
                    textBoxServer.RemovePlaceholder();
                    textBoxDB.RemovePlaceholder();
                    textBoxServer.Texts = lines[0]; 
                    textBoxDB.Texts = lines[1];
                }
                else
                {
                    // Set default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void buttonKetNoi_Click(object sender, EventArgs e)
        {
            string server = textBoxServer.Texts;
            string db = textBoxDB.Texts;
            #region Check CheckBox status to save new or not
            if (checkBoxLuu.Checked) // Overwrite old file
            {
                try
                {
                    // Check file exist or not
                    if (!File.Exists("DBConnection.txt"))
                    {
                        File.Create("DBConnection.txt").Close();
                        using (StreamWriter sw = new StreamWriter("DBConnection.txt"))
                        {
                            sw.WriteLine(server);
                            sw.WriteLine(db);
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter("DBConnection.txt"))
                        {
                            sw.WriteLine(server);
                            sw.WriteLine(db);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
            #endregion

            if (server == string.Empty && db == string.Empty)
            {
                CTMessageBox.Show("Không được để trống! Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #region Check DB Connection
            string connectionString = string.Format("Data source = {0}; Initial Catalog = {1}; Integrated security = True; MultipleActiveResultSets = True;App = EntityFramework", server, db);
            try
            {
                SqlHelper sqlHelper = new SqlHelper(connectionString);
                if (sqlHelper.isConnected)
                {
                    ConnectDB connectDB = new ConnectDB();
                    connectDB.ReloadFileConfig("HotelDTO", connectionString);

                    CTMessageBox.Show("Kết nối cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormLogin formLogin = new FormLogin();                    
                        this.Hide();
                        formLogin.ShowDialog();
                        this.Close();
                    
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng kiểm tra lại thông tin đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
        }

        private void ctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            #region Check DB Connection 
            string connectionString = @"data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=|DataDirectory|\Database\HotelManagement.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework";
            try
            {
                SqlHelper sqlHelper = new SqlHelper(connectionString);
                if (sqlHelper.isConnected)
                {
                    ConnectDB connectDB = new ConnectDB();
                    connectDB.ReloadFileConfig("HotelDTO", connectionString);
                    CTMessageBox.Show("Kết nối cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (FormLogin formLogin = new FormLogin())
                    {
                        this.Hide();
                        formLogin.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng khởi động lại chương trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion

            this.Close();
        }

        #endregion
    }
}
