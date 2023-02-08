using HotelManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DTO;
using HotelManagement.CTControls;

namespace HotelManagement.GUI
{
    public partial class FormQuenMatKhauLayOTP : Form
    {
        string OTP = "ABC";
        string emailto;
        Random random = new Random();
        private FormLogin formLoginParent;
        public FormQuenMatKhauLayOTP(FormLogin formMain)
        {
            InitializeComponent();
            this.formLoginParent = formMain;
         }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            formLoginParent.openChildForm(new FormDangNhap(formLoginParent));
        }
        bool checkUsernameAndEmail()
        {
            return true;
        }
        private void ButtonLayOTP_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan taiKhoan = TaiKhoanBUS.Instance.CheckLegit(this.textBoxUsername.Texts, this.TextBoxEmail.Texts);
                if (taiKhoan!=null)
                {
                    formLoginParent.openChildForm(new FormQuenMatKhauNhapOTP(formLoginParent, this.TextBoxEmail.Texts, taiKhoan));
                }
                else
                {
                    CTMessageBox.Show("Email hoặc tài khoản đăng nhập của bạn bị sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
