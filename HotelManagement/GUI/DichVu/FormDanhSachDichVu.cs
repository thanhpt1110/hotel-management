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
using HotelManagement.BUS;
using ApplicationSettings;
using HotelManagement.DTO;

namespace HotelManagement.GUI
{
    public partial class FormDanhSachDichVu : Form
    {
        private Image DV = Properties.Resources.DichVuDgv;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        private List<DichVu> dichVus;
        private FormMain formMain;
        private TaiKhoan taiKhoan;
        public FormDanhSachDichVu()
        {
            InitializeComponent();
        }

        public FormDanhSachDichVu(FormMain formMain, TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.taiKhoan = taiKhoan;
        }

        private void CTButtonThemDichVu_Click(object sender, EventArgs e)
        {
            if (taiKhoan.CapDoQuyen == 1)
            {
                CTMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThemDichVu formThemDichVu = new FormThemDichVu(this))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThemDichVu.Owner = formBackground;
                    formThemDichVu.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDanhSachDichVu_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            LoadALLDV();

           /* grid.Rows.Add(new object[] { this.DV, "DV001", "Pepsi", "10,000", "100", edit, delete });
            grid.Rows.Add(new object[] { DV, "DV002", "Mì xào", "20,000", "55", edit, delete });
            grid.Rows.Add(new object[] { DV, "DV003", "Bún bò", "25,000", "20", edit, delete });
            grid.Rows.Add(new object[] { DV, "DV004", "Karaoke", "300,000", "10", edit, delete });*/
        }

        private void LoadDV()
        {
            try
            {
                this.grid.Rows.Clear();
                foreach (DichVu dichVu in this.dichVus)
                {
                    int? SLDV;
                    if (dichVu.SLConLai == null || dichVu.SLConLai == -1)
                        SLDV = 0;
                    else
                        SLDV = dichVu.SLConLai;
                    grid.Rows.Add(this.DV, dichVu.MaDV, dichVu.TenDV, dichVu.DonGia.ToString("#,#"), SLDV, this.edit, this.delete);
                }
            }
            catch(Exception)
            {   
                CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
        public void LoadALLDV()
        {
            this.dichVus = DichVuBUS.Instance.GetDichVus();
            LoadDV();    
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
                    if (taiKhoan.CapDoQuyen == 1)
                    {
                        CTMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormSuaDichVu formSuaDichVu = new FormSuaDichVu(DichVuBUS.Instance.FindDichVu(grid.Rows[y].Cells[1].Value.ToString()), this))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formSuaDichVu.Owner = formBackground;
                            formSuaDichVu.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (x == 6)
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
                            DichVuBUS.Instance.RemoveDV(DichVuBUS.Instance.FindDichVu(grid.Rows[y].Cells[1].Value.ToString()));
                            LoadALLDV();
                            CTMessageBox.Show("Xóa thông tin thành công.", "Thông báo",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            CTMessageBox.Show("Đã xảy ra lỗi! Vui lòng thử lại.", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            if (y >= 0 && x == 5 || y >= 0 && x == 6 || y == -1 && x == 1)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimPhongTheoMa__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxTimTheoMaPhong = sender as TextBox;
            textBoxTimTheoMaPhong.KeyPress += TextBoxTimTheoMaPhong_KeyPress;

            if (textBoxTimTheoMaPhong.Focused == false)
            {
                LoadALLDV();
                return;
            }
            this.dichVus = DichVuBUS.Instance.FindDichVuWithName(textBoxTimTheoMaPhong.Text);
            LoadDV();
        }


        private void TextBoxTimTheoMaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxType.Instance.TextBoxNotNumber(e);
        }

        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
