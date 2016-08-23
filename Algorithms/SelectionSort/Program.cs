using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 100);
                Console.Write(arr[i] + " ");
            }

            //Console.ReadKey();

            arr = sort(arr);



            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

        public static int[] sort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int min = Int32.MaxValue;
                for (int j = i; j < arr.Length; j++)
                {
                    if (min > arr[j])
                    {
                        min = arr[j];
                    }
                    
                }
                arr[i] = min;
            }

            return arr;
        }
    }
}
