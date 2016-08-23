using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            CircularBuffer buffer = new CircularBuffer(capacity: 3);

            while (true)
            {
                string input = Console.ReadLine();
                byte value;
                if (byte.TryParse(input, out value))
                    buffer.Write(value);
                else
                    break;
            }

            Console.Write("Buffer: ");
            while (!buffer.IsEmpty)
            {
                byte a = buffer.Read();
                Console.Write(a + " ");
            }


            Console.ReadKey();
        }
    }
}
