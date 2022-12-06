using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class PhongBUS
    {
        private static PhongBUS instance;
        public static PhongBUS Instance
        {
            get { if (instance == null) instance = new PhongBUS(); return instance; }
            private set { instance = value; }
        }
        private PhongBUS() { }
    }
}
