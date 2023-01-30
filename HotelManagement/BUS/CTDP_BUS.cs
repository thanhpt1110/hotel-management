using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.BUS
{
    internal class CTDP_BUS
    {
        private static CTDP_BUS instance;
        public static CTDP_BUS Instance
        {
            get { if (instance == null) instance = new CTDP_BUS(); return instance; }
            private set { instance = value; }
        }
        private CTDP_BUS() { }
        public List<CTDP> GetCTDPs() // Lấy tất cả CTDP
        {
            return CTDP_DAO.Instance.GetCTDPs();
        }
        public int getKhoangTGTheoNgay(string MaCTDP) // Lấy thời gian ở của khách hàng tại 1 phòng nào đó
        {
            return CTDP_DAO.Instance.getKhoangTGTheoNgay(MaCTDP);
        }
        public int getKhoangTGTheoGio(string MaCTDP) // Lấy thời gian ở của khách hàng tại 1 phòng nào đó
        {
            return CTDP_DAO.Instance.getKhoangTGTheoGio(MaCTDP);
        }
        public CTDP FindCTDP(string MaPhong, DateTime currentTime) // Tìm Mã phòng theo 
        {
            return CTDP_DAO.Instance.FindCTDP(MaPhong, currentTime);
        }
        public List<CTDP> getCTDPonTime(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {
            return CTDP_DAO.Instance.getCTDPonTime(Checkin, Checkout, DSPhongThem);
        }
        public string getNextCTDP()
        {
            return CTDP_DAO.Instance.getNextCTDP();
        }
        public void UpdateOrAddCTDP(CTDP ctdp)
        {
            CTDP_DAO.Instance.UpdateOrAddCTDP(ctdp);
        }
        public string getNextCTDPwithList(List<CTDP> list)
        {
            return CTDP_DAO.Instance.getNextCTDPwithList(list);
        }
        public void RemoveCTDP(CTDP cTDP)
        {
            CTDP_DAO.Instance.RemoveCTDP(cTDP);
        }    
    }
}
