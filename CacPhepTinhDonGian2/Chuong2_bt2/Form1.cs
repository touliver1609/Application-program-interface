using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong2_bt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try { 
            int so1 = int.Parse(txt1.Text);
            int so2 = int.Parse(txt2.Text);
            int kq = 0;
            if (rdCong.Checked)
            {
                kq = so1 + so2;
                lblKq.Text = kq.ToString();
            }
            if (rdTru.Checked)
            {
                kq = so1 - so2;
                lblKq.Text = kq.ToString();
            }
            if (rdNhan.Checked)
            {
                kq = so1 * so2;
                lblKq.Text = kq.ToString();
            }
            if (rdChia.Checked)
            {
               // if (so2 == 0)
                 //   throw(new DivideByZeroException());
                //else
                {
                    double a = (double)so1 / so2;
                    lblKq.Text = string.Format("{0:0.00}", a);
                }
            }
            }
            catch(DivideByZeroException)
                {
                    MessageBox.Show("nhập sai"); 
                }
            catch(FormatException)
            {
                MessageBox.Show("nhập sai");
            }
        }


        

       

    }
}
