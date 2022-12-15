using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class CTDV_DAO
    {
        HotelDTO db = new HotelDTO();
        private static CTDV_DAO instance;
        public static CTDV_DAO Instance
        {
            get { if (instance == null) instance = new CTDV_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTDV_DAO() { }

        public List<CTDV> FindCTDV(string MaHD)
        {

                return db.CTDVs.Where(p => p.MaHD == MaHD && p.DaXoa == false).ToList();
            
        } 

        
    }
}
