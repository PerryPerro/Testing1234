using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WMPLib;
using static Logic.FillComboBoxes;
using static Logic.ChangeFeedsAndUrls;
using static Logic.GenereraLista;
using static Logic.addPods;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public string xml = "";
        private List<string> pods = new List<string>();
        WMPLib.WindowsMediaPlayer Player;
        System.Xml.XmlDocument dom = new System.Xml.XmlDocument();
        private Stream ms = new MemoryStream();
    public Form1()

        {

            if (!File.Exists(@"C:\lista.xml"))
            {
                addPods.serializePods();
            }

            InitializeComponent();
            addPods.deSerializePods();
            FillZeListWithCategory();
            FillZeListWithUrl();

            //comboBox2.Items.AddRange(addPods.fyllComboBoxMedUrl().ToArray());
            //comboBox1.Items.AddRange(addPods.fyllComboBoxMedKategori().ToArray());

        }

        public Dictionary<String, String> categorys = new Dictionary<String, String>();
        public List<KeyValuePair<String, String>> kategorier = new List<KeyValuePair<String, String>>();

        public List<string> Pods { get => Pods1; set => Pods1 = value; }
        public List<string> Pods1 { get => pods; set => pods = value; }
        public List<string> Pods2 { get => pods; set => pods = value; }

        private class Hejsan : addPods
        {

        }

    private void button1_Click(object sender, EventArgs e)
        {
            new GenereradLista();

            var ListItems = GenereradLista.SkapaNyttXml(textBox1.Text);
         addPods.addList(textBox1.Text, textBox3.Text, int.Parse(textBox4.Text));
            foreach(string item in ListItems) { 
                Pods.Add(item);
                listBox1.Text = item;
            }


            //if (listBox1.Items.ToString() != textBox3.Text)
            //{
            //    listBox1.Items.Add(textBox3.Text);
            //}

            comboBox1.Text = textBox3.Text;
            addPods.serializePods();

        }
        private void visaLista()
        {
            var valtItem = comboBox1.SelectedItem.ToString();
            listBox2.Items.Add(categorys.ContainsKey(valtItem));
        }

        private void FillZeListWithUrl()
        {
            new fillBoxes();
            var lista = fillBoxes.fyllComboBoxMedUrl();
                for (int i = 0; i < lista.Count; i++)
            {
                comboBox2.Items.Add(lista.ElementAt(i));
            }
        }

        private void FillZeListWithCategory()
        {
            new fillBoxes();
            var lista = fillBoxes.fyllComboBoxMedKategori();
            for (int i=0; i < lista.Count; i++)
            {
                comboBox1.Items.Add(lista.ElementAt(i));
            }
        }
        private void fillListWithObjects()
        {
            listBox2.Items.Clear();
 
            foreach (var item in kategorier)
            {
                if (comboBox1.SelectedItem.ToString() == item.Key)
                {
                    listBox2.Items.Add(item.Value);
                }
                
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            new fillBoxes();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(fillBoxes.fyllListboxMedFeeds(comboBox1.SelectedItem.ToString()).ToArray());


        }

        private void button3_Click(object sender, EventArgs e)
        {
            fillListWithObjects();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // FIXA GENERATE LIST HÄR
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(textBox1.Text);
            }
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);
            foreach (System.Xml.XmlNode item
               in dom.DocumentElement.SelectNodes("channel/item"))
            {
                if (item.SelectSingleNode("title").InnerText == listBox2.SelectedItem.ToString())
                {
                    MessageBox.Show(item.SelectSingleNode("description").InnerText);
                }

            }
     
        }
  

        private void button5_Click(object sender, EventArgs e)
        {
            // FIXA GENERATE LIST HÄR
            var filePath = "";
            dom.LoadXml(xml);
            foreach (System.Xml.XmlNode item
               in dom.DocumentElement.SelectNodes("channel/item"))
            {
                if (item.SelectSingleNode("title").InnerText == listBox2.SelectedItem.ToString())
                {
                    
                    filePath = item.SelectSingleNode("enclosure/@url").InnerText;
                   
                   Process.Start("rundll32.exe", "shell32.dll, OpenAs_RunDLL " + filePath);
                }

            
          
        }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Changer();
            new fillBoxes();
            Changer.changeFeedUrl(comboBox2.SelectedItem.ToString(), textBox5.Text, textBox6.Text, textBox7.Text);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(fillBoxes.fyllComboBoxMedUrl().ToArray());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new fillBoxes();
            fillBoxes.removeFeed(comboBox2.SelectedItem.ToString());
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
