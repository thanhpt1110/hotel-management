using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get { if (instance == null) instance = new NhanVienBUS(); return instance; }
            private set { instance = value; }
        }
        private NhanVienBUS() { }
    }
}
