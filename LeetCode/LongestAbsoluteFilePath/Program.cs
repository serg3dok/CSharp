using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAbsoluteFilePath
{
    class Program
    {
        static void Main(string[] args)
        {
            int result =
                lengthLongestPath(
                    @"dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int lengthLongestPath(String input)
        {

            // variable l for length of current path
            int l = 0;
            int maxL = 1;
            // variable maxL for length of longest path
            //int maxL = 1;
            // tabs
            int t = 0;
            // max tabs
            int maxT = 0;
            
            

            // iterate through all elements of array
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == '\\' && input[i] == 'n')
                {
                    l+=2;
                    i++;
                    continue;
                }
                    

                
                while (input[i - 1] == '\\' && input[i] == 't')
                {
                    l += 2;
                    t++;
                    i++;
                }

                if (t > maxT)
                {
                    maxT = t;
                }
            }

            return l;
        }
    }
}
