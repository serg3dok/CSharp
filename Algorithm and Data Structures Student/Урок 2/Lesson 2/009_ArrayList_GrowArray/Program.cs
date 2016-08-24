// Увеличение размерности внутреннего массива.

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ArrayList_Class
{
    class Program
    {

        public static void PrintValues(IEnumerable obj)
        {

            Console.WriteLine("Dinemic array");

            foreach (var item in obj)

            Console.Write("   {0}", item);
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            
            ArrayList arr = new ArrayList();

           // arr.Capacity = 15;

            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);

            arr.Insert(2, 50);
            //arr.RemoveAt(4);
            //arr.RemoveAt(3);

            //Console.WriteLine(arr[4]);
                        
            Console.WriteLine("Размер внутреннего массива: {0} ", arr.Capacity);
            Console.WriteLine("Количество элементов массива: {0} ", arr.Count);
            
            PrintValues(arr);

            
          
        }
    }
}
