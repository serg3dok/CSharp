using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNodePair
{
    
    #region Создание пары ключ-значения. HashTableNodePair

    public class HashTableNodePair<TKey, TValue>
    {
        // Конструктор для класса ключ-значене, которые хранятся в хеш-таблице 

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
    
    class Program
    {
        static void Main(string[] args)
        {

            HashTableNodePair<int, string> instance1 = new HashTableNodePair<int, string>(0, "Hello");
            HashTableNodePair<int, string> instance2 = new HashTableNodePair<int, string>(1, "World");

            Console.WriteLine("Первое значение в таблице  {0}", instance1.Value);
            Console.WriteLine("Второе значение в таблице {0}", instance2.Value);

            

        }
    }
}
