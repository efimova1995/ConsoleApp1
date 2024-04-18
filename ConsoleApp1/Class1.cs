using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            PrintNumbers(5, 10);
        }

        static void PrintNumbers(int m, int n)
        {
            if (m > n)
            {
                return;
            }
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
}
