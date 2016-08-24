using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Hash
{

    #region Создание пары ключ-значение 
    
    public class HashTableNodePair<TKey, TValue>
    {
        // Конструктор для ключа и значения, которые хранятся в хеш-таблице
        public HashTableNodePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        // Ключ нельзя поменять, так как это повлияет на индексацию таблицы.
        public TKey Key
        {
            get;
            private set;
        }

        // Значение
        public TValue Value
        {
            get;
            set;
        }
    }

    #endregion

    #region Добавление нового узла (пары ключ-значение) в двухсвязный список список

    public class HashTableArrayNode<TKey, TValue>
        {

        LinkedList<HashTableNodePair<TKey, TValue>> _items; 

        // Добавление нового узла                 
        public void Add(TKey key, TValue value)        
        { 

            // Создание таблицы на осноые двусвязного списка     
            if (_items == null)     
              {         
                _items = new LinkedList<HashTableNodePair<TKey, TValue>>();     
              }     
            else     
              {         
                // Несколько одинаковых элементов могут находится в одной таблице, 
                // но ключи по которым они располагаются должны быть разными. 
                
                foreach (HashTableNodePair<TKey, TValue> pair in _items)         
                
                {
                     // Если такой ключ уже существует - выдать исключение
 
                    if (pair.Key.Equals(key))             
                      {                 
                          throw new ArgumentException("Такой ключ уже существует");             
                      }         
                 }     
            }  
    
            // Добавление нового узла.     
            _items.AddLast(new HashTableNodePair<TKey, TValue>(key, value)); 
        }

    #endregion

    #region Нумераторы

        //public System.Collections.Generic.IEnumerator<TValue> GetEnumerator()
                    
        //{
            
        //        if (_items != null)
        //        {
        //            foreach (HashTableNodePair<TKey, TValue> node in _items)
        //            {
        //                yield return node.Value;
        //            }
        //        }
            
        //}

        public System.Collections.Generic.IEnumerator<TKey> GetEnumerator()
        {
            if (_items != null)
            {
                foreach (HashTableNodePair<TKey, TValue> node in _items)
                {
                    yield return node.Key;
                }
            }

        }
              
    }

    #endregion
    
    class Program
    {
        static void Main(string[] args)
        {
            HashTableArrayNode<int, string> instanse = new HashTableArrayNode<int, string>();

            instanse.Add(0, "Hello");
            instanse.Add(1, "World");
            instanse.Add(2, "!");

            foreach (var item in instanse)
            {
                Console.WriteLine(item);
            }      
    
       }
    }
}
