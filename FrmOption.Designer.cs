namespace KiemTraTracNghiem
{
    partial class FrmOption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHoa = new System.Windows.Forms.RadioButton();
            this.rdLy = new System.Windows.Forms.RadioButton();
            this.rdToan = new System.Windows.Forms.RadioButton();
            this.rdTiengAnh = new System.Windows.Forms.RadioButton();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHoa);
            this.groupBox1.Controls.Add(this.rdLy);
            this.groupBox1.Controls.Add(this.rdToan);
            this.groupBox1.Controls.Add(this.rdTiengAnh);
            this.groupBox1.Location = new System.Drawing.Point(79, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn môn";
            // 
            // rdHoa
            // 
            this.rdHoa.AutoSize = true;
            this.rdHoa.Location = new System.Drawing.Point(246, 106);
            this.rdHoa.Name = "rdHoa";
            this.rdHoa.Size = new System.Drawing.Size(97, 36);
            this.rdHoa.TabIndex = 1;
            this.rdHoa.TabStop = true;
            this.rdHoa.Text = "Hóa";
            this.rdHoa.UseVisualStyleBackColor = true;
            // 
            // rdLy
            // 
            this.rdLy.AutoSize = true;
            this.rdLy.Location = new System.Drawing.Point(246, 56);
            this.rdLy.Name = "rdLy";
            this.rdLy.Size = new System.Drawing.Size(75, 36);
            this.rdLy.TabIndex = 1;
            this.rdLy.TabStop = true;
            this.rdLy.Text = "Lý";
            this.rdLy.UseVisualStyleBackColor = true;
            // 
            // rdToan
            // 
            this.rdToan.AutoSize = true;
            this.rdToan.Location = new System.Drawing.Point(31, 106);
            this.rdToan.Name = "rdToan";
            this.rdToan.Size = new System.Drawing.Size(110, 36);
            this.rdToan.TabIndex = 1;
            this.rdToan.TabStop = true;
            this.rdToan.Text = "Toán";
            this.rdToan.UseVisualStyleBackColor = true;
            // 
            // rdTiengAnh
            // 
            this.rdTiengAnh.AutoSize = true;
            this.rdTiengAnh.Checked = true;
            this.rdTiengAnh.Location = new System.Drawing.Point(31, 56);
            this.rdTiengAnh.Name = "rdTiengAnh";
            this.rdTiengAnh.Size = new System.Drawing.Size(175, 36);
            this.rdTiengAnh.TabIndex = 0;
            this.rdTiengAnh.TabStop = true;
            this.rdTiengAnh.Text = "Tiếng Anh";
            this.rdTiengAnh.UseVisualStyleBackColor = true;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Location = new System.Drawing.Point(412, 280);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(124, 44);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 358);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateQ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOption_FormClosed);
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHoa;
        private System.Windows.Forms.RadioButton rdLy;
        private System.Windows.Forms.RadioButton rdToan;
        private System.Windows.Forms.RadioButton rdTiengAnh;
        private System.Windows.Forms.Button btnTiepTuc;
    }
}