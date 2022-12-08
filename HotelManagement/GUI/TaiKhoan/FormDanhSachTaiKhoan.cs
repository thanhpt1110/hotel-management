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
    public partial class FormDanhSachTaiKhoan : Form
    {
        private Image TK = Properties.Resources.TaiKhoan;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public FormDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void CTButtonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            using (FormThemTaiKhoan formThemTaiKhoan = new FormThemTaiKhoan())
            {
                formThemTaiKhoan.ShowDialog();
            }
        }

        private void FormDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);

            LoadAllGrid();
           /* grid.Rows.Add(new object[] { TK, "admin", "Phan Tuấn Thành", "1", edit, delete });
            grid.Rows.Add(new object[] { TK, "admin2", "Phan Tuấn Thành", "2", edit, delete });
            grid.Rows.Add(new object[] { TK, "xyz123", "Phan Tuấn Thành", "3", edit, delete });
            grid.Rows.Add(new object[] { TK, "abc123", "Phan Tuấn Thành", "3", edit, delete });*/
        }
        public void LoadAllGrid()
        {
            LoadGrid(TaiKhoanBUS.Instance.GetTaiKhoans());
        }   
        private void LoadGrid(List<TaiKhoan> taiKhoans)
        {
            grid.Rows.Clear();
            foreach(TaiKhoan taiKhoan in taiKhoans)
            {
                grid.Rows.Add(TK, taiKhoan.TenTK, taiKhoan.NhanVien.TenNV, taiKhoan.CapDoQuyen, edit, delete);
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
                if (x == 4)
                {
                    using (FormSuaTaiKhoan formSuaTaiKhoan = new FormSuaTaiKhoan())
                    {
                        formSuaTaiKhoan.ShowDialog();
                    }
                }
                if (x == 5)
                {
                    // If click Delete button 
                    MessageBox.Show("Clicked Delete button");
                }
            }
        }

        private void grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int curCol = e.ColumnIndex;
            if (curCol == 4 || curCol == 5)
            {
                if (e.RowIndex >= 0)
                    grid.Cursor = Cursors.Hand;
                else if (grid.CurrentCell.Value == DBNull.Value)
                    grid.Cursor = Cursors.Default;
            }
            else
                grid.Cursor = Cursors.Default;
        }
    }
}
