using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{    
    public class Stack<T> 
          {     
              LinkedList<T> _items = new LinkedList<T>();

              public void Push(T value)
              {
                  _items.AddLast(value);
              }

              public T Pop()
              {
                  if (_items.Count == 0)
                  { 
                      throw new InvalidOperationException("Стек пустой");
                  }

                  T result = _items.Last.Value;
                  _items.RemoveLast();
                  
                  return result;
              }
        
              public T Peek()
              {
                  return _items.Last.Value; 
              }
             
              public int Count
              {
                  get 
                  {
                     return _items.Count;                   
                  }
              }
          } 
    
    class Program
    {
        static void Main(string[] args)
        {
        
        
            Stack<int> instance = new Stack<int>();
            
            // Добавление элементов в стек                 // |           |
            instance.Push(10);                             // |     35    |   <----  Указатель на вершину стека
            instance.Push(15);                             // |     25    |
            instance.Push(25);                             // |     15    | 
            instance.Push(35);                             // |     10    |
                                                           // +___________+ 
            
            Console.WriteLine("Вершина стека: {0}", instance.Peek());
            
            // Извлечение двух элементов из массива
            
           int a = instance.Pop();
            instance.Pop();

            Console.WriteLine("a={0}",a);

            Console.WriteLine();
            Console.WriteLine("Вершина стека: {0}", instance.Peek());
            Console.WriteLine("Кличество элементов в стеке: {0}", instance.Count);                                        
                           
        }
    }
}
