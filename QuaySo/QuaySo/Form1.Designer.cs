namespace QuaySo
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
            this.lbSo1 = new System.Windows.Forms.Label();
            this.lbSo3 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSo1
            // 
            this.lbSo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo1.Location = new System.Drawing.Point(12, 29);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(155, 141);
            this.lbSo1.TabIndex = 0;
            this.lbSo1.Text = "0";
            this.lbSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo3
            // 
            this.lbSo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo3.Location = new System.Drawing.Point(334, 29);
            this.lbSo3.Name = "lbSo3";
            this.lbSo3.Size = new System.Drawing.Size(155, 141);
            this.lbSo3.TabIndex = 1;
            this.lbSo3.Text = "0";
            this.lbSo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo2
            // 
            this.lbSo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSo2.Location = new System.Drawing.Point(173, 29);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(155, 141);
            this.lbSo2.TabIndex = 2;
            this.lbSo2.Text = "0";
            this.lbSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiem
            // 
            this.lbDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(12, 188);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(477, 65);
            this.lbDiem.TabIndex = 3;
            this.lbDiem.Text = "0";
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPlay
            // 
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.Location = new System.Drawing.Point(121, 278);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(106, 37);
            this.btPlay.TabIndex = 4;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(279, 278);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(106, 37);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 337);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo3);
            this.Controls.Add(this.lbSo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo3;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btExit;
    }
}

