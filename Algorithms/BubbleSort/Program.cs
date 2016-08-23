using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
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
            
            Console.WriteLine();

            sort(arr, arr.Length-1, 0);


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();

        }

        public static int[] sort(int[] arr, int index, int level)
        {
            if (arr[index] < arr[index - 1])
            {
                int temp = arr[index - 1];
                arr[index - 1] = arr[index];
                arr[index] = temp;
            }
            if (index - 1 == level)
            {
                index = arr.Length-1;
                level ++;
            }
            else
            {
                index--;
            }

            if (level < arr.Length-1)
            {
                sort(arr, index, level);
            }
            

            return arr;
        }

        
    }
}
