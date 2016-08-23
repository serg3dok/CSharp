using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLoops
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
                // for (int j = 1; j < (n - i); j++)
                for (int j = n-1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        // swap 
                        int tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                    }

                }
            }

/*            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();*/

            return arr;
        }
    }
}
