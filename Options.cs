using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace KiemTraTracNghiem
{
    public partial class Options : Form
    {
        public static string name = String.Empty;
        //public static string path = Application.StartupPath;

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            lbChao.Text += " " + name + " mời lựa chọn";
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            FrmTest.soCauHoi = Int32.Parse(txtSoCauHoi.Text);
            if (FrmTest.soCauHoi <= 0)
            {
                MessageBox.Show("Số câu hỏi phải lớn hơn 0");
                return;
            }
            if (rdTiengAnh.Checked)
            {
                FrmTest.monThu = 1;
                //kiểm tra số câu hỏi người dùng muốn làm có nhiều hơn số 
                //câu hỏi hiện tại trong file không
                FrmTest.tongSoCauHoi = readFile("TiengAnh.txt");
                if (FrmTest.tongSoCauHoi < Int32.Parse(txtSoCauHoi.Text))
                {
                    MessageBox.Show("Số câu hỏi hiện tại không đủ!");
                    return;
                }
            }
            else if (rdToan.Checked)
            {
                FrmTest.monThu = 2;
                //kiểm tra số câu hỏi người dùng muốn làm có nhiều hơn số 
                //câu hỏi hiện tại trong file không
                FrmTest.tongSoCauHoi = readFile("Toan.txt");
                if (FrmTest.tongSoCauHoi < Int32.Parse(txtSoCauHoi.Text))
                {
                    MessageBox.Show("Số câu hỏi hiện tại không đủ!");
                    return;
                }
            }
            else if (rdLi.Checked)
            {
                FrmTest.monThu = 3;
                //kiểm tra số câu hỏi người dùng muốn làm có nhiều hơn số 
                //câu hỏi hiện tại trong file không
                FrmTest.tongSoCauHoi = readFile("Ly.txt");
                if (FrmTest.tongSoCauHoi < Int32.Parse(txtSoCauHoi.Text))
                {
                    MessageBox.Show("Số câu hỏi hiện tại không đủ!");
                    return;
                }
            }
            else if (rdHoa.Checked)
            {
                FrmTest.monThu = 4;
                //kiểm tra số câu hỏi người dùng muốn làm có nhiều hơn số 
                //câu hỏi hiện tại trong file không
                FrmTest.tongSoCauHoi = readFile("Hoa.txt");
                if (FrmTest.tongSoCauHoi < Int32.Parse(txtSoCauHoi.Text))
                {
                    MessageBox.Show("Số câu hỏi hiện tại không đủ!");
                    return;
                }
            }

            FrmTest f = new FrmTest();
            f.ShowDialog();
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public int readFile(string filename)
        {
            int lineNumber = 0;
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;
                }
            }
            return lineNumber;
        }

      
    }
}
