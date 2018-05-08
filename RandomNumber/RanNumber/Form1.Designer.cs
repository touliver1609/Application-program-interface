namespace RanNumber
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
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbSo3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd11 = new System.Windows.Forms.RadioButton();
            this.btQuay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSo1
            // 
            this.lbSo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo1.Location = new System.Drawing.Point(51, 33);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(177, 163);
            this.lbSo1.TabIndex = 0;
            this.lbSo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo2
            // 
            this.lbSo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo2.Location = new System.Drawing.Point(250, 33);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(177, 163);
            this.lbSo2.TabIndex = 0;
            this.lbSo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo3
            // 
            this.lbSo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo3.Location = new System.Drawing.Point(449, 33);
            this.lbSo3.Name = "lbSo3";
            this.lbSo3.Size = new System.Drawing.Size(177, 163);
            this.lbSo3.TabIndex = 0;
            this.lbSo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd11);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(51, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rd3
            // 
            this.rd3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd3.AutoSize = true;
            this.rd3.Checked = true;
            this.rd3.Location = new System.Drawing.Point(130, 44);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(83, 43);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "3-10";
            this.rd3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd11
            // 
            this.rd11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd11.AutoSize = true;
            this.rd11.Location = new System.Drawing.Point(334, 44);
            this.rd11.Name = "rd11";
            this.rd11.Size = new System.Drawing.Size(99, 43);
            this.rd11.TabIndex = 0;
            this.rd11.Text = "11-18";
            this.rd11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rd11.UseVisualStyleBackColor = true;
            // 
            // btQuay
            // 
            this.btQuay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btQuay.Location = new System.Drawing.Point(85, 322);
            this.btQuay.Name = "btQuay";
            this.btQuay.Size = new System.Drawing.Size(165, 67);
            this.btQuay.TabIndex = 2;
            this.btQuay.Text = "Quay số";
            this.btQuay.UseVisualStyleBackColor = true;
            this.btQuay.Click += new System.EventHandler(this.btQuay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(337, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Điểm";
            // 
            // lbDiem
            // 
            this.lbDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiem.Location = new System.Drawing.Point(471, 316);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(139, 98);
            this.lbDiem.TabIndex = 4;
            this.lbDiem.Click += new System.EventHandler(this.lbDiem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 412);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbSo3);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Name = "Form1";
            this.Text = "Form1";

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbSo3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd11;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.Button btQuay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiem;
    }
}

