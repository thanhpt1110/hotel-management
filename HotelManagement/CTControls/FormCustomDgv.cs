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

namespace HotelManagement
{
    public partial class FormCustomDgv : Form
    {
        public FormCustomDgv()
        {
            InitializeComponent();
        }

        private void FormCustomDgv_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            Image PT = Properties.Resources.PhieuThue;
            Image details = Properties.Resources.details;
            Image delete = Properties.Resources.delete;

            //Test
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });

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
                    CTMessageBox.Show(mess, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
