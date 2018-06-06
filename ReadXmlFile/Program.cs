using System;
using System.Xml;
using System.Xml.Linq;

namespace ReadXmlFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFileName = @"F:\No-Backup Zone\WebbOchMobil\CentiroAssignment\XmlResult\XmlOrderFile.xml";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFileName);
            XmlNodeList parentNode = xmlDoc.GetElementsByTagName("Item");

            string result;

            foreach (XmlNode childrenNode in parentNode)
            {
                result = childrenNode.SelectSingleNode("Column7").InnerText;

                if (result.Contains("."))
                {
                    result = result.Replace(".", ",");
                }
                Console.WriteLine(result);
            }


            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
