using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

//////////////////////////////////// Конструкторы //////////////////////////////////////////////////////////////
            
            int[] array = {1,2,3,4,5};

            Stack<int> instance1 = new Stack<int>();
            Stack<int> instance2 = new Stack<int>(10);
            Stack<int> instance3 = new Stack<int>(array);

            Console.WriteLine("Количество элементов в первом стеке: {0} ", instance1.Count);
            Console.WriteLine("Количество элементов во втором стеке: {0} ", instance2.Count);
            Console.WriteLine("Количество элементов в третьем стеке: {0}", instance3.Count);

///////////////////////////////////////// Методы ///////////////////////////////////////////////////////////////////
            
            instance1.Push(1);
            instance1.Push(2);
            instance1.Push(3);
            instance1.Push(4);
            instance1.Push(5);

            instance1.Pop();

            Console.WriteLine("Вершина стека: {0} ", instance1.Peek());

            Console.WriteLine("Стек содержит значение 2: {0}", instance1.Contains(2));

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n Демонстрация метода ToArray \n");
            
            int [] myStandardArray = instance1.ToArray();

            for (int i = 0; i < myStandardArray.Length; i++)
			{
			    Console.WriteLine(myStandardArray[i]); 
			}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n Демонстрация метода CopyTo \n");

            int [] Array = new int [10];

            instance1.CopyTo(Array, 3);

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n Демонстрация метода Clear \n");

            instance1.Clear();

          //  Console.WriteLine("Вершина стека: {0} ", instance1.Peek()); // Раскомментировать 
        
        }
    }
}
