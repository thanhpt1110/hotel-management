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
    public partial class FormDanhSachTaiKhoan : Form
    {
        public FormDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void CTButtonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            /*using(FormThemTaiKhoan formThemTaiKhoan = new FormThemTaiKhoan())
            {
                formThemTaiKhoan.ShowDialog();
            }*/
            using(FormSuaTaiKhoan formSuaTaiKhoan = new FormSuaTaiKhoan())
            {
                formSuaTaiKhoan.ShowDialog();
            }
        }
    }
}
