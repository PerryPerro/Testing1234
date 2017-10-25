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
    public abstract class FillComboBoxes
    {
        public class fillBoxes
        {
          
            public fillBoxes() {
             
                    }
            
            public static List<string> fyllComboBoxMedUrl()
            {

                var xmlDoc = XDocument.Load(@"C:\lista.xml");
                var items = from item in xmlDoc.Descendants("Pod")
                            where item.Element("Url").Value != null
                            select item.Element("Url").Value;

                List<string> kategorier = new List<string>();

                foreach (string itemElement in items)
                {
                    kategorier.Add(itemElement);
                }

                return kategorier;
            }

            public static List<string> fyllComboBoxMedKategori()
            {

                var xmlDoc = XDocument.Load(@"C:\lista.xml");
                var items = from item in xmlDoc.Descendants("Pod")
                            where item.Element("Category").Value != null
                            select item.Element("Category").Value;
                List<string> kategorier = new List<string>();

                string hej = items.ToString();

                foreach (string itemElement in items)
                {
                    if (!kategorier.Contains(itemElement.ToString()))
                    {
                        kategorier.Add(itemElement);
                    }

                }

                return kategorier;
            }

            public static List<string> fyllListboxMedFeeds(string category)
            {

                var xmlDoc = XDocument.Load(@"C:\lista.xml");
                var items = from item in xmlDoc.Descendants("Pod")
                            where item.Element("Category").Value == category
                            select item.Element("Url").Value;

                List<string> feeds = new List<string>();

                foreach (string itemElement in items)
                {

                    feeds.Add(itemElement);
                }

                return feeds;
            }

            public static void removeFeed(string url)
            {
                var xdoc = XDocument.Load(@"C:\lista.xml");

                xdoc.XPathSelectElements($"//ArrayOfPod/Pod").Where(x => (string)x.Element("Url") == url).Remove();
                xdoc.Save(@"C:\lista.xml");
            }
        }
    }
}
