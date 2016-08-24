using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpData_HashTableArray
{

    // HashTableNodePair
    #region Создания ключа и значения

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


    // Класс для создание списка узлов. HashTableArrayNode

    #region Добавление нового узла (пары ключ-значение)

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
                        throw new ArgumentException("Такой клюс уже существует");
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
    }

        #endregion


    // Создание массива уникалыниых индексов с записями узлов (пары-ключ значение )

    class HashTableArray<TKey, TValue>
    {
        HashTableArrayNode<TKey, TValue>[] _array;  // создание массива узлов (пары ключ-значение)  

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

        #region Capacity

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

        #region Изменение значения по ключу
        
        public void Update(TKey key, TValue value)
        {
            HashTableArrayNode<TKey, TValue> nodes = _array[GetIndex(key)];
            
            if (nodes == null)
            {
                throw new ArgumentException("Такого ключа нет в хеш-таблице", "key");
            }

            nodes.Update(key, value);
        }
 
        #endregion

        #region Нумераторы


        public System.Collections.Generic.IEnumerator<HashTableNodePair<TKey, TValue>> GetEnumerator()
        {

            foreach (HashTableArrayNode<TKey, TValue> node in
                _array.Where(node => node != null))
            {
                foreach (HashTableNodePair<TKey, TValue> pair in node.Items)
                {
                    yield return pair;
                }
            }

        }
        
        #endregion
    }

        

    


    class Program
    {
        static void Main(string[] args)
        {

            HashTableArray<int, string> instance = new HashTableArray<int, string>(5);

            instance.Add(0, "Hello");
            instance.Add(1, "World");
            instance.Add(2, "Again");
            instance.Add(3, "!");

            instance.Update(2, "Change");

            foreach (var item in instance)
            {
                Console.WriteLine(item.Value);
            }


        }
    }
}
