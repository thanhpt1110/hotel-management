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
using ApplicationSettings;

namespace HotelManagement.GUI
{
    public partial class FormDanhSachDichVu : Form
    {
        private Image DV = Properties.Resources.DichVuDgv;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        private List<DichVu> dichVus;
        public FormDanhSachDichVu()
        {
            InitializeComponent();
        }

        private void CTButtonThemDichVu_Click(object sender, EventArgs e)
        {
            using (FormThemDichVu formThemDichVu = new FormThemDichVu(this))
            {
                formThemDichVu.ShowDialog();
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
            catch (Exception ex)
            {
                MessageBox.Show("Load danh sách dịch vụ không thành công", "THÔNG BÁO");
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
                    using (FormSuaDichVu formSuaDichVu1 = new FormSuaDichVu(DichVuBUS.Instance.FindDichVu(grid.Rows[y].Cells[1].Value.ToString()),this))
                    {
                        formSuaDichVu1.ShowDialog();
                    }
                }
                if (x == 6)
                {
                    // If click Delete button 
                    
                    DichVuBUS.Instance.RemoveDV(DichVuBUS.Instance.FindDichVu(grid.Rows[y].Cells[1].Value.ToString()));
                    LoadALLDV();
                }
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

            int curCol = e.ColumnIndex;
            if (curCol == 5 || curCol == 6)
            {
                if (e.RowIndex >= 0)
                    grid.Cursor = Cursors.Hand;
                else if (grid.CurrentCell.Value == DBNull.Value)
                    grid.Cursor = Cursors.Default;
            }
            else   
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimPhongTheoMa__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxTimTheoMaPhong = sender as TextBox;
            textBoxTimTheoMaPhong.KeyPress += TextBoxTimTheoMaPhong_KeyPress;
            textBoxTimTheoMaPhong.TextChanged += TextBoxTimTheoMaPhong_TextChanged;
        }

        private void TextBoxTimTheoMaPhong_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxFindNameDV = sender as TextBox;

            if (textBoxFindNameDV.Focused == false )
            {
                LoadALLDV();
                return;
            }
            this.dichVus = DichVuBUS.Instance.FindDichVuWithName(textBoxFindNameDV.Text);
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
