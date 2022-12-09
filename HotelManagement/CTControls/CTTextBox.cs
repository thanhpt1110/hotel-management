using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.CTControls
{
    [DefaultEvent("_TextChanged")]
    public partial class CTTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(82, 145, 175);
        private int borderSize = 1;
        private bool underlineedStyle = false;
        private Color borderFocusColor = Color.Black;
        private bool isFocused = false;
        private int borderRadius = 20;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private bool isReadOnly = false;
        
        //Constructor
        public CTTextBox()
        {
            InitializeComponent();
        }

        //Events
        public event EventHandler _TextChanged;

        //Properties
        public bool ReadOnly
        {
            get
            {
                return isReadOnly;
            }
            set
            {
                isReadOnly = value;
                textBox1.ReadOnly = isReadOnly;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public bool UnderlineedStyle
        {
            get => underlineedStyle;
            set
            {
                underlineedStyle = value;
                this.Invalidate();
            }
        }
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        public string Texts
        {
            get
            {
                if (isPlaceholder)
                {
                    return "";
                }
                else
                {
                    return textBox1.Text;
                }
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }
        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }
        public bool IsFocused { get => isFocused; set => isFocused = value; }
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set
            {
                placeholderColor = value;
                if (isPasswordChar)
                {
                    textBox1.ForeColor = value;
                }
            }
        }
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

        public void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }
        public void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }
        //override methods

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Rounded Textbox
            if (borderRadius > 1)
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;

                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused)
                    {
                        penBorder.Color = borderFocusColor;
                    }
                    if (underlineedStyle) //line style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //normal style
                    {
                        //draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, BorderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (!isFocused)
                    {
                        if (underlineedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;
                        if (underlineedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                }
            }


        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
            else
            {
                this.OnClick(e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //this.OnLeave(e);
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
