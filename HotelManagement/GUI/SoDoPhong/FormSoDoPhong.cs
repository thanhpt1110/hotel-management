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
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement.GUI
{
    public partial class FormSoDoPhong : Form
    {
        private FormMain formMain;
        private List<Phong> phongs;
        private TaiKhoan taiKhoan;
        private DateTime dateTime = DateTime.Now;

        public FormSoDoPhong()
        {
            InitializeComponent();
        }

        public FormSoDoPhong(FormMain formMain,TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.taiKhoan = taiKhoan;
            LoadLanDau();
        }


        #region Load sơ đồ phòng
        public void LoadAllPhong()
        {
            try
            {
                phongs = PhongBUS.Instance.GetAllPhong();
                LoadPhong(phongs);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadLanDau()
        {
            try
            {
                //this.ctDatePicker1.Value = DateTime.Now;
                phongs = PhongBUS.Instance.GetAllPhong();
                LoadPhong(phongs);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPhong(List<Phong> phongs)
        {
            try
            {
                List<CTRoom> DSPhong = new List<CTRoom>();


                foreach (Phong phong in phongs)
                {
                    CTDP ctdp = CTDP_DAO.Instance.FindCTDP(phong.MaPH, this.dateTime);
                    if (phong.TTPH == "Bình thường" && ctdp != null)
                    {
                        if (ctdp.TrangThai == "Đang thuê" && (this.CTRadioButtonPhongDangThue.Checked || this.CTRadioButtonTatCaPhong.Checked))
                        {
                            CTRoomDangThue room = new CTRoomDangThue(ctdp, this, this.formMain, this.taiKhoan);
                            room.Name = "PhongSDangThue";
                            if (ctdp.TheoGio == false)
                                room.setThoiGian(CTDP_BUS.Instance.getKhoangTGTheoNgay(ctdp.MaCTDP).ToString() + " Ngày");
                            else
                                room.setThoiGian(CTDP_BUS.Instance.getKhoangTGTheoGio(ctdp.MaCTDP).ToString() + " Giờ");
                            if (phong.TTDD == "Đã dọn dẹp")
                                room.setDaDonDep();
                            else
                                room.setChuaDonDep();
                            room.setMaPhong(phong.MaPH);
                            room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                            DSPhong.Add(room);
                        }
                    }
                    else if (phong.TTPH == "Đang sửa chữa" && (this.CTRadioButtonPhongDangSuaChua.Checked || this.CTRadioButtonTatCaPhong.Checked))
                    {
                        CTRoomDangSuaChua room = new CTRoomDangSuaChua(phong, this, this.formMain);
                        room.Name = "PhongSuaChua";
                        room.setMaPhong(phong.MaPH);
                        if (phong.TTDD == "Đã dọn dẹp")
                            room.setDaDonDep();
                        else
                            room.setChuaDonDep();
                        room.setGhiChu(phong.GhiChu);
                        room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                        DSPhong.Add(room);

                    }

                    if (phong.TTPH == "Bình thường" && ctdp != null)
                    {
                        if (ctdp.TrangThai == "Đã đặt" && (this.CTRadioButtonPhongDaDat.Checked || this.CTRadioButtonTatCaPhong.Checked))
                        {
                            CTRoomDaDat room = new CTRoomDaDat(ctdp, this, this.formMain, taiKhoan);
                            if (ctdp.TheoGio == false)
                                room.setThoiGian(CTDP_BUS.Instance.getKhoangTGTheoNgay(ctdp.MaCTDP).ToString() + " Ngày");
                            else
                                room.setThoiGian(CTDP_BUS.Instance.getKhoangTGTheoGio(ctdp.MaCTDP).ToString() + " Giờ");
                            room.Name = "PhongDaDat";
                            if (phong.TTDD == "Đã dọn dẹp")
                                room.setDaDonDep();
                            else
                                room.setChuaDonDep();
                            room.setMaPhong(phong.MaPH);
                            room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                            DSPhong.Add(room);
                        }

                    }
                    if (phong.TTPH == "Bình thường" && (ctdp == null || ctdp.TrangThai == "Đã xong") && (this.CTRadioButtonPhongTrong.Checked || this.CTRadioButtonTatCaPhong.Checked))
                    {
                        CTRoomTrong room = new CTRoomTrong(phong, this, this.formMain, taiKhoan);
                        room.Name = "PhongTrong";
                        if (phong.TTDD == "Đã dọn dẹp")
                            room.setDaDonDep();
                        else
                            room.setChuaDonDep();
                        room.setMaPhong(phong.MaPH);
                        room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                        DSPhong.Add(room);
                    }
                }
                this.flowLayoutPanel1.Controls.Clear();
                this.flowLayoutPanel2.Controls.Clear();
                this.flowLayoutPanel3.Controls.Clear();
                this.flowLayoutPanel4.Controls.Clear();
                this.flowLayoutPanel5.Controls.Clear();
                foreach (CTRoom cTRoom in DSPhong)
                {
                        
                    if (cTRoom.MaPhong.StartsWith("P1"))
                    {
                        flowLayoutPanel1.Controls.Add(cTRoom);
                    }
                    else if (cTRoom.MaPhong.StartsWith("P2"))
                    {
                        flowLayoutPanel2.Controls.Add(cTRoom);
                    }
                    else if (cTRoom.MaPhong.StartsWith("P3"))
                    {
                        flowLayoutPanel3.Controls.Add(cTRoom);
                    }
                    else if (cTRoom.MaPhong.StartsWith("P4"))
                    {
                        flowLayoutPanel4.Controls.Add(cTRoom);
                    }
                    else if (cTRoom.MaPhong.StartsWith("P5"))
                    {
                        flowLayoutPanel5.Controls.Add(cTRoom);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void ctTextBox1__TextChanged(object sender, EventArgs e)
        {
            if(this.ctTextBox1.Texts!=null)
                ResetTimer(this.timerSearch);
        }

        private  void ResetTimer(Timer timer)
        {
            /*if(flag1==1)
            {
                flag1 = 0;
                return;
            }  */  
            timer.Stop();
            timer.Start();         
        }
        #region Process event radio button
        private void CTRadioButtonPhongTrong_CheckedChanged(object sender, EventArgs e)
        {
            // SetAppear();
            this.label1.Hide();
            this.panelSoDoPhong.Hide();
            LoadAddLoaiPhong();
            LoadCheckBoxLoaiPhong();
            LoadCheckBoxTTDD();
            this.label1.Show();
            this.panelSoDoPhong.Show();
            LoadPhong(phongs);
        }

 
        private void LoadCheckBoxPhong()
        {
         /*   //CheckBox checkBox = null;

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
            }    */
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
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetAppear()
        {
/*            panelSoDoPhong.Dock = DockStyle.None;
            panelSoDoPhong.Size = new Size(0, 0);
            timerAppear.Start();*/
        }

        private void timerAppear_Tick(object sender, EventArgs e)
        {
            panelSoDoPhong.Dock = DockStyle.Fill;
                timerAppear.Stop();
        }
        #endregion

        #region Date and time value changed
        private void setDate(DateTime dateTime)
        {
            this.dateTime = dateTime.Date;
        }

        private void setTime(string Time, string Letter)
        {
            Letter = Letter.Trim(' ');
            string[] time = Time.Split(':');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);
            if (Letter == "AM" && hour == 12 || Letter == "PM" && hour != 12)
                hour += 12;

            TimeSpan ts = new TimeSpan(hour, minute, 0);
            this.dateTime += ts;
        }

        private void cbBoxGio_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setDate(ctDatePicker1.Value);
            setTime(cbBoxGio.Texts, cbBoxLetter.Texts);
            phongs = PhongBUS.Instance.GetAllPhong();
            phongs = PhongBUS.Instance.FindPhongWithMaPH(ctTextBox1.Texts);
            LoadCheckBoxLoaiPhong();
            LoadPhong(phongs);
            LoadCheckBoxPhong();
        }

        private void cbBoxLetter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            setDate(ctDatePicker1.Value);
            setTime(cbBoxGio.Texts, cbBoxLetter.Texts);
            phongs = PhongBUS.Instance.GetAllPhong();
            phongs = PhongBUS.Instance.FindPhongWithMaPH(ctTextBox1.Texts);
            LoadCheckBoxLoaiPhong();
            LoadPhong(phongs);
            LoadCheckBoxPhong();
        }

        private void ctDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            setDate(ctDatePicker1.Value);
            setTime(cbBoxGio.Texts, cbBoxLetter.Texts);
            phongs = PhongBUS.Instance.GetAllPhong();
            phongs = PhongBUS.Instance.FindPhongWithMaPH(ctTextBox1.Texts);
            LoadCheckBoxLoaiPhong();
            LoadPhong(phongs);
            LoadCheckBoxPhong();
        }
        #endregion

        private void setLoadComboBox(DateTime datetime)
        {
            datetime = this.dateTime;
            int iHour  = datetime.Hour; string strHour = null;
            int iMinute = datetime.Minute; string strMinute = null;
            string letter = null;
            if (iHour > 12)
            {
                iHour -= 12;
                letter = "   PM";
            }
            else if (iHour == 12)
                letter = "   PM";
            else if (iHour < 12)
            {
                if (iHour == 0)
                    iHour = 12;
                letter = "   AM";
            }
            strHour = iHour.ToString();
            strMinute = iMinute.ToString();
            if (strMinute.Length == 1) 
                strMinute = "0" + strMinute;
            if (strHour.Length == 1)
                strHour = "0" + strHour;
            cbBoxGio.Texts = strHour + ':' + strMinute;
            cbBoxLetter.Texts = letter;
        }

        private void FormSoDoPhong_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1;
            setLoadComboBox(dateTime);
        }

        private void timerSearch_Tick(object sender, EventArgs e)
        {
            this.timerSearch.Stop();
            this.label1.Hide();
            this.panelSoDoPhong.Hide();
            LoadAddLoaiPhong();
            LoadCheckBoxLoaiPhong();
            LoadCheckBoxTTDD();
            this.label1.Show();
            this.panelSoDoPhong.Show();
            LoadPhong(phongs);
        }

    }
}
