using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAbsoluteFilePath
{
    class Program
    {

        /*

        dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext
        dir\n\tsubdir1\n\t\tfile1.ext
        dir\n\tsubdir1\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext
        dir\n\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext
            
        dir
            \n
            \t
                subdir1
                \n
                \t\t
                    file1.ext
                    \n
                \t\t
                    subsubdir1
                    \n
            \t
                subdir2
                \n
                \t\t
                    subsubdir2
                    \n
                    \t\t\t
                        file2.ext


    */

        static void Main(string[] args)
        {
            int result = lengthLongestPath(@"dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int lengthLongestPath(String input)
        {

            

            // variable l for length of current path
            int l = 0;

            // variable maxL for length of longest path
            int maxL = 1;

            //int maxL = 1;
            // tabs
            int tab = 0; // indentation

            // previous tabs
            int prevTab = 0;

            // max tabs
            int maxTab = 0;


            string[] elements = input.Split('\\');

            

            // iterate through all elements of array
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] == "n")
                {
                    l++;
                    continue;
                }
                    


                while (elements[i] == "t")
                {
                    //l+=2;
                    tab++; // tabs counter
                    i+=2;  // one is n
                    l += 2; // \n

                    
                }
                if (tab < prevTab)
                {
                    int dif = prevTab - tab;

                }
                    

                
                while (input[i - 1] == '\\' && input[i] == 't')
                {
                    l += 2;
                    tab++;
                    i++;
                }

                if (tab > maxTab)
                {
                    maxTab = tab;
                }

                prevTab = tab;
            }

            return l;
        }

        
    }
}
