﻿using HotelManagement.DTO;
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
namespace HotelManagement.GUI.ThongKe
{
    public partial class FormThongKe : Form
    {
        private FormMain formMain;
        public FormThongKe()
        {
            InitializeComponent();
        }
        public FormThongKe(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ngày hóa đơn";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "VND";
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 1;
  

        }

        private void setButtonNormal()
        {
            ButtonTuyChon.BackColor
                = ButtonHomNay.BackColor
                = Button7Ngay.BackColor
                = Button30Ngay.BackColor 
                = Button6Thang.BackColor = Color.FromArgb(207, 236, 236);
            ButtonTuyChon.ForeColor
                = ButtonHomNay.ForeColor
                = Button7Ngay.ForeColor
                = Button30Ngay.ForeColor
                = Button6Thang.ForeColor = Color.Black;
        }
        private void ButtonTuyChon_Click(object sender, EventArgs e)
        {
            setButtonNormal();
            ButtonTuyChon.BackColor = Color.FromArgb(30, 119, 148);
            ButtonTuyChon.ForeColor = Color.White;
        }

        private void ButtonHomNay_Click(object sender, EventArgs e)
        {
            setButtonNormal();
            ButtonHomNay.BackColor = Color.FromArgb(30, 119, 148);
            ButtonHomNay.ForeColor = Color.White;
        }

        private void Button7Ngay_Click(object sender, EventArgs e)
        {
            setButtonNormal();
            Button7Ngay.BackColor = Color.FromArgb(30, 119, 148);
            Button7Ngay.ForeColor = Color.White;
        }

        private void Button30Ngay_Click(object sender, EventArgs e)
        {
            setButtonNormal();
            Button30Ngay.BackColor = Color.FromArgb(30, 119, 148);
            Button30Ngay.ForeColor = Color.White;
        }

        private void Button6Thang_Click(object sender, EventArgs e)
        {
            setButtonNormal();
            Button6Thang.BackColor = Color.FromArgb(30, 119, 148);
            Button6Thang.ForeColor = Color.White;
        }


    }
}
