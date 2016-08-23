using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Stack
    {
        private static int[] _stackArray;
        static public int level;
        static public int ArraySize;

        static void Main(string[] args)
        {
            ArraySize = 10;
            _stackArray = new int[ArraySize];
            level = 0;

            //Add numbers
            for (int i = 0; i < ArraySize; i++)
            {
                AddNew(i);
            }
            
            //print out
            foreach (int n in _stackArray)
            {
                Console.Out.Write(n + " ");
            }
            Console.In.ReadLine();

        }

        static void AddNew(int number)
        {
            
            if (level == 0)
            {
                _stackArray[0] = number;
            }
            else if (level == 1)
            {
                _stackArray[1] = _stackArray[0];
                _stackArray[0] = number;
            }
            else
            {
                int i = level;
                while (i > 0)
                {
                    _stackArray[i] = _stackArray[i-1];
                    i--;
                }
                _stackArray[0] = number;

            }
            level++;

        }

    }
}
