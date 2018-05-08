using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace BTC4_Bai3
{
    public partial class Form1 : Form
    {
        string path = "";
        Random rand = new Random();
        int nChoose, nCount, nWin, nLose;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            nChoose = int.Parse(bt.Text);
            pic1.Image = Image.FromFile(path + "die" + nChoose.ToString() + ".gif");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\Hinhxucxac\";
            Init();

        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void Play()
        {
            nCount++;
            int a = rand.Next(1, 7);
            string kq = "";
            pic2.Image = Image.FromFile(path + "die" + a.ToString() + ".gif");
            if (a == nChoose)
            {
                nWin++;
                kq = "Thắng";
            }
            else
            {
                nLose++;
                kq = "Thua";
            }
            lbLanDoan.Text = String.Format("{0}", nCount);
            lbLanThang.Text = String.Format("{0} ({1:0.00}%)", nWin, (double)nWin * 100 / nCount);
            lbLanthua.Text = String.Format("{0} ({1:0.00}%)", nLose, (double)nLose * 100 / nCount);
            listBox1.Items.Add(String.Format("{0}. {1} (Đoán {2} ra {3})", nCount, kq, nChoose, a));
        }
        private void Init()
        {
            nChoose = 1;
            nCount = nWin = nLose = 0;
            lbLanDoan.Text = lbLanThang.Text = lbLanthua.Text = "";
            pic1.Image = Image.FromFile(path + "die1.gif");
            listBox1.Items.Clear();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    Play();
                    return true;
                case Keys.Escape:
                    Init();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }



    }
}
