using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class CTDP_BUS
    {
        private static CTDP_BUS instance;
        public static CTDP_BUS Instance
        {
            get { if (instance == null) instance = new CTDP_BUS(); return instance; }
            private set { instance = value; }
        }
        private CTDP_BUS() { }
    }
}
