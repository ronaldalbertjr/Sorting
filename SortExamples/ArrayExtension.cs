using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortExamples
{
    public static class ArrayExtension
    {
        public static int[] BubbleSort(this int[] arrayToBeSorted)
        {
            int auxNumber = 0;
            for (int i = 0; i < arrayToBeSorted.Length; i++)
            {
                for (int j = 0; j < arrayToBeSorted.Length - 1; j++)
                {
                    if (arrayToBeSorted[j] > arrayToBeSorted[j + 1])
                    {
                        auxNumber = arrayToBeSorted[j];
                        arrayToBeSorted[j] = arrayToBeSorted[j + 1];
                        arrayToBeSorted[j + 1] = auxNumber;
                    }
                }
            }
            return arrayToBeSorted;
        }

        public static int[] FillArrayWithRandomNumbers(this int[] array, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(min, max);
            return array;
        }

        public static void ShowArray(this int[] array)
        {
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
        }
    }
}
