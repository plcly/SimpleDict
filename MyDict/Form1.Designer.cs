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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcLeft = new System.Windows.Forms.TabControl();
            this.tpPhrase = new System.Windows.Forms.TabPage();
            this.tpReview = new System.Windows.Forms.TabPage();
            this.lbxReview = new System.Windows.Forms.ListBox();
            this.tpDone = new System.Windows.Forms.TabPage();
            this.lbxDone = new System.Windows.Forms.ListBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcLeft.SuspendLayout();
            this.tpPhrase.SuspendLayout();
            this.tpReview.SuspendLayout();
            this.tpDone.SuspendLayout();
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
            this.wb.Location = new System.Drawing.Point(279, 3);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(1056, 947);
            this.wb.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSearch.Location = new System.Drawing.Point(360, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(387, 38);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseMove);
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
            this.lbxBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxBook.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbxBook.FormattingEnabled = true;
            this.lbxBook.ItemHeight = 26;
            this.lbxBook.Location = new System.Drawing.Point(3, 3);
            this.lbxBook.Name = "lbxBook";
            this.lbxBook.Size = new System.Drawing.Size(266, 928);
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
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 46);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除选中";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tcLeft);
            this.panel1.Controls.Add(this.wb);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 963);
            this.panel1.TabIndex = 11;
            // 
            // tcLeft
            // 
            this.tcLeft.Controls.Add(this.tpPhrase);
            this.tcLeft.Controls.Add(this.tpReview);
            this.tcLeft.Controls.Add(this.tpDone);
            this.tcLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcLeft.Location = new System.Drawing.Point(0, 0);
            this.tcLeft.Name = "tcLeft";
            this.tcLeft.SelectedIndex = 0;
            this.tcLeft.Size = new System.Drawing.Size(280, 963);
            this.tcLeft.TabIndex = 9;
            this.tcLeft.SelectedIndexChanged += new System.EventHandler(this.tcLeft_SelectedIndexChanged);
            // 
            // tpPhrase
            // 
            this.tpPhrase.Controls.Add(this.lbxBook);
            this.tpPhrase.Location = new System.Drawing.Point(4, 25);
            this.tpPhrase.Name = "tpPhrase";
            this.tpPhrase.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhrase.Size = new System.Drawing.Size(272, 934);
            this.tpPhrase.TabIndex = 0;
            this.tpPhrase.Text = "收藏";
            this.tpPhrase.UseVisualStyleBackColor = true;
            // 
            // tpReview
            // 
            this.tpReview.Controls.Add(this.lbxReview);
            this.tpReview.Location = new System.Drawing.Point(4, 25);
            this.tpReview.Name = "tpReview";
            this.tpReview.Padding = new System.Windows.Forms.Padding(3);
            this.tpReview.Size = new System.Drawing.Size(243, 934);
            this.tpReview.TabIndex = 1;
            this.tpReview.Text = "复习";
            this.tpReview.UseVisualStyleBackColor = true;
            // 
            // lbxReview
            // 
            this.lbxReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxReview.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbxReview.FormattingEnabled = true;
            this.lbxReview.ItemHeight = 26;
            this.lbxReview.Location = new System.Drawing.Point(3, 3);
            this.lbxReview.Name = "lbxReview";
            this.lbxReview.Size = new System.Drawing.Size(237, 928);
            this.lbxReview.TabIndex = 9;
            this.lbxReview.DoubleClick += new System.EventHandler(this.lbxBook_DoubleClick);
            // 
            // tpDone
            // 
            this.tpDone.Controls.Add(this.lbxDone);
            this.tpDone.Location = new System.Drawing.Point(4, 25);
            this.tpDone.Name = "tpDone";
            this.tpDone.Padding = new System.Windows.Forms.Padding(3);
            this.tpDone.Size = new System.Drawing.Size(243, 934);
            this.tpDone.TabIndex = 2;
            this.tpDone.Text = "已掌握";
            this.tpDone.UseVisualStyleBackColor = true;
            // 
            // lbxDone
            // 
            this.lbxDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxDone.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbxDone.FormattingEnabled = true;
            this.lbxDone.ItemHeight = 26;
            this.lbxDone.Location = new System.Drawing.Point(3, 3);
            this.lbxDone.Name = "lbxDone";
            this.lbxDone.Size = new System.Drawing.Size(237, 928);
            this.lbxDone.TabIndex = 10;
            this.lbxDone.DoubleClick += new System.EventHandler(this.lbxBook_DoubleClick);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(226, 10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(66, 46);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "已掌握";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(116, 10);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(104, 46);
            this.btnAddReview.TabIndex = 13;
            this.btnAddReview.Text = "添加复习";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 1037);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易单词本";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.LocationChanged += new System.EventHandler(this.frmMain_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.tcLeft.ResumeLayout(false);
            this.tpPhrase.ResumeLayout(false);
            this.tpReview.ResumeLayout(false);
            this.tpDone.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcLeft;
        private System.Windows.Forms.TabPage tpPhrase;
        private System.Windows.Forms.TabPage tpReview;
        private System.Windows.Forms.TabPage tpDone;
        private System.Windows.Forms.ListBox lbxReview;
        private System.Windows.Forms.ListBox lbxDone;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAddReview;
    }
}

