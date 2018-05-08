using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RanNumber
{
    public partial class Form1 : Form
    {
        int diem = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            int a = rand.Next(1, 7);
            int b = rand.Next(1, 7);
            int c = rand.Next(1, 7);
            lbDiem.Text = diem.ToString();
            lbSo1.Text = a.ToString();
            lbSo2.Text = b.ToString();
            lbSo3.Text = c.ToString();
            int tong = a + b + c;
            if (rd3.Checked)
            {
                if (tong <= 10) diem += 10;
                else
                    diem -= 10;
            }
            else
            {
                if (rd11.Checked)
                {
                    if (tong > 10) diem += 10;
                    else
                        diem -= 10;
                }
            }


        }

        private void lbDiem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
