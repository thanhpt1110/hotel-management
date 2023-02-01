using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.DTO;
using HotelManagement.GUI;

namespace HotelManagement.CTControls
{
    public partial class CTRoom: UserControl
    {
        private string loaiPhong;
        private string maPhong;

        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
        }



        protected override void OnHandleCreated(EventArgs e)
        {
        }


        protected override void OnResize(EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CTRoom
            // 
            this.DoubleBuffered = true;
            this.Name = "CTRoom";
            this.Load += new System.EventHandler(this.CTRoom_Load);
            this.ResumeLayout(false);

        }

        private void CTRoom_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        public virtual string getMaPhong() { return null; }

        public virtual void setLoaiPhong(string LoaiPhong) { }
        public virtual void setMaPhong(string maPhong) { }
        public virtual void setTrangThai(string trangThai) { }
        public virtual void setThoiGianNone() { }
        public virtual void setThoiGian(string thoiGian) { }
        public virtual void setPhongTrong() { }
        public virtual void setChuaDonDep() { }
        public virtual void setDaDonDep() { }
        public virtual void setGhiChu(string ghiChu) { }
        //Private methods

    }
}
