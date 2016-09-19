using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {9, 9, 9, 9};

            arr = plusOne(arr);

            foreach (var i in arr)
            {
                  Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        public static int[] plusOne(int[] digits)
        {
            int last = digits.Length - 1; // last index of array

            digits[last]++; // add 1 to last element

            if (digits[last] < 10) return digits; // return array if last element less than 10

            // iterate all elements from right to left
            for (int i = last; i > -1; i--)
            {
                // check if element equals 10
                if (digits[i] == 10)
                {
                    // assign 0
                    digits[i] = 0;
                    
                    // check if it's not first element
                    if (i != 0)
                    {
                        // add 1 to next element
                        digits[i - 1]++; 
                    }
                    else
                    {
                        // create new bigger array
                        int[] moreDigits = new int[last + 2];
                        // first element is 1
                        moreDigits[0] = 1;
                        for (int j = 1; j < last - 2; j++)
                        {
                            //assign values from old array to new
                            moreDigits[j] = digits[j];
                        }

                        return moreDigits;

                    }
                }
            }

            return digits;
        }


    }
}
