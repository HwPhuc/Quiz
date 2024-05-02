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
        public FrmCreateQuestions()
        {
            InitializeComponent();
        }

        private void FrmCreateQuestions_Load(object sender, EventArgs e)
        {

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
            if (rdA.Checked) dapAnDung = "A";
            else if (rdB.Checked) dapAnDung = "B";
            else if (rdC.Checked) dapAnDung = "C";
            else if (rdD.Checked) dapAnDung = "D";

            string noiDungGhi = cauHoi + ";" + dapAnA + ";" + dapAnB + ";" + dapAnC + ";" + dapAnD + ";" + dapAnDung;

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
                rdA.Checked = false;
                rdB.Checked = false;
                rdC.Checked = false;
                rdD.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }
    }
}
