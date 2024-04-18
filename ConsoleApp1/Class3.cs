using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            PrintArrayFromEnd(array, array.Length - 1);
        }

        static void PrintArrayFromEnd(int[] array, int index)
        {
            if (index < 0)
            {
                return;
            }
            Console.WriteLine(array[index]);
            PrintArrayFromEnd(array, index - 1);
        }
    }
}
