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
        private List<PhraseBook> listReviewPhraseBook;
        private List<PhraseBook> listDonePhraseBook;
        private IPhraseDb phraseDb;
        private PhraseStatus phraseStatus;
        public frmMain()
        {
            InitializeComponent();
            phraseDb = new XmlPhraseDb();
            dictUrl = ConfigurationManager.AppSettings[Const.DictConfigName];
            isAutoCheck = bool.Parse(ConfigurationManager.AppSettings[Const.IsAutoCheckConfigName]);
            chkAuto.Checked = isAutoCheck;
            listPhrase = phraseDb.LoadPhrasesFromDb();
            listReviewPhraseBook = phraseDb.LoadReviewPhrasesFromDb();
            listDonePhraseBook = phraseDb.LoadDonePhrasesFromDb();
            phraseStatus = PhraseStatus.Phrase;
            BindListBoxes();
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
            var listBox = GetListBox();
            var item = listBox.SelectedItem as PhraseBook;
            if (item != null)
            {
                switch (phraseStatus)
                {
                    case PhraseStatus.Phrase:
                        listPhrase.Remove(item);
                        break;
                    case PhraseStatus.Review:
                        listReviewPhraseBook.Remove(item);
                        break;
                    case PhraseStatus.Done:
                        listDonePhraseBook.Remove(item);
                        break;
                    default:
                        break;
                }
                BindListBoxes();
                SavePhraseByeState();
            }
        }

        private void SavePhraseByeState()
        {
            switch (phraseStatus)
            {
                case PhraseStatus.Phrase:
                    phraseDb.SavePhrasesToDb(listPhrase);
                    break;
                case PhraseStatus.Review:
                    phraseDb.SaveReviewPhrasesToDb(listReviewPhraseBook);
                    break;
                case PhraseStatus.Done:
                    phraseDb.SaveDonePhrasesToDb(listDonePhraseBook);
                    break;
                default:
                    break;
            }
        }
        private void SavePhraseAll()
        {
            phraseDb.SavePhrasesToDb(listPhrase);
            phraseDb.SaveReviewPhrasesToDb(listReviewPhraseBook);
            phraseDb.SaveDonePhrasesToDb(listDonePhraseBook);
        }
        private ListBox GetListBox()
        {
            switch (phraseStatus)
            {
                case PhraseStatus.Phrase:
                    return lbxBook;
                case PhraseStatus.Review:
                    return lbxReview;
                case PhraseStatus.Done:
                    return lbxDone;
                default:
                    return lbxBook;
            }
        }

        private void lbxBook_DoubleClick(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;
            var item = listBox.SelectedItem as PhraseBook;
            if (item != null)
            {
                Search(item.WordSourceName);
            }
        }
        #region Methods
        public void Search(string txt = null)
        {
            if (string.IsNullOrEmpty(txt))
            {
                txt = txtSearch.Text;
            }
            txtSearch.Text = txt;
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
                BindListBoxes();
                phraseDb.SavePhrasesToDb(listPhrase);
            }
        }
        private void BindListBoxes()
        {
            lbxBook.DataSource = null;
            lbxBook.DataSource = listPhrase;
            lbxBook.DisplayMember = "WordSourceName";

            lbxReview.DataSource = null;
            lbxReview.DataSource = listReviewPhraseBook;
            lbxReview.DisplayMember = "WordSourceName";

            lbxDone.DataSource = null;
            lbxDone.DataSource = listDonePhraseBook;
            lbxDone.DisplayMember = "WordSourceName";
        }



        #endregion

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            phraseDb.SavePhrasesToDb(listPhrase);
            PhraseForm phraseForm = new PhraseForm(listPhrase, this);
            phraseForm.Show();
        }

        private void txtSearch_MouseMove(object sender, MouseEventArgs e)
        {
            txtSearch.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Search();

        }

        private void tcLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcLeft.SelectedTab.Name)
            {
                case "tpPhrase":
                    phraseStatus = PhraseStatus.Phrase;
                    break;
                case "tpReview":
                    phraseStatus = PhraseStatus.Review;
                    break;
                case "tpDone":
                    phraseStatus = PhraseStatus.Done;
                    break;
                default:
                    break;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            var listBox = GetListBox();
            var item = listBox.SelectedItem as PhraseBook;
            if (item != null)
            {
                switch (phraseStatus)
                {
                    case PhraseStatus.Phrase:
                        listPhrase.Remove(item);
                        break;
                    case PhraseStatus.Review:
                        listReviewPhraseBook.Remove(item);
                        break;
                    default:
                        return;
                }
                if (!listDonePhraseBook.Any(p => p.WordSourceName == item.WordSourceName))
                {
                    listDonePhraseBook.Add(item);
                }
                SavePhraseAll();
                BindListBoxes();
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            var listBox = GetListBox();
            var item = listBox.SelectedItem as PhraseBook;
            if (item != null)
            {
                switch (phraseStatus)
                {
                    case PhraseStatus.Phrase:
                        listPhrase.Remove(item);
                        break;
                    case PhraseStatus.Done:
                        listDonePhraseBook.Remove(item);
                        break;
                    default:
                        return;
                }
                if (!listReviewPhraseBook.Any(p => p.WordSourceName == item.WordSourceName))
                {
                    listReviewPhraseBook.Add(item);
                }
                SavePhraseAll();
                BindListBoxes();
            }
        }
    }
}
