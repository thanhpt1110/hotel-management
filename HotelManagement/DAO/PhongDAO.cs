using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

                return db.Phongs.Where(p => p.DaXoa == false).ToList();
            
        }    
        public Phong FindPhong(string MaPh)
        {

                return db.Phongs.Find(MaPh);
            
        }
        public List<Phong> FindPhongWithMaPH(string MaPh)
        {

                return db.Phongs.Where(p => p.MaPH.Contains(MaPh) && p.DaXoa == false).ToList();
            
        }

        public void UpdateOrAdd(Phong phong)
        {

                phong.LoaiPhong = db.LoaiPhongs.Find(phong.MaLPH);
                phong.DaXoa = false;
                db.Phongs.AddOrUpdate(phong);
                db.SaveChanges();
            
        }
        public void RemovePhong(string maPH)
        {
            Phong phong = db.Phongs.Find(maPH);
            phong.DaXoa = true;
            db.Phongs.AddOrUpdate(phong);
            db.SaveChanges();
        }
        public List<Phong> FindPhongTrong(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {

                List<CTDP> cTDPs = CTDP_DAO.Instance.getCTDPonTime(Checkin, Checkout, DSPhongThem).Where(p=>p.TrangThai!= "Đã hủy" || p.TrangThai!="Đã xong").ToList();
                //List<Phong> PhongKhongTrong = new List<Phong>();
                var MaPh = cTDPs.Select(p => p.Phong.MaPH).ToList();
                List<Phong> phongs = db.Phongs.Where(p=>p.DaXoa==false).ToList();
                List<Phong> phongtrong = new List<Phong>();
                for (int i = 0; i < phongs.Count; i++)
                {
                    int flag = 0;
                    foreach (CTDP cTDP in cTDPs)
                    {
                        if (phongs[i].MaPH == cTDP.MaPH)
                            flag = 1;
                    }
                    if (flag == 0)
                    {
                        phongtrong.Add(phongs[i]);
                    }
                }
                return phongtrong;
            
        }
        public bool FindPhongTrong(CTDP room)
        {

                List<CTDP> cTDPs = CTDP_DAO.Instance.getCTDPonTime(room.CheckIn, room.CheckOut, null);
                //List<Phong> PhongKhongTrong = new List<Phong>();
                var MaPh = cTDPs.Select(p => p.Phong.MaPH).ToList();
                List<Phong> phongs = db.Phongs.Where(p=>p.TTDD!="Đang sửa chữa").ToList();
                List<Phong> phongtrong = new List<Phong>();
                for (int i = 0; i < phongs.Count; i++)
                {
                    int flag = 0;
                    foreach (CTDP cTDP in cTDPs)
                    {
                        if (phongs[i].MaPH == cTDP.MaPH)
                            flag = 1;
                    }
                    if (flag == 0)
                    {
                        phongtrong.Add(phongs[i]);
                    }
                }
                foreach (Phong phong in phongtrong)
                {
                    if (phong.MaPH == room.MaPH)
                        return true;
                }
                return false;
            
        }

    }
}
