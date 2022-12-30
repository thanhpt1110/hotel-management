using HotelManagement.CTControls;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                HotelDTO db = new HotelDTO();
                phieuThue.DaXoa = false;
                phieuThue.NhanVien = db.NhanViens.Find(phieuThue.MaNV);
                phieuThue.KhachHang = db.KhachHangs.Find(phieuThue.MaKH);
                db.PhieuThues.AddOrUpdate(phieuThue);
                db.SaveChanges();

            }
            catch (DbEntityValidationException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public List<PhieuThue> GetPhieuThuesWithNameCus(string name)
        {
            return db.PhieuThues.Where(p => p.KhachHang.TenKH.Contains(name)).ToList();
        }
        public string GetMaPTNext()
        {
            List<PhieuThue> PT = db.PhieuThues.ToList();
            string MaMax = PT[PT.Count - 1].MaPT.ToString();
            MaMax = MaMax.Substring(MaMax.Length - 3, 3);
            int max = int.Parse(MaMax);
            max++;
            if (max < 10)
            {
                return "PT00" + max.ToString();
            }
            else if (max < 100)
            {
                return "PT0" + max.ToString();
            }
            return "PT" + max.ToString();
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
