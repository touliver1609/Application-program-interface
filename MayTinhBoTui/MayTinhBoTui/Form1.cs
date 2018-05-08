using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MayTinhBoTui
{

    public partial class Form1 : Form
    {
        char[] toantu = { '+', '-', '*', '/' };
        int vitri;
        int so1, so2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vitri = -1;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string x = lbText.Text;
            for (int i = 0; i < lbText.Text.Length; i++)
                if (lbText.Text.Contains("="))
                {
                    lbText.Text = bt.Text;
                    vitri = -1;
                    return;
                }
            lbText.Text += bt.Text;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
          lbText.Text=lbText.Text.Substring(0, lbText.Text.Length - 1);
        }


        private void btChia_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            try
            {
                if (vitri == -1)
                {
                    for (int i = 0; i < toantu.Length; i++)
                        if (char.Parse(b.Text) == toantu[i])
                        {
                            vitri = i;
                            lbText.Text += b.Text;
                            return;
                        }
                }
                else
                    throw new Exception("Đã chọn toán tử không thể chọn nữa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btR_Click(object sender, EventArgs e)
        {
            lbText.Text = null;
            vitri = -1;
        }

        private void btBang_Click(object sender, EventArgs e)
        {
            try
            {
                if ( vitri == -1 || lbText.Text.EndsWith(toantu[vitri].ToString()) || lbText.Text == null || lbText.Text.Contains('='))
                {
                    throw new FormatException("Biểu thức sai!\nVui lòng xem lại biểu thức!");
                }
                else
                {
                    string[] x = lbText.Text.Split(toantu[vitri]);
                    so1 = int.Parse(x[0]);
                    so2 = int.Parse(x[1]);
                    switch (vitri)
                    {
                        case 0: lbText.Text = so1 + "+" + so2 + "=" + (so1 + so2).ToString();
                            break;
                        case 1: lbText.Text = so1 + "-" + so2 + "=" + (so1 - so2).ToString();
                            break;
                        case 2: lbText.Text = so1 + "*" + so2 + "=" + (so1 * so2).ToString();
                            break;
                        case 3:

                            if (so2 == 0)
                            {
                                throw new DivideByZeroException("Không thể chia cho 0");
                            }
                            lbText.Text = so1 + "/" + so2 + "=" + ((double)so1 / so2).ToString();
                            break;
                        default: lbText.Text = "sai"; break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
