using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong2_bt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCong_Click(object sender, EventArgs e)
        {
            int th1 = int.Parse(txt1.Text);
            int th2 = int.Parse(txt2.Text);
            int kq = th1+th2;
            lblKq.Text = kq.ToString();


        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int th1 = int.Parse(txt1.Text);
            int th2 = int.Parse(txt2.Text);
            int kq = th1 - th2;
            lblKq.Text = kq.ToString();

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int th1 = int.Parse(txt1.Text);
            int th2 = int.Parse(txt2.Text);
            int kq = th1 * th2;
            lblKq.Text = kq.ToString();

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int th1 = int.Parse(txt1.Text);
            int th2 = int.Parse(txt2.Text);
            if (th2 == 0)
                MessageBox.Show("Lỗi");
            else
            {
                double kq = (double)th1 / th2;
               lblKq.Text = string.Format("{0:0.00}", kq);

            }

        }
    }
}
