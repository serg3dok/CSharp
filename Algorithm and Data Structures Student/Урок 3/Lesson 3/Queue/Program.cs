using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{

    public class Queue<T>
    {
        LinkedList<T> _items = new LinkedList<T>();

        // Метод добавляет новый элемент в конец очереди

        public void Enqueue(T value)
        {
            _items.AddFirst(value);
        }
        
        // Метод удаляет первый элемент из очереди

        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста");
            }

            T last = _items.Last.Value;
            _items.RemoveLast();
            return last;
        }

        // Метод возвращает первый элемент очереди

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Очередь пуста");
            }

            return _items.Last.Value;
        }

        // Свойство хранит в себе количество элементов очереди

        public int Count
        {
            get { return _items.Count; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Добавление элементов в очередь

            Queue<int> instance = new Queue<int>();

            instance.Enqueue(10);              // ->->->->->->->->->->->->->
            instance.Enqueue(15);              // Очередь: 30 25 20 15 10
            instance.Enqueue(20);              // ->->->->->->->->->->->->->
            instance.Enqueue(25);
            instance.Enqueue(30);              

            Console.WriteLine("Количество элементов очереди: {0}", instance.Count);
            Console.WriteLine("Первый элемент очереди: {0}", instance.Peek()); // 10

            // Удаляем первый элемент из очереди


           int first = instance.Dequeue();    // ->->->->->->->->->->->->->
                                              // Очередь: 30 25 20 15 
                                              // ->->->->->->->->->->->->->

            Console.WriteLine("Количество элементов очереди: {0}", instance.Count);
            Console.WriteLine("Первый элемент очереди: {0}", instance.Peek()); //15
            Console.WriteLine("first =  {0}", first);
            

        }
    }
}
