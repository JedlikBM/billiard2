using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billiard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> golyok = new List<int>();
            kezdes(golyok);
            foreach (var item in golyok)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void kezdes(List<int> golyok)
        {
            for (int i = 1; i <= 15; i++)
            {
                golyok.Add(i);
            }
        }
    }
}
