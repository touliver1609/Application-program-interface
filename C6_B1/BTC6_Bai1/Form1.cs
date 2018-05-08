using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC6_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThayThe_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Replace(txtS2.Text, txtS3.Text);
        }

        private void btChen_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Insert(int.Parse(txtVitri.Text), txtS2.Text);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            int pos = txtS1.Text.IndexOf(txtS2.Text);
            while (pos >= 0)
            {
                txtS1.Text = txtS1.Text.Remove(pos, txtS2.Text.Length);
                pos = txtS1.Text.IndexOf(txtS2.Text);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void btDao_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\n', '\t' };
            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            txtS1.Text = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                txtS1.Text += arr[i] + " ";
            }
            txtS1.Text = txtS1.Text.TrimEnd();
        }

        private void btChuanHoa_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\n', '\t' };
            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            txtS1.Text = "";
            foreach (string str in arr)
            {
                string s = str;
                s = s.Substring(0, 1).ToUpper() + s.Substring(1);
                txtS1.Text += s + " ";
            }
            txtS1.Text = txtS1.Text.TrimEnd();
        }
    }
}
