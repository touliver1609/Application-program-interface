namespace frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.menuWin = new System.Windows.Forms.ToolStripMenuItem();
            this.cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.Hor = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWin,
            this.menuFile,
            this.menuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuClose,
            this.menuCloseAll});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            this.menuFile.ToolTipText = "Tạo 1 file mới.";
            // 
            // menuNew
            // 
            this.menuNew.MergeIndex = 0;
            this.menuNew.Name = "menuNew";
            this.menuNew.Size = new System.Drawing.Size(152, 22);
            this.menuNew.Text = "New";
            this.menuNew.ToolTipText = "Tạo 1 file mới";
            this.menuNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(152, 22);
            this.menuClose.Text = "Close";
            this.menuClose.ToolTipText = "Đóng cửa sổ hiện tại";
            this.menuClose.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuCloseAll
            // 
            this.menuCloseAll.MergeIndex = 3;
            this.menuCloseAll.Name = "menuCloseAll";
            this.menuCloseAll.Size = new System.Drawing.Size(152, 22);
            this.menuCloseAll.Text = "Close all";
            this.menuCloseAll.ToolTipText = "Đóng tất cả cửa sổ.";
            this.menuCloseAll.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopy,
            this.menuCut,
            this.menuPaste});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuCopy
            // 
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(102, 22);
            this.menuCopy.Text = "Copy";
            // 
            // menuCut
            // 
            this.menuCut.Name = "menuCut";
            this.menuCut.Size = new System.Drawing.Size(102, 22);
            this.menuCut.Text = "Cut";
            // 
            // menuPaste
            // 
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.Size = new System.Drawing.Size(102, 22);
            this.menuPaste.Text = "Paste";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Chú ý";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Chú ý:";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // menuWin
            // 
            this.menuWin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascade,
            this.Hor,
            this.Ver});
            this.menuWin.Name = "menuWin";
            this.menuWin.Size = new System.Drawing.Size(63, 20);
            this.menuWin.Text = "&Window";
            // 
            // cascade
            // 
            this.cascade.Name = "cascade";
            this.cascade.Size = new System.Drawing.Size(152, 22);
            this.cascade.Text = "Cascade";
            this.cascade.Click += new System.EventHandler(this.cascade_Click);
            // 
            // Hor
            // 
            this.Hor.Name = "Hor";
            this.Hor.Size = new System.Drawing.Size(152, 22);
            this.Hor.Text = "Tile Horizontal";
            this.Hor.Click += new System.EventHandler(this.Hor_Click);
            // 
            // Ver
            // 
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(152, 22);
            this.Ver.Text = "Tile Vertical";
            this.Ver.Click += new System.EventHandler(this.Ver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 433);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                   MDI";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem menuCloseAll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuCopy;
        private System.Windows.Forms.ToolStripMenuItem menuCut;
        private System.Windows.Forms.ToolStripMenuItem menuPaste;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolStripMenuItem menuWin;
        private System.Windows.Forms.ToolStripMenuItem cascade;
        private System.Windows.Forms.ToolStripMenuItem Hor;
        private System.Windows.Forms.ToolStripMenuItem Ver;
    }
}

