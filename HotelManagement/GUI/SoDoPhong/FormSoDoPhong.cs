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
            LoadAllPhong();
        }
        #region Đặt phòng
        public void LoadAllPhong()
        {
            SetAppear();
            phongs = PhongBUS.Instance.GetAllPhong();
            LoadPhong(phongs);
        }

        private void LoadPhong(List<Phong> phongs)
        {
            SetAppear();
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
                        CTRoomDangThue room = new CTRoomDangThue(ctdp, this,this.formMain);

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
                if (phong.TTPH == "Bình thường" && ctdp == null)
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
            phongs = PhongBUS.Instance.FindPhongWithMaPH(textBox.Text);
            LoadPhong(phongs);
        }



        private void ctDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.LoadAllPhong();
        }

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

        private void ctTimePicker1_Load(object sender, EventArgs e)
        {

        }
    }
}
