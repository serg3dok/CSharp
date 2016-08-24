using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
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
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    int currentJ = j;

                    bool swaped = true;
                    while (j > 0 && swaped)
                    {
                        if (arr[j] < arr[j - 1])
                        {
                            int tmp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j - 1] = tmp;
                        }
                        else
                        {
                            swaped = false;
                        }

                        j--;
                    }

                    j = currentJ;

                }
            }

            return arr;
        }
    }
}
