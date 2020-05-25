using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDict
{
    public partial class frmMain : Form
    {
        
        private string dictUrl;
        private bool isAutoCheck;
        private List<PhraseBook> listPhrase;
        private IPhraseDb phraseDb;
        public frmMain()
        {
            InitializeComponent();
            phraseDb = new XmlPhraseDb();
            dictUrl = ConfigurationManager.AppSettings[Const.DictConfigName];
            isAutoCheck = bool.Parse(ConfigurationManager.AppSettings[Const.IsAutoCheckConfigName]);
            chkAuto.Checked = isAutoCheck;
            listPhrase = phraseDb.LoadPhrasesFromDb();
            BindListBox();
            txtSearch.GotFocus += txtSelectAll;
            txtSearch.Focus();
        }
        private void txtSelectAll(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }
        private void frmMain_Activated(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }
        private void frmMain_LocationChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                Search();
                e.Handled = true;
            }
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            isAutoCheck = chkAuto.Checked;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[Const.IsAutoCheckConfigName].Value = isAutoCheck.ToString();
            config.Save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePhrase();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var item = lbxBook.SelectedItem as PhraseBook;
            if (item != null)
            {
                listPhrase.Remove(item);
                BindListBox();
            }
            phraseDb.SavePhrasesToDb(listPhrase);
        }
        private void lbxBook_DoubleClick(object sender, EventArgs e)
        {
            var item = lbxBook.SelectedItem as PhraseBook;
            if (item != null)
            {
                Search(item.WordSourceName);
            }
        }
        private void btnSavePhrase_Click(object sender, EventArgs e)
        {
            phraseDb.SavePhrasesToDb(listPhrase);
        }
        #region Methods
        public void Search(string txt = null)
        {
            if (string.IsNullOrEmpty(txt))
            {
                txt = txtSearch.Text;
            }
            if (isAutoCheck)
            {
                SavePhrase();
            }
            
            wb.Navigate(dictUrl + txt);
        }
        private void SavePhrase()
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text)
                && !listPhrase.Any(p => p.WordSourceName == txtSearch.Text.Trim()))
            {
                listPhrase.Add(new PhraseBook
                {
                    WordSourceName = txtSearch.Text.Trim()
                });
                BindListBox();
                phraseDb.SavePhrasesToDb(listPhrase);
            }
        }
        private void BindListBox()
        {
            lbxBook.DataSource = null;
            lbxBook.DataSource = listPhrase;
            lbxBook.DisplayMember = "WordSourceName";
        }



        #endregion

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            phraseDb.SavePhrasesToDb(listPhrase);
            PhraseForm phraseForm = new PhraseForm(listPhrase,this);
            phraseForm.Show();
        }

        private void txtSearch_MouseMove(object sender, MouseEventArgs e)
        {
            txtSearch.Focus();
        }
    }
}
