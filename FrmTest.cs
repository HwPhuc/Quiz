using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace KiemTraTracNghiem
{
    public partial class FrmTest : Form
    {
        bool flag=true; //cờ kiểm tra việc đóng form
        int time = 0;
        public static int soCauHoi; //số câu hỏi mà người dùng chọn để kiểm tra
        public static int monThu;
        public static int tongSoCauHoi;//tổng câu hỏi có trong file

        string[] arrQuestion;
        string[] A_arr;
        string[] B_arr;
        string[] C_arr;
        string[] D_arr;
        string[] arrAnswer;

        int soCauDalam = 0;
        int soCauLamDung = 0;

        int kk;
        Random rand = new Random();
        int timeLimit = soCauHoi*10;//Mỗi câu hỏi có 10s trả lời
    
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            txtCauHoi.Text = "Bạn có " + timeLimit + " giây để trả lời các câu hỏi " +
                "Vui lòng bấm nút Start để bắt đầu";            

            // khởi tạo các mảng dữ liệu
            arrQuestion = new string[tongSoCauHoi];
            A_arr = new string[tongSoCauHoi];
            B_arr = new string[tongSoCauHoi];
            C_arr = new string[tongSoCauHoi];
            D_arr = new string[tongSoCauHoi];
            arrAnswer = new string[tongSoCauHoi];
            switch(monThu)
            {
                case 1:
                    choose("TiengAnh.txt");
                    this.Text = "Tiếng anh";
                    break;
                case 2:
                    choose("Toan.txt");
                    this.Text = "Toán";
                    break;
                case 3:
                    choose("Ly.txt");
                    this.Text = "Lý"; break;
                case 4:
                    choose("Hoa.txt");
                    this.Text = "Hóa"; break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time -= 1;
                lbTime.Text = (time/60).ToString() + " : " + (time%60).ToString();
            }
            else//nếu hết thời gian
            {
                btnNext.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            time = timeLimit;
            btnStart.Enabled = false;
            btnSave.Enabled = true;
            btnNext.Enabled = true;
            btnQuayLai.Enabled = false;
            //gán lại bắng 0 mỗi khi bắt đầu
            soCauLamDung = 0;
            soCauDalam = 0;
            lbTotal.Text = tongSoCauHoi.ToString();
            //lấy số ngẫu nhiên trong tổng số câu hỏi
            kk=rand.Next(tongSoCauHoi);

            taoCauHoi();

        }

        private void choose(string fileName)
        {
            // mở file lấy câu hỏi và lưu vào mảng
            using (StreamReader dethi_inputfile =
                new System.IO.StreamReader(fileName))
            {
                // nhập dữ liệu vào các mảng dữ liệu
                for (int i = 0; i < tongSoCauHoi; i++)
                {
                    string[] parts = dethi_inputfile.ReadLine().Split(';');
                    //sử dụng split để cắt một dòng thành 6 phần
                    if (parts.Length < 6) continue;// nếu ít hơn 6 phần thì bỏ qua

                    arrQuestion[i] = parts[0];
                    string s = arrQuestion[i];
                    A_arr[i] = parts[1];
                    B_arr[i] = parts[2];
                    C_arr[i] = parts[3];
                    D_arr[i] = parts[4];
                    arrAnswer[i] = parts[5].Trim();
                }
            }
        }
        
        void taoCauHoi()
        {
            //hiển thị câu hỏi và các đáp án
            txtCauHoi.Text = arrQuestion[kk].ToString();
            rdA.Text = A_arr[kk].ToString();
            rdB.Text = B_arr[kk].ToString();
            rdC.Text = C_arr[kk].ToString();
            rdD.Text = D_arr[kk].ToString();

            soCauDalam += 1;//tăng số câu đã làm
            //hiển thị số câu đã làm
            lbQuestion.Text = soCauDalam.ToString() + '/' + soCauHoi.ToString();
            lbTrue.Text = soCauLamDung.ToString() + '/' + soCauHoi.ToString();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            string answer="";
            if(rdA.Checked)
            {
                answer= rdA.Text;

            }else if(rdB.Checked)
            {
                answer= rdB.Text;
            }else if (rdC.Checked)
            {
                answer= rdC.Text;
            }else if(rdD.Checked) 
            { 
                answer= rdD.Text;
            }

            //so sánh đáp án  được chọn và kết quả đúng
            if(answer == arrAnswer[kk])
            {
                soCauLamDung++;
                lbTrue.Text = soCauLamDung.ToString() + '/' + soCauHoi.ToString();
            }
            else
            {
                
                timer1.Stop();//trả lời sai thì dừng thời gian
                DialogResult rs = MessageBox.Show("Đáp án đúng là: " + arrAnswer[kk],
                    "Nofication", MessageBoxButtons.OK);
                if (rs == DialogResult.OK)
                {
                    timer1.Start();
                }
            }
            //gán mặc định là đáp án A
            rdA.Checked = true;

            //nếu chưa làm hết số câu và thời gian vẫn còn thì tiếp tục làm tiếp
            if (soCauDalam < soCauHoi && time > 0)
            {
                kk = rand.Next(0, tongSoCauHoi);
                taoCauHoi();
            }else
                //ngược lại thì không cho bấm tiếp tục
                btnNext.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbTime.Text = (time / 60).ToString() + " : " + (time % 60).ToString();

            //lấy ngày tháng 
            string ngayThang = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            string ketQua = String.Format("{0},Họ tên: {1},Điểm: {2}",
                ngayThang, Options.name, (soCauLamDung * 5).ToString());
            //làm đúng được 5 điểm mỗi câu
            try
            {
                using (StreamWriter writer = new StreamWriter("ketQua.txt", true))
                {
                    writer.WriteLine(ketQua);
                }
            }catch (Exception ex)
            {
            }
            MessageBox.Show("Đã lưu thành công kết quả!\n" +
                "Điểm bạn nhận được là: "+ soCauLamDung*5);
            btnNext.Enabled = false;
            btnSave.Enabled = false;
            btnQuayLai.Enabled = true;
            btnStart.Enabled = true;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            flag = false;//thoát không phải bấm X
            this.Close();
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing&&flag)//nếu bấm X
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thoát chương trình",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                    Application.Exit(); 
            }
        }

       
    }
}
