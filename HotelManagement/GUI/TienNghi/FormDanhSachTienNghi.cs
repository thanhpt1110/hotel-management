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
        public FormDanhSachTienNghi()
        {
            InitializeComponent();
        }

        private void CTButtonThemTienNghi_Click(object sender, EventArgs e)
        {
            using (FormThemTienNghi formThemTienNghi = new FormThemTienNghi())
                formThemTienNghi.ShowDialog();
        }

        private void FormDanhSachTienNghi_Load(object sender, EventArgs e)
        {
             grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);


            /*            grid.Rows.Add(new object[] { TN, "TN001", "Ti vi", edit, delete });
                        grid.Rows.Add(new object[] { TN, "TN002", "Máy lạnh", edit, delete });
                        grid.Rows.Add(new object[] {TN, "TN003", "Máy sấy", edit, delete });*/
            LoadAllData();
        }
        public void LoadAllData()
        {
            tienNghis = TienNghiBUS.Instance.GetTienNghis();
            LoadData();
        }
        private void LoadData()
        {
            grid.Rows.Clear();
            foreach (TienNghi tienNghi in tienNghis)
            {
                grid.Rows.Add(new object[] { TN, tienNghi.MaTN, tienNghi.TenTN, edit, delete });
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
                if (x == 3)
                {
                    using (FormSuaTienNghi formSuaTienNghi = new FormSuaTienNghi())
                        formSuaTienNghi.ShowDialog();
                }
                if (x == 4)
                {
                    // If click Delete button 
                    MessageBox.Show("Click delete button");
                }
            }
        }

        private void grid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int curCol = e.ColumnIndex;
            if (curCol == 3 || curCol == 4)
            {
                if (e.RowIndex >= 0)
                    grid.Cursor = Cursors.Hand;
                else if (grid.CurrentCell.Value == DBNull.Value)
                    grid.Cursor = Cursors.Default;
            }
            else
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimTenTienNghi__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxTienNghi = sender as TextBox;
            textBoxTienNghi.TextChanged += TextBoxTienNghi_TextChanged;
        }

        private void TextBoxTienNghi_TextChanged(object sender, EventArgs e)
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
    }
}
