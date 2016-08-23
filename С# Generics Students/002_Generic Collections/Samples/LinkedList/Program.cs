using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            var first = list.First;
            list.AddAfter(first, 3);
            list.AddBefore(first, 4);
            var node = list.First;

            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.ReadKey();
        }
    }
}
