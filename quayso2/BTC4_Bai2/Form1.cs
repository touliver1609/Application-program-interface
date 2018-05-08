using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC4_Bai2
{
    public partial class Form1 : Form
    {
        string path = "";
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTen.Text = "    1551010096_NguyenTranTanPhat   ";
            path = Application.StartupPath + @"\Hinhxucxac\";
            pic1.Image = Image.FromFile(path + "6.bmp");
            pic2.Image = Image.FromFile(path + "6.bmp");
            pic3.Image = Image.FromFile(path + "6.bmp");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTen.Text = lbTen.Text.Substring(1) + lbTen.Text.Substring(0, 1);
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            int a = rand.Next(1, 7);
            int b = rand.Next(1, 7);
            int c = rand.Next(1, 7);
            pic1.Image = Image.FromFile(path + a.ToString() + ".bmp");
            pic2.Image = Image.FromFile(path + b.ToString() + ".bmp");
            pic3.Image = Image.FromFile(path + c.ToString() + ".bmp");
            lbKQ.Text = String.Format("{0}", a + b + c);
        }
    }
}
