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
            if (!char.IsLetter(ch) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void CurrencyType(object sender, EventArgs e)
        {
            TextBox textBox1 = sender as TextBox;
            if (textBox1.Focused == true)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    System.Globalization.NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();
                    nfi.NumberGroupSeparator = ",";
                    double nValue = 0;
                    bool bError = false;
                    try
                    {
                        nValue = double.Parse(textBox1.Text, System.Globalization.NumberStyles.AllowThousands, nfi);
                    }
                    catch (System.Exception se)
                    {
                        bError = true;
                        System.Windows.Forms.MessageBox.Show("Error : " + se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //if (!bError)
                        {
                            textBox1.Text = string.Format(nfi, "{0:N0}", nValue);
                            textBox1.Select(textBox1.Text.Length, 0);
                        }
                    }
                }
            }
        }
    }
}
