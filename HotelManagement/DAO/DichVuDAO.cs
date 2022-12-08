using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class DichVuDAO
    {
        HotelDTO db = new HotelDTO();
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }
        private DichVuDAO() { }

        public List<DichVu> GetDichVus()
        {
            return db.DichVus.ToList();
        }    
        public DichVu FindDichVu(string MaDV)
        {
            return db.DichVus.Find(MaDV);
        }
    }
}
