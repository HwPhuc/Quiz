using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraTracNghiem
{
    public partial class FrmCreateQuestions : Form
    {
        public static int monThu;
        bool flag = true;
        public FrmCreateQuestions()
        {
            InitializeComponent();
        }


        private void btnGhiCauHoi_Click(object sender, EventArgs e)
        {
            string tenFile = "";
            switch (monThu)
            {
                case 1:
                    tenFile = "TiengAnh.txt";
                    break;
                case 2:
                    tenFile = "Toan.txt";
                    break;
                case 3:
                    tenFile = "Ly.txt";
                    break;
                case 4:
                    tenFile = "Hoa.txt";
                    break;
                default:
                    MessageBox.Show("Môn học không hợp lệ!");
                    return;
            }

            string cauHoi = txtCauHoi.Text;
            string dapAnA = txtDAA.Text;
            string dapAnB = txtDAB.Text;
            string dapAnC = txtDAC.Text;
            string dapAnD = txtDAD.Text;

            string dapAnDung = "";
            if (rdA.Checked) dapAnDung = dapAnA;
            else if (rdB.Checked) dapAnDung = dapAnB;
            else if (rdC.Checked) dapAnDung = dapAnC;
            else if (rdD.Checked) dapAnDung = dapAnD;

            string noiDungGhi = cauHoi + ";" + dapAnA + ";" + dapAnB + ";" + 
                dapAnC + ";" + dapAnD + ";" + dapAnDung;

            try
            {
                using (StreamWriter writer = new StreamWriter(tenFile, true)) // true: append to file
                {
                    writer.WriteLine(noiDungGhi);
                }
                MessageBox.Show("Ghi câu hỏi thành công!");
                // Xóa các textbox và radio button để nhập câu hỏi tiếp theo (tùy chọn)
                txtCauHoi.Text = "";
                txtDAA.Text = "";
                txtDAB.Text = "";
                txtDAC.Text = "";
                txtDAD.Text = "";
                rdA.Checked = true;
                txtCauHoi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }

        private void FrmCreateQuestions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(flag)
            {
                Application.Exit();
            }
        }

        private void FrmCreateQuestions_Load(object sender, EventArgs e)
        {
            switch (monThu)
            {
                case 1: label1.Text += " TIẾNG ANH"; break;
                case 2: label1.Text += " TOÁN"; break;
                case 3: label1.Text += " LÝ"; break;
                case 4: label1.Text += " HÓA"; break;
            }
        }
    }
}
