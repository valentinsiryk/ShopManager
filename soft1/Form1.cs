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

        public int curZakazGlobal = 0;
        public int otgruzOk = 1;

        private void btnShowAllZakaz(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(".\\test.xml");
            otgruzOk = 1;

            listZakazov.Items.Clear();
            listTovarov.Items.Clear();
            listSkladov.Items.Clear();
            xmlParser xml1 = new xmlParser();
            int count = xml1.getCountZakaz();
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int type = comboBoxZakazov.SelectedIndex;
                    int position = i;
                    if (doc.DocumentElement.ChildNodes[i].ChildNodes[2].InnerText == type.ToString())
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
            for (int i = 0; i < 300; i++)
            {
                xml_request server = new xml_request();

                string request = "http://vsiryk.hol.es/xml/test.xml";
                string response = server.getResponse(request);
                server.saveToFile(response);
            }
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
            if (otgruzOk == 1)
            {
                listSkladov.Items.Clear(); //clear list skladov

                XmlDocument doc = new XmlDocument();
                doc.Load(".\\test.xml");
                int curTovar = listTovarov.FocusedItem.Index;
                int countSkladov = 0;

                //MessageBox.Show(countTovarov.ToString(), "ed");
                countSkladov = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[2].ChildNodes.Count;

                for (int curSklad = 0; curSklad < countSkladov; curSklad++)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem());
                    //item.SubItems.Add(new ListViewItem.ListViewSubItem());
                    //item.SubItems[0].Text = "sklad" + (curSklad + 1);//doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[0].InnerText;
                    item.SubItems[0].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[2].ChildNodes[curSklad].ChildNodes[0].InnerText;
                    item.SubItems[1].Text = doc.DocumentElement.ChildNodes[curZakazGlobal].ChildNodes[curTovar + 3].ChildNodes[2].ChildNodes[curSklad].ChildNodes[1].InnerText;
                    //item.SubItems[2].Text = "0";
                    listSkladov.Items.Add(item);
                }
            }
            else
                MessageBox.Show("Необходимо закончить отгрузку даного товара", "Error!");

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


    }
}
