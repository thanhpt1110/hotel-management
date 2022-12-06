using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class CTDP_DAO
    {
        HotelDTO db = new HotelDTO();
        private static CTDP_DAO instance;
        public static CTDP_DAO Instance
        {
            get { if (instance == null) instance = new CTDP_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTDP_DAO() { }
    }
}
