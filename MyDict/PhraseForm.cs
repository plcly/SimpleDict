using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDict
{
    public partial class PhraseForm : Form
    {
        private List<PhraseBook> listPhraseBook = new List<PhraseBook>();
        private List<PhraseBook> listDonePhraseBook = new List<PhraseBook>();
        private List<PhraseBook> listReviewPhraseBook = new List<PhraseBook>();
        private int phraseIndex = 0;
        private frmMain mainForm;
        private IPhraseDb phraseDb;
        private PhraseStatus phraseStatus;
        public PhraseForm()
        {
            InitializeComponent();
        }
        public PhraseForm(List<PhraseBook> listPhraseBook, frmMain mainForm)
        {
            InitializeComponent();
            phraseDb = new XmlPhraseDb();
            lblPhrase.Text = Const.DefaultLabelText;
            this.listPhraseBook = listPhraseBook;
            this.mainForm = mainForm;
            listReviewPhraseBook = phraseDb.LoadReviewPhrasesFromDb();
            listDonePhraseBook = phraseDb.LoadDonePhrasesFromDb();
            phraseStatus = PhraseStatus.Phrase;
        }

        private void PhraseForm_Load(object sender, EventArgs e)
        {
            ShowPhrase();
        }

        private void ShowPhrase()
        {
            List<PhraseBook> listPhraseBookActive = null;
            switch (phraseStatus)
            {
                case PhraseStatus.Phrase:
                    listPhraseBookActive = listPhraseBook;
                    break;
                case PhraseStatus.Review:
                    listPhraseBookActive = listReviewPhraseBook;
                    break;
                default:
                    break;
            }
            if (listPhraseBookActive != null && listPhraseBookActive.Count > 0 && phraseIndex >= 0 && phraseIndex < listPhraseBookActive.Count)
            {
                lblPhrase.Text = listPhraseBookActive[phraseIndex].WordSourceName;
            }
            else
            {
                lblPhrase.Text = Const.DefaultLabelText;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            List<PhraseBook> listPhraseBookActive = null;
            switch (phraseStatus)
            {
                case PhraseStatus.Phrase:
                    listPhraseBookActive = listPhraseBook;
                    break;
                case PhraseStatus.Review:
                    listPhraseBookActive = listReviewPhraseBook;
                    break;
                default:
                    break;
            }
            if (phraseIndex == 0)
            {
                phraseIndex = listPhraseBookActive.Count - 1;
            }
            else
            {
                phraseIndex--;
            }
            ShowPhrase();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<PhraseBook> listPhraseBookActive = null;
            switch (phraseStatus)
            {
                case PhraseStatus.Phrase:
                    listPhraseBookActive = listPhraseBook;
                    break;
                case PhraseStatus.Review:
                    listPhraseBookActive = listReviewPhraseBook;
                    break;
                default:
                    break;
            }
            if (phraseIndex == listPhraseBookActive.Count - 1)
            {
                phraseIndex = 0;
            }
            else
            {
                phraseIndex++;
            }
            ShowPhrase();
        }

        private void btnShowInMain_Click(object sender, EventArgs e)
        {
            mainForm.Search(lblPhrase.Text);
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (!listReviewPhraseBook.Any(p => p.WordSourceName == lblPhrase.Text))
            {
                listReviewPhraseBook.Add(new PhraseBook { WordSourceName = lblPhrase.Text });
                phraseDb.SaveReviewPhrasesToDb(listReviewPhraseBook);
            }
        }

        private void btnOpenReview_Click(object sender, EventArgs e)
        {
            phraseStatus = PhraseStatus.Review;
            phraseIndex = 0;
            ShowPhrase();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            List<PhraseBook> listPhraseBookActive = null;
            switch (phraseStatus)
            {
                case PhraseStatus.Phrase:
                    listPhraseBookActive = listPhraseBook;
                    break;
                case PhraseStatus.Review:
                    listPhraseBookActive = listReviewPhraseBook;
                    break;
                default:
                    break;
            }
            var item = listPhraseBookActive.FirstOrDefault(p => p.WordSourceName == lblPhrase.Text);
            if (item != null)
            {
                listPhraseBookActive.Remove(item);
                if (!listDonePhraseBook.Any(p => p.WordSourceName == lblPhrase.Text))
                {
                    listDonePhraseBook.Add(item);
                }

                switch (phraseStatus)
                {
                    case PhraseStatus.Phrase:
                        phraseDb.SavePhrasesToDb(listPhraseBookActive);
                        break;
                    case PhraseStatus.Review:
                        phraseDb.SaveReviewPhrasesToDb(listPhraseBookActive);
                        break;
                    default:
                        break;
                }

                phraseDb.SaveDonePhrasesToDb(listDonePhraseBook);
            }
            phraseIndex = 0;
            ShowPhrase();
        }

        private void btnPhrase_Click(object sender, EventArgs e)
        {
            phraseStatus = PhraseStatus.Phrase;
            phraseIndex = 0;
            ShowPhrase();
        }
    }
}
