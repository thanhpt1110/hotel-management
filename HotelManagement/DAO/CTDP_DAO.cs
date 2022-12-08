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
        public List<CTDP> GetCTDPs()
        {
            return db.CTDPs.ToList();
        }

        public int getKhoangTG(string MaCTDP)
        {
            DateTime checkin = new DateTime();
            DateTime checkout = new DateTime();
            CTDP ctdp = db.CTDPs.Find(MaCTDP);
            if (ctdp != null)
            {
                checkin = ctdp.CheckIn;
                checkout = ctdp.CheckOut;
            }
            TimeSpan timeSpan = checkout.Subtract(checkin);   
            return timeSpan.Days;
        }
    }
}
