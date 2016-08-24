using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Class
{
    public class LinkedListNode<T>
    {

        // Создание нового узла со специальным значением.     

        public LinkedListNode(T value) // конструктор
        {

            Value = value;

        }

        // Значение узла.     

        public T Value // свойство  
        {
            get;
            internal set;
        }

        // Установка следующего значения для узла (null если последний).     

        public LinkedListNode<T> Next
        {
            get;
            internal set;
        }

    }
    
}
