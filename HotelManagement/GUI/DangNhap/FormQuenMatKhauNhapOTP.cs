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
using static System.Net.WebRequestMethods;
using HotelManagement.DTO;
using HotelManagement.CTControls;

namespace HotelManagement.GUI
{
    public partial class FormQuenMatKhauNhapOTP : Form
    {
        private string OTP = "ABC";
        private string emailto;
        private Random random = new Random();
        private FormLogin formLoginParent;
        private TaiKhoan taiKhoan;
        int time = 60;
        public FormQuenMatKhauNhapOTP(FormLogin formMain)
        { 
            this.formLoginParent = formMain;
             InitializeComponent();
        }
        public FormQuenMatKhauNhapOTP(FormLogin formMain,string emailto=null, TaiKhoan taiKhoan=null)
        {
            InitializeComponent();
            this.formLoginParent = formMain;
            this.emailto = emailto;
            this.taiKhoan=taiKhoan;
            LoadOTP();
        }
        void LoadOTP()
        {
            time = 60;
            this.ButtonResend.Enabled = false;
            timer1.Start();
            this.OTP = random.Next(10000, 99999).ToString();
            MailMessage mail = new MailMessage("tbtcooperation@gmail.com", emailto);
            string pass;

            pass = "rmlppremfdeqdfjt";
            mail.Subject = " Đặt lại mật khẩu tài khoản ứng dụng Quản lý khách sạn";
            // mail.From = new MailAddress(from);
            mail.IsBodyHtml = true;
            mail.Body = "<div style=\"font-family: Helvetica,Arial,sans-serif;min-width:1000px;overflow:auto;line-height:2\">\r\n  <div style=\"margin:50px auto;width:70%;padding:20px 0\">\r\n    <div style=\"border-bottom:1px solid #eee\">\r\n      <a href=\"\" style=\"font-size:1.4em;color: #00466a;text-decoration:none;font-weight:600\">Hotel Management</a>\r\n    </div>\r\n    <p style=\"font-size:1.1em\">Xin chào,</p>\r\n    <p>Đây là thư tự động gửi vào email. Vui lòng không trả lời thư này.<br> Dưới đây là mã OTP của bạn!</p>\r\n    <h2 style=\"background: #00466a;margin: 0 auto;width: max-content;padding: 0 10px;color: #fff;border-radius: 4px;\">"+  OTP +"</h2>\r\n    <p style=\"font-size:0.9em;\">Xin cảm ơn,<br />Hotel Management</p>\r\n    <hr style=\"border:none;border-top:1px solid #eee\" />\r\n    <div style=\"float:right;padding:8px 0;color:#aaa;font-size:0.8em;line-height:1;font-weight:300\">\r\n    </div>\r\n  </div>\r\n</div>";
               
                
            mail.To.Add(emailto);
            // Cấu hình gửi
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("tbtcooperation@gmail.com", pass);
            try
            {
                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                CTMessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   

        }
        private bool checkOTPCorrect()
        {
            if (this.textBoxOTP.Texts == OTP)
            {
                return true;
            }
            return false;
        }
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkOTPCorrect())
                {
                    formLoginParent.openChildForm(new FormDatLaiMatKhau(formLoginParent,this.taiKhoan));
                }
                else
                {
                    CTMessageBox.Show("Mã OTP bạn nhập chưa đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PictureBoxBack_Click(object sender, EventArgs e)
        {
            formLoginParent.openChildForm(new FormQuenMatKhauLayOTP(formLoginParent));
        }

        private void ButtonResend_Click(object sender, EventArgs e)
        {
            LoadOTP();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ButtonResend.Text = time.ToString();
            time--;
            if (this.time == 0)
            {
                timer1.Stop();
                this.ButtonResend.Enabled = true;
                this.ButtonResend.Text = "RESEND";
            }
        }
    }
}
