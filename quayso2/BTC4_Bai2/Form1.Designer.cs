namespace BTC4_Bai2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTen = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.btQuay = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTen
            // 
            this.lbTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTen.Location = new System.Drawing.Point(0, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(790, 81);
            this.lbTen.TabIndex = 0;
            this.lbTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(64, 107);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(171, 167);
            this.pic1.TabIndex = 1;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(300, 107);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(171, 167);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(556, 107);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(171, 167);
            this.pic3.TabIndex = 1;
            this.pic3.TabStop = false;
            // 
            // lbKQ
            // 
            this.lbKQ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKQ.Location = new System.Drawing.Point(283, 293);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(209, 67);
            this.lbKQ.TabIndex = 2;
            this.lbKQ.Text = "0";
            this.lbKQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btQuay
            // 
            this.btQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btQuay.Location = new System.Drawing.Point(175, 380);
            this.btQuay.Name = "btQuay";
            this.btQuay.Size = new System.Drawing.Size(159, 60);
            this.btQuay.TabIndex = 3;
            this.btQuay.Text = "Quay số";
            this.btQuay.UseVisualStyleBackColor = true;
            this.btQuay.Click += new System.EventHandler(this.btQuay_Click);
            // 
            // btDong
            // 
            this.btDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDong.Location = new System.Drawing.Point(448, 380);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(159, 60);
            this.btDong.TabIndex = 3;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 452);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btQuay);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.lbTen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quay số";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.Button btQuay;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Timer timer1;
    }
}

