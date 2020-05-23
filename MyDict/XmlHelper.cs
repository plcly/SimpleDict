using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MyDict
{
    public class XmlHelper
    {
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
    }
}
