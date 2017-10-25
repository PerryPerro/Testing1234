using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //public class Pods
    //{
    //    [Serializable()]
    //    public class Pod : ISerializable
    //    {
    //        public string Url { get; set; }
    //        public string Category { get; set; }
    //        public double UpdateIntervall { get; set; }

    //        public Pod() { }

    //       public Pod(string url = "hej",
    //       string category = "då",
    //       double updateIntervall = 3)
    //        {
    //            Url = url;
    //            Category = category;
    //            UpdateIntervall = updateIntervall;
    //        }

    //        public void GetObjectData(SerializationInfo info, StreamingContext context)
    //        {
                
    //            info.AddValue("Url", Url);
    //            info.AddValue("Category", Category);
    //            info.AddValue("Intervall", UpdateIntervall);
    //        }

    //        public Pod(SerializationInfo info, StreamingContext ctxt)
    //        {
    //            //Get the values from info and assign them to the properties
    //            Url = (string)info.GetValue("Url", typeof(string));
    //            Category = (string)info.GetValue("Category", typeof(string));
    //            UpdateIntervall = (double)info.GetValue("UpdateIntervall", typeof(double));
    //        }

            //public void xmlDownload()
            //{
            //    using (var client = new System.Net.WebClient())
            //    {
            //        client.Encoding = Encoding.UTF8;
            //        xml = client.DownloadString(textBox1.Text);
            //    }

            //    //Skapa en objektrepresentation.

            //    dom.LoadXml(xml);

            //    //Iterera igenom elementet item.
            //    foreach (System.Xml.XmlNode item
            //       in dom.DocumentElement.SelectNodes("channel/item"))
            //    {
            //        //Skriv ut dess titel.
            //        var title = item.SelectSingleNode("title");
            //        Pods.Add(item.SelectSingleNode("title").InnerText);
            //        listBox1.Text = title.InnerText;
            //        Console.WriteLine(title.InnerText);
            //    }
            //}
//        }
//    }
}
