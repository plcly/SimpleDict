using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDict
{
    public class Const
    {
        public static readonly string DefaultLabelText = "Empty here";
        public static readonly string DbName = "xmldb.xml";
        public static readonly string DbReviewName = "xmlReviewdb.xml";
        public static readonly string DbDoneName = "xmlDondb.xml";
        public static readonly string DictConfigName = "DictUrl";
        public static readonly string IsAutoCheckConfigName = "IsAutoCheck";
    }
    public enum PhraseStatus
    {
        Phrase,
        Review,
        Done
    }
}
