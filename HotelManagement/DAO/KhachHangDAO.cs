using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class KhachHangDAO
    {
        HotelDTO db = new HotelDTO();
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachHangDAO() { }
        
        public List<KhachHang> GetKhachHangs()
        {
            return db.KhachHangs.ToList();
        }
        public KhachHang FindKhachHang(string MaKH)
        {
            return db.KhachHangs.Find(MaKH);
        }
        public void UpdateOrAdd(KhachHang khachHang)
        {
            db.KhachHangs.AddOrUpdate(khachHang);
            db.SaveChanges();
        }    
        public void RemoveKH(KhachHang khachHang)
        {
            db.KhachHangs.Remove(khachHang);
            db.SaveChanges();
        }
        public List<KhachHang> FindKhachHangWithName(string TenKH)
        {
            return db.KhachHangs.Where(p => p.TenKH.Contains(TenKH)).ToList();
        }

    }
}
