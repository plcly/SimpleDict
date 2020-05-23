using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDict
{
    interface IPhraseDb
    {
        List<PhraseBook> LoadPhrasesFromDb();
        void SavePhrasesToDb(List<PhraseBook> phraseList);
        void SaveSinglePhraseToDb(PhraseBook phraseList);
    }
}
