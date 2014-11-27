using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;

namespace soft1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAllZakaz(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");


            listZakazov.Items.Clear();
            xmlParser xml1 = new xmlParser();
            int count = xml1.getCountZakaz();
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (doc.DocumentElement.ChildNodes[i].ChildNodes[2].InnerText != "1")
                    {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem());
                    item.SubItems[0].Text = xml1.getZakaz(i);
                    if (doc.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText == "1")
                        item.ImageIndex = 0; //image
                    listZakazov.Items.Add(item);
                    }
                }
            }

        }

        private void btnAllZakaz_Click(object sender, EventArgs e)
        {
            xml_request server = new xml_request();

            string request = "http://vsiryk.hol.es/xml/test.xml";
            string response = server.getResponse(request);
            server.saveToFile(response);
        }

        private void listZakazov_ItemActivate(object sender, EventArgs e)
        {
            listTovarov.Items.Clear();
            xmlParser xml = new xmlParser();
            for (int i = 0; i < 2; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = xml.getTovarItem(i); ;
                listTovarov.Items.Add(item);
                
            }
        }

    }
}
