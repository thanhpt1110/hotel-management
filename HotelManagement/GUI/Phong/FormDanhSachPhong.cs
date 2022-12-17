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
        private FormMain formMain;
        public FormDanhSachPhong()
        {
            InitializeComponent();
        }

        public FormDanhSachPhong(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void CTButtonThemPhong_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThemPhong formThemPhong = new FormThemPhong())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThemPhong.Owner = formBackground;
                    formThemPhong.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                LoadFullDataGrid();
                formBackground.Dispose(); 
            }
        }

        private void FormDanhSachPhong_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            LoadFullDataGrid();

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
                grid.Rows.Add(new object[] { PH, phong.MaPH, phong.TTPH, phong.TTDD, phong.LoaiPhong.TenLPH, edit, delete });
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
                    CTMessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        string MaPH = grid.Rows[y].Cells[1].Value.ToString();
                        using (FormSuaPhong formSuaPhong = new FormSuaPhong(PhongBUS.Instance.FindePhong(MaPH)))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formSuaPhong.Owner = formBackground;
                            formSuaPhong.ShowDialog();
                            this.LoadFullDataGrid();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                        LoadFullDataGrid();
                        formBackground.Dispose(); 
                    }
                }
                if (x == 6)
                {
                    // If click delete button
                    DialogResult dialogresult = CTMessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogresult == DialogResult.Yes)
                    {
                        try
                        {
                            // Function here
                        }
                        catch (Exception)
                        {
                            CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            this.LoadFullDataGrid();
                            CTMessageBox.Show("Xóa thông tin thành công.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

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

            if (textBoxPhong.Focused == false)
            {
                LoadFullDataGrid();
                return;
            }
            this.phongs = PhongBUS.Instance.FindPhongWithMaPH(textBoxPhong.Text);
            LoadDataGrid();
        }


        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }

        private void grid_Scroll(object sender, ScrollEventArgs e)
        {
            e.NewValue = 1;
        }
    }
}
