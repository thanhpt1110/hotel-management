using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DTO;
using HotelManagement.DAO;
namespace HotelManagement.BUS
{
    internal class CTDV_BUS
    {
        private static CTDV_BUS instance;
        public static CTDV_BUS Instance
        {
            get { if (instance == null) instance = new CTDV_BUS(); return instance; }
            private set { instance = value; }
        }
        private CTDV_BUS() { }

        public List<CTDV> FindCTDV(string MaHD)
        {
            return CTDV_DAO.Instance.FindCTDV(MaHD);
        }
        public void InsertOrUpdateList(List<CTDV> cTDVs)
        {
            CTDV_DAO.Instance.InsertOrUpdateList(cTDVs);
        }
    }
}
