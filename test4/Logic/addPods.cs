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

    
    public class addPods
    {
        private Stream ms = new MemoryStream();
       static List<Pod> allaPoddar = new List<Pod>();
        
        public addPods()
        {
            Stream stream = File.Open("PodData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, allaPoddar);
            stream.Close();

            stream = File.Open("PodData.dat", FileMode.Open);
            bf = new BinaryFormatter();
        }
        
        public static void addList(string url,string kategori, double intervall)
        {
            Pod varjePodcast = new Pod(url,kategori,intervall);
            allaPoddar.Add(varjePodcast);
        }
        public static void serializePods()
        {

            using (Stream fs = new FileStream(@"C:\lista.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof
                        (List<Pod>));
                serializer.Serialize(fs, allaPoddar);                
            }
          
        }
        public static void deSerializePods()
        {
            XmlSerializer serializer2 = new XmlSerializer(typeof(List<Pod>));

            using (FileStream fs2 = File.OpenRead(@"C:\lista.xml"))
            {
                allaPoddar = (List<Pod>)serializer2.Deserialize(fs2);
            }
        }
        
       

        }
    }


