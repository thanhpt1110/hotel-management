using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class TienNghiBUS
    {
        private static TienNghiBUS instance;
        public static TienNghiBUS Instance
        {
            get { if (instance == null) instance = new TienNghiBUS(); return instance; }
            private set { instance = value; }
        }
        private TienNghiBUS() { }
    }
}
