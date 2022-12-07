    using HotelManagement.GUI;
using System;
using System.Collections;
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
    public partial class CTClose : UserControl
    {
        private bool mouseHover = false;
        private bool mouseMove = false;
        private bool mouseLeave = false;
        private int Case = 0;
        private object form;
        public CTClose()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }
        public CTClose(int Case,object form)
        {
            this.DoubleBuffered = true;
            this.Case = Case;
            this.form = form;
            InitializeComponent();
        }

        private void close_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            mouseHover = false;
            mouseLeave = false;
            this.Invalidate();
        }

        private void close_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (mouseHover || mouseMove)
            {
                Bitmap bitmap = Properties.Resources.fixedCloseResize;
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            }
            else if (mouseLeave)
            {
                Bitmap bitmap = Properties.Resources.fixedRedResize;
                g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

            }
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            mouseMove = false;
            mouseHover = true;
            mouseLeave = false;
            this.Invalidate();
        }

        private void close_MouseLeave(object sender, EventArgs e)
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
