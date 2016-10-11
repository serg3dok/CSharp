using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum2
{
    class Program
    {

        /*
            
            1. put array in hashMap with indexes
            2. find numbers using hashMap API


    */

        static void Main(string[] args)
        {

            int[] arr = { 15, 8, 7, 2 };
            int target = 9;

            int[] indexes = findIndexes(arr, target);

            foreach (var index in indexes)
            {
                Console.Write(index + " ");
            }
            Console.ReadKey();
        }

        public static int[] findIndexes(int[] arr, int target)
        {
            Dictionary<int, int> numIndexes = new Dictionary<int, int>();

            int secondIndex = -1;


            for (int i = 0; i < arr.Length; i++)
            {
                numIndexes.Add(arr[i], i);
            }

            for (int i = 0; i < arr.Length; i++) 
            {
                int targetMinusElemArr = target - arr[i];
                if (numIndexes.ContainsKey(targetMinusElemArr))
                {
                    numIndexes.TryGetValue(targetMinusElemArr, out secondIndex);
                    int[] result = {i, secondIndex};
                    return result;
                }
            }

            throw new Exception("numbers not found");

        }

    }
}
