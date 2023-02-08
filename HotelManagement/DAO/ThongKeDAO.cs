using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Security.Policy;

namespace HotelManagement.DAO
{
    internal class ThongKeDAO
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HotelDTO"].ConnectionString;
        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
        public struct DoanhThuTheoNgay
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }
        public struct SoPhongTheoNgay
        {
            public string Date { get; set; }
            public int TotalAmount { get; set; }
        }
        private DateTime ngayBD;
        private DateTime ngayKT;
        private int SoNgay;
        public List<KeyValuePair<string, int>> TopDichVuList { get; set; }
        public List<DoanhThuTheoNgay> DoanhThuThuongDonList { get; set; }
        public List<DoanhThuTheoNgay> DoanhThuThuongDoiList { get; set; }
        public List<DoanhThuTheoNgay> DoanhThuVipDonList { get; set; }
        public List<DoanhThuTheoNgay> DoanhThuVipDoiList { get; set; }
        public List<DoanhThuTheoNgay> DoanhThuDichVuList { get; set; }
        public List<SoPhongTheoNgay> SoPhongDatList { get; set; }
        public decimal TongDoanhThuThuongDon { get; set; }
        public decimal TongDoanhThuThuongDoi { get; set; }
        public decimal TongDoanhThuVipDon { get; set; }
        public decimal TongDoanhThuVipDoi { get; set; }
        public decimal TongDoanhThuThue { get; set; }
        public decimal TongDoanhThuDichVu { get; set; }
        public int SoPhongDat { get; set; }

        public string TenLoaiPhongDoanhThuCaoNhat { get; set; }
        public decimal DoanhThuLoaiPhongCaoNhat { get; set; }
        public string TenLoaiPhongDuocDatNhieuNhat { get; set; }
        public int SoLanLoaiPhongDatNhieuNhat { get; set; }
        public string TenDichVuDoanhThuCaoNhat { get; set; }
        public decimal DoanhThuDichVuCaoNhat { get; set; }

        public ThongKeDAO()
        {

        }

        public bool LoadData(DateTime ngayBD, DateTime ngayKT)
        {
            ngayBD = new DateTime(ngayBD.Year, ngayBD.Month, ngayBD.Day, 0, 0, 0);
            ngayKT = new DateTime(ngayKT.Year, ngayKT.Month, ngayKT.Day, 23, 59, 59);
            if (ngayBD != this.ngayBD || ngayKT != this.ngayKT)
            {
                this.ngayBD = ngayBD;
                this.ngayKT = ngayKT;
                this.SoNgay = (ngayKT - ngayBD).Days;
                //Các hàm GET data
                GetDoanhThuThuongDon();
                GetDoanhThuThuongDoi();
                GetDoanhThuVipDon();
                GetDoanhThuVipDoi();
                GetDoanhThuThue();
                GetDoanhThuDichVu();
                GetSoPhongDat();
                GetDichVuBieuDo();
                GetLoaiPhongDoanhThuCaoNhat();
                GetDichVuDoanhThuCaoNhat();
                GetLoaiPhongDatNhieuNhat();
                //
                Console.WriteLine("Refresh data: {0} - {1}", ngayBD.ToString(), ngayKT.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Date not refresheed, same query: {0} - {1}", ngayBD.ToString(), ngayKT.ToString());
                return false;
            }
        }
        private void GetDoanhThuThuongDon()
        {
            DoanhThuThuongDonList = new List<DoanhThuTheoNgay>();
            TongDoanhThuThuongDon = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select NgHD, SUM(ThanhTien)
                                              from HoaDon inner join CTDP
                                              on HoaDon.MaCTDP = CTDP.MaCTDP
                                              inner join Phong
                                              on Phong.MaPH = CTDP.MaPH
                                              inner join LoaiPhong
                                              on LoaiPhong.MaLPH = Phong.MaLPH
                                              where HoaDon.DaXoa = 0 and LoaiPhong.MaLPH = 'NOR01' and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán'
                                              group by NgHD
                                              order by NgHD asc
                                            ";
                    SqlDataReader reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TongDoanhThuThuongDon += (decimal)reader[1];
                    }

                    reader.Close();
                    //Group by Hours
                    if (SoNgay <= 1)
                    {
                        DoanhThuThuongDonList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                            into order
                                            select new DoanhThuTheoNgay
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Days
                    else if (SoNgay <= 30)
                    {
                        DoanhThuThuongDonList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new DoanhThuTheoNgay
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Weeks
                    else if (SoNgay <= 92)
                    {
                        DoanhThuThuongDonList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new DoanhThuTheoNgay
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Months
                    else if (SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        DoanhThuThuongDonList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new DoanhThuTheoNgay
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        DoanhThuThuongDonList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new DoanhThuTheoNgay
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }
        private void GetDoanhThuThuongDoi()
        {
            DoanhThuThuongDoiList = new List<DoanhThuTheoNgay>();
            TongDoanhThuThuongDoi = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select NgHD, SUM(ThanhTien)
                                              from HoaDon inner join CTDP
                                              on HoaDon.MaCTDP = CTDP.MaCTDP
                                              inner join Phong
                                              on Phong.MaPH = CTDP.MaPH
                                              inner join LoaiPhong
                                              on LoaiPhong.MaLPH = Phong.MaLPH
                                              where HoaDon.DaXoa = 0 and LoaiPhong.MaLPH = 'NOR02' and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán'
                                              group by NgHD, CTDP.CheckIn, CTDP.CheckOut
                                              order by NgHD asc
                                            ";
                    SqlDataReader reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TongDoanhThuThuongDoi += (decimal)reader[1];
                    }

                    reader.Close();
                    //Group by Hours
                    if (SoNgay <= 1)
                    {
                        DoanhThuThuongDoiList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("hh tt")
                                            into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Days
                    else if (SoNgay <= 30)
                    {
                        DoanhThuThuongDoiList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Weeks
                    else if (SoNgay <= 92)
                    {
                        DoanhThuThuongDoiList = (from orderList in resultTable
                                                 group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                     orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = "Week " + order.Key.ToString(),
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Months
                    else if (SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        DoanhThuThuongDoiList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        DoanhThuThuongDoiList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                }
            }
        }
        private void GetDoanhThuVipDon()
        {
            DoanhThuVipDonList = new List<DoanhThuTheoNgay>();
            TongDoanhThuVipDon = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select NgHD, SUM(ThanhTien)
                                              from HoaDon inner join CTDP
                                              on HoaDon.MaCTDP = CTDP.MaCTDP
                                              inner join Phong
                                              on Phong.MaPH = CTDP.MaPH
                                              inner join LoaiPhong
                                              on LoaiPhong.MaLPH = Phong.MaLPH
                                              where HoaDon.DaXoa = 0 and LoaiPhong.MaLPH = 'VIP01' and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán' 
                                              group by NgHD, CTDP.CheckIn, CTDP.CheckOut
                                              order by NgHD asc
                                            ";
                    SqlDataReader reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TongDoanhThuVipDon += (decimal)reader[1];
                    }

                    reader.Close();
                    //Group by Hours
                    if (SoNgay <= 1)
                    {
                        DoanhThuVipDonList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("hh tt")
                                            into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Days
                    else if (SoNgay <= 30)
                    {
                        DoanhThuVipDonList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Weeks
                    else if (SoNgay <= 92)
                    {
                        DoanhThuVipDonList = (from orderList in resultTable
                                                 group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                     orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = "Week " + order.Key.ToString(),
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Months
                    else if (SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        DoanhThuVipDonList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        DoanhThuVipDonList = (from orderList in resultTable
                                                 group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                                 select new DoanhThuTheoNgay
                                                 {
                                                     Date = order.Key,
                                                     TotalAmount = order.Sum(amount => amount.Value)
                                                 }).ToList();
                    }
                }
            }
        }
        private void GetDoanhThuVipDoi()
        {
            DoanhThuVipDoiList = new List<DoanhThuTheoNgay>();
            TongDoanhThuVipDoi = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select NgHD, SUM(ThanhTien)
                                              from HoaDon inner join CTDP
                                              on HoaDon.MaCTDP = CTDP.MaCTDP
                                              inner join Phong
                                              on Phong.MaPH = CTDP.MaPH
                                              inner join LoaiPhong
                                              on LoaiPhong.MaLPH = Phong.MaLPH
                                              where HoaDon.DaXoa = 0 and LoaiPhong.MaLPH = 'VIP02' and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán' 
                                              group by NgHD, CTDP.CheckIn, CTDP.CheckOut
                                              order by NgHD asc
                                            ";
                    SqlDataReader reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TongDoanhThuVipDoi += (decimal)reader[1];
                    }

                    reader.Close();
                    //Group by Hours
                    if (SoNgay <= 1)
                    {
                        DoanhThuVipDoiList = (from orderList in resultTable
                                              group orderList by orderList.Key.ToString("hh tt")
                                            into order
                                              select new DoanhThuTheoNgay
                                              {
                                                  Date = order.Key,
                                                  TotalAmount = order.Sum(amount => amount.Value)
                                              }).ToList();
                    }
                    //Group by Days
                    else if (SoNgay <= 30)
                    {
                        DoanhThuVipDoiList = (from orderList in resultTable
                                              group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                              select new DoanhThuTheoNgay
                                              {
                                                  Date = order.Key,
                                                  TotalAmount = order.Sum(amount => amount.Value)
                                              }).ToList();
                    }
                    //Group by Weeks
                    else if (SoNgay <= 92)
                    {
                        DoanhThuVipDoiList = (from orderList in resultTable
                                              group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                  orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                              select new DoanhThuTheoNgay
                                              {
                                                  Date = "Week " + order.Key.ToString(),
                                                  TotalAmount = order.Sum(amount => amount.Value)
                                              }).ToList();
                    }
                    //Group by Months
                    else if (SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        DoanhThuVipDoiList = (from orderList in resultTable
                                              group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                              select new DoanhThuTheoNgay
                                              {
                                                  Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                  TotalAmount = order.Sum(amount => amount.Value)
                                              }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        DoanhThuVipDoiList = (from orderList in resultTable
                                              group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                              select new DoanhThuTheoNgay
                                              {
                                                  Date = order.Key,
                                                  TotalAmount = order.Sum(amount => amount.Value)
                                              }).ToList();
                    }
                }
            }
        }
        private void GetDoanhThuThue()
        {
            TongDoanhThuThue = TongDoanhThuThuongDon + TongDoanhThuThuongDoi + TongDoanhThuVipDoi + TongDoanhThuVipDon;
        }
        private void GetDoanhThuDichVu()
        {
            DoanhThuDichVuList = new List<DoanhThuTheoNgay>();
            TongDoanhThuDichVu = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"select DichVu.MaDV, ThanhTien
                                            from CTDV inner join HoaDon
                                            on CTDV.MaCTDP = HoaDon.MaCTDP
                                            inner join DichVu
                                            on DichVu.MaDV = CTDV.MaDV
                                            where HoaDon.DaXoa = 0 and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán'
                                            group by DichVu.MaDV, NgHD, ThanhTien, HoaDon.MaHD
                                            order by NgHD asc
                                            ";
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TongDoanhThuDichVu += (decimal)reader[1];
                    }
                    reader.Close();
                }
            }
        }
        private void GetSoPhongDat()
        {
            SoPhongDat = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select NgPT, count(*) as SoPhongDat
                                              from PhieuThue inner join CTDP
                                              on CTDP.MaPT = PhieuThue.MaPT
                                              where PhieuThue.DaXoa = 0 and NgPT between @fromDate and @toDate
                                              group by NgPT, MaPH
                                              order by NgPT asc
                                            ";
                    SqlDataReader reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, int>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, int>((DateTime)reader[0], (int)reader[1])
                            );
                        SoPhongDat += (int)reader[1];
                    }

                    reader.Close();
                    //Group by Hours
                    if (SoNgay <= 1)
                    {
                        SoPhongDatList = (from orderList in resultTable
                                          group orderList by orderList.Key.ToString("hh tt")
                                            into order
                                          select new SoPhongTheoNgay
                                          {
                                              Date = order.Key,
                                              TotalAmount = order.Sum(amount => amount.Value)
                                          }).ToList();
                    }
                    //Group by Days
                    else if (SoNgay <= 30)
                    {
                        SoPhongDatList = (from orderList in resultTable
                                          group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                          select new SoPhongTheoNgay
                                          {
                                              Date = order.Key,
                                              TotalAmount = order.Sum(amount => amount.Value)
                                          }).ToList();
                    }
                    //Group by Weeks
                    else if (SoNgay <= 92)
                    {
                        SoPhongDatList = (from orderList in resultTable
                                          group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                              orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                          select new SoPhongTheoNgay
                                          {
                                              Date = "Week " + order.Key.ToString(),
                                              TotalAmount = order.Sum(amount => amount.Value)
                                          }).ToList();
                    }
                    //Group by Months
                    else if (SoNgay <= (365 * 2))
                    {
                        bool isYear = SoNgay <= 365 ? true : false;
                        SoPhongDatList = (from orderList in resultTable
                                          group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                          select new SoPhongTheoNgay
                                          {
                                              Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                              TotalAmount = order.Sum(amount => amount.Value)
                                          }).ToList();
                    }
                    //Group by Years
                    else
                    {
                        SoPhongDatList = (from orderList in resultTable
                                          group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                          select new SoPhongTheoNgay
                                          {
                                              Date = order.Key,
                                              TotalAmount = order.Sum(amount => amount.Value)
                                          }).ToList();
                    }
                    reader.Close();
                }
            }
        }
        private void GetDichVuBieuDo()
        {
            TopDichVuList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 Dich Vu
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select top 5 TenDV, SUM(SL) as SL
                                              from CTDV inner join HoaDon
                                              on CTDV.MaCTDP = HoaDon.MaCTDP
                                              inner join DichVu
                                              on DichVu.MaDV = CTDV.MaDV
                                              where HoaDon.DaXoa = 0 and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán'
                                              group by DichVu.MaDV, TenDV, SL, NgHD 
                                              order by NgHD asc";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopDichVuList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }
        private void GetLoaiPhongDoanhThuCaoNhat()
        {
            TenLoaiPhongDoanhThuCaoNhat = "";
            DoanhThuLoaiPhongCaoNhat = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 Dich Vu
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select top 1 TenLPH, HoaDon.TriGia
	                                          from HoaDon inner join CTDP
	                                          on HoaDon.MaCTDP = CTDP.MaCTDP
	                                          inner join Phong
	                                          on Phong.MaPH = CTDP.MaPH
	                                          inner join LoaiPhong
	                                          on LoaiPhong.MaLPH = Phong.MaLPH
                                              where HoaDon.DaXoa = 0 and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán'
	                                          group by LoaiPhong.MaLPH, TenLPH, HoaDon.TriGia
                                              order by TriGia desc";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TenLoaiPhongDoanhThuCaoNhat = (string)reader[0];
                        DoanhThuLoaiPhongCaoNhat = (decimal)reader[1];
                    }
                    reader.Close();
                }
            }
        }
        private void GetDichVuDoanhThuCaoNhat()
        {
            TenDichVuDoanhThuCaoNhat = "";
            DoanhThuDichVuCaoNhat = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 Dich Vu
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select top 1 TenDV, SUM(CTDV.DonGia)*SL as DoanhThu
                                              from DichVu inner join CTDV
                                              on DichVu.MaDV = CTDV.MaDV
                                              inner join HoaDon
                                              on CTDV.MaCTDP = HoaDon.MaCTDP
                                              where HoaDon.DaXoa = 0 and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán'
                                              group by TenDV, DichVu.MaDV, SL
                                              order by SUM(CTDV.DonGia)*SL desc";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TenDichVuDoanhThuCaoNhat = (string)reader[0];
                        DoanhThuDichVuCaoNhat = (decimal)reader[1];
                    }
                    reader.Close();
                }
            }
        }
        private void GetLoaiPhongDatNhieuNhat()
        {
            TenLoaiPhongDuocDatNhieuNhat = "";
            SoLanLoaiPhongDatNhieuNhat = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 Dich Vu
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = ngayBD;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = ngayKT;
                    command.CommandText = @"  select top 1 TenLPH, COUNT(CTDP.MaCTDP) AS SoLanDat
                                              from HoaDon inner join CTDP
                                              on HoaDon.MaCTDP = CTDP.MaCTDP
                                              inner join Phong 
                                              on CTDP.MaPH = Phong.MaPH
                                              inner join LoaiPhong
                                              on LoaiPhong.MaLPH = Phong.MaLPH
                                              where HoaDon.DaXoa = 0 and NgHD between @fromDate and @toDate and HoaDon.TrangThai = N'Đã thanh toán'
                                              group by TenLPH, LoaiPhong.MaLPH
                                              order by COUNT(CTDP.MaCTDP) desc";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TenLoaiPhongDuocDatNhieuNhat = (string)reader[0];
                        SoLanLoaiPhongDatNhieuNhat = (int)reader[1];
                    }
                    reader.Close();
                }
            }
        }
    }
}
