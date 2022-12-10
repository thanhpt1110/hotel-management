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
using HotelManagement.BUS;
namespace HotelManagement.GUI
{
    public partial class FormDanhSachPhong : Form
    {
        private List<Phong> phongs;
        private Image PH = Properties.Resources.Phong;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        public FormDanhSachPhong()
        {
            InitializeComponent();
            LoadFullDataGrid();
        }

        private void CTButtonThemPhong_Click(object sender, EventArgs e)
        {
            using (FormThemPhong formThemPhong = new FormThemPhong())
                formThemPhong.ShowDialog();
        }

        private void FormDanhSachPhong_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);


            /*grid.Rows.Add(new object[] { PH, "PH001", "Trống", "Đang dọn dẹp", "Phòng đơn", edit, delete });
            grid.Rows.Add(new object[] { PH, "PH002", "Đang thuê", "Đã dọn dẹp", "Phòng đơn", edit, delete });
            grid.Rows.Add(new object[] { PH, "PH003", "Trống", "Đang dọn dẹp", "Phòng đôi", edit, delete });
            grid.Rows.Add(new object[] { PH, "PH004", "Đã đặt", "Đang dọn dẹp", "Phòng VIP", edit, delete });*/
        }

        public void LoadFullDataGrid()
        {
            this.phongs = PhongBUS.Instance.GetAllPhong();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            grid.Rows.Clear();
            foreach (Phong phong in this.phongs)
            {
                grid.Rows.Add(new object[] { PH, phong.MaPH, phong.TTPH, phong.MaPH, phong.LoaiPhong.TenLPH, edit, delete });
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
                    for (int i = 1; i < col - 2 + 1; i++)
                    {
                        if (i == 1) continue;
                        XcelApp.Cells[1, i - 1] = grid.Columns[i - 1].HeaderText;
                    }

                    // Get data of cells
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col - 2; j++)
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
            if (y >= 0)
            {
                // If click Update button 
                if (x == 5)
                {
                    using (FormSuaPhong formSuaPhong = new FormSuaPhong())
                    {
                        formSuaPhong.ShowDialog();
                    }
                }
                if (x == 6)
                {
                    // If click Delete button 
                    MessageBox.Show("Clicked Delete button");
                }
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            int[] arrX = { 1, 2, 3, 4 };
            bool isExists = false;

            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;

            if (y >= 0 && x == 5 || y >= 0 && x == 6 || y == -1 && isExists)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimPhongTheoMa__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxPhong = sender as TextBox;
            textBoxPhong.TextChanged += TextBoxPhong_TextChanged;
        }

        private void TextBoxPhong_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxPhong = sender as TextBox;

            if (textBoxPhong.Focused == false)
            {
                LoadFullDataGrid();
                return;
            }
            this.phongs = PhongBUS.Instance.FindPhongWithMaPH(textBoxPhong.Text);
            LoadDataGrid();
        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
