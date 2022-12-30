using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.CTControls;

namespace HotelManagement.DAO
{
    internal class KhachHangDAO
    {
        private HotelDTO db = new HotelDTO();
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) { instance = new KhachHangDAO(); } ; return instance; }
            private set { instance = value; }
        }




        private KhachHangDAO() { db = new HotelDTO(); }

        public List<KhachHang> GetKhachHangs()
        {

                return db.KhachHangs.Where(p => p.DaXoa == false).ToList();
            
        }
        public KhachHang FindKhachHang(string MaKH)
        {

                return db.KhachHangs.Find(MaKH);
            
        }
        public void UpdateOrAdd(KhachHang khachHang)
        {
            try
            {
                khachHang.DaXoa = false;
                db.KhachHangs.AddOrUpdate(khachHang);
               db.SaveChanges();
                instance = null;

            }
            catch (DbEntityValidationException ex)
            {
                CTMessageBox.Show(ex.Message);
            }
            
        }
        public void RemoveKH(KhachHang khachHang)
        {

                khachHang.DaXoa = true;
                db.KhachHangs.AddOrUpdate(khachHang);
                db.SaveChanges();
            
        }
        public List<KhachHang> FindKhachHangWithName(string TenKH)
        {

                return db.KhachHangs.Where(p => p.TenKH.Contains(TenKH) && p.DaXoa == false).ToList();
            
        }
        public string GetMaKHNext()
        {

                List<KhachHang> KH = db.KhachHangs.ToList();
                string MaMax = KH[KH.Count - 1].MaKH.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "KH00" + max.ToString();
                }
                else if (max < 100)
                {
                    return "KH0" + max.ToString();
                }
                return "KH" + max.ToString();
            
        }
        public KhachHang FindKHWithCCCD(string cccd)
        {

                return db.KhachHangs.Where(p => p.CCCD_Passport == cccd).SingleOrDefault();
            
        }
    }
}
