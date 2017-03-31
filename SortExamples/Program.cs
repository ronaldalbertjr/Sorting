using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortExamples
{
    class Program
    {
        static int[] arrayOfNumbers = new int[999];
        static void Main(string[] args)
        {
            arrayOfNumbers.FillArrayWithRandomNumbers(0, 10000000).BubbleSort().ShowArray();
            Console.ReadKey();
        }
    }
}
