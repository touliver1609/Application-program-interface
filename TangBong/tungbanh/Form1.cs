using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tungbanh
{
    public partial class Form1 : Form
    {
        int dx = 5, dy = 8;
        int diem;
        Point pointM;
        public Form1()
        {
            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.S:
                    timer1.Enabled = !timer1.Enabled;
                    return true;
                case Keys.Left:
                    if (label1.Left > label2.Right)
                        label1.Left -= 10;
                    break;
                case Keys.Right:
                    if ((label1.Right + 10) <= (ClientRectangle.Width))
                        label1.Left += 10;
                    break;
                case Keys.Up:
                    timer1.Interval -= 5;
                    break;
                case Keys.Down:
                    timer1.Interval += 5;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Bottom > ClientRectangle.Height)
            {
                timer1.Stop();
                MessageBox.Show("Bạn đã thua số điểm là: " + diem + "\nBấm S để tiếp tục!\nThoát nhấn ESC", "Thông Báo");
                diem = 0;
                label3.Text = diem.ToString();
            }
            
            if (pictureBox1.Left <= label2.Right || pictureBox1.Right >= ClientRectangle.Width)
            {
                dx = - dx;
            }
            if (pictureBox1.Top < 0 || pictureBox1.Bottom > ClientRectangle.Height)
            {
                dy = -dy;
            }
            if (kiemTra())
            {
                dy = -dy;
                diem ++;
                label3.Text = diem.ToString();
            }
            pictureBox1.Left += dx;
            pictureBox1.Top += dy;
        }

        private bool kiemTra()
        {
            if ((pictureBox1.Bottom > label1.Top) && 
                ((pictureBox1.Left > label1.Left && pictureBox1.Right < label1.Right )  || 
                    (pictureBox1.Left > label1.Left && pictureBox1.Left < label1.Right) ||
                       (pictureBox1.Right > label1.Left && pictureBox1.Right < label1.Right)))
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diem = 0;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            pointM = e.Location;
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && 
                (label1.Left + (e.X - pointM.X) > label2.Right)&&
                (label1.Right + (e.X - pointM.X) < ClientRectangle.Width))
            {
                label1.Left += (e.X - pointM.X);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
