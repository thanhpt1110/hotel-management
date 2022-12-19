using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
    internal class HoaDonDAO
    {
        HotelDTO db = new HotelDTO();
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private HoaDonDAO() { }
        public List<HoaDon> GetHoaDons()
        {

                return db.HoaDons.ToList();
            
        } 
        public HoaDon FindHD(string MaHD)
        {

                return db.HoaDons.Find(MaHD);
            
        }
        public void Update_InsertHD(HoaDon HD)
        {
                HD.CTDP = db.CTDPs.Find(HD.MaCTDP);
                HD.NhanVien = db.NhanViens.Find(HD.MaNV);
                
                db.HoaDons.AddOrUpdate(HD);
                db.SaveChanges();
                
        }
        public void ThanhToanHD(HoaDon HD)
        {
            db.HoaDons.AddOrUpdate(HD);
            db.SaveChanges();
        }    
        public List<HoaDon> FindHoaDonWith_CCCD(string cccd)
        {

                return db.HoaDons.Where(p => p.CTDP.PhieuThue.KhachHang.CCCD_Passport == cccd).ToList();
            
        }
        public string getMaHDNext()
        {

                List<HoaDon> HD = db.HoaDons.ToList();
                string MaMax = HD[HD.Count - 1].MaHD.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "HD00" + max.ToString();
                }
                else if (max < 100)
                {
                    return "HD0" + max.ToString();
                }
                return "HD" + max.ToString();
            
        }
        public void RemoveHD(HoaDon hoaDon)
        {
            db.HoaDons.Remove(hoaDon);
            db.SaveChanges();
        }
    }
}
