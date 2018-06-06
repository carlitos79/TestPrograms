using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AppendTextInFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\No-Backup Zone\WebbOchMobil\CentiroAssignment\OrderFiles";
            string target = @"F:\No-Backup Zone\WebbOchMobil\CentiroAssignment\OrderFiles\OutputFile.txt";

            string[] fileEntries = Directory.GetFiles(path);

            foreach (string fileName in fileEntries)
            {
                var lines = File.ReadAllLines(fileName);
                File.AppendAllLines(target, lines);
            }
        }
    }
}
