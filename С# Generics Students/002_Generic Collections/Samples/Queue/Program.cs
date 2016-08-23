using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Employee> queue = new Queue<Employee>();
            queue.Enqueue(new Employee { Name = "Alex" });
            queue.Enqueue(new Employee { Name = "Nick" });
            queue.Enqueue(new Employee { Name = "Andrew" });
            queue.Enqueue(new Employee { Name = "Denis" });

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue().Name);
            }

            Console.WriteLine(new string('-', 20));

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee { Name = "Alex" });
            stack.Push(new Employee { Name = "Nick" });
            stack.Push(new Employee { Name = "Andrew" });
            stack.Push(new Employee { Name = "Denis" });

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().Name);
            }
            Console.ReadKey();
        }
    }
}
