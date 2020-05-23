namespace SimpleDict
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSearch = new System.Windows.Forms.Button();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.lbxBook = new System.Windows.Forms.ListBox();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSavePhrase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(753, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(370, 66);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(980, 964);
            this.wb.TabIndex = 3;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearch.Location = new System.Drawing.Point(370, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(348, 38);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(880, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 46);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "收藏";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(1119, 31);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(89, 19);
            this.chkAuto.TabIndex = 7;
            this.chkAuto.Text = "自动收藏";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // lbxBook
            // 
            this.lbxBook.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbxBook.FormattingEnabled = true;
            this.lbxBook.ItemHeight = 26;
            this.lbxBook.Location = new System.Drawing.Point(12, 66);
            this.lbxBook.Name = "lbxBook";
            this.lbxBook.Size = new System.Drawing.Size(352, 966);
            this.lbxBook.TabIndex = 8;
            this.lbxBook.DoubleClick += new System.EventHandler(this.lbxBook_DoubleClick);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(1007, 10);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(75, 46);
            this.btnFavorite.TabIndex = 6;
            this.btnFavorite.Text = "生词本";
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 46);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除选中";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSavePhrase
            // 
            this.btnSavePhrase.Location = new System.Drawing.Point(197, 10);
            this.btnSavePhrase.Name = "btnSavePhrase";
            this.btnSavePhrase.Size = new System.Drawing.Size(75, 46);
            this.btnSavePhrase.TabIndex = 10;
            this.btnSavePhrase.Text = "保存";
            this.btnSavePhrase.UseVisualStyleBackColor = true;
            this.btnSavePhrase.Click += new System.EventHandler(this.btnSavePhrase_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 1037);
            this.Controls.Add(this.btnSavePhrase);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbxBook);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易单词本";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.LocationChanged += new System.EventHandler(this.frmMain_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.ListBox lbxBook;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSavePhrase;
    }
}

