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
    public partial class FormDanhSachLoaiPhong : Form
    {
        public FormDanhSachLoaiPhong()
        {
            InitializeComponent();
        }

        private void CTButtonThemLoaiPhong_Click(object sender, EventArgs e)
        {
            FormThemLoaiPhong formThemLoaiPhong = new FormThemLoaiPhong();
            formThemLoaiPhong.ShowDialog();
        }
    }
}
