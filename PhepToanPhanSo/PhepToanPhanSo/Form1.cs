using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhepToanPhanSo
{
    public partial class Form1 : Form
    {
        PhanSo ps1, ps2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ps1 = new PhanSo();
            ps2 = new PhanSo();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                ps1.Tuso = Int32.Parse(txtTuSo1.Text);
                ps1.Mauso = Int32.Parse(txtMauSo1.Text);
                ps2.Tuso = Int32.Parse(txtTuSo2.Text);
                ps2.Mauso = Int32.Parse(txtMauSo2.Text);
                Button bt = (Button)sender;
                string op = bt.Text;
                PhanSo kq = null;
                switch (op)
                {
                    case "+": kq = ps1.Cong(ps2); break;
                    case "-": kq = ps1.Tru(ps2); break;
                    case "*": kq = ps1.Nhan(ps2); break;
                    case "/": kq = ps1.Chia(ps2); break;
                }
                lbTuso.Text = kq.Tuso.ToString();
                lbMauso.Text = kq.Mauso.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng giá trị");
            }
            catch
            {
                MessageBox.Show("Lỗi chia cho 0");
            }
        }


    }
}
