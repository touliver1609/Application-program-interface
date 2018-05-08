using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtSoa.Text);
                double b = double.Parse(txtSob.Text);
                double c = double.Parse(txtSoc.Text);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                            lbKq.Text = "Phương trình có vô số nghiệm";
                        else
                            lbKq.Text = "Phương trình vô nghiệm";
                    }
                    else
                        lbKq.Text = string.Format("{0:0.00}", "Phương trình có 1 nghiệm duy nhất: " + -c / b);
                }
                else
                {
                    double denta = b * b - 4 * a * c;
                    if (denta < 0)
                        lbKq.Text = "Phương trình vô nghiệm";
                    else if (denta == 0)
                        lbKq.Text = string.Format("{0:0.00}", "Phương trình có 1 nghiệm duy nhất: " + -b / 2 * a);
                    else
                    {
                        double x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                        lbKq.Text = string.Format("{0:0.00}", "Phương trình có 2 nghiệm riêng biệt:\nX1 = " + x1 + "\nX2 = " + x2);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập sai hoặc chưa nhập giá trị! Vui lòng nhập lại", "Error");
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
