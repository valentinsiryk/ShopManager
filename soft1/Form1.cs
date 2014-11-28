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
            comboBoxZakazov.SelectedIndex = 0;
        }

        public int otgruzOk = 1;
        public int curZakazGlobal = 0;

        private void btnShowAllZakaz(object sender, EventArgs e)
        {
            otgruzOk = 1;

            listZakazov.Items.Clear(); //clear list zakazov
            listTovarov.Items.Clear(); //clear list tovarov
            listSkladov.Items.Clear(); //clear list skladov

            //XmlDocument doc = new XmlDocument();
            //doc.Load(".\\test.xml");  //load xml into the file 
            xml_request req = new xml_request();
            XmlDocument doc = req.getXmlDoc("http://vsiryk.hol.es/xml/test.xml");


            int countZakazov = doc.DocumentElement.ChildNodes.Count;

            for (int i = 0; i < countZakazov; i++)
            {
                if (doc.DocumentElement.ChildNodes[i].ChildNodes[2].InnerText == comboBoxZakazov.SelectedIndex.ToString())
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem());
                    item.SubItems[0].Text = doc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText; //id zakaza
                    //item.SubItems[1].Text = i.ToString(); //!
                    if (doc.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText == "1") //status vipolneniya
                        item.ImageIndex = 0; //image
                    listZakazov.Items.Add(item);
                }
            }

        }

        private void btnGetXml(object sender, EventArgs e)
        {
                xml_request server = new xml_request();

                string request = "http://vsiryk.hol.es/xml/test.xml";
                string response = server.getXmlDoc(request).InnerXml;

                server.saveToFile(response, @".\response.xml");
        }

        private void listZakazov_Click(object sender, EventArgs e)
        {
            listTovarov.Items.Clear(); //clear list tovarov
            listSkladov.Items.Clear(); //clear list skladov

            /*XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");*/

            xml_request req = new xml_request();
            XmlDocument doc = req.getXmlDoc("http://vsiryk.hol.es/xml/test.xml");

            string curZakazId = listZakazov.SelectedItems[0].SubItems[0].Text;

            curZakazGlobal = 0;
            while (curZakazId != doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[0].InnerText)
            {
                curZakazGlobal++;
            }

            int countTovarov = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes.Count - 3;
            for (int curTovar = 0; curTovar < countTovarov; curTovar++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[0].InnerText;
                item.SubItems[1].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[1].InnerText;
                item.SubItems[2].Text = "0";
                listTovarov.Items.Add(item);
            }
        }

        private void listTovarov_Click(object sender, EventArgs e)
        {
            listSkladov.Items.Clear(); //clear list skladov
            showSklady(listTovarov.SelectedItems[0].SubItems[0].Text); //подставить айди желаемого товара


            
            /*
            XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");

            int curTovar = listTovarov.FocusedItem.Index;
            int countSkladov = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[2].ChildNodes.Count;

            for (int curSklad = 0; curSklad < countSkladov; curSklad++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[2].ChildNodes[curSklad].ChildNodes[0].InnerText;
                item.SubItems[1].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[2].ChildNodes[curSklad].ChildNodes[1].InnerText;
                listSkladov.Items.Add(item);
            }
            */

        }

        void showSklady(string idTovara)
        {
            string req = "http://vsiryk.hol.es/xml/sklady.xml";
            xml_request server = new xml_request();
            /*
            string response = server.getXmlDoc(req).InnerXml;
            server.saveToFile(response, @".\response_sklady.xml");

            XmlDocument docSklady = new XmlDocument();
            docSklady.Load(".\\response_sklady.xml");*/
            XmlDocument docSklady = server.getXmlDoc(req);
            int countSkladov = docSklady.DocumentElement.ChildNodes.Count;

            for (int i = 0; i < countSkladov; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = docSklady.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText;
                item.SubItems[1].Text = docSklady.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText;
                listSkladov.Items.Add(item);
            }
        }




        private void btnOtgruz_Click(object sender, EventArgs e)
        {
            try
            {
                decimal numValue = numericUpDown1.Value;
                decimal curSucNum = Int32.Parse(listTovarov.SelectedItems[0].SubItems[2].Text);
                decimal curSkladNal = Int32.Parse(listSkladov.SelectedItems[0].SubItems[1].Text);
                decimal curZakazTovNum = Int32.Parse(listTovarov.SelectedItems[0].SubItems[1].Text);


                /*else if (curSucNum > Int32.Parse(listTovarov.SelectedItems[0].SubItems[1].Text))
                    MessageBox.Show("Количество отгрузки превышает количество заказа!", "Error!");*/
                {
                    decimal val = curSucNum + numValue;
                    if (numValue > Int32.Parse(listSkladov.SelectedItems[0].SubItems[1].Text))
                        MessageBox.Show("Недостаточно товара на складе!", "Error!");
                    else if ((curSucNum + numValue) > Int32.Parse(listTovarov.SelectedItems[0].SubItems[1].Text))
                        MessageBox.Show("Количество отгрузки превышает количество заказа!", "Error!");
                    else
                    {
                        if (numValue > 0)
                        {
                            otgruzOk = 0;
                            listTovarov.SelectedItems[0].SubItems[2].Text = val.ToString();
                            listSkladov.SelectedItems[0].SubItems[1].Text = (curSkladNal - numValue).ToString();
                            if (listTovarov.SelectedItems[0].SubItems[1].Text == listTovarov.SelectedItems[0].SubItems[2].Text)
                                otgruzOk = 1;

                        }
                    }
                    /*curSkladNal -= numericUpDown1.Value;
                    listSkladov.SelectedItems[0].SubItems[1].Text = curSkladNal.ToString();*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нужно выбрать склад!", "Error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xml_request req = new xml_request();

            MessageBox.Show(req.getXmlDoc("http://xml.weather.yahoo.com/forecastrss?p=94704").InnerXml, "xml doc");
        }


    }
}
