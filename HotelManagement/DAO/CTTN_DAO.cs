using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public List<CTTN> GetCTTNs()
        {
            return db.CTTNs.Where(p => p.DaXoa == false).ToList();
        }
        public void UpdateOrInsert(CTTN cTTN)
        {
            cTTN.DaXoa = false;
            db.CTTNs.AddOrUpdate(cTTN);
            db.SaveChanges();
        }
        public void RemoveCTTN(CTTN cTTN)
        {
            cTTN.DaXoa = true;
            db.CTTNs.AddOrUpdate(cTTN);
            db.SaveChanges();
        }
        public List<CTTN> FindCTTN(string MaLPH)
        {
            return db.CTTNs.Where(p => p.MaLPH == MaLPH && p.DaXoa == false).ToList();
        }
    }
}
