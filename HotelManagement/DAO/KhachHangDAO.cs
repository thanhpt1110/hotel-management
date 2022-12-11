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
            if (khachHang.PhieuThues.ToList().Count>=1)
            {
                MessageBox.Show("Không thể xóa thông tin của khách hàng này", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            db.KhachHangs.Remove(khachHang);
            db.SaveChanges();
        }
        public List<KhachHang> FindKhachHangWithName(string TenKH)
        {
            return db.KhachHangs.Where(p => p.TenKH.Contains(TenKH)).ToList();
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
            else if(max <100)
            {
                return "KH0" + max.ToString();
            }    
            return "KH" + max.ToString();
        }
    }
}
