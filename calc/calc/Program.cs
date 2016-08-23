using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        public static List<int> numbers;
        public static List<char> operators;
        public static string[] all;

        static void Main(string[] args)
        {
            ReadInput();
        }

        static void ReadInput()
        {
            string input = System.Console.ReadLine();
            input = input.Replace(" ", "");

            int i = 0;
            foreach (char c in input)
            {
                if (char.IsNumber(c))
                {
                    numbers.Add(int.Parse(c));
                    Console.WriteLine(numbers);
                }
                Console.WriteLine(c + " is a number");
                //if (c.GetType().Equals)

                i++;
            }

            //System.Console.WriteLine(all[0]);

            string wait = System.Console.ReadLine();
            

        }
                
    }
        
}
