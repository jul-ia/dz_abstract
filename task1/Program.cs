using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler xml = new XMLHandler();
            xml.Create();
            xml.Open();
            xml.Change();
            xml.Save();
            Console.WriteLine();

            AbstractHandler txt = new TXTHandler();
            txt.Create();
            txt.Open();
            txt.Change();
            txt.Save();
            Console.WriteLine();

            AbstractHandler doc = new DOCHandler();
            doc.Create();
            doc.Open();
            doc.Change();
            doc.Save();

            Console.ReadLine();
        }
    }
}
