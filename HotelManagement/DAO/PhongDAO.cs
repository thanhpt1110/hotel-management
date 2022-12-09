using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhongDAO
    {
        HotelDTO db = new HotelDTO();
        private static PhongDAO instance;
        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        }
        private PhongDAO() { }
        public List<Phong> GetAllPhongs()
        {
            return db.Phongs.ToList();  
        }    
        public Phong FindPhong(string MaPh)
        {
            return db.Phongs.Find(MaPh);
        }
        public List<Phong> FindPhongWithMaPH(string MaPh)
        {
            return db.Phongs.Where(p => p.MaPH.Contains(MaPh)).ToList();
        }
    }
}
