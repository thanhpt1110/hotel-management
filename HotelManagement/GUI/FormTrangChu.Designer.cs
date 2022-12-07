namespace HotelManagement.GUI
{
    partial class FormTrangChu
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
            this.LabelTrangChu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelTrangChu
            // 
            this.LabelTrangChu.AutoSize = true;
            this.LabelTrangChu.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrangChu.Location = new System.Drawing.Point(480, 20);
            this.LabelTrangChu.Name = "LabelTrangChu";
            this.LabelTrangChu.Size = new System.Drawing.Size(153, 40);
            this.LabelTrangChu.TabIndex = 0;
            this.LabelTrangChu.Text = "Trang chủ";
            // 
            // FormTrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1244, 794);
            this.Controls.Add(this.LabelTrangChu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTrangChu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormTrangChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTrangChu;
    }
}