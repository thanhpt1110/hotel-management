namespace HotelManagement.CTControls
{
    partial class CTTimePicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxGio = new System.Windows.Forms.ComboBox();
            this.ComboBoxPhut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // ComboBoxGio
            // 
            this.ComboBoxGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ComboBoxGio.DropDownHeight = 100;
            this.ComboBoxGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxGio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ComboBoxGio.FormattingEnabled = true;
            this.ComboBoxGio.IntegralHeight = false;
            this.ComboBoxGio.Items.AddRange(new object[] {
            " 00",
            " 01",
            " 02",
            " 03",
            " 04",
            " 05",
            " 06",
            " 07",
            " 08",
            " 09",
            " 10",
            " 11",
            " 12",
            " 13",
            " 14",
            " 15",
            " 16",
            " 17",
            " 18",
            " 19",
            " 20",
            " 21",
            " 22",
            " 23"});
            this.ComboBoxGio.Location = new System.Drawing.Point(6, 6);
            this.ComboBoxGio.Name = "ComboBoxGio";
            this.ComboBoxGio.Size = new System.Drawing.Size(45, 25);
            this.ComboBoxGio.TabIndex = 3;
            this.ComboBoxGio.Text = " hh";
            // 
            // ComboBoxPhut
            // 
            this.ComboBoxPhut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ComboBoxPhut.DropDownHeight = 100;
            this.ComboBoxPhut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPhut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ComboBoxPhut.FormattingEnabled = true;
            this.ComboBoxPhut.IntegralHeight = false;
            this.ComboBoxPhut.Items.AddRange(new object[] {
            " 00",
            " 30"});
            this.ComboBoxPhut.Location = new System.Drawing.Point(75, 6);
            this.ComboBoxPhut.Name = "ComboBoxPhut";
            this.ComboBoxPhut.Size = new System.Drawing.Size(50, 25);
            this.ComboBoxPhut.TabIndex = 3;
            this.ComboBoxPhut.Text = " mm";
            // 
            // CTTimePicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.ComboBoxPhut);
            this.Controls.Add(this.ComboBoxGio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CTTimePicker";
            this.Size = new System.Drawing.Size(134, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxGio;
        private System.Windows.Forms.ComboBox ComboBoxPhut;
    }
}
