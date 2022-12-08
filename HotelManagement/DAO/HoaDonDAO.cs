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
            db.HoaDons.AddOrUpdate(HD);
            db.SaveChanges();
        }
        public List<HoaDon> FindHoaDonWith_CCCD(string cccd)
        {
            return db.HoaDons.Where(p => p.CTDP.PhieuThue.KhachHang.CCCD_Passport == cccd).ToList();
        }
    }
}
