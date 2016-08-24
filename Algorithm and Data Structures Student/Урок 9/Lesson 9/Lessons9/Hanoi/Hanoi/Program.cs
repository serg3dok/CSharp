using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {

        private static void HanoiTower(int Number, int first, int second, int third)
        {
            if (Number > 1)
            {
                HanoiTower(Number - 1, first, third, second);
            }

            Console.WriteLine("Переложить диск из стержня {0} на стержень {1}", first, second);

            if (Number > 1)
            {
                HanoiTower(Number - 1, third, second, first);
            }
        }

        static void Main(string[] args)
        {
            const int Number = 3;
            Console.WriteLine("В башне {0} диска:", Number);
            HanoiTower(Number, 1, 2, 3);
        }
    }
}
