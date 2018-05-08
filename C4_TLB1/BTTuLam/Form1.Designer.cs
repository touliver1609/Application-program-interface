namespace BTTuLam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btQua = new System.Windows.Forms.Button();
            this.btVe = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbMau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một chuỗi:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(409, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn màu:";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChuoi.Location = new System.Drawing.Point(21, 38);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(175, 35);
            this.txtChuoi.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtChuoi, "Bạn phải nhập vào một chuỗi");
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btInsert.Location = new System.Drawing.Point(21, 79);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(91, 32);
            this.btInsert.TabIndex = 3;
            this.btInsert.Text = "Insert ";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(21, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(198, 279);
            this.listBox1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.listBox1, "Bạn phải chọn một phần tử");
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(437, 131);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(208, 279);
            this.listBox2.TabIndex = 4;
            // 
            // btQua
            // 
            this.btQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btQua.Location = new System.Drawing.Point(286, 131);
            this.btQua.Name = "btQua";
            this.btQua.Size = new System.Drawing.Size(91, 38);
            this.btQua.TabIndex = 3;
            this.btQua.Text = "==>";
            this.btQua.UseVisualStyleBackColor = true;
            this.btQua.Click += new System.EventHandler(this.btQua_Click);
            // 
            // btVe
            // 
            this.btVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btVe.Location = new System.Drawing.Point(286, 189);
            this.btVe.Name = "btVe";
            this.btVe.Size = new System.Drawing.Size(91, 38);
            this.btVe.TabIndex = 3;
            this.btVe.Text = "<==";
            this.btVe.UseVisualStyleBackColor = true;
            this.btVe.Click += new System.EventHandler(this.btVe_Click);
            // 
            // btRemove
            // 
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRemove.Location = new System.Drawing.Point(286, 247);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(91, 38);
            this.btRemove.TabIndex = 3;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btClear.Location = new System.Drawing.Point(286, 305);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(91, 38);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear all";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btExit.Location = new System.Drawing.Point(286, 363);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(91, 38);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Exit ";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Chú ý:";
            // 
            // cbMau
            // 
            this.cbMau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMau.FormattingEnabled = true;
            this.cbMau.Location = new System.Drawing.Point(445, 52);
            this.cbMau.Name = "cbMau";
            this.cbMau.Size = new System.Drawing.Size(199, 33);
            this.cbMau.TabIndex = 5;
            this.cbMau.SelectedIndexChanged += new System.EventHandler(this.cbMau_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.cbMau);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btVe);
            this.Controls.Add(this.btQua);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI TẬP TỰ LÀM";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btQua;
        private System.Windows.Forms.Button btVe;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbMau;
    }
}

