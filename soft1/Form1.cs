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

        public int curZakazGlobal = 0;

        private void btnShowAllZakaz(object sender, EventArgs e)
        {
            listZakazov.Items.Clear(); //clear list zakazov
            listTovarov.Items.Clear(); //clear list tovarov
            listSkladov.Items.Clear(); //clear list skladov
            DescriptionIn.Text = "Описание товара...";
            string curIdZakaza = "null";

            xml_request req = new xml_request();
            //XmlDocument doc = req.getXmlDoc("http://vsiryk.hol.es/xml/zakazi.xml"); 
            XmlDocument doc = req.getXmlDoc("http://192.168.35.19/Index.php?option=zakazi");
            
            int countZakazov = doc.DocumentElement.ChildNodes.Count;
            for (int i = 0; i < countZakazov; i++)
            {
                if (doc.DocumentElement.ChildNodes[i].ChildNodes[2].InnerText == comboBoxZakazov.SelectedIndex.ToString())
                {
                    if (doc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText != curIdZakaza)
                    {
                        ListViewItem item = new ListViewItem();
                        item.SubItems.Add(new ListViewItem.ListViewSubItem());
                        item.SubItems[0].Text = doc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText; //id zakaza
                        if (doc.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText == "1") //status vipolneniya
                            item.ImageIndex = 0; //image
                        listZakazov.Items.Add(item);
                        curIdZakaza = item.SubItems[0].Text;
                    }
                }
            }

        }

        private void listZakazov_Click(object sender, EventArgs e)
        {
            listTovarov.Items.Clear(); //clear list tovarov
            listSkladov.Items.Clear(); //clear list skladov
            DescriptionIn.Text = "Описание товара...";

            xml_request req = new xml_request();
            //XmlDocument doc = req.getXmlDoc("http://vsiryk.hol.es/xml/zakazi.xml");
            XmlDocument doc = req.getXmlDoc("http://192.168.35.19/Index.php?option=zakazi");
            string curZakazId = listZakazov.SelectedItems[0].SubItems[0].Text;
            
            int countOrdersInXml = doc.DocumentElement.ChildNodes.Count;
            for (int i = 0; i < countOrdersInXml; i++)
            {
                if (doc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText == curZakazId.ToString())
                {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = doc.DocumentElement.ChildNodes[i].ChildNodes[3].InnerText;
                item.SubItems[1].Text = doc.DocumentElement.ChildNodes[i].ChildNodes[4].InnerText; //берем имя с базы
                item.SubItems[2].Text = doc.DocumentElement.ChildNodes[i].ChildNodes[5].InnerText;
                item.SubItems[3].Text = "0";
                listTovarov.Items.Add(item);
                }
            }
        }

        private string getNameInfTovar(string idTovara, string key)
        {
            xml_request req = new xml_request();
            string url = "http://192.168.35.19/Index.php?option=inf_tov&id_tov=" + idTovara;
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
            skladListUpdate(idTovara);

            DescriptionIn.Text = getNameInfTovar(idTovara, "info");
        }

        private void skladListUpdate(string idTovara)
        {
            listSkladov.Items.Clear();
            xml_request server = new xml_request();
            //string req_sklady = "http://vsiryk.hol.es/xml/tov_na_skl.xml"; //+ idTovara
            string req_sklady = "http://192.168.35.19/Index.php?option=tovari_na_sclade&id_tovar=" + idTovara;         
            XmlDocument docSklady = server.getXmlDoc(req_sklady);
            int countSkladov = docSklady.DocumentElement.ChildNodes.Count;

            for (int i = 0; i < countSkladov; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
                item.SubItems[0].Text = docSklady.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText;
                item.SubItems[1].Text = docSklady.DocumentElement.ChildNodes[i].ChildNodes[2].InnerText;
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
                        WebRequest.Create(url); // Create a request for the URL. 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlFile req = new XmlFile();
            xml_request sf = new xml_request();

            sf.saveToFile(req.getResponseFromServer("http://" + textBoxTest.Text),@".\cur.xml");
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
                    WebRequest.Create(url); // Create a request for the URL. 
                    MessageBox.Show("Выполнен!\n" + url, "ok");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }

        }

        private void btnShowCategories_Click(object sender, EventArgs e)
        {
            xml_request req = new xml_request();
            //XmlDocument doc = req.getXmlDoc("http://vsiryk.hol.es/xml/categories.xml");
            XmlDocument doc = req.getXmlDoc("http://195.168.35.19/Index.php?option=get_kategory"); 

            int countCategories = doc.DocumentElement.ChildNodes.Count;
            for (int i = 0; i < countCategories; i++)
            {
                string catName = doc.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText;
                string idCat = doc.DocumentElement.ChildNodes[i].ChildNodes[0].InnerText;
                comboBoxCategory.Items.Add(catName);
                if (i == 0)
                {      
                    comboBoxCategory.Text = catName;
                    ///showSubCat(catName);
                }
            }
        }

        private void showSubCat(string catId)
        {
            xml_request req = new xml_request();
            XmlDocument doc = req.getXmlDoc("192.168.35.19/Index.php?option=get_sub_kategory&id_kategory=" + catId);
            int countSubCats = doc.DocumentElement.ChildNodes.Count;
            for (int i = 0; i < countSubCats; i++)
            {
                string subCatName = doc.DocumentElement.ChildNodes[i].ChildNodes[1].InnerText;
                comboBoxCategory.Items.Add(subCatName);
                if (i == 0)
                    comboBoxCategory.Text = subCatName;
            }
            
        }

        private void comboBoxCategory_TextChanged(object sender, EventArgs e)
        {
            /*посмотреть какая категория выбрана,
             * отправить запрос на список категорий, 
             * найти категорию с выбранным именем,
             * посмотреть ее ИД, вызвать функцию showSubCat(catId)*/
            //(catId);
        }
    }
}
