using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        
        public void InsertOrUpdateList(List<CTDV> cTDVs)
        {
            foreach(CTDV cTDV in cTDVs)
            {
                if (cTDV.SL != 0)
                {
                    db.CTDVs.AddOrUpdate(cTDV);
                    CTDV cTDV1 = db.CTDVs.Where(p => p.DonGia == cTDV.DonGia && p.MaDV == cTDV.MaDV && p.MaHD == cTDV.MaHD).SingleOrDefault();
                    if (cTDV.SL == 0 && cTDV1 != null)
                    {
                        //CTDV ctdv = db.CTDVs.Where(p => p.MaDV == cTDV.MaDV && p.DonGia == cTDV.DonGia && p.MaHD == cTDV.MaHD).SingleOrDefault();
                        db.CTDVs.Remove(cTDV1);
                    }
                }
            }
            db.SaveChanges();
            instance = null;
        }    
    }
}
