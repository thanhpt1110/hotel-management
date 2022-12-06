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
    public partial class FormDanhSachNhanVien : Form
    {
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void CTButtonThemNhanVien_Click(object sender, EventArgs e)
        {
            using(FormThemNhanVien formThemNhanVien = new FormThemNhanVien())
            {
                formThemNhanVien.ShowDialog();
            }
        }
    }
}
