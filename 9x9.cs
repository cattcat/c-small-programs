using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 9; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    Console.Write(x + "*" + y + "=" + (x * y)+"\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}