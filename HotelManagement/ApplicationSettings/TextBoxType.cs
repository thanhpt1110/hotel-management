using HotelManagement.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationSettings
{
    public class TextBoxType
    {
        private static TextBoxType instance;
        public static TextBoxType Instance
        {
            get { if (instance == null) instance = new TextBoxType(); return instance; }
            private set { instance = value; }
        }
        private TextBoxType() { }

        public void TextBoxOnlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void TextBoxNotNumber(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
