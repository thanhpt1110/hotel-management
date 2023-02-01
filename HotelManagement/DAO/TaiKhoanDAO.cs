using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

                TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == username && p.Password == password && p.DaXoa == false).SingleOrDefault();
                if (tk == null)
                    return false;
                return true;
            
        }
        public int GetQuyenTruyCap(string username)
        {

            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == username && p.DaXoa == false).SingleOrDefault();
                return tk.CapDoQuyen;
            
        }
        public List<TaiKhoan> GetTaiKhoans()
        {

                return db.TaiKhoans.Where(p=>p.DaXoa==false).ToList();
            
        }
        public List<TaiKhoan> GetTaiKhoansWithUserName(string username)
        {

                return db.TaiKhoans.Where(p => p.TenTK.Contains(username)).ToList();
            
        }    
        public TaiKhoan GetTKDangNhap(string username)
        {
            HotelDTO db = new HotelDTO();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == username && p.DaXoa == false).SingleOrDefault();

            return tk;
            
        }
        public void AddOrUpdateTK(TaiKhoan taiKhoan)
        {
            try
            {
                taiKhoan.NhanVien = db.NhanViens.Find(taiKhoan.MaNV);
                taiKhoan.DaXoa = false;
                db.TaiKhoans.AddOrUpdate(taiKhoan);
                db.SaveChanges();
                instance = null;
            }
            catch(Exception)
            {
                db.TaiKhoans.Remove(taiKhoan);
            }
            
        }
        public void RemoveTk(TaiKhoan taiKhoan)
        {

                taiKhoan.DaXoa = true;
                db.TaiKhoans.AddOrUpdate(taiKhoan);
                db.SaveChanges();
                instance = null;

        }
        public TaiKhoan CheckLegit(string username,string email)
        {

                return db.TaiKhoans.Where(p => p.TenTK == username && p.NhanVien.Email == email && p.DaXoa==false).SingleOrDefault();
            
        }
        
    }
}
