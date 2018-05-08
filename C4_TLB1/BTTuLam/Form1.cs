using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTuLam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InsertColor();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Play();
        }
        private void InsertColor()
        {
            string[] color = { "Blue", "Green", "Red", "Cyan", "Black" };
            cbMau.Items.AddRange(color);
            cbMau.SelectedItem = "Blue";
        }
        private void Play()
        {

            listBox1.Items.Add(txtChuoi.Text);
            txtChuoi.Text = "";
        }

        private void btQua_Click(object sender, EventArgs e)
        {
            // nếu ko chọn phâng tử nào thì thoát không làm
            if (listBox1.SelectedItems.Count == 0) return;
            foreach (string item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
        }

        private void btVe_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
            if (listBox2.SelectedItem != null)
                listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    Play();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng ứng dụng không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.FromName(cbMau.SelectedItem.ToString());
            listBox2.BackColor = color;
        }


    }
}
