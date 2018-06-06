using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace FileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\No-Backup Zone\WebbOchMobil\CentiroAssignment\OrderFiles\OutputFile.txt";

            ProcessFile(path);
        }

        public static void ProcessFile(string path)
        {
            var lines = File.ReadAllLines(path);

            var xml = new XElement("TopElement", lines.Select(line => new XElement("Item", line.Split('|').Select((column, index) => new XElement("Column" + index, column)))));

            xml.Save(@"F:\No-Backup Zone\WebbOchMobil\CentiroAssignment\XmlResult\XmlOrderFile.xml");
        }
    }
}
