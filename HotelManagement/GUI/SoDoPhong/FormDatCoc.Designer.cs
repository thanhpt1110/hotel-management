namespace HotelManagement.GUI.SoDoPhong
{
    partial class FormDatCoc
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ctButton1 = new HotelManagement.CTControls.CTButton();
            this.ctButton2 = new HotelManagement.CTControls.CTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // ctButton1
            // 
            this.ctButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ctButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ctButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ctButton1.BorderRadius = 20;
            this.ctButton1.BorderSize = 0;
            this.ctButton1.FlatAppearance.BorderSize = 0;
            this.ctButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctButton1.ForeColor = System.Drawing.Color.White;
            this.ctButton1.Location = new System.Drawing.Point(29, 131);
            this.ctButton1.Name = "ctButton1";
            this.ctButton1.Size = new System.Drawing.Size(123, 40);
            this.ctButton1.TabIndex = 1;
            this.ctButton1.Text = "ctButton1";
            this.ctButton1.TextColor = System.Drawing.Color.White;
            this.ctButton1.UseVisualStyleBackColor = false;
            // 
            // ctButton2
            // 
            this.ctButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ctButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ctButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.ctButton2.BorderRadius = 20;
            this.ctButton2.BorderSize = 0;
            this.ctButton2.FlatAppearance.BorderSize = 0;
            this.ctButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctButton2.ForeColor = System.Drawing.Color.White;
            this.ctButton2.Location = new System.Drawing.Point(188, 131);
            this.ctButton2.Name = "ctButton2";
            this.ctButton2.Size = new System.Drawing.Size(123, 40);
            this.ctButton2.TabIndex = 2;
            this.ctButton2.Text = "ctButton2";
            this.ctButton2.TextColor = System.Drawing.Color.White;
            this.ctButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tương ứng với: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền cọc: ";
            // 
            // FormDatCoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctButton2);
            this.Controls.Add(this.ctButton1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormDatCoc";
            this.Text = "FormDatCoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private CTControls.CTButton ctButton1;
        private CTControls.CTButton ctButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}