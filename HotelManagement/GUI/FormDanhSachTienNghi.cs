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
    public partial class FormDanhSachTienNghi : Form
    {
        public FormDanhSachTienNghi()
        {
            InitializeComponent();
        }

        private void CTButtonThemTienNghi_Click(object sender, EventArgs e)
        {
            FormThemTienNghi formThemTienNghi = new FormThemTienNghi();
            formThemTienNghi.ShowDialog();
        }
    }
}
