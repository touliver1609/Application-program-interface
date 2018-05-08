using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTuLam_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtXuat.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }

        private void btMot_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file(*.txt)|*.txt|" + "Document file (*.docx)|*.docx|" + "All file (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileselect = openFileDialog1.FileName;
                openFileDialog1.Multiselect = true;
                txtXuat.Text = fileselect;
            }
        }

        private void btNhieu_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file(*.txt)|*.txt|" + "Document file (*.docx)|*.docx|" + "All file (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileselect = openFileDialog1.FileName;
                txtXuat.Text = fileselect;

            }
        }

        private void btThumuc_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtXuat.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btNen_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtXuat.BackColor = colorDialog1.Color;
            }
        }

        private void btMau_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtXuat.ForeColor = colorDialog1.Color;
            }
        }

        private void btFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtXuat.Font = fontDialog1.Font;
            }
        }
    }
}
