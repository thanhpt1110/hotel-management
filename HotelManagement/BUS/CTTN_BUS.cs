using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class CTTN_BUS
    {
        private static CTTN_BUS instance;
        public static CTTN_BUS Instance
        {
            get { if (instance == null) instance = new CTTN_BUS(); return instance; }
            private set { instance = value; }
        }
        private CTTN_BUS() { }
        public List<CTTN> GetCTTNs()
        {
            return CTTN_DAO.Instance.GetCTTNs();
        }
        public void UpdateOrInsert(CTTN cTTN)
        {
            CTTN_DAO.Instance.UpdateOrInsert(cTTN);
        }
        public void RemoveCTTN(CTTN cTTN)
        {
            CTTN_DAO.Instance.RemoveCTTN(cTTN);
        }
        public List<CTTN> FindCTTN(string MaLPH)
        {
            return CTTN_DAO.Instance.FindCTTN(MaLPH);
        }
    }
}
