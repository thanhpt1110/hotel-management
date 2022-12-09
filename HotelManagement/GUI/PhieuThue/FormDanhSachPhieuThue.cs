using HotelManagement.BUS;
using HotelManagement.CTControls;
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
using HotelManagement.DAO;

namespace HotelManagement.GUI
{
    public partial class FormDanhSachPhieuThue : Form
    {
        private Image PT = Properties.Resources.PhieuThueDgv;
        private Image details = Properties.Resources.details;
        private List<PhieuThue> phieuThues;
        public FormDanhSachPhieuThue()
        {
            InitializeComponent();
        }

        private void CTButtonDatPhong_Click(object sender, EventArgs e)
        {
            using (FormDatPhong formDatPhong = new FormDatPhong())
                formDatPhong.ShowDialog();
        }

        private void FormDanhSachPhieuThue_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);


            /*            grid.Rows.Add(new object[] { PT, "PT001", "Phan Tuấn Thành", "10/11/2003 15:45:00", "Nguyễn Văn Anh", details});
                        grid.Rows.Add(new object[] { PT, "PT002", "Nguyễn Phúc Bình", "10/11/2003 15:45:00", "Nguyễn Văn Anh",  details});
                        grid.Rows.Add(new object[] {PT, "PT003", "Lê Thanh Tuấn", "10/11/2003 15:45:00", "Nguyễn Văn Anh", details});
                        grid.Rows.Add(new object[] {PT, "PT004", "Phan Tuấn Thành", "10/11/2003 15:45:00", "Nguyễn Văn Anh", details });*/
            LoadFullDataGrid();
        }

        public void LoadFullDataGrid()
        {
            phieuThues = PhieuThueBUS.Instance.GetPhieuThues();
            LoadDataGrid();
        }    
        public void LoadDataGrid()
        {
            this.grid.Rows.Clear();
            foreach (PhieuThue phieuThue in phieuThues)
            {
                grid.Rows.Add(new object[] { PT, phieuThue.MaPT,phieuThue.KhachHang.TenKH,String.Format("dd/MM/yyyy HH:mm:ss" , phieuThue.NgPT),phieuThue.NhanVien.TenNV,details});
            }
        }    
        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    int row = grid.Rows.Count;
                    int col = grid.Columns.Count;

                    // Get Header text of Column
                    for (int i = 1; i < col - 1 + 1; i++)
                    {
                        if (i == 1) continue;
                        XcelApp.Cells[1, i - 1] = grid.Columns[i - 1].HeaderText;
                    }

                    // Get data of cells
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col - 1; j++)
                        {
                            XcelApp.Cells[i + 2, j] = grid.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
                else
                {
                    string mess = "Chưa có dữ liệu trong bảng!";
                    int x = 105, y = 60;
                    using (FormMessageBoxThongBao frm = new FormMessageBoxThongBao(mess, x, y))
                    {
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            // If click details button
            if (y >= 0 && x == 5)
            {
                using (FormChiTietPhieuThue formChiTietPhieuThue = new FormChiTietPhieuThue())
                    formChiTietPhieuThue.ShowDialog();
            }
        }

        private void grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int curCol = e.ColumnIndex;
            if (curCol == 5)
            {
                if (e.RowIndex >= 0)
                    grid.Cursor = Cursors.Hand;
                else if (grid.CurrentCell.Value == DBNull.Value)
                    grid.Cursor = Cursors.Default;
            }
            else
                grid.Cursor = Cursors.Default;
        }

        private void ctTextBox1__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxPT = sender as TextBox;
            textBoxPT.TextChanged += TextBoxPT_TextChanged;
        }

        private void TextBoxPT_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxPT = sender as TextBox;

            if (textBoxPT.Focused == false)
            {
                LoadFullDataGrid();
                return;
            }
            this.phieuThues = PhieuThueBUS.Instance.GetPhieuThuesWithNameCus(textBoxPT.Text);
            LoadDataGrid();
        }
    }
}
