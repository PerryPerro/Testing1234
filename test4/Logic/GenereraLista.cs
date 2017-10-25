using Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using static Data.Pods;

namespace Logic
{
    public abstract class GenereraLista
    {
        public class GenereradLista
        {
            public GenereradLista()
            {

            }

            public static List<String> SkapaNyttXml(string url)
            {
                var xml = "";
                List<String> list = new List<String>();
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString(url);
                }

                //Skapa en objektrepresentation.
                var dom = new System.Xml.XmlDocument();
                dom.LoadXml(xml);

                //Iterera igenom elementet item.
                foreach (System.Xml.XmlNode item
                   in dom.DocumentElement.SelectNodes("channel/item"))
                {
                    //Skriv ut dess titel.
                    list.Add(item.SelectSingleNode("title").InnerText);

                }
                return list;


            }

        }
    }
}
