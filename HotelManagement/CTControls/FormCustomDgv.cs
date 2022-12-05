using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

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
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });
            grid.Rows.Add(new object[] { PT, "PT001", "11/10/2003 19:45:00", "Phan Tuấn Thành", "Phan Tuấn Thành", details, delete });
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);

                // Custom properties
                //XcelApp.Columns.ColumnWidth = 20;

                // 2 biến i, j tự custom lại theo Datagridview của form đó
                // Get Header text of Column
                for (int i = 1; i < grid.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = grid.Columns[i - 1].HeaderText;
                }

                // Get data of cells
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    for (int j = 0; j < grid.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }
    }
}
