using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class TienNghiDAO
    {
        HotelDTO db = new HotelDTO();
        private static TienNghiDAO instance;
        public static TienNghiDAO Instance
        {
            get { if (instance == null) instance = new TienNghiDAO(); return instance; }
            private set { instance = value; }
        }
        private TienNghiDAO() { }
    }
}
