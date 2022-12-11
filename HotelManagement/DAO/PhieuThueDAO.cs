using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuThueDAO
    {
        HotelDTO db = new HotelDTO();
        private static PhieuThueDAO instance;
        public static PhieuThueDAO Instance
        {
            get { if (instance == null) instance = new PhieuThueDAO(); return instance; }
            private set { instance = value; }
        }
        private PhieuThueDAO() { }
        public List<PhieuThue> GetPhieuThues()
        {
            return db.PhieuThues.ToList();
        }
        public PhieuThue GetPhieuThue(string MaPT)
        {
            return db.PhieuThues.Find(MaPT);
        }
        public void UpdatePhieuThue(PhieuThue phieuThue)
        {
            db.PhieuThues.AddOrUpdate(phieuThue);
        }
        public List<PhieuThue> GetPhieuThuesWithNameCus(string name)
        {
            return db.PhieuThues.Where(p => p.KhachHang.TenKH.Contains(name)).ToList();
        }
        public string GetMaKHNext()
        {
            List<NhanVien> DV = db.NhanViens.ToList();
            string MaMax = DV[DV.Count - 1].MaNV.ToString();
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
        public void RemoveAllPhieuThueWithMaKH(List<PhieuThue> phieuThues)
        {
            if(phieuThues!=null)
                foreach(PhieuThue phieuThue in phieuThues)
                {
                    db.PhieuThues.Remove(phieuThue);
                }
            db.SaveChanges();
        }
    }
}
