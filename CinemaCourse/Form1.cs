using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CinemaCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFilm();
        }

        XmlDocument doc = new XmlDocument();

        private void LoadFilm()
        {
            doc.Load("C:\\Users\\sjdro\\source\\repos\\CinemaCourse\\CinemaCourse\\xmltext.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string nameFilm = node.Attributes[0].Value;
                string nameCinema = string.Format(node["Cinema"].InnerText);
                string genreFilm = string.Format(node["Genre"].InnerText);
                string dateFilm = string.Format(node["Date"].InnerText);
                string beginningFilm = string.Format(node["Beginning"].InnerText);
                int durationFilm = int.Parse(node["Duration"].InnerText);
                listBox1.Items.Add(new Film(nameFilm, nameCinema, genreFilm, dateFilm, beginningFilm, durationFilm));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }
    }
}
