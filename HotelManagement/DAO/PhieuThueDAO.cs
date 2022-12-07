using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuThueDAO
    {
        HotelDTO db = new HotelDTO();
        private static PhieuThueDAO instance;
        public static PhieuThueDAO Instance
        {
            get { if (instance == null) instance = new PhieuThueDAO(); return instance; }
            private set { instance = value; }
        }
        private PhieuThueDAO() { }
        public List<PhieuThue> GetPhieuThues()
        {
            return db.PhieuThues.ToList();
        }
    }
}
