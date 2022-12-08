namespace HotelManagement.GUI.ThongKe
{
    partial class FormThongKe
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
            this.LabelThongKe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelThongKe
            // 
            this.LabelThongKe.AutoSize = true;
            this.LabelThongKe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThongKe.Location = new System.Drawing.Point(460, 34);
            this.LabelThongKe.Name = "LabelThongKe";
            this.LabelThongKe.Size = new System.Drawing.Size(291, 37);
            this.LabelThongKe.TabIndex = 0;
            this.LabelThongKe.Text = "XÁC SUẤT THỐNG KÊ";
            // 
            // FormThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 794);
            this.Controls.Add(this.LabelThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelThongKe;
    }
}