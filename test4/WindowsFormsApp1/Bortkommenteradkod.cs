using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bortkommenteradkod
    {
        // I FÄLTET 
        //Stream stream = File.Open("PodData.dat", FileMode.Create);
        //BinaryFormatter bf = new BinaryFormatter();

        //bf.Serialize(stream, allaPoddar);
        //stream.Close();

        //stream = File.Open("PodData.dat", FileMode.Open);
        //bf = new BinaryFormatter();
        // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        //public void setCategory(string category)
        //{
        //category = textBox3.Text.ToString();
        //var choosenPod = listBox1.SelectedItem.ToString();
        //kategorier.Add(new KeyValuePair<String, String>(category, choosenPod));
        ////varför inte katergorier.Key?
        //var item = new KeyValuePair<String, String>(category, choosenPod);
        //if (comboBox1.Items.Contains(item.Key) == false)
        //{
        //    comboBox1.Items.Add(item.Key);
        //}


        //}
        //private void fillComboboxes()
        //{

        //comboBox2.Items.AddRange(addPods.fyllComboBoxMedUrl().ToArray());
        // comboBox1.Items.AddRange(addPods.fyllComboBoxMedKategori();
        //}
        //private void serializePods()
        //{

        //    using (Stream fs = new FileStream(@"C:\lista.xml", FileMode.Create, FileAccess.Write, FileShare.None))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof
        //                (List<Pod>));
        //        serializer.Serialize(fs, allaPoddar);

        //    }
        //    //XmlSerializer serializer2 = new XmlSerializer(typeof
        //    //    ())
        //}
        //private void deSerializePods()
        //{
        //    XmlSerializer serializer2 = new XmlSerializer(typeof(List<Pod>));

        //    using (FileStream fs2 = File.OpenRead(@"C:\lista.xml"))
        //    {
        //        allaPoddar = (List<Pod>)serializer2.Deserialize(fs2);
        //    }
        //}
        //private void createXmlFile()
        //{
        //    if (!File.Exists("lista.xml"))
        //    {
        //        using (Stream fs = new FileStream(@"C:\lista.xml", FileMode.Create, FileAccess.Write, FileShare.None))
        //        {
        //            XmlSerializer serializer = new XmlSerializer(typeof
        //                    (List<Pod>));
        //            serializer.Serialize(fs, allaPoddar);

        //        }
        //    }
        //}

        //Button 1 CLICK  ---> allaPoddar.Add(varjePodcast); Pod varjePodcast = new Pod(textBox1.Text,textBox3.Text , int.Parse(textBox4.Text));
        // ANVÄNDS INTE -------->  setCategory(textBox3.Text); i konstruktorn på Form1.cs <------------------------
        //********************************************************************************
        //  //public static List<String> SkapaListamedKategorier()
        //{
        //    var xmlDocument = XDocument.Load(@"C:\Lista.xml");
        //    var Pods = xmlDocument.Descendants("Pod");
        //    var Podobjekts = Pods.Select(element => new Pods)
        //}

        // TESTAR NYTT PÅ BTN1 CLICK sparar gamla.
        //     {
        //        new GenereradLista();
        //    var ListItems = GenereradLista.SkapaNyttXml(textBox1.Text);
        //    addPods.addList(textBox1.Text, textBox3.Text, int.Parse(textBox4.Text));

        //        using (var client = new System.Net.WebClient())
        //        {
        //            client.Encoding = Encoding.UTF8;
        //            xml = client.DownloadString(textBox1.Text); 
        //        }
        //dom.LoadXml(xml);

        //        foreach (System.Xml.XmlNode item
        //           in dom.DocumentElement.SelectNodes("channel/item"))
        //        {
        //            var title = item.SelectSingleNode("title");
        //Pods.Add(item.SelectSingleNode("title").InnerText);
        //            listBox1.Text = title.InnerText;
        //            Console.WriteLine(title.InnerText);
        //        }

        //            if (listBox1.Items.ToString() != textBox3.Text)
        //            {
        //                listBox1.Items.Add(textBox3.Text);
        //            }

        //        comboBox1.Text = textBox3.Text;
        //        addPods.serializePods();

        //    }

        // GENERERA LISTA TEEEEST
        //public static string VisaXmlLista()
        //{
        //    var serializer = new XmlSerializer(typeof(List<Pod>));
        //    using (var stream = new StreamReader(@"C:\Lista.xml"))
        //    {
        //        var ListaAvXml = (List<Pod>)serializer.Deserialize(stream);


        //    }

        //XmlSerializer serializer2 = new XmlSerializer(typeof(List<Pod>));
        //var returVarde = "";
        //using (FileStream fs2 = File.OpenRead(@"C:\lista.xml"))
        //{
        //    allaPoddar = (List<Pod>)serializer2.Deserialize(fs2);
        //    var listansInnehall = allaPoddar.ToString();
        //    foreach(Pod varjeVarde in allaPoddar)
        //    {
        //        returVarde = varjeVarde.ToString();
        //    }

        // returVarde = listansInnehall;
        //}
        //return returVarde;


        // LISTBOX1 event handler
        //new addPods();
        //List<String> listMedTitlar = new List<String>();
        //var xmlLista = addPods.VisaXmlLista();
        //for(int i = 0; i < xmlLista.Count(); i++)
        //{
        //    listMedTitlar.Add(xmlLista.ElementAt(i));
        //}
        //var ListItems = GenereradLista.SkapaNyttXml(textBox1.Text);
        //for 
        //listBox2.Items.Clear();
        //new fillBoxes();
        //    var lista = fillBoxes.fyllComboBoxMedUrl();
        //    for (int i = 0; i < lista.Count; i++)
        //    {
        //        listBox2.Items.Add(lista.ElementAt(i));
        //    }
        //new GenereradLista();
        //var ListItems = GenereradLista.SkapaNyttXml(textBox1.Text);
    }
}
