namespace BTTuLam_2
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
            this.btMot = new System.Windows.Forms.Button();
            this.btNhieu = new System.Windows.Forms.Button();
            this.btThumuc = new System.Windows.Forms.Button();
            this.btNen = new System.Windows.Forms.Button();
            this.btMau = new System.Windows.Forms.Button();
            this.btFont = new System.Windows.Forms.Button();
            this.txtXuat = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btMot
            // 
            this.btMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btMot.Location = new System.Drawing.Point(19, 18);
            this.btMot.Name = "btMot";
            this.btMot.Size = new System.Drawing.Size(271, 47);
            this.btMot.TabIndex = 0;
            this.btMot.Text = "Chọn một tập tin";
            this.btMot.UseVisualStyleBackColor = true;
            this.btMot.Click += new System.EventHandler(this.btMot_Click);
            // 
            // btNhieu
            // 
            this.btNhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNhieu.Location = new System.Drawing.Point(19, 77);
            this.btNhieu.Name = "btNhieu";
            this.btNhieu.Size = new System.Drawing.Size(271, 47);
            this.btNhieu.TabIndex = 0;
            this.btNhieu.Text = "Chọn nhiều tập tin";
            this.btNhieu.UseVisualStyleBackColor = true;
            this.btNhieu.Click += new System.EventHandler(this.btNhieu_Click);
            // 
            // btThumuc
            // 
            this.btThumuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThumuc.Location = new System.Drawing.Point(19, 136);
            this.btThumuc.Name = "btThumuc";
            this.btThumuc.Size = new System.Drawing.Size(271, 47);
            this.btThumuc.TabIndex = 0;
            this.btThumuc.Text = "Chọn thư mục";
            this.btThumuc.UseVisualStyleBackColor = true;
            this.btThumuc.Click += new System.EventHandler(this.btThumuc_Click);
            // 
            // btNen
            // 
            this.btNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNen.Location = new System.Drawing.Point(19, 195);
            this.btNen.Name = "btNen";
            this.btNen.Size = new System.Drawing.Size(271, 47);
            this.btNen.TabIndex = 0;
            this.btNen.Text = "Chọn màu nền";
            this.btNen.UseVisualStyleBackColor = true;
            this.btNen.Click += new System.EventHandler(this.btNen_Click);
            // 
            // btMau
            // 
            this.btMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btMau.Location = new System.Drawing.Point(19, 254);
            this.btMau.Name = "btMau";
            this.btMau.Size = new System.Drawing.Size(271, 47);
            this.btMau.TabIndex = 0;
            this.btMau.Text = "Chọn màu chữ";
            this.btMau.UseVisualStyleBackColor = true;
            this.btMau.Click += new System.EventHandler(this.btMau_Click);
            // 
            // btFont
            // 
            this.btFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFont.Location = new System.Drawing.Point(19, 313);
            this.btFont.Name = "btFont";
            this.btFont.Size = new System.Drawing.Size(271, 47);
            this.btFont.TabIndex = 0;
            this.btFont.Text = "Chọn Font";
            this.btFont.UseVisualStyleBackColor = true;
            this.btFont.Click += new System.EventHandler(this.btFont_Click);
            // 
            // txtXuat
            // 
            this.txtXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtXuat.Location = new System.Drawing.Point(309, 24);
            this.txtXuat.Multiline = true;
            this.txtXuat.Name = "txtXuat";
            this.txtXuat.Size = new System.Drawing.Size(437, 289);
            this.txtXuat.TabIndex = 1;
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReset.Location = new System.Drawing.Point(309, 319);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(197, 47);
            this.btReset.TabIndex = 0;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(549, 319);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(197, 47);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 395);
            this.Controls.Add(this.txtXuat);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btFont);
            this.Controls.Add(this.btMau);
            this.Controls.Add(this.btNen);
            this.Controls.Add(this.btThumuc);
            this.Controls.Add(this.btNhieu);
            this.Controls.Add(this.btMot);
            this.Name = "Form1";
            this.Text = "BÀI TỰ LÀM 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMot;
        private System.Windows.Forms.Button btNhieu;
        private System.Windows.Forms.Button btThumuc;
        private System.Windows.Forms.Button btNen;
        private System.Windows.Forms.Button btMau;
        private System.Windows.Forms.Button btFont;
        private System.Windows.Forms.TextBox txtXuat;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

