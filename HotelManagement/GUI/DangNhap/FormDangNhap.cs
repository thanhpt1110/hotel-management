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
    public partial class FormDangNhap : Form
    {
        private FormLogin formLoginParent;
        public FormDangNhap(FormLogin formMain)
        {
            InitializeComponent();
            formLoginParent = formMain;
        }
        
        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            formLoginParent.openChildForm(new FormQuenMatKhauLayOTP(formLoginParent));
            formLoginParent.bringControlBoxAndTBTLabelToFront();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(1);
            formLoginParent.Hide();
            formMain.ShowDialog();
            formLoginParent.Close();
        }
    }
}
