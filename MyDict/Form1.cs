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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MyDict
{
    public partial class Form1 : Form
    {
        private static readonly string dbName = "xmldb.xml";
        private string dictUrl;
        private bool isAutoCheck;
        private List<PhraseBook> listPhrase;
        public Form1()
        {
            InitializeComponent();
            dictUrl = ConfigurationManager.AppSettings["dictUrl"];
            isAutoCheck = chkAuto.Checked;
            listPhrase = LoadPhrases();
            BindListBox();
            txtSearch.Focus();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }
        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }
        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
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
        }
        private void lbxBook_DoubleClick(object sender, EventArgs e)
        {
            var item = lbxBook.SelectedItem as PhraseBook;
            if (item != null)
            {
                Search(item.WordSourceName);
            }
        }
        #region Methods
        private void Search(string txt = null)
        {
            if (string.IsNullOrEmpty(txt))
            {
                txt = txtSearch.Text;
            }
            if (isAutoCheck)
            {
                SavePhrase();
            }
            wb.Url = new Uri(dictUrl + txt);
        }
        private List<PhraseBook> LoadPhrases()
        {
            if (!File.Exists(dbName))
            {
                return new List<PhraseBook>();
            }
            var xml = File.ReadAllText(dbName);
            if (string.IsNullOrEmpty(xml))
            {
                return new List<PhraseBook>();
            }
            var listPhrase = Deserialize<List<PhraseBook>>(xml);
            return listPhrase;
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
            }
        }
        private void BindListBox()
        {
            lbxBook.DataSource = null;
            lbxBook.DataSource = listPhrase;
            lbxBook.DisplayMember = "WordSourceName";
            var xml = Serialize(listPhrase);
            File.WriteAllText(dbName, xml);
        }

        public static string Serialize<T>(T model) where T : class
        {
            string xml;
            using (var ms = new MemoryStream())
            {
                XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                xmlSer.Serialize(ms, model);
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                xml = sr.ReadToEnd();
            }
            return xml;
        }

        public static T Deserialize<T>(string strXml) where T : class
        {
            try
            {
                object obj;
                using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(strXml)))
                {
                    using (XmlReader xmlReader = XmlReader.Create(memoryStream))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                        obj = xmlSerializer.Deserialize(xmlReader);
                    }
                }
                return obj as T;
            }
            catch (Exception)
            {
                return null;
            }
        }





        #endregion

        
    }
}
