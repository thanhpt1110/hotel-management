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
    public partial class FormDanhSachChiTietTienNghi : Form
    {
        public FormDanhSachChiTietTienNghi()
        {
            InitializeComponent();
        }

        private void CTButtonThemChiTietTienNghi_Click(object sender, EventArgs e)
        {
            FormThemChiTietTienNghi formThemChiTietTienNghi = new FormThemChiTietTienNghi();
            formThemChiTietTienNghi.ShowDialog();
        }
    }
}
