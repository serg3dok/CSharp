using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            var buffer = new Buffer<double>();
            buffer.Write(1.1);
            buffer.Write(1.2);
            buffer.Write(1.3);
            buffer.Write(1.4);

            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
