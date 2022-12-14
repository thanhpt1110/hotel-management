using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
using HotelManagement.DTO;

namespace HotelManagement.BUS
{
    internal class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) instance = new TaiKhoanBUS(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanBUS() { }

        public bool checkLogin(string username, string password)
        {
            return TaiKhoanDAO.Instance.CheckLogin(username, password);
        }
        public int getQuyenTruyCap(string username)
        {
            return TaiKhoanDAO.Instance.GetQuyenTruyCap(username);
        }
        public List<TaiKhoan> GetTaiKhoans()
        {
            return TaiKhoanDAO.Instance.GetTaiKhoans();
        }
        public List<TaiKhoan> GetTaiKhoansWithUserName(string username)
        {
            return TaiKhoanDAO.Instance.GetTaiKhoansWithUserName(username);
        }
        public TaiKhoan CheckLegit(string username, string email)
        {
            return TaiKhoanDAO.Instance.CheckLegit(username, email);
        }
        public void AddOrUpdateTK(TaiKhoan taiKhoan)
        {
            TaiKhoanDAO.Instance.AddOrUpdateTK(taiKhoan);
        }
        public void RemoveTk(TaiKhoan taiKhoan)
        {
            TaiKhoanDAO.Instance.RemoveTk(taiKhoan);
        }
        public TaiKhoan GetTKDangNhap(string username)
        {
            return TaiKhoanDAO.Instance.GetTKDangNhap(username);
        }
    }
}
