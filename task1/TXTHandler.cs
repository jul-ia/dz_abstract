using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class TXTHandler : AbstractHandler
    {
        public string type = "TXT";

        public override void Open()
        {
            Console.WriteLine("{0} document has been opened.", type);
        }
        public override void Create()
        {
            Console.WriteLine("{0} document has been created.", type);
        }
        public override void Change()
        {
            Console.WriteLine("{0} document has been changed.", type);
        }
        public override void Save()
        {
            Console.WriteLine("{0} document has been saved.", type);
        }

    }
}
