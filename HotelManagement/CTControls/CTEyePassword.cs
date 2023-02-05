using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.CTControls
{
    public partial class CTEyePassword : UserControl
    {
        public CTEyePassword()
        {
            InitializeComponent();
        }

        private bool isShow = false;

        public bool IsShow { get => isShow; set => isShow = value; }

    }
}
