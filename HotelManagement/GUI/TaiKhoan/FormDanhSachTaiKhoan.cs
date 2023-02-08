using HotelManagement.CTControls;
using HotelManagement.DTO;
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

namespace HotelManagement.GUI
{
    public partial class FormDanhSachTaiKhoan : Form
    {
        private Image TK = Properties.Resources.TaiKhoan;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        private List<TaiKhoan> taiKhoans;
        private FormMain formMain;
        public FormDanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        public FormDanhSachTaiKhoan(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void CTButtonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThemTaiKhoan formThemTaiKhoan = new FormThemTaiKhoan())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThemTaiKhoan.Owner = formBackground;
                    formThemTaiKhoan.ShowDialog();
                    formBackground.Dispose();
                }
                LoadAllGrid();
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                formBackground.Dispose(); 
            }
        }

        private void FormDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);

            LoadAllGrid();
           /* grid.Rows.Add(new object[] { TK, "admin", "Phan Tuấn Thành", "1", edit, delete });
            grid.Rows.Add(new object[] { TK, "admin2", "Phan Tuấn Thành", "2", edit, delete });
            grid.Rows.Add(new object[] { TK, "xyz123", "Phan Tuấn Thành", "3", edit, delete });
            grid.Rows.Add(new object[] { TK, "abc123", "Phan Tuấn Thành", "3", edit, delete });*/
        }

        public void LoadAllGrid()
        {
            try
            {
                this.taiKhoans = TaiKhoanBUS.Instance.GetTaiKhoans();
                LoadGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void LoadGrid()
        {
            try
            {
                grid.Rows.Clear();
                foreach(TaiKhoan taiKhoan in this.taiKhoans)
                {
                    grid.Rows.Add(TK, taiKhoan.TenTK, taiKhoan.NhanVien.TenNV, taiKhoan.CapDoQuyen, edit, delete);
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (x == 4)
                {
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormSuaTaiKhoan formSuaTaiKhoan = new FormSuaTaiKhoan(TaiKhoanBUS.Instance.GetTKDangNhap(grid.Rows[y].Cells[1].Value.ToString())))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formSuaTaiKhoan.Owner = formBackground;
                            formSuaTaiKhoan.ShowDialog();
                            this.LoadAllGrid();
                            this.CTTextBoxTimTheoTenTaiKhoan.Texts = "";
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { formBackground.Dispose(); }
                }
                if (x == 5)
                {
                    // If click Delete button 
                    DialogResult dialogresult = CTMessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogresult == DialogResult.Yes)
                    {
                        try
                        {
                            TaiKhoan taiKhoan = TaiKhoanBUS.Instance.GetTKDangNhap(grid.Rows[y].Cells[1].Value.ToString());
                            TaiKhoanBUS.Instance.RemoveTk(taiKhoan);
                            LoadAllGrid();
                            CTMessageBox.Show("Xóa thông tin thành công.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            
                        }
                    }

                }
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            if (y >= 0 && x == 4 || y >= 0 && x == 5 || y == -1 && x == 3)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimTheoTenTaiKhoan__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxTaiKhoan = sender as TextBox;

            if (textBoxTaiKhoan.Focused == false)
            {
                LoadAllGrid();
                return;
            }
            this.taiKhoans = TaiKhoanBUS.Instance.GetTaiKhoansWithUserName(textBoxTaiKhoan.Text);
            LoadGrid();
        }

        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
