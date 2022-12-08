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

namespace HotelManagement.GUI
{
    public partial class FormDanhSachHoaDon : Form
    {
        public FormDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void FormDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            Image HD = Properties.Resources.HoaDon;
            Image details = Properties.Resources.details;

            //Test 
            grid.Rows.Add(new object[] { HD, "HD001", "11/10/2003 19:45:00", "Nguyễn Văn A", "Phan Tuấn Thành", "0", "Chưa thanh toán", details});
            grid.Rows.Add(new object[] { HD, "HD002", "11/10/2003 19:45:00", "Nguyễn Văn B", "Phan Tuấn Thành", "100,000", "Đã thanh toán", details});
            grid.Rows.Add(new object[] { HD, "HD003", "11/10/2003 19:45:00", "Nguyễn Văn C", "Phan Tuấn Thành", "2,000,000", "Chưa thanh toán", details});
            grid.Rows.Add(new object[] { HD, "HD004", "11/10/2003 19:45:00", "Nguyễn Văn D", "Phan Tuấn Thành", "0", "Đã thanh toán", details});
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
            // If click details button
            if (x == 7 && y >= 0)
            {
                using (FormHoaDon formHoaDon = new FormHoaDon())
                {
                    formHoaDon.ShowDialog();
                }
            }
        }

        private void grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int curCol = e.ColumnIndex;
            if (curCol == 7)
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
