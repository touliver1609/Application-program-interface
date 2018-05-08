using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToanChoBe
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string[] toantu = { "+", "-", "x", "/" };
        int vitri = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {

            int a = rand.Next(10);
            int b = rand.Next(10);
            vitri = rand.Next(4);
            lbSo1.Text = a.ToString();
            lbSo2.Text = b.ToString();
            lbToanTu.Text = toantu[vitri];
            lbKetQua.Text = "";
            txtTraLoi.Text = "";
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int kq = 0;
            int a = int.Parse(lbSo1.Text);
            int b = int.Parse(lbSo2.Text);
            try
            {
                switch (vitri)
                {
                    case 0:
                        kq = a + b;
                        break;
                    case 1:
                        kq = a - b;
                        break;
                    case 2:
                        kq = a * b;
                        break;
                    case 3:
                        if (b != 0) kq = a / b;
                        break;
                }
                int doan = int.Parse(txtTraLoi.Text);
                if (doan == kq)
                    lbKetQua.Text = "Đúng rồi!!!";
                else
                    lbKetQua.Text = "Sai rồi!! kết quả là:" + kq.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập số!!!!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Lỗi chia cho 0");
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtTraLoi.Text += bt.Text;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text == "")
                txtTraLoi.Text = "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text == "") return;
            else
                txtTraLoi.Text = txtTraLoi.Text.Substring(0, txtTraLoi.Text.Length - 1);
        }


    }
}
