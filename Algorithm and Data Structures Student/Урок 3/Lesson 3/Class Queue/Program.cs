using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(100, 40);

////////////////////////////////////////// Конструкторы /////////////////////////////////////////////////////////

            Console.WriteLine("\n Конструкторы \n");
            
            int [] array = {1,2,3,4,5}; 

            Queue<int> instance1 = new Queue<int>();
            Queue<int> instance2 = new Queue<int>(5);
            Queue<int> instance3 = new Queue<int>(array);
         
///////////////////////////////////////////// Методы ////////////////////////////////////////////////////////////

            Console.WriteLine("\n Добавление и удаление элементов с очереди \n");

            Console.WriteLine("Количество элементов в первой очереди: {0}", instance1.Count);
            Console.WriteLine("Количество элементов во второй очереди: {0}", instance2.Count);
            Console.WriteLine("Количество элементов в третьей очереди: {0}", instance3.Count);

            instance1.Enqueue(1);
            instance1.Enqueue(2);
            instance1.Enqueue(3);
            instance1.Enqueue(4);
            instance1.Enqueue(5);

            instance1.Dequeue();

            Console.WriteLine("Начало очереди: {0}", instance1.Peek());

///////////////////////////////////////////////////////Contains/////////////////////////////////////////////////////

            Console.WriteLine("\n Демонстрация метода Contains \n");
            
            Console.WriteLine("Очередь содержит значение 3 : {0}", instance1.Contains(3));

//////////////////////////////////////////////////////ToArray///////////////////////////////////////////////////////
            
            Console.WriteLine("\n Демонстрация метода ToArray \n");

            int[] myStandardArray = instance1.ToArray();

            for (int i = 0; i < myStandardArray.Length; i++)
            {
                Console.WriteLine(myStandardArray[i]);
            }

//////////////////////////////////////////////////////CopyTo////////////////////////////////////////////////////////////
            
            Console.WriteLine("\n Демонстрация метода CopyTo \n");

            int[] Array = new int[10];

            instance1.CopyTo(Array, 3);

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

////////////////////////////////////////////////////////Clear///////////////////////////////////////////////////////////
            
            Console.WriteLine("\n Демонстрация метода Clear \n");

            instance1.Clear();

           Console.WriteLine("Вершина стека: {0} ", instance1.Peek()); // Раскомментировать 
            
        }
    }
}
