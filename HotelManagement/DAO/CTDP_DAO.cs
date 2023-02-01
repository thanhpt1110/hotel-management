using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.CTControls;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
    internal class CTDP_DAO
    {
        private static CTDP_DAO instance;
        public static CTDP_DAO Instance
        {
            get { if (instance == null) instance = new CTDP_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTDP_DAO() { }
        public List<CTDP> GetCTDPs()
        {
            HotelDTO db = new HotelDTO();
            return db.CTDPs.ToList();
        }   
        public int getKhoangTGTheoNgay(string MaCTDP)
        {
            CTDP ctdp;
            TimeSpan timeSpan = new TimeSpan();
            HotelDTO db = new HotelDTO();
            
                ctdp = db.CTDPs.Find(MaCTDP);
            
            DateTime checkin = new DateTime();
                DateTime checkout = new DateTime();
               
                if (ctdp != null)
                {
                    checkin = ctdp.CheckIn;
                    checkout = ctdp.CheckOut;
                    timeSpan = checkout.Subtract(checkin);
                }
              return timeSpan.Days;
        }
        public int getKhoangTGTheoGio(string MaCTDP)
        {
            CTDP ctdp;
            TimeSpan timeSpan = new TimeSpan();
            HotelDTO db = new HotelDTO();

            ctdp = db.CTDPs.Find(MaCTDP);

            DateTime checkin = new DateTime();
            DateTime checkout = new DateTime();

            if (ctdp != null)
            {
                checkin = ctdp.CheckIn;
                checkout = ctdp.CheckOut;
                timeSpan = checkout.Subtract(checkin);
            }
            return timeSpan.Hours;
        }
        public CTDP FindCTDP(string MaPhong, DateTime currentTime)
        {
                HotelDTO db = new HotelDTO();
                CTDP ctdp;
                ctdp = db.CTDPs.Where(p => p.MaPH == MaPhong && ((p.CheckIn <= currentTime && currentTime <= p.CheckOut) || p.CheckIn == currentTime) && p.TrangThai != "Đã xong" && p.TrangThai != "Đã hủy").SingleOrDefault();            
                return ctdp;
            
        }
        public List<CTDP> getCTDPonTime(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {
                
                List<CTDP> listCTDP;
                HotelDTO db = new HotelDTO();
                listCTDP= db.CTDPs.Where(p=>p.DaXoa==false).ToList();
                if (DSPhongThem != null)
                {
                    foreach (var ctdp in DSPhongThem)
                    {
                        listCTDP.Add(ctdp);
                    } 
                }
                var cTDPs = from p in listCTDP where (((Checkin >= p.CheckIn && Checkin <= p.CheckOut) || (p.CheckIn <= Checkout && Checkout <= p.CheckOut) || (Checkin <= p.CheckIn && Checkout >= p.CheckOut)) && (p.TrangThai!="Đã xong" &&  p.TrangThai!="Đã hủy") ) select p;

                List<CTDP> ctdpList = new List<CTDP>();
                foreach (var ctdp in cTDPs)
                {
                    ctdpList.Add(ctdp);
                }
                return ctdpList;
            
        }
        public string getNextCTDP()
        {
                List<CTDP> cTDPs;
                HotelDTO db = new HotelDTO();      
                cTDPs = db.CTDPs.ToList();
                string MaMax = cTDPs[cTDPs.Count - 1].MaCTDP.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "CTDP00" + max.ToString();
                }
                else if (max < 100)
                {
                    return "CTDP0" + max.ToString();
                }
                return "CTDP" + max.ToString();
           
        }
        public void UpdateOrAddCTDP(CTDP ctdp)
        {
            try
            {
                HotelDTO db = new HotelDTO();
                
                    ctdp.PhieuThue = db.PhieuThues.Find(ctdp.MaPT);
                    ctdp.Phong = db.Phongs.Find(ctdp.MaPH);
                    ctdp.DaXoa = false;
                    db.CTDPs.AddOrUpdate(ctdp);
                    db.SaveChanges();
                
                    instance = null;
                db.Dispose();

            }
            catch (Exception)
            {
               
            }
        }
        public void RemoveCTDP(CTDP cTDP)
        {
            HotelDTO db = new HotelDTO();
                
                cTDP.DaXoa = true;
                db.CTDPs.AddOrUpdate(cTDP);
                db.SaveChanges();

        }
        public string getNextCTDPwithList(List<CTDP> list)
        {
            List<CTDP> cTDPs;
            HotelDTO db = new HotelDTO();

            cTDPs = db.CTDPs.ToList();       
                if (list.Count > 0)
                {
                    foreach (var ctdp in list)
                    {
                        cTDPs.Add(ctdp);
                    }
                }
                string MaMax = cTDPs[cTDPs.Count - 1].MaCTDP.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "CTDP00" + max.ToString();
                }
                else if (max < 100)
                {
                    return "CTDP0" + max.ToString();
                }
                return "CTDP" + max.ToString();      
        }

    }
}
