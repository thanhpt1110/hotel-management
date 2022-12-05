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
    public partial class FormDanhSachDatPhong : Form
    {
        public FormDanhSachDatPhong()
        {
            InitializeComponent();
        }

        private void CTButtonDatPhong_Click(object sender, EventArgs e)
        {
            FormDatPhong formDatPhong = new FormDatPhong();
            formDatPhong.ShowDialog();
        }
    }
}
