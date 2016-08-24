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
        public ArrayList()
            : this(0)
        {

        }

        // Конструктор с параметром 
        public ArrayList(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException("length");
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

        // Расширение массива
        private void GrowArray()
        {
            int newLength = _items.Length == 0 ? 4 : _items.Length << 1;
            T[] newArray = new T[newLength];
            _items.CopyTo(newArray, 0);
            _items = newArray;
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

        // Поиск индекса элемента
        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_items[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
         
        // Метод опередиляет пренадлежность элемента к массиву
        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
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
            int[] array = { 5, 10, 15, 20, 25 };

            ArrayList<int> dArr = new ArrayList<int>(array);

            Console.WriteLine("Значение 5 пренадлежит массиву: {0} ",dArr.Contains(5));
            
            Console.WriteLine( dArr.IndexOf(15));



            PrintValues(dArr);
        }
    }
}
