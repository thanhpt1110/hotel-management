using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.CTControls;
namespace HotelManagement.DAO
{
    internal class CTDP_DAO
    {
        HotelDTO db = new HotelDTO();
        private static CTDP_DAO instance;
        public static CTDP_DAO Instance
        {
            get { if (instance == null) instance = new CTDP_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTDP_DAO() { }
        public List<CTDP> GetCTDPs()
        {
            using (HotelDTO db = new HotelDTO())
            {

                return db.CTDPs.ToList();
            }
        }

        public int getKhoangTG(string MaCTDP)
        {
            TimeSpan timeSpan = new TimeSpan();
            using (HotelDTO db = new HotelDTO())
            {
                DateTime checkin = new DateTime();
                DateTime checkout = new DateTime();
                CTDP ctdp = db.CTDPs.Find(MaCTDP);
                if (ctdp != null)
                {
                    checkin = ctdp.CheckIn;
                    checkout = ctdp.CheckOut;
                    timeSpan = checkout.Subtract(checkin);
                }
            }
                return timeSpan.Days;
        }
        public CTDP FindCTDP(string MaPhong, DateTime currentTime)
        {
          //  CTMessageBox.Show(currentTime.ToString());
                CTDP ctdp = db.CTDPs.Where(p => p.MaPH == MaPhong &&( (p.CheckIn <= currentTime &&  currentTime <= p.CheckOut)||p.CheckIn==currentTime)).SingleOrDefault();
                return ctdp;
            
        }
        public List<CTDP> getCTDPonTime(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {

                List<CTDP> listCTDP = db.CTDPs.ToList();
                if (DSPhongThem != null)
                {
                    foreach (var ctdp in DSPhongThem)
                    {
                        listCTDP.Add(ctdp);
                    }
                }
                var cTDPs = from p in listCTDP where (((Checkin >= p.CheckIn && Checkin <= p.CheckOut) || (p.CheckIn <= Checkout && Checkout <= p.CheckOut) || (Checkin >= p.CheckIn && Checkout <= p.CheckOut)) && p.TrangThai!="Đã xong") select p;

                List<CTDP> ctdpList = new List<CTDP>();
                foreach (var ctdp in cTDPs)
                {
                    ctdpList.Add(ctdp);
                }
                return ctdpList;
            
        }
        public string getNextCTDP()
        {

                List<CTDP> cTDPs = db.CTDPs.ToList();
                string MaMax = cTDPs[cTDPs.Count - 1].MaCTDP.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "CTDP00" + max.ToString();
                }
                else if (max >= 10)
                {
                    return "CTDP0" + max.ToString();
                }
                return "CTDP" + max.ToString();
           
        }
        public void UpdateOrAddCTDP(CTDP ctdp)
        { 
                ctdp.PhieuThue = db.PhieuThues.Find(ctdp.MaPT);
                 ctdp.Phong = db.Phongs.Find(ctdp.MaPH);
                ctdp.DaXoa = false;
                
                db.CTDPs.AddOrUpdate(ctdp);
                db.SaveChanges();
            
        }
        public string getNextCTDPwithList(List<CTDP> list)
        {

                List<CTDP> cTDPs = db.CTDPs.ToList();
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
                else if (max >= 10)
                {
                    return "CTDP0" + max.ToString();
                }
                return "CTDP" + max.ToString();      
        }

    }
}
