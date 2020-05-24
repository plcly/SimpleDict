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
        private static readonly string defaultLabelText = "Empty here";
        private int phraseIndex = 0;
        private frmMain mainForm;
        public PhraseForm()
        {
            InitializeComponent();
            lblPhrase.Text = defaultLabelText;
        }
        public PhraseForm(List<PhraseBook> listPhraseBook, frmMain mainForm)
        {
            InitializeComponent();
            lblPhrase.Text = defaultLabelText;
            this.listPhraseBook = listPhraseBook;
            this.mainForm = mainForm;
        }

        private void PhraseForm_Load(object sender, EventArgs e)
        {
            if (listPhraseBook != null && listPhraseBook.Count > 0)
            {
                ShowPhrase();
            }
        }

        private void ShowPhrase()
        {
            if (listPhraseBook != null && listPhraseBook.Count > 0 && phraseIndex >= 0 && phraseIndex < listPhraseBook.Count)
            {
                lblPhrase.Text = listPhraseBook[phraseIndex].WordSourceName;
            }
            else
            {
                lblPhrase.Text = defaultLabelText;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (phraseIndex == 0)
            {
                phraseIndex = listPhraseBook.Count - 1;
            }
            else
            {
                phraseIndex--;
            }            
            ShowPhrase();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (phraseIndex == listPhraseBook.Count - 1)
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
    }
}
