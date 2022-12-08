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
    }
}
