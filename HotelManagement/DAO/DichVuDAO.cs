using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            instance = null;
                return db.DichVus.Where(p => p.DaXoa == false).ToList();
            
        }    
        public DichVu FindDichVu(string MaDV)
        {
            using (HotelDTO hotelDTO = new HotelDTO())
            {
                return hotelDTO.DichVus.Find(MaDV);
            }
            
        }
        public void UpdateORAdd(DichVu dv)
        {

            try
            {
                dv.DaXoa = false;
                db.DichVus.AddOrUpdate(dv);
                db.SaveChanges();
                instance = null;
            }
            catch(Exception )
            {
                db.DichVus.Remove(dv);
            }

        }
        public void RemoveDV(DichVu dv)
        {
            try
            {
                dv.DaXoa = true;
                db.DichVus.AddOrUpdate(dv);
                db.SaveChanges();
                instance = null;
            }
            catch (Exception)
            {
                db.DichVus.Remove(dv);
            }

        }
        public string GetMaDVNext()
        {

                List<DichVu> DV = db.DichVus.ToList();
                string MaMax = DV[DV.Count - 1].MaDV.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 2, 2);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "DV0" + max.ToString();
                }
                return "DV" + max.ToString();
            
        }
       
        public List<DichVu> FindDichVuWithName(string TenDV)
        {

                return db.DichVus.Where(p => p.TenDV.Contains(TenDV) && p.DaXoa == false).ToList();
            
        }
        public List<DichVu> GetDichVusConLai()
        {
            return db.DichVus.Where(p => p.DaXoa == false && p.SLConLai != 0).ToList();
        }
        public DichVu FindDichVuWithNameAndDonGia(string TenDV, string DonGia)
        {
            decimal dongia = decimal.Parse(DonGia);
            return db.DichVus.Where(p => p.TenDV == TenDV && p.DonGia == dongia ).SingleOrDefault();
        }
        public void UpdateDV(List<DichVu> dichVus)
        {
            try
            {
                foreach (DichVu dichVu in dichVus)
                {
                    //     if(dichVu.SLConLai!=-1)
                    db.DichVus.AddOrUpdate(dichVu);
                }
                db.SaveChanges();
                instance = null;
            }
            catch (Exception)
            {
                foreach (DichVu dichVu in dichVus)
                {
                    db.DichVus.Remove(dichVu);
                }
            }

        }
    }
}
