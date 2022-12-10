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
            mail.Subject = "Nhận mã OTP";
            // mail.From = new MailAddress(from);
            mail.Body = "Mã OTP của bạn là: " + OTP;
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
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (checkOTPCorrect())
            {
                formLoginParent.openChildForm(new FormDatLaiMatKhau(formLoginParent,this.taiKhoan));
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
