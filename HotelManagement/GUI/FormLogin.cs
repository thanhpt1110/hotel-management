using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.label5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="tuanadmin" && textBox2.Text=="123456" || textBox1.Text == "1" && textBox2.Text == "1")
            {
                this.Hide();
                FormMain f = new FormMain();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                this.label5.Visible = true;
            }
        }
    }
}
