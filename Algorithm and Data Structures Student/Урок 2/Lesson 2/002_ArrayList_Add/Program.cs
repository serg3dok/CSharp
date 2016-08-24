
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
        public ArrayList() : this(0)
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

        // Метод добавляет новый элемент в конец массива 
        public void Add(T item)
        {
            {
                if (_items.Length == Count)
                {
                    GrowArray();
                }

                _items[Count++] = item;
            }            
        }
        
        // Расширение массива
        private void GrowArray()
        {
            int newLength = _items.Length == 0 ? 4 : _items.Length << 1; // 0000 0100 => 0000 1000
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

            dArr.Add(50);

            PrintValues(dArr);                        
        }
    }
}
