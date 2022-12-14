using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class KhachHangBUS
    {
        
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            private set { instance = value; }
        }
        private KhachHangBUS() { }
        public List<KhachHang> GetKhachHangs()
        {
            return KhachHangDAO.Instance.GetKhachHangs();
        }
        public KhachHang FindKhachHang(string MaKH)
        {
            return KhachHangDAO.Instance.FindKhachHang(MaKH);
        }
        public void UpdateOrAdd(KhachHang khachHang)
        {
            KhachHangDAO.Instance.UpdateOrAdd(khachHang);
        }
        public void RemoveKH(KhachHang khachHang)
        {
            KhachHangDAO.Instance.RemoveKH(khachHang);
        }
        public List<KhachHang> FindKhachHangWithName(string TenKH)
        {
            return KhachHangDAO.Instance.FindKhachHangWithName(TenKH);
        }
        public string GetMaKHNext()
        {
            return KhachHangDAO.Instance.GetMaKHNext();
        }
        public KhachHang FindKHWithCCCD(string cccd)
        {
            return KhachHangDAO.Instance.FindKHWithCCCD(cccd);
        }
    }
}
