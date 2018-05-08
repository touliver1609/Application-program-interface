using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTC5_Bai1
{
    public partial class Form1 : Form
    {
        string path = "";
        int count = 0;
        Point point;
        Random rand = new Random();
        int width = 90;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pic.Name = count;

            path = Application.StartupPath + @"\Images\";
            AddImage(path);
        }
        private string RandomImage(string path)
        {
            //lấy file hình ảnh trong thư mục ta dùng Directory 
            string[] files = Directory.GetFiles(path);
            int n = rand.Next(files.Length);
            return files[n];
        }
        private void AddImage(string path)
        {
            count++;
            string ImgFile = RandomImage(path);
            //tạo một khung pictureBox động
            PictureBox pic = new PictureBox();
            pic.Width = pic.Width;
            //xử lí sự kiện bàn phím
            pic.Name = count.ToString();
            //tọa độ ban đầu của ảnh là ngay gốc trên bên trái
            pic.Location = new Point(0, 0);
            //lấy hình ảnh tại file thiết lập
            pic.Image = Image.FromFile(ImgFile);
            //thiết lập hình khich với khung
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pic.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            pic.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);
            // hiển thị hình chọn ngẫu nhiên
            this.Controls.Add(pic);
            // dời Index cho Panel về cuối
            this.Controls.SetChildIndex(pnBound, this.Controls.Count - 1);
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - point.Y;
                int dy = e.Y - point.X;
                pic.Left += dx;
                pic.Top += dy;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            //nếu hình vào contain
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
            }
            AddImage(path);
        }

        private void pnBound_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
        }

        private void pnBound_MouseMove(object sender, MouseEventArgs e)
        {
            //người dùng nhấn chuột trái thì thực hiện
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - point.Y;
                int dy = e.Y - point.X;
                pnBound.Left += dx;
                pnBound.Top += dy;
            }
        }
        // xử lí sự kiện bàn phím cho hình di chuyển
        protected override bool ProcessDialogKey(Keys keyData)
        {
            Control[] arr = this.Controls.Find(count.ToString(), false);
            PictureBox pic = (PictureBox)arr[0];
            switch (keyData)
            {

                case Keys.Up:
                    pic.Top -= 5;
                    break;
                case Keys.Down:
                    pic.Top += 5;
                    break;
                case Keys.Left:
                    pic.Left -= 5;
                    break;
                case Keys.Right:
                    pic.Left += 5;
                    break;
            }
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                AddImage(path);
            }

            return base.ProcessDialogKey(keyData);
        }

    }
}
