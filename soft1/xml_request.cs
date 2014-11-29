using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Xml;

namespace soft1
{
    public class xml_request
    {
        public XmlDocument getXmlDoc(string url) //функция возвращает XmlDocument, для дальнейшего парсинга
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            return doc;
        }

        public void saveToFile(string text, string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(text);
                    fs.Write(info, 0, info.Length); // Add some information to the file.
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error!");
            }
            
        }
    }
}
