﻿using System;

// Индексаторы (переопределение).

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            BaseClass instance1 = instance;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance1[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
