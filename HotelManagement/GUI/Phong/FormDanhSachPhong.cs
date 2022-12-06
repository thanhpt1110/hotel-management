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
    public partial class FormDanhSachPhong : Form
    {
        public FormDanhSachPhong()
        {
            InitializeComponent();
        }

        private void CTButtonThemPhong_Click(object sender, EventArgs e)
        {
            FormThemPhong formThemPhong = new FormThemPhong();
            formThemPhong.ShowDialog();
        }
    }
}
