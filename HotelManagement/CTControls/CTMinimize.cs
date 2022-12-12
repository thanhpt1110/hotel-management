using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.CTControls
{
    public partial class CTMinimize : UserControl
    {
        private bool mouseHover = false;
        private bool mouseMove = false;
        private bool mouseLeave = false;

        public CTMinimize()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }


        private void minimize_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (mouseHover || mouseMove)
            {
                Bitmap bitmap = Properties.Resources.fixedMinResize;
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            }
            else if (mouseLeave)
            {
                Bitmap bitmap = Properties.Resources.fixedYellowResize;
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            }
        }
        private void minimize_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            mouseHover = false;
            mouseLeave = false;
            this.Invalidate();
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            mouseMove = false;
            mouseHover = true;
            mouseLeave = false;
            this.Invalidate();
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            mouseMove = false;
            mouseHover = false;
            mouseLeave = true;
            this.Invalidate();
        }

        public void turnOn()
        {
            mouseMove = true;
            mouseHover = true;
            this.Invalidate();
        }

        public void turnOff()
        {
            mouseMove = false;
            mouseHover = false;
            mouseLeave = true;
            this.Invalidate();
        }
    }
}
