namespace LangEditor
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLang = new System.Windows.Forms.DataGridView();
            this.chKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLang)).BeginInit();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mainmenu.Size = new System.Drawing.Size(886, 26);
            this.mainmenu.TabIndex = 0;
            this.mainmenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.exportXmlToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 20);
            this.mnuFile.Text = "檔案";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "Open...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnuSaveAs.Text = "Save As...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(152, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // dgvLang
            // 
            this.dgvLang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLang.BackgroundColor = System.Drawing.Color.White;
            this.dgvLang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chKey,
            this.chValue});
            this.dgvLang.Location = new System.Drawing.Point(13, 30);
            this.dgvLang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLang.Name = "dgvLang";
            this.dgvLang.RowTemplate.Height = 24;
            this.dgvLang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLang.Size = new System.Drawing.Size(860, 623);
            this.dgvLang.TabIndex = 1;
            // 
            // chKey
            // 
            this.chKey.HeaderText = "代碼";
            this.chKey.Name = "chKey";
            this.chKey.Width = 200;
            // 
            // chValue
            // 
            this.chValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chValue.HeaderText = "資料值";
            this.chValue.Name = "chValue";
            // 
            // exportXmlToolStripMenuItem
            // 
            this.exportXmlToolStripMenuItem.Name = "exportXmlToolStripMenuItem";
            this.exportXmlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportXmlToolStripMenuItem.Text = "Export Xml";
            this.exportXmlToolStripMenuItem.Click += new System.EventHandler(this.exportXmlToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 666);
            this.Controls.Add(this.dgvLang);
            this.Controls.Add(this.mainmenu);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainmenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FISCA 語系編輯器";
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.DataGridView dgvLang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn chValue;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem exportXmlToolStripMenuItem;
    }
}

