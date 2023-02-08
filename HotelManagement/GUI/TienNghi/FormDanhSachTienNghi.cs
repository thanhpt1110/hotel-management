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


namespace HotelManagement.GUI
{
    public partial class FormDanhSachTienNghi : Form
    {
        List<TienNghi> tienNghis;
        private Image TN = Properties.Resources.TienNghi;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        private FormMain formMain;
        private TaiKhoan taiKhoan;
        public FormDanhSachTienNghi()
        {
            InitializeComponent();
        }

        public FormDanhSachTienNghi(FormMain formMain,TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.taiKhoan = taiKhoan;
        }

        private void CTButtonThemTienNghi_Click(object sender, EventArgs e)
        {
            if (taiKhoan.CapDoQuyen == 1)
            {
                CTMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThemTienNghi formThemTienNghi = new FormThemTienNghi())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThemTienNghi.Owner = formBackground;
                    formThemTienNghi.ShowDialog();
                    this.LoadAllData();
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

        private void FormDanhSachTienNghi_Load(object sender, EventArgs e)
        {
             grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            /*grid.Rows.Add(new object[] { TN, "TN001", "Ti vi", edit, delete });
            grid.Rows.Add(new object[] { TN, "TN002", "Máy lạnh", edit, delete });
            grid.Rows.Add(new object[] {TN, "TN003", "Máy sấy", edit, delete });*/
            LoadAllData();
        }

        public void LoadAllData()
        {
            try
            {
                tienNghis = TienNghiBUS.Instance.GetTienNghis();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                grid.Rows.Clear();
                foreach (TienNghi tienNghi in tienNghis)
                {
                    grid.Rows.Add(new object[] { TN, tienNghi.MaTN, tienNghi.TenTN, edit, delete });
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
                if (x == 3)
                {
                    if (taiKhoan.CapDoQuyen == 1)
                    {
                        CTMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormSuaTienNghi formSuaTienNghi = new FormSuaTienNghi(TienNghiBUS.Instance.FindTienNghi(grid.Rows[y].Cells[1].Value.ToString())))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formSuaTienNghi.Owner = formBackground;
                            formSuaTienNghi.ShowDialog();
                            this.LoadAllData();
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
                if (x == 4)
                {
                    // If click Delete button 
                    if (taiKhoan.CapDoQuyen == 1)
                    {
                        CTMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult dialogresult = CTMessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", 
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogresult == DialogResult.Yes)
                    {
                        try
                        {
                            TienNghiBUS.Instance.RemoveTN(TienNghiBUS.Instance.FindTienNghi(grid.Rows[y].Cells[1].Value.ToString()));
                            this.LoadAllData();
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
            if (y >= 0 && x == 3 || y >= 0 && x == 4 || y == -1 && x == 1)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimTenTienNghi__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxTienNghi = sender as TextBox;
            if (textBoxTienNghi.Focused == false)
            {
                LoadAllData();
                return;
            }
            this.tienNghis = TienNghiBUS.Instance.FindTienNghiWithName(textBoxTienNghi.Text);
            LoadData();
        }

        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
