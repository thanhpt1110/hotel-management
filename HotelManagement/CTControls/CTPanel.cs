using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTPanel
{
    public partial class CTPanel : UserControl
    {
        // Fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        // Constructor
        public CTPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }

        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }
        public Color GradientTopColor { get => gradientTopColor; set { gradientTopColor = value; this.Invalidate(); } }
        public Color GradientBottomColor { get => gradientBottomColor; set { gradientBottomColor = value; this.Invalidate(); } }

        //Methods 
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        //Overriden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.GradientBottomColor, this.gradientAngle);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, ClientRectangle);

            // Border Radius    
            RectangleF rectF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetFigurePath(rectF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                this.Region = new Region(rectF);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CTPanel
            // 
            this.DoubleBuffered = true;
            this.Name = "CTPanel";
            this.ResumeLayout(false);

        }
    }
}
