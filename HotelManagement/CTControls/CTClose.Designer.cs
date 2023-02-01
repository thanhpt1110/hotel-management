namespace HotelManagement.CTControls
{
    partial class CTClose
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CTClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.fixedRedResize;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "CTClose";
            this.Size = new System.Drawing.Size(15, 15);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.close_Paint);
            this.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            this.MouseHover += new System.EventHandler(this.close_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.close_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
