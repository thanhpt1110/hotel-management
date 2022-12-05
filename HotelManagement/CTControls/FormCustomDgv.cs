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
    }
}
