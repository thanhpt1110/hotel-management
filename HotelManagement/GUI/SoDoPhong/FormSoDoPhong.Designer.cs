namespace HotelManagement.GUI
{
    partial class FormSoDoPhong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelSoDoPhong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelSoDoPhong
            // 
            this.LabelSoDoPhong.AutoSize = true;
            this.LabelSoDoPhong.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSoDoPhong.Location = new System.Drawing.Point(484, 9);
            this.LabelSoDoPhong.Name = "LabelSoDoPhong";
            this.LabelSoDoPhong.Size = new System.Drawing.Size(192, 40);
            this.LabelSoDoPhong.TabIndex = 1;
            this.LabelSoDoPhong.Text = "Sơ đồ phòng";
            // 
            // FormSoDoPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 794);
            this.Controls.Add(this.LabelSoDoPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSoDoPhong";
            this.Text = "FormSoDoPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSoDoPhong;
    }
}