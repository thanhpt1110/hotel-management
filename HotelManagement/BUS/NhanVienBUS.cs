using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get { if (instance == null) instance = new NhanVienBUS(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVien> GetAllNhanViens()
        {
            return NhanVienDAO.Instance.GetAllNhanViens();
        }
        private NhanVienBUS() { }
        public List<NhanVien> GetNhanViens()
        {
            return NhanVienDAO.Instance.GetNhanViens();
        }
        public NhanVien GetNhanVien(string MaNV)
        {
            return NhanVienDAO.Instance.GetNhanVien(MaNV);
        }
        public void UpdateOrInsert(NhanVien nhanVien)
        {
            NhanVienDAO.Instance.UpdateOrInsert(nhanVien);
        }
        public void RemoveNhanVien(NhanVien nhanVien)
        {
            NhanVienDAO.Instance.RemoveNhanVien(nhanVien);
        }
        public List<NhanVien> GetNhanViensWithName(string tenNV)
        {
            return NhanVienDAO.Instance.GetNhanViensWithName(tenNV);
        }
        public string GetMaNVNext()
        {
            return NhanVienDAO.Instance.GetMaNVNext();
        }
    }
}
