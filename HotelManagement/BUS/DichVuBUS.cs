using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    internal class DichVuBUS
    {
        private static DichVuBUS instance;
        public static DichVuBUS Instance
        {
            get { if (instance == null) instance = new DichVuBUS(); return instance; }
            private set { instance = value; }
        }
        private DichVuBUS() { }
        public List<DichVu> GetDichVus()
        {
            return DichVuDAO.Instance.GetDichVus();
        }
        public DichVu FindDichVu(string MaDV)
        {
            return DichVuDAO.Instance.FindDichVu(MaDV);     
        }
        public void UpdateORAdd(DichVu dv)
        {
            DichVuDAO.Instance.UpdateORAdd(dv);
        }
        public void RemoveDV(DichVu dv)
        { 
            DichVuDAO.Instance.RemoveDV(dv);
        }
        public string GetMaDVNext()
        {
           return DichVuDAO.Instance.GetMaDVNext();
        }
        public List<DichVu> FindDichVuWithName(string TenDV)
        {
            return DichVuDAO.Instance.FindDichVuWithName(TenDV);
        }
        public List<DichVu> GetDichVusConLai()
        {
            return DichVuDAO.Instance.GetDichVusConLai();
        }
        public DichVu FindDichVuWithNameAndDonGia(string TenDV, string DonGia)
        {
            return DichVuDAO.Instance.FindDichVuWithNameAndDonGia(TenDV, DonGia);
        }
        public void UpdateDV(List<DichVu> dichVus)
        {
            DichVuDAO.Instance.UpdateDV(dichVus);
        }    
    }
}
