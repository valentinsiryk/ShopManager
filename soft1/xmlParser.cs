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
        public void parse()
        {
            try
            {
            XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");

            string user = doc.DocumentElement.ChildNodes[0].ChildNodes[1].InnerText;
            /*string password =   doc.DocumentElement.ChildNodes[1].InnerText;

            int port =          int.Parse(doc.DocumentElement.ChildNodes[2].InnerText.Trim());

            string client =     doc.DocumentElement.ChildNodes[3].InnerText;*/

            MessageBox.Show(user, "b");
             }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Error!");
            }
                      
        }
    }
}
