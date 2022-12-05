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
    public partial class FormDanhSachKhachHang : Form
    {
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void CTButtonThemKhachHang_Click(object sender, EventArgs e)
        {
            FormThemKhachHang formThemKhachHang = new FormThemKhachHang();
            formThemKhachHang.ShowDialog();
        }
    }
}
