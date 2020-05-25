using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDict
{
    public class XmlPhraseDb : IPhraseDb
    {
        public List<PhraseBook> LoadPhrasesFromDb()
        {
            return LoadPhrasesFromDb(Const.DbName);
        }
        public List<PhraseBook> LoadReviewPhrasesFromDb()
        {
            return LoadPhrasesFromDb(Const.DbReviewName);
        }
        public List<PhraseBook> LoadDonePhrasesFromDb()
        {
            return LoadPhrasesFromDb(Const.DbDoneName);
        }
        private List<PhraseBook> LoadPhrasesFromDb(string dbName)
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
            var listPhrase = XmlHelper.Deserialize<List<PhraseBook>>(xml);
            return listPhrase;
        }
        public void SavePhrasesToDb(List<PhraseBook> phraseList)
        {
            SavePhrasesToDb(phraseList, Const.DbName);
        }
        public void SaveReviewPhrasesToDb(List<PhraseBook> phraseList)
        {
            SavePhrasesToDb(phraseList, Const.DbReviewName);
        }
        public void SaveDonePhrasesToDb(List<PhraseBook> phraseList)
        {
            SavePhrasesToDb(phraseList, Const.DbDoneName);
        }
        private void SavePhrasesToDb(List<PhraseBook> phraseList, string dbName)
        {
            var xml = XmlHelper.Serialize(phraseList);
            File.WriteAllText(dbName, xml);
        }

        public void SaveSinglePhraseToDb(PhraseBook phraseList)
        {
            throw new NotImplementedException();
        }
    }
}
