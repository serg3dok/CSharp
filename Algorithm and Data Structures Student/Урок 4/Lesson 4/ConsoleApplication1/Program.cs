using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTraversal
{
    class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }
        public BinaryTreeNode<TNode> Left
        {
            get;
            set;
        }

        public BinaryTreeNode<TNode> Right
        {
            get;
            set;
        }

        public TNode Value
        {
            get;
            private set;
        }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

    }

    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;

        private int _count;

        #region Добавление нового узла дерева

        public void Add(T value)
        {
            // Первый случай: дерево пустое     

            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }

            // Второй случай: дерево не пустое, поэтому применяем рекурсивный алгорит 
            //                для поиска места добавления узла        

            else
            {
                AddTo(_head, value);
            }
            _count++;
        }

        // Рекурсивный алгоритм 

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            // Первый случай: значение добавляемого узла меньше чем значение текущего. 

            if (value.CompareTo(node.Value) < 0)
            {
                // если левый потомок отсутствует - добавляем его          

                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация               
                    AddTo(node.Left, value);
                }
            }
            // Второй случай: значение добавляемого узла равно или больше текущего значения      
            else
            {
                // Если правый потомок отсутствует - добавлем его.          

                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // повторная итерация

                    AddTo(node.Right, value);
                }
            }
        }

        #endregion

        #region Нумератор

        public IEnumerator<T> GetEnumerator()
        {
            return InOrderTraversal();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Количество узлов в дереве

        public int Count
        {
            get
            {
                return _count;
            }
        }

        #endregion

        #region Семметричный порядок
               
        public IEnumerator<T> InOrderTraversal()
        {
           
           
            if (_head != null)
            {
                // Сохраняем узел в стек 

                Stack<BinaryTreeNode<T>> stack = new Stack<BinaryTreeNode<T>>();
                BinaryTreeNode<T> current = _head;

                // При перемещении по дереву мы должны отслеживать к какому следующему узлу перейти: к левому или правому потомку.   

                bool goLeftNext = true;

                // Начало. Помещение корня дерева в стек.         

                stack.Push(current);

                while (stack.Count > 0)
                {
                    // Если мы переходим влево ...        
                    if (goLeftNext)
                    {
                        // Запись всех левых потомков в стек.                 
                       
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }
                    
                    // Возврашение самого левого потомка

                    yield return current.Value;
                    
                    // Если у него есть правый потомок 
             
                    if (current.Right != null)
                    {
                        current = current.Right;

                        // Если мы один раз переходим в право, то ложны опять осуществить проход по левой стороне                
                        
                        goLeftNext = true;
                    }
                    else
                    {
                        // Если правого потомка нет, мы должны извлечь из стека родительский узел
                        
                        current = stack.Pop();
                        goLeftNext = false;
                    }
                }
            }
        }

        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> instance = new BinaryTree<int>();

            instance.Add(8);    //                        8
            instance.Add(5);    //                      /   \
            instance.Add(12);   //                     5    12 
            instance.Add(3);    //                    / \   / \  
            instance.Add(7);    //                   3   7 10 15
            instance.Add(10);   //
            instance.Add(15);   //

            foreach (var item in instance)
            {
                Console.WriteLine(item);
            }

        }
    }
}
