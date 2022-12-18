using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.BUS;
using HotelManagement.CTControls; 

namespace HotelManagement.GUI
{
    public partial class FormDatLaiMatKhau : Form
    {
        private FormLogin formLoginParent;
        private TaiKhoan taiKhoan;
        public FormDatLaiMatKhau(FormLogin formMain)
        {
            InitializeComponent();
            this.formLoginParent = formMain;
        }
        public FormDatLaiMatKhau(FormLogin formMain,TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.formLoginParent = formMain;
            this.taiKhoan = taiKhoan;
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            formLoginParent.openChildForm(new FormQuenMatKhauNhapOTP(formLoginParent));
        }
        
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(this.textBoxPassword.Texts == "" && this.textBoxPassConfirm.Texts=="")
            {
                CTMessageBox.Show("Vui lòng nhập password", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }        
            if(this.textBoxPassword.Texts!=this.textBoxPassConfirm.Texts)
            {
                CTMessageBox.Show("Vui lòng kiểm tra lại password của bạn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                taiKhoan.Password=this.textBoxPassword.Texts;
                try
                {
                    TaiKhoanBUS.Instance.AddOrUpdateTK(taiKhoan);
                    CTMessageBox.Show("Đổi mật khẩu thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                catch (Exception ex)
                {
                    CTMessageBox.Show(ex.Message,"THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                formLoginParent.openChildForm(new FormDangNhap(formLoginParent));

            }
        }

        private void textBoxPassword__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxPassword = sender as TextBox;
            if (textBoxPassword.Focused == false)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }


        private void textBoxPassConfirm__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxPasswordConfirm = sender as TextBox;
            if (textBoxPasswordConfirm.Focused == false)
            {
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
        }

    }
}
