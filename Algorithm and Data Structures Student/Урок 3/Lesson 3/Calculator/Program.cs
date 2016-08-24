using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
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
                throw new InvalidOperationException("The stack is empty");
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

   static void Calculator()
    {
        while (true)
        {
            Console.Write(" Введите данные в формате: число1 число2 математическая операция: ");

            string input = Console.ReadLine();
            
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }
                      
            double value;
            char sign = '0';

            Stack<double> stack  = new Stack<double>();
                 
            foreach (string token in input.Split(new char[] { ' ' })) // 1 2 +
            {
                // Если число целое - запись его в стек             

                if (double.TryParse(token, out value))   // 2 // <--------
                {                                        // 1 // 
                    // Запись числа в стек                 
                    stack.Push(value);
                }
                // Если самвол - записать в переменную sign 
                else 
                
                {                
                    char.TryParse(token, out sign);                
                }

            }
                    // Если найден символ - извлечь два числа из стека и произвести математическую операцию с записью результата в стек                  
                    
                    double rhs = stack.Pop(); // 2
                    double lhs = stack.Pop(); // 1
                                        
                    switch (sign)
                    {
                        case '+':
                            stack.Push(lhs + rhs);
                            break;
                        case '-':
                            stack.Push(lhs - rhs);
                            break;
                        case '*':
                            stack.Push(lhs * rhs);
                            break;
                        case '/':
                            stack.Push(lhs / rhs);
                            break;
                        case '%':
                            stack.Push(lhs % rhs);
                            break;
                        default:
                            throw new ArgumentException(string.Format("Неверный ввод: {0}", sign));
                    }                                
                    
                    // Последний результат в стеке - результат.         
                    Console.WriteLine(stack.Peek()); // 3 // <------
                }                     
        }
    
        static void Main(string[] args)
        {

            Calculator();
        
        }
    }
}
