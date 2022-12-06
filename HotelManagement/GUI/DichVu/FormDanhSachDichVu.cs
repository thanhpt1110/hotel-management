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
    public partial class FormDanhSachDichVu : Form
    {
        public FormDanhSachDichVu()
        {
            InitializeComponent();
        }

        private void CTButtonThemDichVu_Click(object sender, EventArgs e)
        {
            FormThemDichVu formThemDichVu = new FormThemDichVu();
            formThemDichVu.ShowDialog();
        }

        private void FormDanhSachDichVu_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            Image DV = Properties.Resources.DichVuDgv;
            Image edit = Properties.Resources.edit;
            Image delete = Properties.Resources.delete;

            //Test 
            grid.Rows.Add(new object[] { DV, "DV001", "Pepsi", "10,000", "100", edit, delete });
            grid.Rows.Add(new object[] { DV, "DV002", "Mì xào", "20,000", "55", edit, delete });
            grid.Rows.Add(new object[] { DV, "DV003", "Bún bò", "25,000", "20", edit, delete });
            grid.Rows.Add(new object[] { DV, "DV004", "Karaoke", "300,000", "10", edit, delete });
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
                if (x == 5)
                {
                    MessageBox.Show("Clicked Update button");
                }
                if (x == 6)
                {
                    // If click Delete button 
                    MessageBox.Show("Clicked Delete button");
                }
            }
        }

        private void grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int curCol = e.ColumnIndex;
            if (curCol == 5 || curCol == 6)
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
