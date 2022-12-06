using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class CTTN_DAO
    {
        HotelDTO db = new HotelDTO();
        private static CTTN_DAO instance;
        public static CTTN_DAO Instance
        {
            get { if (instance == null) instance = new CTTN_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTTN_DAO() { }
    }
}
