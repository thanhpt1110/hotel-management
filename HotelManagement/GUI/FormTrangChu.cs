using HotelManagement.CTControls;
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
    public partial class FormTrangChu : Form
    {
        private FormMain formMain;
        public FormTrangChu()
        {
            InitializeComponent();
        }
        public FormTrangChu(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void CTButtonTest_Click(object sender, EventArgs e)
        {
            CTMessageBox.Show("Sinh viên khoa công nghệ phần mềm - Đại học Công Nghệ Thông Tin - Đại học Quốc gia Thành Phố Hồ Chí Minh","Thông báo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }
    }
}
