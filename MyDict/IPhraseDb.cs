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
        List<PhraseBook> LoadReviewPhrasesFromDb();
        List<PhraseBook> LoadDonePhrasesFromDb();
        void SaveSinglePhraseToDb(PhraseBook phraseList);
        void SavePhrasesToDb(List<PhraseBook> phraseList);
        void SaveReviewPhrasesToDb(List<PhraseBook> phraseList);
        void SaveDonePhrasesToDb(List<PhraseBook> phraseList);
    }
}
