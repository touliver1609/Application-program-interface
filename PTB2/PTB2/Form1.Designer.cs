namespace PTB2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSoc = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbKq = new System.Windows.Forms.Label();
            this.btGiai = new System.Windows.Forms.Button();
            this.btDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình giải phương trình bậc 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "a=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "c=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "b=";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(205, 87);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(98, 30);
            this.txtSoa.TabIndex = 4;
            // 
            // txtSoc
            // 
            this.txtSoc.Location = new System.Drawing.Point(557, 87);
            this.txtSoc.Name = "txtSoc";
            this.txtSoc.Size = new System.Drawing.Size(98, 30);
            this.txtSoc.TabIndex = 5;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(376, 87);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(98, 30);
            this.txtSob.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kết quả:";
            // 
            // lbKq
            // 
            this.lbKq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKq.Location = new System.Drawing.Point(229, 157);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(514, 80);
            this.lbKq.TabIndex = 8;
            // 
            // btGiai
            // 
            this.btGiai.Location = new System.Drawing.Point(229, 253);
            this.btGiai.Name = "btGiai";
            this.btGiai.Size = new System.Drawing.Size(89, 36);
            this.btGiai.TabIndex = 9;
            this.btGiai.Text = "Giải";
            this.btGiai.UseVisualStyleBackColor = true;
            this.btGiai.Click += new System.EventHandler(this.btGiai_Click);
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(549, 253);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(89, 36);
            this.btDong.TabIndex = 10;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(796, 301);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btGiai);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoc);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "PHƯƠNG TRÌNH BẬC 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtSoc;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbKq;
        private System.Windows.Forms.Button btGiai;
        private System.Windows.Forms.Button btDong;
    }
}

