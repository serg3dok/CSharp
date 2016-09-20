using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PlusOne2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 2, 9, 9 };

            arr = plusOne(arr);

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        public static int[] plusOne(int[] digits)
        {

            // Iterate all elements from last to first
            for (int i = digits.Length - 1; i > -1; i--)
            {
                digits[i]++;
                // return array if current element less than 10
                if (digits[i] < 10) return digits;
                else
                {
                    // assign to current element 0 instead of 10
                    digits[i] = 0;
                }
            }

            // first element is 0 so create new bigger array 
            int[] moreDigits = new int[digits.Length + 1];

            // first element is 1
            moreDigits[0] = 1;
            for (int i = 1; i < moreDigits.Length; i++)
            {
                moreDigits[i] = digits[i - 1];
            } 

            return moreDigits;
        }

    }
}
