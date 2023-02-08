using HotelManagement.CTControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BUS;
using HotelManagement.DTO;
using HotelManagement.DAO;

namespace HotelManagement.GUI
{
    public partial class FormDanhSachHoaDon : Form
    {
        private Image HD = Properties.Resources.HoaDon;
        private Image details = Properties.Resources.details;
        private FormMain formMain;
        private List<HoaDon> hoaDons;
        private bool reset = true;
        private DateTime dateTime = DateTime.Now;
        private string cccd = null;

        public FormDanhSachHoaDon()
        {
            InitializeComponent();
            LoadAllDataGrid();
        }

        public FormDanhSachHoaDon(FormMain formMain)
        {
            InitializeComponent();
            LoadAllDataGrid();
            this.formMain = formMain;
        }

        private void FormDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            /*  //Test 
              grid.Rows.Add(new object[] { HD, "HD001", "11/10/2003 19:45:00", "Nguyễn Văn A", "Phan Tuấn Thành", "0", "Chưa thanh toán", details});
              grid.Rows.Add(new object[] { HD, "HD002", "11/10/2003 19:45:00", "Nguyễn Văn B", "Phan Tuấn Thành", "100,000", "Đã thanh toán", details});
              grid.Rows.Add(new object[] { HD, "HD003", "11/10/2003 19:45:00", "Nguyễn Văn C", "Phan Tuấn Thành", "2,000,000", "Chưa thanh toán", details});
              grid.Rows.Add(new object[] { HD, "HD004", "11/10/2003 19:45:00", "Nguyễn Văn D", "Phan Tuấn Thành", "0", "Đã thanh toán", details});*/
        }

        public void LoadAllDataGrid()
        {
            try
            {
                hoaDons = HoaDonBUS.Instance.GetHoaDons();
                LoadDataGrid(hoaDons);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDataGrid(List<HoaDon> hoaDons)
        {
            DichVu dichvu;
            grid.Rows.Clear();
            try
            {
                foreach (HoaDon hoadon in hoaDons)
                {
                    //  int days = CTDP_BUS.Instance.getKhoangTGTheoNgay(hoadon.MaCTDP);
                    CTDP ctdp = CTDP_BUS.Instance.GetCTDPs().Where(p => p.MaCTDP == hoadon.MaCTDP).Single();
                    Phong phong = PhongBUS.Instance.FindePhong(ctdp.MaPH);
                    LoaiPhong loaiphong = LoaiPhongBUS.Instance.getLoaiPhong(phong.MaLPH);
                    string tennv = null;
                    List<CTDV> ctdvs = CTDV_BUS.Instance.FindCTDV(hoadon.MaHD);
                    foreach (CTDV ctdv in ctdvs)
                    {
                        dichvu = DichVuBUS.Instance.FindDichVu(ctdv.MaDV);
                    }
                    if (hoadon.MaNV != null)
                        tennv = hoadon.NhanVien.TenNV;
                    if (hoadon.TrangThai == "Đã thanh toán")
                    {
                        PhieuThue phieuThue = PhieuThueBUS.Instance.GetPhieuThue(ctdp.MaPT);
                        KhachHang khachHang = KhachHangBUS.Instance.GetKhachHangs().Where(p => p.MaKH == phieuThue.MaKH).Single();
                        grid.Rows.Add(HD, hoadon.MaHD, hoadon.NgHD, tennv, khachHang.TenKH, hoadon.TriGia.ToString("#,#"), hoadon.TrangThai, details);
                    }
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadGridWith_CCCD()
        {
            try
            {
                cccd = this.CTTextBoxTimTheoCCCD.Texts;
                hoaDons = HoaDonBUS.Instance.FindHoaDonWith_CCCD(cccd);
                LoadDataGrid(hoaDons);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            try

            {
                if (grid.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    int row = grid.Rows.Count;
                    int col = grid.Columns.Count;

                    // Get Header text of Column
                    for (int i = 1; i < col - 1 + 1; i++)
                    {
                        if (i == 1) continue;
                        XcelApp.Cells[1, i - 1] = grid.Columns[i - 1].HeaderText;
                    }

                    // Get data of cells
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col - 1; j++)
                        {
                            XcelApp.Cells[i + 2, j] = grid.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
                else
                {
                    string mess = "Chưa có dữ liệu trong bảng!";
                    CTMessageBox.Show(mess, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            // If click details button
            if (x == 7 && y >= 0)
            {
                try
                {
                    string MaHD = grid.Rows[y].Cells[1].Value.ToString();
                    HoaDon HD = HoaDonBUS.Instance.FindHD(MaHD);
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormHoaDon formHoaDon = new FormHoaDon(HD))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formHoaDon.Owner = formBackground;
                            formHoaDon.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { formBackground.Dispose(); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            int[] arrX = { 1, 2, 5, 6 };
            bool isExists = false;

            if (Array.IndexOf(arrX, x) != -1) 
                isExists = true; 

            if (y >= 0 && x == 7 || y == -1 && isExists)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimTheoCCCD__TextChanged(object sender, EventArgs e)
        {
            cccd = this.CTTextBoxTimTheoCCCD.Texts;
            dateTime = this.ctDatePicker1.Value;
            if (reset)
            {
                if (cccd != String.Empty)
                {
                    hoaDons = HoaDonBUS.Instance.FindHoaDonWith_CCCD(cccd);
                    LoadDataGrid(hoaDons);
                }
            }
            else
            {
                if (cccd == String.Empty)
                {
                    dateTime = this.ctDatePicker1.Value;
                    hoaDons = HoaDonBUS.Instance.FindHoaDonWith_Date(dateTime);
                    LoadDataGrid(hoaDons);
                }
                else
                {
                    hoaDons = HoaDonBUS.Instance.FindHoaDonWith_DateAndCCCD(dateTime, cccd);
                    LoadDataGrid(hoaDons);
                }
            }
        }

        private void ctDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            reset = false;
            dateTime = this.ctDatePicker1.Value;
            cccd = this.CTTextBoxTimTheoCCCD.Texts;

            if (this.CTTextBoxTimTheoCCCD.Texts == string.Empty)
            {
                hoaDons = HoaDonBUS.Instance.FindHoaDonWith_Date(dateTime);
                LoadDataGrid(hoaDons);
            }
            else
            {
                hoaDons = HoaDonBUS.Instance.FindHoaDonWith_DateAndCCCD(dateTime, cccd);
                LoadDataGrid(hoaDons);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ctDatePicker1.Value = DateTime.Now;
            reset = true;
            LoadAllDataGrid();
            CTTextBoxTimTheoCCCD.Texts = string.Empty;
        }
    }
}
