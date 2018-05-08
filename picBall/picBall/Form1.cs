using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picBall
{
    public partial class Form1 : Form
    {
        //khai báo tọa độ của cạnh ngang
        int dx = 7;
        //khai báo tọa độ của cạnh đứng
        int dy = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBall.Left <= 0 || picBall.Right >= ClientRectangle.Width)
            {
                dx = -dx;
            }
            if (picBall.Top <= 0 || picBall.Bottom >= ClientRectangle.Height)
            {
                dy = -dy;
            }
            picBall.Left += dx;
            picBall.Top += dy;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }
    }
}
