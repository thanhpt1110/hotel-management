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
    public partial class FormDanhSachDichVu : Form
    {
        public FormDanhSachDichVu()
        {
            InitializeComponent();
        }

        private void CTButtonThemDichVu_Click(object sender, EventArgs e)
        {
            FormThemDichVu formThemDichVu = new FormThemDichVu();
            formThemDichVu.ShowDialog();
        }
    }
}
