using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

            foreach (var item in set1.Union(set2)) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
