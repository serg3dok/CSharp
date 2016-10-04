using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {

        /*
            Given nums = [2, 7, 11, 15], target = 9,

            Because nums[0] + nums[1] = 2 + 7 = 9,

            return [0, 1].


            2 7 11 15

            Brute Force Approach

            i
            2 7 11 15
              j
            - 7 11 15

            target = 9



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
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (target - arr[i] == arr[j])
                    {
                        return new[] {i, j};
                    }
                }
            }

            throw new Exception("numbers not found");
        }
    }
}
