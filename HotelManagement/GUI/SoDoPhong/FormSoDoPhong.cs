using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DTO;
using HotelManagement.BUS;
using HotelManagement.CTControls;
using HotelManagement.DAO;
using System.Net.NetworkInformation;



namespace HotelManagement.GUI
{
    public partial class FormSoDoPhong : Form
    {
        private FormMain formMain;
        List<Phong> phongs;
        TaiKhoan taiKhoan;
        public FormSoDoPhong()
        {
            InitializeComponent();
        }
        public FormSoDoPhong(FormMain formMain,TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.ctDatePicker1.Value = DateTime.Now;
            this.taiKhoan = taiKhoan;
            LoadLanDau();


        }
        #region Đặt phòng
        public void LoadAllPhong()
        {
            SetAppear();
            phongs = PhongBUS.Instance.GetAllPhong();
            LoadPhong(phongs);
        }
        public void LoadLanDau()
        {
            SetAppear();
            //this.ctDatePicker1.Value = DateTime.Now;
            phongs = PhongBUS.Instance.GetAllPhong();
            SetAppear();
            LoadPhong(phongs);
         

        }

        private void LoadPhong(List<Phong> phongs)
        {
            List<CTRoomDaDat> roomDaDats = new List<CTRoomDaDat>();
            List<CTRoomDangSuaChua> roomDangSuaChuas = new List<CTRoomDangSuaChua>();
            List<CTRoomDangThue> roomDangThues = new List<CTRoomDangThue>();
            List<CTRoomTrong> roomTrongs = new List<CTRoomTrong>();
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel2.Controls.Clear();
            this.flowLayoutPanel3.Controls.Clear();
            this.flowLayoutPanel4.Controls.Clear();
            this.flowLayoutPanel5.Controls.Clear();



            foreach (Phong phong in phongs)
            {
                CTDP ctdp = CTDP_DAO.Instance.FindCTDP(phong.MaPH, this.ctDatePicker1.Value);
                if (phong.TTPH == "Bình thường" && ctdp != null)
                {
                    if (ctdp.TrangThai == "Đang thuê")
                    {
                        CTRoomDangThue room = new CTRoomDangThue(ctdp, this, this.formMain);

                        room.setThoiGian(CTDP_BUS.Instance.getKhoangTG(ctdp.MaCTDP).ToString() + " Ngày");
                        if (phong.TTDD == "Đã dọn dẹp")
                            room.setDaDonDep();
                        else
                            room.setChuaDonDep();
                        room.setMaPhong(phong.MaPH);
                        room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                        roomDangThues.Add(room);
                    }
                }
                else if (phong.TTPH == "Đang sửa chữa")
                {
                    CTRoomDangSuaChua room = new CTRoomDangSuaChua(phong, this, this.formMain);

                    room.setMaPhong(phong.MaPH);
                    if (phong.TTDD == "Đã dọn dẹp")
                        room.setDaDonDep();
                    else
                        room.setChuaDonDep();
                    room.setGhiChu(phong.GhiChu);
                    room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                    roomDangSuaChuas.Add(room);

                }

                if (phong.TTPH == "Bình thường" && ctdp != null)
                {
                    if (ctdp.TrangThai == "Đã đặt")
                    {
                        CTRoomDaDat room = new CTRoomDaDat(ctdp, this, this.formMain,taiKhoan);
                        room.setThoiGian(CTDP_BUS.Instance.getKhoangTG(ctdp.MaCTDP).ToString() + " Ngày");

                        if (phong.TTDD == "Đã dọn dẹp")
                            room.setDaDonDep();
                        else
                            room.setChuaDonDep();
                        room.setMaPhong(phong.MaPH);
                        room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                        roomDaDats.Add(room);
                    }

                }
                if (phong.TTPH == "Bình thường" && (ctdp == null || ctdp.TrangThai=="Đã xong"))
                {
                    CTRoomTrong room = new CTRoomTrong(phong, this, this.formMain);
                    if (phong.TTDD == "Đã dọn dẹp")
                        room.setDaDonDep();
                    else
                        room.setChuaDonDep();
                    room.setMaPhong(phong.MaPH);
                    room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                    roomTrongs.Add(room);
                }
            }
            foreach (Phong phong in phongs)
            {
                foreach (CTRoomDangThue room in roomDangThues)
                {
                    room.Name = "PhongDangThue";
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel5.Controls.Add(room);
                }
                foreach (CTRoomTrong room in roomTrongs)
                {
                    room.Name = "PhongTrong";
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel5.Controls.Add(room);
                }
                foreach (CTRoomDangSuaChua room in roomDangSuaChuas)
                {
                    room.Name = "PhongSuaChua";
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel5.Controls.Add(room);
                }
                foreach (CTRoomDaDat room in roomDaDats)
                {
                    room.Name = "PhongDaDat";

                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowLayoutPanel5.Controls.Add(room);
                }
            }
        }

        #endregion

        private void ctTextBox1__TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text != "")
            {
                phongs = PhongBUS.Instance.FindPhongWithMaPH(textBox.Text);
                LoadPhong(phongs);

            }
            else
            {
                LoadAllPhong();
            }
                LoadCheckBoxPhong();

        }

        #region CheckBoxLoaiPhong
        private void HideCheckBoxPhongThue()
        {
            foreach(Control control in flowLayoutPanel1.Controls)
            {
                if(control.Name== "PhongDangThue")
                {
                    CTRoomDangThue cTRoomDangThue = control as CTRoomDangThue;
                    cTRoomDangThue.Hide();
                }    
               
            }
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control.Name == "PhongDangThue")
                {
                    CTRoomDangThue cTRoomDangThue = control as CTRoomDangThue;
                    cTRoomDangThue.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                if (control.Name == "PhongDangThue")
                {
                    CTRoomDangThue cTRoomDangThue = control as CTRoomDangThue;
                    cTRoomDangThue.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel4.Controls)
            {
                if (control.Name == "PhongDangThue")
                {
                    CTRoomDangThue cTRoomDangThue = control as CTRoomDangThue;
                    cTRoomDangThue.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel5.Controls)
            {
                if (control.Name == "PhongDangThue")
                {
                    CTRoomDangThue cTRoomDangThue = control as CTRoomDangThue;
                    cTRoomDangThue.Hide();
                }
            }
        }

        private void HideCheckBoxPhongTrong()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.Name == "PhongTrong")
                {
                    /*CTRoomTrong cTRoomTrong = control as CTRoomTrong;
                    cTRoomTrong.Hide();*/
                    control.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control.Name == "PhongTrong")
                {
                    /*CTRoomTrong cTRoomTrong = control as CTRoomTrong;
                    cTRoomTrong.Hide();*/
                    control.Hide();

                }
            }
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                if (control.Name == "PhongTrong")
                {
                    /* CTRoomTrong cTRoomTrong = control as CTRoomTrong;
                     cTRoomTrong.Hide();*/
                    control.Hide();

                }
            }
            foreach (Control control in flowLayoutPanel4.Controls)
            {
                if (control.Name == "PhongTrong")
                {
                    /*CTRoomTrong cTRoomTrong = control as CTRoomTrong;
                    cTRoomTrong.Hide();*/
                    control.Hide();

                }
            }
            foreach (Control control in flowLayoutPanel5.Controls)
            {
                if (control.Name == "PhongTrong")
                {
                    /*CTRoomTrong cTRoomTrong = control as CTRoomTrong;
                    cTRoomTrong.Hide();*/
                    control.Hide();

                }
            }
        }

        private void HideCheckBoxPhongSuaChua()
        {
            foreach(Control control in flowLayoutPanel1.Controls)
            {
                if (control.Name == "PhongSuaChua")
                {
                    CTRoomDangSuaChua cTRoomDangSuaChua = control as CTRoomDangSuaChua;
                    cTRoomDangSuaChua.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control.Name == "PhongSuaChua")
                {
                    CTRoomDangSuaChua cTRoomDangSuaChua = control as CTRoomDangSuaChua;
                    cTRoomDangSuaChua.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                if (control.Name == "PhongSuaChua")
                {
                    CTRoomDangSuaChua cTRoomDangSuaChua = control as CTRoomDangSuaChua;
                    cTRoomDangSuaChua.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel4.Controls)
            {
                if (control.Name == "PhongSuaChua")
                {
                    CTRoomDangSuaChua cTRoomDangSuaChua = control as CTRoomDangSuaChua;
                    cTRoomDangSuaChua.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel5.Controls)
            {
                if (control.Name == "PhongSuaChua")
                {
                    CTRoomDangSuaChua cTRoomDangSuaChua = control as CTRoomDangSuaChua;
                    cTRoomDangSuaChua.Hide();
                }
            }
        }

        private void HideCheckBoxPhongDaDat()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control.Name == "PhongDaDat")
                {
                    CTRoomDaDat cTRoomDaDat = control as CTRoomDaDat;
                    cTRoomDaDat.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control.Name == "PhongDaDat")
                {
                    CTRoomDaDat cTRoomDaDat = control as CTRoomDaDat;
                    cTRoomDaDat.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                if (control.Name == "PhongDaDat")
                {
                    CTRoomDaDat cTRoomDaDat = control as CTRoomDaDat;
                    cTRoomDaDat.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel4.Controls)
            {
                if (control.Name == "PhongDaDat")
                {
                    CTRoomDaDat cTRoomDaDat = control as CTRoomDaDat;
                    cTRoomDaDat.Hide();
                }
            }
            foreach (Control control in flowLayoutPanel5.Controls)
            {
                if (control.Name == "PhongDaDat")
                {
                    CTRoomDaDat cTRoomDaDat = control as CTRoomDaDat;
                    cTRoomDaDat.Hide();
                }
            }
        }

        private void ShowCheckBoxAll()
        {
            foreach(Control control in flowLayoutPanel1.Controls)
            {
                control.Show();
            }
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                control.Show();
            }
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                control.Show();
            }
            foreach (Control control in flowLayoutPanel4.Controls)
            {
                control.Show();
            }
            foreach (Control control in flowLayoutPanel5.Controls)
            {
                control.Show();
            }
        }

        private void LoadCheckBoxPhong()
        {
            //CheckBox checkBox = null;

            ShowCheckBoxAll();

            foreach (Control control in this.PanelRadioButtonTrangThaiPhong.Controls)
            {

                if (control.Name != "LabelTrangThaiPhong")
                {
                    CTRadioButton item = control as CTRadioButton;
                    if (item.Checked && item.Name == "CTRadioButtonPhongTrong")
                    {

                        HideCheckBoxPhongDaDat();
                        HideCheckBoxPhongThue();
                        HideCheckBoxPhongSuaChua();


                    }
                    else if (item.Checked && item.Name == "CTRadioButtonPhongDaDat")
                    {
                        HideCheckBoxPhongTrong();
                        HideCheckBoxPhongSuaChua();
                        HideCheckBoxPhongThue();

                    }
                    else if (item.Checked && item.Name == "CTRadioButtonPhongDangThue")
                    {
                        HideCheckBoxPhongDaDat();
                        HideCheckBoxPhongTrong();
                        HideCheckBoxPhongSuaChua();

                    }
                    else if (item.Checked && item.Name == "CTRadioButtonPhongDangSuaChua")
                    {
                        HideCheckBoxPhongDaDat();
                        HideCheckBoxPhongTrong();
                        HideCheckBoxPhongThue();

                    }
                    else if (item.Checked && item.Name == "CTRadioButtonTatCaPhong")
                    {
                        ShowCheckBoxAll();
                    }
                }
            }    
        }
        #endregion

        #region LoadLoaiPhong

        private void LoadPhongThuongDon()
        {
            phongs = phongs.Where(p => p.MaLPH == "NOR01").ToList();            
        }
        private void LoadPhongThuongDoi()
        {
            phongs = phongs.Where(p => p.MaLPH == "NOR02").ToList();

        }
        private void LoadPhongVipDon()
        {
            phongs = phongs.Where(p => p.MaLPH == "VIP01").ToList();

        }
        private void LoadPhongVipDoi()
        {
            phongs = phongs.Where(p => p.MaLPH == "VIP02").ToList();

        }
        private void LoadAddLoaiPhong()
        {
            phongs = PhongBUS.Instance.FindPhongWithMaPH(ctTextBox1.Texts);
        }

        private void LoadCheckBoxLoaiPhong()
        {
            foreach (Control control in this.PanelLoaiPhong.Controls)
            {

                if (control.Name != "LabelLoaiPhong")
                {
                    CTRadioButton item = control as CTRadioButton;
                    if(item.Checked && item.Name== "CTRadioButtonPhongThuongDon")
                    {
                        LoadPhongThuongDon();
                    }    
                    else if(item.Checked && item.Name == "CTRadioButtonPhongThuongDoi")
                    {
                        LoadPhongThuongDoi();
                    }    
                    else if(item.Checked && item.Name== "CTRadioButtonPhongVIPDon")
                    {
                        LoadPhongVipDon();
                    }
                    else if(item.Checked && item.Name == "CTRadioButtonPhongVIPDoi")
                    {
                        LoadPhongVipDoi();
                    }
                }
            }
        }

        #endregion


        #region TTDD
        private void LoadPhongDaDonDep()
        {
            phongs = phongs.Where(p => p.TTDD == "Đã dọn dẹp").ToList();
        }    
        private void LoadPhongChuaDonDep()
        {
            phongs = phongs.Where(p => p.TTDD == "Chưa dọn dẹp").ToList();
        }
        private void LoadCheckBoxTTDD()
        {
            foreach (Control control in this.PanelTinhTrangPhong.Controls)
            {

                if (control.Name != "LabelTinhTrangDonDep")
                {
                    CTRadioButton item = control as CTRadioButton;
                    if(item.Checked && item.Name== "CTRadioButtonDaDonDep")
                    {
                        LoadPhongDaDonDep();
                    }    
                    else if(item.Checked && item.Name == "CTRadioButtonChuaDonDep")
                    {
                        LoadPhongChuaDonDep();
                    }
                }
            }
        }
        private void ctDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            phongs = PhongBUS.Instance.GetAllPhong();
            phongs = PhongBUS.Instance.FindPhongWithMaPH(ctTextBox1.Texts);
            LoadCheckBoxLoaiPhong();
            LoadPhong(phongs);
            LoadCheckBoxPhong();
        }
        #endregion
        private void SetAppear()
        {
            panelSoDoPhong.Dock = DockStyle.None;
            panelSoDoPhong.Size = new Size(0, 0);
            timerAppear.Start();
        }

        private void timerAppear_Tick(object sender, EventArgs e)
        {
            panelSoDoPhong.Dock = DockStyle.Fill;
                timerAppear.Stop();
        }

        private void CTRadioButtonPhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            phongs = PhongBUS.Instance.FindPhongWithMaPH(ctTextBox1.Texts);
            SetAppear();
            LoadCheckBoxLoaiPhong();
            LoadCheckBoxTTDD();
            LoadPhong(phongs);
            LoadCheckBoxPhong();
        }
    }
}
