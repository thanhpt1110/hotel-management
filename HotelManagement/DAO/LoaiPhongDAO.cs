using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class LoaiPhongDAO
    {
        HotelDTO db = new HotelDTO();
        private static LoaiPhongDAO instance;
        public static LoaiPhongDAO Instance
        {
            get { if (instance == null) instance = new LoaiPhongDAO(); return instance; }
            private set { instance = value; }
        }
        private LoaiPhongDAO() { }
    }
}
