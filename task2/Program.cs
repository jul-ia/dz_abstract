using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable ip = player as IPlayable;
            ip.Play();
            ip.Pause();
            ip.Stop();

            Console.WriteLine();

            IRecodable ir = player as IRecodable;
            ir.Record();
            ir.Pause();
            ir.Stop();

            Console.ReadLine();
        }
    }
}
