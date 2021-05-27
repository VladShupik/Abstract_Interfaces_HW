using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractHandrler xml = new XMLHandler("FirstXML");
            XMLHandler xml = new XMLHandler("FirstXML");
            xml.Open();
            xml.Chenge();
            xml.Save();
            Console.WriteLine(new string('-',50));
            DOCHandler doc = new DOCHandler("FirstDOC");
            doc.Open();
            doc.Chenge();
            doc.Save();
            Console.WriteLine(new string('-', 50));
            TXTHandler txt = new TXTHandler("FirstTXT");
            txt.Open();
            txt.Chenge();
            txt.Save();
        }
    }
}
