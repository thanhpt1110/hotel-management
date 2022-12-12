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
        public FormSoDoPhong()
        {
            InitializeComponent();
        }
        public FormSoDoPhong(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            LoadPhong();
        }
        public void LoadPhong()
        {
            List<CTRoomDaDat> roomDaDats = new List<CTRoomDaDat>();
            List<CTRoomDangSuaChua> roomDangSuaChuas = new List<CTRoomDangSuaChua>();
            List<CTRoomDangThue> roomDangThues = new List<CTRoomDangThue>();
            List<CTRoomTrong> roomTrongs = new List<CTRoomTrong>();
            this.flowPanelTang1.Controls.Clear();
            this.flowPanelTang2.Controls.Clear();
            this.flowPanelTang3.Controls.Clear();
            this.flowPanelTang4.Controls.Clear();
            this.flowPanelTang5.Controls.Clear();
            phongs = PhongBUS.Instance.GetAllPhong();

            foreach (Phong phong in phongs)
            {
                CTDP ctdp = CTDP_DAO.Instance.FindCTDP(phong.MaPH, TimePicker.Value.Date);
                if (phong.TTPH == "Bình thường" && ctdp != null)
                {
                    if (ctdp.TrangThai == "Đang thuê")
                    {
                        CTRoomDangThue room = new CTRoomDangThue(ctdp, this);

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
                    CTRoomDangSuaChua room = new CTRoomDangSuaChua(phong, this);

                    room.setMaPhong(phong.MaPH);
                    if (phong.TTDD == "Đã dọn dẹp")
                        room.setDaDonDep();
                    else
                        room.setChuaDonDep();
                    room.setGhiChu(phong.GhiChu);
                    room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                    roomDangSuaChuas.Add(room);

                }
                else if (phong.TTPH == "Bình thường" && ctdp == null)
                {
                    CTRoomTrong room = new CTRoomTrong(phong, this);
                    if (phong.TTDD == "Đã dọn dẹp")
                        room.setDaDonDep();
                    else
                        room.setChuaDonDep();
                    room.setMaPhong(phong.MaPH);
                    room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                    roomTrongs.Add(room);
                }
                if (phong.TTPH == "Bình thường" && ctdp != null)
                {
                    if (ctdp.TrangThai == "Đã đặt")
                    {
                        CTRoomDaDat room = new CTRoomDaDat(ctdp, this);
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
            }
            foreach (Phong phong in phongs)
            {
                foreach (CTRoomDangThue room in roomDangThues)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
                foreach (CTRoomTrong room in roomTrongs)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
                foreach (CTRoomDangSuaChua room in roomDangSuaChuas)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
                foreach (CTRoomDaDat room in roomDaDats)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
            }

        }
        private void LoadPhongFind()
        {

            List<CTRoomDaDat> roomDaDats = new List<CTRoomDaDat>();
            List<CTRoomDangSuaChua> roomDangSuaChuas = new List<CTRoomDangSuaChua>();
            List<CTRoomDangThue> roomDangThues = new List<CTRoomDangThue>();
            List<CTRoomTrong> roomTrongs = new List<CTRoomTrong>();
            this.flowPanelTang1.Controls.Clear();
            this.flowPanelTang2.Controls.Clear();
            this.flowPanelTang3.Controls.Clear();
            this.flowPanelTang4.Controls.Clear();
            this.flowPanelTang5.Controls.Clear();



            foreach (Phong phong in phongs)
            {
                CTDP ctdp = CTDP_DAO.Instance.FindCTDP(phong.MaPH, TimePicker.Value.Date);
                if (phong.TTPH == "Bình thường" && ctdp != null)
                {
                    if (ctdp.TrangThai == "Đang thuê")
                    {
                        CTRoomDangThue room = new CTRoomDangThue(ctdp, this);

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
                    CTRoomDangSuaChua room = new CTRoomDangSuaChua(phong, this);

                    room.setMaPhong(phong.MaPH);
                    if (phong.TTDD == "Đã dọn dẹp")
                        room.setDaDonDep();
                    else
                        room.setChuaDonDep();
                    room.setGhiChu(phong.GhiChu);
                    room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                    roomDangSuaChuas.Add(room);

                }
                else if (phong.TTPH == "Bình thường" && ctdp == null)
                {
                    CTRoomTrong room = new CTRoomTrong(phong, this);
                    if (phong.TTDD == "Đã dọn dẹp")
                        room.setDaDonDep();
                    else
                        room.setChuaDonDep();
                    room.setMaPhong(phong.MaPH);
                    room.setLoaiPhong(phong.LoaiPhong.TenLPH);
                    roomTrongs.Add(room);
                }
                if (phong.TTPH == "Bình thường" && ctdp != null)
                {
                    if (ctdp.TrangThai == "Đã đặt")
                    {
                        CTRoomDaDat room = new CTRoomDaDat(ctdp, this);
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
            }
            foreach (Phong phong in phongs)
            {
                foreach (CTRoomDangThue room in roomDangThues)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
                foreach (CTRoomTrong room in roomTrongs)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
                foreach (CTRoomDangSuaChua room in roomDangSuaChuas)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
                foreach (CTRoomDaDat room in roomDaDats)
                {
                    if (room.getMaPhong().StartsWith("P1") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang1.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P2") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang2.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P3") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang3.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P4") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang4.Controls.Add(room);
                    else if (room.getMaPhong().StartsWith("P5") && phong.MaPH == room.getMaPhong())
                        this.flowPanelTang5.Controls.Add(room);
                }
            }
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.LoadPhong();
        }

        private void ctTextBox1__TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.TextChanged += TextBox_TextChanged;

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            phongs = PhongBUS.Instance.FindPhongWithMaPH(textBox.Text);
            LoadPhongFind();
        }
    }
}
