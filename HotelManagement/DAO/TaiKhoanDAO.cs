using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class TaiKhoanDAO
    {
        HotelDTO db = new HotelDTO();
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }

        public bool CheckLogin(string username, string password)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == username && p.Password == password).SingleOrDefault();
            if (tk == null)
                return false;
            return true;
        }
        public int GetQuyenTruyCap(string username)
        {
            TaiKhoan tk = db.TaiKhoans.Find(username);
            return tk.CapDoQuyen;
        }
        public List<TaiKhoan> GetTaiKhoans()
        {
            return db.TaiKhoans.ToList();
        }
        public List<TaiKhoan> GetTaiKhoansWithUserName(string username)
        {
            return db.TaiKhoans.Where(p=>p.TenTK.Contains(username)).ToList();  
        }    
    }
}
