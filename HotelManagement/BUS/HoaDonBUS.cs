using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    internal class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get { if (instance == null) instance = new HoaDonBUS(); return instance; }
            private set { instance = value; }
        }
        private HoaDonBUS() { }
        public List<HoaDon> GetHoaDons()
        {
            return HoaDonDAO.Instance.GetHoaDons();
        }
        public HoaDon FindHD(string MaHD)
        {
            return HoaDonDAO.Instance.FindHD(MaHD);
        }
        public void Update_Inserthd(HoaDon HD)
        {
            HoaDonDAO.Instance.Update_InsertHD(HD);
        }
        public List<HoaDon> FindHoaDonWith_CCCD(string cccd)
        {
            return HoaDonDAO.Instance.FindHoaDonWith_CCCD(cccd);
        }
        public List<HoaDon> FindHoaDonWith_DateAndCCCD(DateTime dateTime, string cccd)
        {
            return HoaDonDAO.Instance.FindHoaDonWith_DateAndCCCD(dateTime, cccd);
        }
        public string getMaHDNext()
        {
            return HoaDonDAO.Instance.getMaHDNext();
        }
        public void ThanhToanHD(HoaDon HD)
        {
            HoaDonDAO.Instance.ThanhToanHD(HD);
        }
        public void RemoveHD(HoaDon hd)
        {
            HoaDonDAO.Instance.RemoveHD(hd);
        }
        public List<HoaDon> FindHoaDonWith_Date(DateTime dateTime)
        {
            return HoaDonDAO.Instance.FindHoaDonWith_Date(dateTime);
        }
    }
}
