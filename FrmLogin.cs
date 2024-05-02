using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraTracNghiem
{
    public partial class FrmLogin : Form
    {
        string passWord = "admin";
        //bool check = true;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và mật khẩu!");
                txtName.Focus();    
                return;
            }
            //nếu nhập đúng mật khẩu
            else if (txtPass.Text == passWord)
            {
                //đăng nhập với tư cách là người thêm câu hỏi
                if (txtName.Text == passWord)
                {
                    this.Hide();
                    FrmOption f = new FrmOption();
                    f.ShowDialog();
                }
                //đăng nhập với tư cách là người thực hiện bài kiểm tra
                else
                {
                    Options.name = txtName.Text;
                    this.Hide();
                    Options f = new Options();
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nhập sai mật khẩu!");
                txtPass.Focus();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
