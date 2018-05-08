using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuaySo
{
    public partial class Form1 : Form
    {
        int diem;
        Random rand;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            diem = 0;
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(9);
            int so2 = rand.Next(9);
            int so3 = rand.Next(9);
            if ((so1 == so2) && (so2 == so3))
                diem += 100;
            else
                diem -= 10;
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            lbDiem.Text = diem.ToString();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
