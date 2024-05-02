namespace KiemTraTracNghiem
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHoa = new System.Windows.Forms.RadioButton();
            this.rdLi = new System.Windows.Forms.RadioButton();
            this.rdToan = new System.Windows.Forms.RadioButton();
            this.rdTiengAnh = new System.Windows.Forms.RadioButton();
            this.txtSoCauHoi = new System.Windows.Forms.TextBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.lbChao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số câu hỏi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHoa);
            this.groupBox1.Controls.Add(this.rdLi);
            this.groupBox1.Controls.Add(this.rdToan);
            this.groupBox1.Controls.Add(this.rdTiengAnh);
            this.groupBox1.Location = new System.Drawing.Point(46, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn môn";
            // 
            // rdHoa
            // 
            this.rdHoa.AutoSize = true;
            this.rdHoa.Location = new System.Drawing.Point(562, 47);
            this.rdHoa.Name = "rdHoa";
            this.rdHoa.Size = new System.Drawing.Size(107, 41);
            this.rdHoa.TabIndex = 1;
            this.rdHoa.TabStop = true;
            this.rdHoa.Text = "Hóa";
            this.rdHoa.UseVisualStyleBackColor = true;
            // 
            // rdLi
            // 
            this.rdLi.AutoSize = true;
            this.rdLi.Location = new System.Drawing.Point(421, 47);
            this.rdLi.Name = "rdLi";
            this.rdLi.Size = new System.Drawing.Size(73, 41);
            this.rdLi.TabIndex = 1;
            this.rdLi.TabStop = true;
            this.rdLi.Text = "Lí";
            this.rdLi.UseVisualStyleBackColor = true;
            // 
            // rdToan
            // 
            this.rdToan.AutoSize = true;
            this.rdToan.Location = new System.Drawing.Point(249, 47);
            this.rdToan.Name = "rdToan";
            this.rdToan.Size = new System.Drawing.Size(122, 41);
            this.rdToan.TabIndex = 1;
            this.rdToan.TabStop = true;
            this.rdToan.Text = "Toán";
            this.rdToan.UseVisualStyleBackColor = true;
            // 
            // rdTiengAnh
            // 
            this.rdTiengAnh.AutoSize = true;
            this.rdTiengAnh.Checked = true;
            this.rdTiengAnh.Location = new System.Drawing.Point(32, 47);
            this.rdTiengAnh.Name = "rdTiengAnh";
            this.rdTiengAnh.Size = new System.Drawing.Size(195, 41);
            this.rdTiengAnh.TabIndex = 0;
            this.rdTiengAnh.TabStop = true;
            this.rdTiengAnh.Text = "Tiếng Anh";
            this.rdTiengAnh.UseVisualStyleBackColor = true;
            // 
            // txtSoCauHoi
            // 
            this.txtSoCauHoi.Location = new System.Drawing.Point(223, 222);
            this.txtSoCauHoi.Name = "txtSoCauHoi";
            this.txtSoCauHoi.Size = new System.Drawing.Size(100, 44);
            this.txtSoCauHoi.TabIndex = 2;
            this.txtSoCauHoi.Text = "10";
            this.txtSoCauHoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(530, 217);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(115, 41);
            this.btnXong.TabIndex = 0;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // lbChao
            // 
            this.lbChao.AutoSize = true;
            this.lbChao.Location = new System.Drawing.Point(61, 27);
            this.lbChao.Name = "lbChao";
            this.lbChao.Size = new System.Drawing.Size(151, 37);
            this.lbChao.TabIndex = 4;
            this.lbChao.Text = "Xin chào,";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 291);
            this.Controls.Add(this.lbChao);
            this.Controls.Add(this.btnXong);
            this.Controls.Add(this.txtSoCauHoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHoa;
        private System.Windows.Forms.RadioButton rdLi;
        private System.Windows.Forms.RadioButton rdToan;
        private System.Windows.Forms.RadioButton rdTiengAnh;
        private System.Windows.Forms.TextBox txtSoCauHoi;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.Label lbChao;
    }
}