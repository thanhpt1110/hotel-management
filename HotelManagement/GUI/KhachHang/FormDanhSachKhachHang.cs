using HotelManagement.CTControls;
using HotelManagement.DTO;
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

namespace HotelManagement.GUI
{
    public partial class FormDanhSachKhachHang : Form
    {
        private Image KH = Properties.Resources.KhachHang;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }
        private void CTButtonThemKhachHang_Click(object sender, EventArgs e)
        {
            using (FormThemKhachHang formThemKhachHang = new FormThemKhachHang())
                formThemKhachHang.ShowDialog();
        }

        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);

            LoadAllGrid();
            /*grid.Rows.Add(new object[] { KH, "KH001", "Phan Tuấn Thành", "123456789101", "0956093276", "Việt Nam", "Nam", edit, delete });
            grid.Rows.Add(new object[] { KH, "KH002", "Trần Văn C", "123456789101", "0956093276", "Singapore", "Nữ", edit, delete });
            grid.Rows.Add(new object[] { KH, "KH003", "Nguyễn Thị B", "123456789101", "0956093276", "Thái Lan", "Nữ", edit, delete });
            grid.Rows.Add(new object[] { KH, "KH004", "Nguyễn Văn A", "123456789101", "0956093276", "Mỹ", "Nam", edit, delete });*/
        }
        public void LoadAllGrid()
        {
            LoadGrid(KhachHangBUS.Instance.GetKhachHangs());
                
        }    
        private void LoadGrid(List<KhachHang> khachHangs)
        {
            grid.Rows.Clear();
            foreach (KhachHang khachHang in khachHangs)
            {
                grid.Rows.Add(this.KH, khachHang.MaKH, khachHang.TenKH, khachHang.CCCD_Passport, khachHang.SDT, khachHang.QuocTich, khachHang.GioiTinh, edit, delete);
            }    
        }
        private void LoadGridWithCCCD()
        {
            List<KhachHang> khachHangs = KhachHangBUS.Instance.FindKhachHangWithName(this.CTTextBoxTimKhachHangTheoTen.Texts);
             LoadGrid(khachHangs);
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
                    for (int i = 1; i < col - 2 + 1; i++)
                    {
                        if (i == 1) continue;
                        XcelApp.Cells[1, i - 1] = grid.Columns[i - 1].HeaderText;
                    }

                    // Get data of cells
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col - 2; j++)
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
                    int x = 105, y = 60;
                    using (FormMessageBoxThongBao frm = new FormMessageBoxThongBao(mess, x, y))
                    {
                        frm.ShowDialog();
                    }
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
            if (y >= 0)
            {
                // If click Update button 
                if (x == 7)
                {
                    using (FormSuaKhachHang formSuaKhachHang = new FormSuaKhachHang())
                    {
                        formSuaKhachHang.ShowDialog();
                    }
                }
                if (x == 8)
                {
                    // If click Delete button 
                    MessageBox.Show("Clicked Delete button");
                }
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            int[] arrX = { 1, 5, 6 };
            bool isExists = false;

            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;

            if (y >= 0 && x == 7 || y >= 0 && x == 8 || y == -1 && isExists)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
