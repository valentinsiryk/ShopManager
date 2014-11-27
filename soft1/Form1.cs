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

        public int curZakazGlobal = 0;

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
                    int position = i;
                    if (doc.DocumentElement.ChildNodes[i].ChildNodes[2].InnerText != "1")
                    {
                        ListViewItem item = new ListViewItem();
                        item.SubItems.Add(new ListViewItem.ListViewSubItem());
                        item.SubItems[0].Text = xml1.getZakaz(i);
                        item.SubItems[1].Text = position.ToString();
                        if (doc.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText == "1")
                            item.ImageIndex = 0; //image
                        listZakazov.Items.Add(item);
                    }
                }
            }

        }

        private void btnGetXml(object sender, EventArgs e)
        {
            xml_request server = new xml_request();

            string request = "http://vsiryk.hol.es/xml/test.xml";
            string response = server.getResponse(request);
            server.saveToFile(response);
        }

        private void listZakazov_Click(object sender, EventArgs e)
        {
            listTovarov.Items.Clear(); //clear list tovarov
            listSkladov.Items.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");
            int curZakaz = Int32.Parse(listZakazov.FocusedItem.SubItems[1].Text);
            curZakazGlobal = curZakaz;

            //xmlParser xml = new xmlParser();
            int countTovarov = doc.DocumentElement.ChildNodes[curZakaz].ChildNodes.Count - 3;
            //MessageBox.Show(countTovarov.ToString(), "ed");

            for (int curTovar = 0; curTovar < countTovarov; curTovar++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = doc.DocumentElement.ChildNodes[curZakaz].ChildNodes[curTovar + 3].ChildNodes[0].InnerText;
                item.SubItems[1].Text = doc.DocumentElement.ChildNodes[curZakaz].ChildNodes[curTovar + 3].ChildNodes[1].InnerText;
                item.SubItems[2].Text = "0";
                listTovarov.Items.Add(item);
            }
        }

        private void listTovarov_Click(object sender, EventArgs e)
        {
            listSkladov.Items.Clear(); //clear list skladov

            XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");
            int curTovar = listTovarov.FocusedItem.Index;
            int countSkladov = 0;
            
            //MessageBox.Show(countTovarov.ToString(), "ed");
            countSkladov = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar+3].ChildNodes[2].ChildNodes.Count;
            
            for (int curSklad = 0; curSklad < countSkladov; curSklad++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                //item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = "sklad" + (curSklad + 1);//doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[0].InnerText;
                item.SubItems[1].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[2].ChildNodes[curSklad].InnerText;
                //item.SubItems[2].Text = "0";
                listSkladov.Items.Add(item);
            }

        }

    }
}
