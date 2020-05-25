namespace SimpleDict
{
    partial class PhraseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhraseForm));
            this.lblPhrase = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnShowInMain = new System.Windows.Forms.Button();
            this.btnAddReview = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnOpenReview = new System.Windows.Forms.Button();
            this.btnPhrase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhrase
            // 
            this.lblPhrase.AutoSize = true;
            this.lblPhrase.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhrase.Location = new System.Drawing.Point(331, 161);
            this.lblPhrase.Name = "lblPhrase";
            this.lblPhrase.Size = new System.Drawing.Size(118, 24);
            this.lblPhrase.TabIndex = 0;
            this.lblPhrase.Text = "No Phrase";
            this.lblPhrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(143, 367);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 57);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(573, 367);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 57);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnShowInMain
            // 
            this.btnShowInMain.Location = new System.Drawing.Point(320, 367);
            this.btnShowInMain.Name = "btnShowInMain";
            this.btnShowInMain.Size = new System.Drawing.Size(151, 49);
            this.btnShowInMain.TabIndex = 3;
            this.btnShowInMain.Text = "在主窗口中查询";
            this.btnShowInMain.UseVisualStyleBackColor = true;
            this.btnShowInMain.Click += new System.EventHandler(this.btnShowInMain_Click);
            // 
            // btnAddReview
            // 
            this.btnAddReview.Location = new System.Drawing.Point(12, 35);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(104, 57);
            this.btnAddReview.TabIndex = 4;
            this.btnAddReview.Text = "添加到复习";
            this.btnAddReview.UseVisualStyleBackColor = true;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(12, 205);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(104, 57);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "已掌握";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnOpenReview
            // 
            this.btnOpenReview.Location = new System.Drawing.Point(12, 120);
            this.btnOpenReview.Name = "btnOpenReview";
            this.btnOpenReview.Size = new System.Drawing.Size(104, 57);
            this.btnOpenReview.TabIndex = 6;
            this.btnOpenReview.Text = "打开复习";
            this.btnOpenReview.UseVisualStyleBackColor = true;
            this.btnOpenReview.Click += new System.EventHandler(this.btnOpenReview_Click);
            // 
            // btnPhrase
            // 
            this.btnPhrase.Location = new System.Drawing.Point(12, 290);
            this.btnPhrase.Name = "btnPhrase";
            this.btnPhrase.Size = new System.Drawing.Size(104, 57);
            this.btnPhrase.TabIndex = 7;
            this.btnPhrase.Text = "打开生词";
            this.btnPhrase.UseVisualStyleBackColor = true;
            this.btnPhrase.Click += new System.EventHandler(this.btnPhrase_Click);
            // 
            // PhraseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhrase);
            this.Controls.Add(this.btnOpenReview);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.btnShowInMain);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.lblPhrase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhraseForm";
            this.Text = "生词本";
            this.Load += new System.EventHandler(this.PhraseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhrase;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnShowInMain;
        private System.Windows.Forms.Button btnAddReview;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnOpenReview;
        private System.Windows.Forms.Button btnPhrase;
    }
}