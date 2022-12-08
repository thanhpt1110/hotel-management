using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class NhanVienDAO
    {
        HotelDTO db = new HotelDTO();
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        private NhanVienDAO() { }
        
        public List<NhanVien> GetNhanViens()
        {
            return db.NhanViens.ToList();
        }
        public NhanVien GetNhanVien(string MaNV)
        {
            return db.NhanViens.Find(MaNV);
        }
        public void UpdateOrInsert(NhanVien nhanVien)
        {
            db.NhanViens.AddOrUpdate(nhanVien);
        }
        public void RemoveNhanVien(NhanVien nhanVien)
        {
            db.NhanViens.Remove(nhanVien);
        }
    }
}
