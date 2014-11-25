using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soft1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = "text";
            item.ImageIndex = 0;
            listZakazov.Items.Add(item);
        }

        private void btnAllZakaz_Click(object sender, EventArgs e)
        {
            xml_request server = new xml_request();

            string request = "http://vsiryk.hol.es/xml/test.xml";
            string response = server.getResponse(request);
            server.saveToFile(response);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xmlParser a1 = new xmlParser();
            a1.parse();
        }
    }
}
