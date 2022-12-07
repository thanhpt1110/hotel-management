using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationSettings
{
    internal class WinAPI
    {
        public const int HOR_Positive = 0x1;

        public const int HOR_Negative = 0x2;

        public const int VER_Positive = 0x4;

        public const int VER_Negative = 0x8;

        public const int CENTER = 0x10;

        public const int BLEND = 0x8000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);
    }
}
