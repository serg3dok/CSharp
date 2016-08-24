using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{

    #region Класс для создания пары ключ-значение. HashTableNodePair
    public class HashTableNodePair<TKey, TValue>
    {               
       #region Создания ключа и значения
        
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
      #endregion
    }
    #endregion

    #region Класс для создания списка узлов. HashTableArrayNode
    public class HashTableArrayNode<TKey, TValue>
    {
   
      LinkedList<HashTableNodePair<TKey, TValue>> _items;
                
      #region Добавление нового узла (пары ключ-значение)
      
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

      #region Перезапись значения по ключу.

        public void Update(TKey key, TValue value)
        {
            bool updated = false;

            if (_items != null)
            {
                // Проверка каждого элемента в списке по ключу         

                foreach (HashTableNodePair<TKey, TValue> pair in _items)
                {
                    if (pair.Key.Equals(key))
                    {
                        // Перезапись значения

                        pair.Value = value;
                        updated = true;
                        break;
                    }
                }
            }

            if (!updated)
            {
                throw new ArgumentException("Такой ключ не был найден");
            }
        }

        #endregion

      #region Поиск значения по ключу.

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default(TValue); // запись значения по умолчанию
            bool found = false;

            if (_items != null)
            {
                foreach (HashTableNodePair<TKey, TValue> pair in _items)
                {
                    if (pair.Key.Equals(key))
                    {
                        value = pair.Value;
                        found = true;
                        break;
                    }
                }
            }
            return found;
        }

        #endregion

      #region Удаление узла по ключу

        public bool Remove(TKey key)
        {
            bool removed = false; if (_items != null)
            {
                LinkedListNode<HashTableNodePair<TKey, TValue>> current = _items.First;

                while (current != null)
                {
                    if (current.Value.Key.Equals(key))
                    {
                        _items.Remove(current);
                        removed = true; break;
                    }
                    current = current.Next;
                }
            }
            return removed;
        }
        #endregion

      #region Удаление всех элементов из списка

        public void Clear()
        {
            if (_items != null)
            {
                _items.Clear();
            }
        }


        #endregion

      #region Нумераторы

        //public IEnumerable<TValue> Values
        //{
        //    get
        //    {
        //        if (_items != null)
        //        {
        //            foreach (HashTableNodePair<TKey, TValue> node in _items)
        //            {
        //                yield return node.Value;
        //            }
        //        }
        //    }
        //} 

        //public IEnumerable<TKey> Keys
        //{
        //    get
        //    {
        //        if (_items != null)
        //        {
        //            foreach (HashTableNodePair<TKey, TValue> node in _items)
        //            {
        //                yield return node.Key;
        //            }
        //        }
        //    }
        //}

        public IEnumerable<HashTableNodePair<TKey, TValue>> Items
        {
            get
            {
                if (_items != null)
                {
                    foreach (HashTableNodePair<TKey, TValue> node in _items)
                    {
                        yield return node;
                    }
                }
            }
        }

                

     #endregion

    }
    #endregion  
    
    #region Создание массива уникалыниых HashTableArray индексов с записями узлов (пары-ключ значение )
    public class HashTableArray<TKey, TValue> 
      {     
           HashTableArrayNode<TKey, TValue> [] _array;  // создание массива узлов (пары ключ-значение)  
              
           public HashTableArray(int capacity)     
                {         
                   _array = new HashTableArrayNode<TKey, TValue>[capacity]; // выделение памяти под массив 
                }

           #region Получения индекса для записи узла (ключ-значение) в массив

           private int GetIndex(TKey key)
           {
               return Math.Abs(key.GetHashCode() % Capacity);
           }

           #endregion

           #region Размерность массива

           public int Capacity
           {
               get
               {
                   return _array.Length;
               }
           }

           #endregion

           #region Добавление элемента

           public void Add(TKey key, TValue value)
           {

               int index = GetIndex(key);
               HashTableArrayNode<TKey, TValue> nodes = _array[index];
               
               if (nodes == null)
               {
                   nodes = new HashTableArrayNode<TKey, TValue>();
                   _array[index] = nodes;
               }

               nodes.Add(key, value);

           }

           #endregion               

           #region Нумераторы

           //public IEnumerable<TValue> Values 
           //{ 
           //    get 
           //    { 
           //        foreach (HashTableArrayNode<TKey, TValue> node in _array.Where(node => node != null)) 
           //        { 
           //            foreach (TValue value in node.Values) 
           //            { 
           //                yield return value; 
           //            } 
           //        } 
           //    } 
           //} 

           //public IEnumerable<TKey> Keys
           //{
           //    get
           //    {
           //        foreach (HashTableArrayNode<TKey, TValue> node in _array.Where(node => node != null))
           //        {
           //            foreach (TKey key in node.Keys)
           //            {
           //                yield return key;
           //            }
           //        }
           //    }
           //}

           public IEnumerable<HashTableNodePair<TKey, TValue>> Items
           {
               get
               {
                  

                       foreach (HashTableArrayNode<TKey, TValue> node in _array.Where(node => node != null))
                       {
                           foreach (HashTableNodePair<TKey, TValue> pair in node.Items)
                           {
                               yield return pair;
                           }
                       }
                   
               }
           }

           //public System.Collections.Generic.IEnumerator<HashTableNodePair<TKey, TValue>> GetEnumerator()
           //{

           //    foreach (HashTableArrayNode<TKey, TValue> node in _array.Where(node => node != null))
           //    {
           //        foreach (HashTableNodePair<TKey, TValue> pair in node.Items)
           //        {
           //            yield return pair;
           //        }
           //    }
           //}        

           #endregion
        
      }
    #endregion

    #region Создание Хеш-таблицы. HashTable
    public class HashTable<TKey, TValue> 
             {     
                // Если заполнение массива первышает 75% - массив увеличивается.     
                
                const double _fillFactor = 0.75;
  
                // Максимальное количество элементов   

                int _maxItemsAtCurrentSize;  
                
                // Количество элементов в хеш таблице 
                int _count;  
    
                // Массив хранения элементов.     
                
                HashTableArray<TKey, TValue> _array;
  
                //  Конструктор хеш табицы по умолчанию.     
                            
               public HashTable() : this(1000) 
                    {     
                    }  
                                  
               // Параметризованный конструктор 
                    
               public HashTable(int initialCapacity)     
                     {         
                       if (initialCapacity < 1)         
                         {             
                            throw new ArgumentOutOfRangeException("Заданный размер меньше 1");         
                         }
  
                      _array = new HashTableArray<TKey, TValue>(initialCapacity);
            
                      // Увеличение максимального значения
                      
                      _maxItemsAtCurrentSize = (int)(initialCapacity * _fillFactor) + 1;

                     }
                   

               #region Добавления элемента в хеш-таблице.

               public void Add(TKey key, TValue value)
               {                        
                   
                   if (_count >= _maxItemsAtCurrentSize)
                   {
                       // Увеличение размерности массива
                       HashTableArray<TKey, TValue> largerArray = new HashTableArray<TKey, TValue>(_array.Capacity * 2);

                       // перезапись заначения в массив         
                       foreach (HashTableNodePair<TKey, TValue> node in _array.Items)
                       {
                           largerArray.Add(node.Key, node.Value);
                       }

                       // Массив в хеш-таблице                      
                       _array = largerArray;
                                                       
                       _maxItemsAtCurrentSize = (int)(_array.Capacity * _fillFactor) + 1;
                   }

                   _array.Add(key, value); 
                   _count++;

                }
               
               #endregion

               #region Нумератор

               public System.Collections.Generic.IEnumerator<HashTableNodePair<TKey, TValue>> GetEnumerator()
               {
                   foreach (HashTableNodePair<TKey, TValue> value in _array.Items)
                   {
                       yield return value;
                   }

               }


               #endregion

               #region Количество элементов

               public int Count
               {
                   get
                   {
                       return _count;
                   }
               }
               #endregion           


           //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
           // Добавить методы: 

                 // Удаления значений из хеш таблицы (Remove ).
                 // Добавление элементов в таблицу по ключу.
                 // Метод поиска заданного ключа в таблице (ContainsKey)
                 // Метод поиска заданного значения в таблице (ContainsValue)  
       }
    #endregion

    class Program
       {
           static void Main(string[] args)
           {

               HashTable<int, string> instance = new HashTable<int, string>(5);

               instance.Add(0, "Hello");
               instance.Add(1, "World");
               instance.Add(2, "Again");
               instance.Add(3, "!");
               instance.Add(4, "!");

               foreach (var item in instance)
               {
                   Console.WriteLine(item.Value);
               }
           }
       }




   }
