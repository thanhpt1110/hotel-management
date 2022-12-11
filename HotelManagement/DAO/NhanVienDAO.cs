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
        public List<NhanVien> GetNhanViensWithName(string tenNV)
        {
            return db.NhanViens.Where(p => p.TenNV.Contains(tenNV)).ToList();
        }
        public string GetMaKHNext()
        {
            List<NhanVien> NV = db.NhanViens.ToList();
            string MaMax = NV[NV.Count - 1].MaNV.ToString();
            MaMax = MaMax.Substring(MaMax.Length - 3, 3);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "NV00" + max.ToString();
            }
            else if (max < 100)
            {
                return "NV0" + max.ToString();
            }
            return "NV" + max.ToString();
        }
    }
}
