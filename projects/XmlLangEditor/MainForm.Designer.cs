namespace XmlLangEditor
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.chAssembly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chzhCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chenUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chAssembly,
            this.chKey,
            this.chDefault,
            this.chzhCN,
            this.chenUS});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 24);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1070, 642);
            this.dgv.TabIndex = 0;
            this.dgv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuImport,
            this.mnuPaste});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(44, 20);
            this.mnuSave.Text = "儲存";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuImport
            // 
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(44, 20);
            this.mnuImport.Text = "匯入";
            this.mnuImport.Visible = false;
            this.mnuImport.Click += new System.EventHandler(this.mnuImport_Click);
            // 
            // chAssembly
            // 
            this.chAssembly.HeaderText = "組件";
            this.chAssembly.Name = "chAssembly";
            this.chAssembly.ReadOnly = true;
            // 
            // chKey
            // 
            this.chKey.HeaderText = "代碼";
            this.chKey.Name = "chKey";
            this.chKey.ReadOnly = true;
            this.chKey.Width = 250;
            // 
            // chDefault
            // 
            this.chDefault.HeaderText = "預設";
            this.chDefault.Name = "chDefault";
            this.chDefault.Width = 260;
            // 
            // chzhCN
            // 
            this.chzhCN.HeaderText = "簡中";
            this.chzhCN.Name = "chzhCN";
            this.chzhCN.Width = 260;
            // 
            // chenUS
            // 
            this.chenUS.HeaderText = "英文";
            this.chenUS.Name = "chenUS";
            this.chenUS.Width = 260;
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(44, 20);
            this.mnuPaste.Text = "貼上";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 666);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Xml Language Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn chAssembly;
        private System.Windows.Forms.DataGridViewTextBoxColumn chKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn chDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn chzhCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn chenUS;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
    }
}

