﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
namespace HotelManagement.BUS
{
    internal class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) instance = new TaiKhoanBUS(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanBUS() { }

        public bool checkLogin(string username,string password)
        {
            return TaiKhoanDAO.Instance.CheckLogin(username, password);
        }
        public int getQuyenTruyCap(string username)
        {
            return TaiKhoanDAO.Instance.GetQuyenTruyCap(username);
        }
    }
}