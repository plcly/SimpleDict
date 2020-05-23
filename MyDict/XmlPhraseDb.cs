using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDict
{
    public class XmlPhraseDb : IPhraseDb
    {
        private string dbName;
        public XmlPhraseDb(string dbName)
        {
            this.dbName = dbName;
        }
        public List<PhraseBook> LoadPhrasesFromDb()
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
            var xml = XmlHelper.Serialize(phraseList);
            File.WriteAllText(dbName, xml);
        }

        public void SaveSinglePhraseToDb(PhraseBook phraseList)
        {
            throw new NotImplementedException();
        }
    }
}
