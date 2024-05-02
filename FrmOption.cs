using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraTracNghiem
{
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if(rdTiengAnh.Checked)
            {
                FrmCreateQuestions.monThu = 1;
            }else if(rdToan.Checked) {
                FrmCreateQuestions.monThu= 2;
            }else if(rdLy.Checked) {
                FrmCreateQuestions.monThu= 3;
            }else if(rdHoa.Checked) {
                FrmCreateQuestions.monThu= 4;
            }
            FrmCreateQuestions f = new FrmCreateQuestions();
            f.ShowDialog();
        }

        private void FrmOption_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {

        }


    }
}
