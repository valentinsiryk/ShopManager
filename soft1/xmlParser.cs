using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

using System.Xml;

namespace soft1
{
    class xmlParser
    {
        public int getCountZakaz()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");
            return doc.DocumentElement.ChildNodes.Count; 
        }


        public string getZakaz(int i)
        {
      
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(".\\test.xml");
                string zakazId = doc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText;

                return zakazId;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error!");
                return "error";
            }

        }

        public string getTovarItem(int i)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(".\\test.xml");
                string zakaz = doc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText;
                MessageBox.Show(doc.DocumentElement.ChildNodes[i].NextSibling.InnerText, "j");
                return zakaz;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error!");
                return "error";
            }
        }
    }
}
