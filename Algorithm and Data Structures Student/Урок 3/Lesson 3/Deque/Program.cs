using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque
{        
        public class Deque<T>
        {
            LinkedList<T> _items = new LinkedList<T>();
            
            public void EnqueueFirst(T value) 
                  {
                      _items.AddFirst(value);  
                  }
            
            public void EnqueueLast(T value) 
                  {
                      _items.AddLast(value);
                  }
            
            public T DequeueFirst() 
                  {
                      if (_items.Count == 0) 
                         { 
                             throw new InvalidOperationException("Очередь пуста"); 
                         }
                      
                             T temp = _items.First.Value;
                             _items.RemoveFirst();
                             
                             return temp;  
                  }
            
            public T DequeueLast() 
                  {
                      if (_items.Count == 0) 
                          {
                              throw new InvalidOperationException("Очередь пуста"); //!!!!!
                          }
                      
                      T temp = _items.Last.Value;
                      _items.RemoveLast();
                      return temp; 
                  }
            
            public T PeekFirst() 
                  {
                      if (_items.Count == 0) 
                         {
                             throw new InvalidOperationException("Очередь пуста"); 
                         }
                      
                      return _items.First.Value;  
                  }
            
            public T PeekLast() 
                  { 
                     if (_items.Count == 0)     
                        {
                            throw new InvalidOperationException("Очередь пуста");     
                        }
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
        
        
           Deque<int> instance = new Deque<int>();
            
                                        // First -> указатель на начало очереди
                                        // Last  -> указатель на конец очереди
           
           instance.EnqueueLast(1);    // -> -> -> -> -> -> ->  
           instance.EnqueueLast(2);    // Двусвязная очередь: 5 -> 4 -> 3 -> 2 -> 1
           instance.EnqueueLast(3);    // -> -> -> -> -> -> ->
           instance.EnqueueLast(4);
           instance.EnqueueLast(5);

           Console.WriteLine(instance.PeekFirst()); // возвращает первый элемент очереди
           Console.WriteLine(instance.PeekLast());  // возвращает последний элемент очереди 

           instance.EnqueueFirst(6);     // -> -> -> -> -> -> -> 
           instance.EnqueueFirst(7);     // Двусвязная очередь: 5 -> 4 -> 3 -> 2 -> 1 -> 6 -> 7 -> 8
           instance.EnqueueFirst(8);     // -> -> -> -> -> -> ->
           
            
           Console.WriteLine(instance.PeekFirst()); // возвращает первый элемент очереди
           Console.WriteLine(instance.PeekLast());  // возвращает последний элемент очереди 

        
        }
    }
}
