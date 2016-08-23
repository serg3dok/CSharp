using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var empByName = new SortedDictionary<string, List<Employee>>();
            empByName.Add("Alex", new List<Employee>() { new Employee() { Name = "Alex" } });
            empByName.Add("Nick", new List<Employee>() { new Employee() { Name = "Nick" } });
            empByName.Add("Denis", new List<Employee>() { new Employee() { Name = "Denis" } });

            foreach (var item in empByName)
            {
                Console.WriteLine(item.Key);
            }
            Console.ReadKey();
        }
    }
}
