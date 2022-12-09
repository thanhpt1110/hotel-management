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
    public partial class FormQuenMatKhauNhapOTP : Form
    {
        private FormLogin formLoginParent;
        public FormQuenMatKhauNhapOTP(FormLogin formMain)
        {
            InitializeComponent();
            this.formLoginParent = formMain;
        }
        private bool checkOTPCorrect()
        {
            return true;
        }
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            if (checkOTPCorrect())
            {
                formLoginParent.openChildForm(new FormDatLaiMatKhau(formLoginParent));
            }
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            formLoginParent.openChildForm(new FormQuenMatKhauLayOTP(formLoginParent));
        }
    }
}
