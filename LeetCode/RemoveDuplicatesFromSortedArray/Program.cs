using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 5, 5, 6, 7, 7 };

            arr = RemoveDuplicates(arr);

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        private static int[] RemoveDuplicates(int[] arr)
        {
            // counter for duplicates
            int duplicates = 0;

            // iterate through all elements
            for (int i = 1; i < arr.Length; i++)
            {
                // increment duplicates if duplicates found
                if (arr[i] == arr[i - 1])
                {
                    duplicates++;
                }
                else
                {
                    // if current element is not duplicate move it left to the right position
                    arr[i - duplicates] = arr[i];
                }
            }


            return arr;
        }
    }
}
