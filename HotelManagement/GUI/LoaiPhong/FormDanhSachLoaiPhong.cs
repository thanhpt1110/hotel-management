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
    public partial class FormDanhSachLoaiPhong : Form
    {
        private Image LP = Properties.Resources.LoaiPhong;
        private Image edit = Properties.Resources.edit;
        //private Image delete = Properties.Resources.delete;
        private Image details = Properties.Resources.details;
        private List<LoaiPhong> loaiPhongs;
        private FormMain formMain;
        private TaiKhoan taiKhoan1;

        public FormDanhSachLoaiPhong()
        {
            InitializeComponent();
        }

        public FormDanhSachLoaiPhong(FormMain formMain,TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.taiKhoan1 = taiKhoan;
        }

        /*private void CTButtonThemLoaiPhong_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThemLoaiPhong formThemLoaiPhong = new FormThemLoaiPhong())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThemLoaiPhong.Owner = formBackground;
                    formThemLoaiPhong.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO");
            }
            finally { formBackground.Dispose(); }
        }*/

        private void FormDanhSachLoaiPhong_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
            LoadAllDataGrid();
            /*grid.Rows.Add(new object[] { LP, "LP001", "Phòng đơn", "1", "2", "100,000", "50,000", edit, delete });
            grid.Rows.Add(new object[] { LP, "LP002", "Phòng đôi", "2", "4", "200,000", "100,000", edit, delete });
            grid.Rows.Add(new object[] { LP, "LP003", "Phòng VIP", "3", "8", "400,000", "200,000", edit, delete });*/
        }

        public void LoadAllDataGrid()
        {
            try
            {
            this.loaiPhongs = LoaiPhongBUS.Instance.GetLoaiPhongs();
            LoadDataGrid();
            }    
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataGrid()
        {
            try
            {
                grid.Rows.Clear();
                foreach(LoaiPhong loaiPhong in this.loaiPhongs)
                {
                    grid.Rows.Add(LP, loaiPhong.MaLPH, loaiPhong.TenLPH, loaiPhong.SoGiuong, loaiPhong.SoNguoiToiDa, loaiPhong.GiaNgay.ToString("#,#"), loaiPhong.GiaGio.ToString("#,#"), details, edit);
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
                    CTMessageBox.Show(mess, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // IF click Details button
                if (x == 7)
                {
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        string MaLP = grid.Rows[y].Cells[1].Value.ToString();
                        string TenLP = grid.Rows[y].Cells[2].Value.ToString();
                        using (FormDanhSachChiTietTienNghi formDanhSachChiTietTienNghi = new FormDanhSachChiTietTienNghi(MaLP, TenLP, formMain,this.taiKhoan1))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formDanhSachChiTietTienNghi.Owner = formBackground;
                            formDanhSachChiTietTienNghi.ShowDialog();
                            this.LoadAllDataGrid();
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
                // If click Update button 
                if (x == 8)
                {
                    if (taiKhoan1.CapDoQuyen == 1)
                    {
                        CTMessageBox.Show("Bạn không có quyền thực hiện thao tác này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormSuaLoaiPhong formSuaLoaiPhong = new FormSuaLoaiPhong(LoaiPhongBUS.Instance.getLoaiPhong(grid.Rows[y].Cells[1].Value.ToString())))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formSuaLoaiPhong.Owner = formBackground;
                            formSuaLoaiPhong.ShowDialog();
                            formBackground.Dispose();
                        }
                        LoadAllDataGrid();
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
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            int[] arrX = { 1, 5, 6 };
            bool isExists = false;

            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;

            if (y >= 0 && x == 7 || y >= 0 && x == 8 || y == -1 && isExists)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimPhongTheoMa__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxFindNameLP = sender as TextBox;
            textBoxFindNameLP.TextChanged += TextBoxFindNameLP_TextChanged;
        }

        private void TextBoxFindNameLP_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxFindNameLP = sender as TextBox;

            if (textBoxFindNameLP.Focused == false)
            {
                LoadAllDataGrid();
                return;
            }
            this.loaiPhongs = LoaiPhongBUS.Instance.getLoaiPhongWithName(textBoxFindNameLP.Text);
            LoadDataGrid();
        }
        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
