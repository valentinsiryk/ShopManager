using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
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

        //public int otgruzOk = 1;
        public int curZakazGlobal = 0;

        private void btnShowAllZakaz(object sender, EventArgs e)
        {
            //otgruzOk = 1;

            listZakazov.Items.Clear(); //clear list zakazov
            listTovarov.Items.Clear(); //clear list tovarov
            listSkladov.Items.Clear(); //clear list skladov
            DescriptionIn.Text = "Описание товара...";

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
            DescriptionIn.Text = "Описание товара...";

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
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[0].InnerText;
                //item.SubItems[1].Text = getNameInfTovar(item.SubItems[0].Text, "name"); //берем имя с базы
                item.SubItems[1].Text = "name"; //name tovara
                item.SubItems[2].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[1].InnerText;
                item.SubItems[3].Text = "0";
                listTovarov.Items.Add(item);
            }
        }

        private string getNameInfTovar(string idTovara, string key)
        {
            xml_request req = new xml_request();
            string url = "http://192.168.35.19/Index.php?option=inf_tov&id_tov=" + idTovara;
            MessageBox.Show(url, "url");
            XmlDocument doc = req.getXmlDoc(url);
            if (key == "name")
                return doc.DocumentElement.ChildNodes[0].InnerText;
            else if (key == "info")
                return doc.DocumentElement.ChildNodes[1].InnerText;
            else
                return "error";
        }

        private void listTovarov_Click(object sender, EventArgs e)
        {
            string idTovara = listTovarov.SelectedItems[0].SubItems[0].Text; //подставить айди желаемого товара

            xml_request server = new xml_request();
            string req_descr = "http://vsiryk.hol.es/xml/descr.xml";

            //DescriptionIn.Text = getNameInfTovar(idTovara, "info");


            XmlDocument docDeskr = server.getXmlDoc(req_descr);
            DescriptionIn.Text = docDeskr.DocumentElement.InnerText;

            skladListUpdate(idTovara);
            /*
            XmlDocument docSklady = server.getXmlDoc(req_sklady);
            int countSkladov = docSklady.DocumentElement.ChildNodes.Count;

            for (int i = 0; i < countSkladov; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = docSklady.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText;
                item.SubItems[1].Text = docSklady.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText;
                listSkladov.Items.Add(item);
            }*/
        }

        private void skladListUpdate(string idTovara)
        {
            listSkladov.Items.Clear();
            xml_request server = new xml_request();
            string req_sklady = "http://vsiryk.hol.es/xml/sklady.xml"; //+ idTovara
            XmlDocument docSklady = server.getXmlDoc(req_sklady);
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
                if (numValue > 0)
                {
                    decimal curSucNum = Int32.Parse(listTovarov.SelectedItems[0].SubItems[3].Text);
                    decimal curSkladNal = Int32.Parse(listSkladov.SelectedItems[0].SubItems[1].Text);
                    decimal curCountTovarov = Int32.Parse(listTovarov.SelectedItems[0].SubItems[2].Text);


                    if (numValue > curSkladNal)
                        MessageBox.Show("Недостаточно товара на складе!", "Error!");
                    else if ((curSucNum + numValue) > curCountTovarov)
                        MessageBox.Show("Количество отгрузки превышает количество заказа!", "Error!");
                    else
                    {
                        decimal val = curSucNum + numValue;

                        listTovarov.SelectedItems[0].SubItems[3].Text = val.ToString();
                        listSkladov.SelectedItems[0].SubItems[1].Text = (curSkladNal - numValue).ToString();

                        XmlFile req = new XmlFile();
                        string idTovara = listTovarov.SelectedItems[0].SubItems[0].Text;
                        string idSklada = listSkladov.SelectedItems[0].SubItems[0].Text;
                        string url = "http://192.168.35.19/Index.php?option=otgryz&id_tovar=" + idTovara + "&id_sclad=" + idSklada + "&kol_vo=" + numValue.ToString();
                        //MessageBox.Show(url, "url");
                        //req.getResponseFromServer(url);

                        WebRequest.Create(url); // Create a request for the URL. 
                    }
                }
                //skladListUpdate(listTovarov.SelectedItems[0].SubItems[0].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xml_request req = new xml_request();

            MessageBox.Show(req.getXmlDoc("http://xml.weather.yahoo.com/forecastrss?p=94704").InnerXml, "xml doc");
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            try
            {
                int countTov = listTovarov.Items.Count;
                int flag = 0;

                for (int curTov = 0; curTov < countTov; curTov++)
                    if (listTovarov.Items[curTov].SubItems[2].Text != listTovarov.Items[curTov].SubItems[3].Text)
                        flag = 1;
                if (flag == 0)
                {
                    string url = "http://192.168.35.19/Index.php?option=change_status&id_zakaza=" + listZakazov.SelectedItems[0].SubItems[0].Text;
                    //MessageBox.Show(url, "url");
                    //req.getResponseFromServer(url);
                    WebRequest.Create(url); // Create a request for the URL. 
                    MessageBox.Show("Выполнен!\n" + url, "ok");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }

        }


    }
}
