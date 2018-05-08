namespace BTC5_Bai1
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
            this.pnBound = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnBound
            // 
            this.pnBound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnBound.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBound.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnBound.Location = new System.Drawing.Point(701, 12);
            this.pnBound.Name = "pnBound";
            this.pnBound.Size = new System.Drawing.Size(142, 418);
            this.pnBound.TabIndex = 0;
            this.pnBound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBound_MouseDown);
            this.pnBound.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBound_MouseMove);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(10, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dùng chuột hoặc các phím mũi tên di chuyển hình vào panel bên phải";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnBound);
            this.Name = "Form1";
            this.Text = "MOVE OBJECT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnBound;
        private System.Windows.Forms.Label label1;
    }
}

