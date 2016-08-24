// Создание динамического массива 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{

    public class ArrayList<T> : IEnumerable
        
    {
        T[] _items;

        // Конструктор по умолчанию
        public ArrayList(): this(0)
        {

        }

        // Конструктор с параметром 
        public ArrayList(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException("Error length");
            }
            _items = new T[length];
        }

        // Конструктор с параметром
        public ArrayList(ICollection<T> list)
        {
            int index = 0;
            _items = new T[list.Count];

            foreach (var element in list)
            {
                Count++;
                _items[index++] = element;
                               
            }
        }

        // Подсчет элементов в массиве
        public int Count
        {
            get;
            internal set;

        }

       // Метод возврящает перечислитель, осуществляет перебор коллекции.
       public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _items[i];
            }
        }

       System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }

    class Program
    {

        public static void PrintValues(IEnumerable obj)
        {
            
            Console.WriteLine("Dinemic array");

            foreach (var item in obj)
                               
                Console.Write("   {0}", item);
                Console.WriteLine();
        }



        static void Main(string[] args)
        {
            ArrayList<int> dArr1 = new ArrayList<int>();

            ArrayList<int> dArr2 = new ArrayList<int>(5);

            int[] array = { 5, 10, 15, 20, 25 };

            ArrayList<int> dArr3 = new ArrayList<int>(array);

            PrintValues(dArr1);
            Console.WriteLine(dArr1.Count);
            PrintValues(dArr2);
            Console.WriteLine(dArr2.Count);
            PrintValues(dArr3);
            Console.WriteLine(dArr3.Count);

            Console.ReadKey();
        }
    }
}
