using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortV2
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
            for (int i = 1; i < arr.Length; i++)
            {
                int current = i;
                while (i > 0 && arr[i] < arr[i - 1])
                {
                    int tmp = arr[i];
                    arr[i] = arr[i-1];
                    arr[i - 1] = tmp;
                    i--;
                }
                i = current;
            }


            return arr;
        }
    }
}
