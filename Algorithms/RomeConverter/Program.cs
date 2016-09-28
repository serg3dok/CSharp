using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RomeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
           // int aNum = 3994;
            
            // 50 test cases
            Random rnd = new Random();

            for (int i = 0; i < 50; i++)
            {
                int n = rnd.Next(0, 5000);
                //int n = new Int32();
                Console.Write(n + " = ");
                Console.WriteLine(convertArabicToRome(n));
                


            }

            //Console.WriteLine(convertArabicToRome(aNum));
            Console.ReadKey();
        }

        public static string convertArabicToRome(int arabicNumber)
        {
            string arabicNumberString = arabicNumber.ToString();
            int l = arabicNumberString.Length;
            int lStep = l;

/*            Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {
                {1, "I"},
                {2, "II"},
                {3, "III"},
                {4, "IV"},
                {5, "V"},
                {6, "VI"},
                {7, "VII"},
                {8, "VIII"},
                {9, "IX"},

                {10, "X"},
                {20, "XX"},
                {30, "XXX"},
                {40, "XL"},

                {50, "L"},
                {60, "LX"},
                {70, "LXX"},
                {80, "LXXX"},
                {90, "XC"},

                {100, "C"},
                {400, "CD"},
                {500, "D"},
                {900, "CM"},

                {1000, "M"},
            };*/

            string romeResult = "";


            for (int i = 0; i < l; i++) 
            {
                int currentNumber = int.Parse(arabicNumberString[i].ToString());

                if (lStep == 4)
                {
                    //string s = "M";
                    if (currentNumber > 3)
                    {
                        Console.WriteLine("Number can't be bigger than 3999");
                        return "";
                    }
                    for (int j = 0; j < currentNumber; j++)
                    {
                        romeResult += "M";
                    }
                }

                if (lStep == 3)
                {
                    if (currentNumber < 4)
                    {
                        for (int j = 0; j < currentNumber; j++)
                        {
                            romeResult += "C";
                        }
                    }
                    if (currentNumber == 4) romeResult += "CD";
                    if (currentNumber == 5) romeResult += "D";
                    if (currentNumber > 5 && currentNumber < 9)
                    {
                        romeResult += "D";
                        for (int j = 0; j < currentNumber-5; j++)
                        {
                            romeResult += "C";
                        }
                    }
                    if (currentNumber == 9) romeResult += "CM";
                }

                if (lStep == 2)
                {
                    if (currentNumber < 4)
                    {
                        for (int j = 0; j < currentNumber; j++)
                        {
                            romeResult += "X";
                        }
                    }
                    if (currentNumber == 4) romeResult += "XL";
                    if (currentNumber == 5) romeResult += "L";
                    if (currentNumber > 5 && currentNumber < 9)
                    {
                        romeResult += "L";
                        for (int j = 0; j < currentNumber - 5; j++)
                        {
                            romeResult += "X";
                        }
                    }
                    if (currentNumber == 9) romeResult += "XC";
                }

                if (lStep == 1)
                {
                    if (currentNumber < 4)
                    {
                        for (int j = 0; j < currentNumber; j++)
                        {
                            romeResult += "I";
                        }
                    }
                    if (currentNumber == 4) romeResult += "IV";
                    if (currentNumber == 5) romeResult += "V";
                    if (currentNumber > 5 && currentNumber < 9)
                    {
                        romeResult += "V";
                        for (int j = 0; j < currentNumber - 5; j++)
                        {
                            romeResult += "I";
                        }
                    }
                    if (currentNumber == 9) romeResult += "IX";
                }

                lStep--;
            }

            //Console.WriteLine();

            return romeResult;
        }
    }
}
