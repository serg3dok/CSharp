using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            int [] mass = {6,7,8,9,10,1,2,3,4,5};
                        
            ArrayList arr = new ArrayList(mass);

           // arr.Capacity = 11;            
            PrintValues(arr);

            #region Демострация метода IndexOf
            Console.WriteLine("Демострация метода IndexOf {0} \n", arr.IndexOf(4));
            #endregion

            #region Демострация метода BinarySearch
            Console.WriteLine ("Демострация метода BinarySearch {0} \n", arr.BinarySearch(4));
            #endregion
                        

            #region Демонстрация метода Sort

            Console.WriteLine("Демонстрация метода Sort");
            arr.Sort();
            PrintValues(arr);
                        
            #endregion

            #region Демонстрация метода Reverse

            Console.WriteLine("Демонстрация метода Reverse");
            arr.Reverse();
            PrintValues(arr);
            
            #endregion

            Console.WriteLine("Емкость внутреннего массива {0}", arr.Capacity);

            #region Добавление коллекции в конец существующей колекции

            int [] a = {1,11,111};

            Console.WriteLine("Добавление коллекции в в конец существующей колекции");
            arr.AddRange(a);
            PrintValues(arr);            
            
            #endregion

            #region Увиличение емкости внутреннего массива

            Console.WriteLine("Емкость внутреннего массива {0}", arr.Capacity);

            #endregion
            
        }
    }
}
