using System;
using System.Collections;

namespace _15_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0, countALL = 0;
            string str = Console.ReadLine();
            str = str.ToUpper();
            char[] chars = str.ToCharArray();
            foreach (char c in chars)
            {
                countALL++;
                switch (c)
                {
                    case 'A': countA++; break;
                    case 'E': countE++; break;
                    case 'I': countI++; break;
                    case 'O': countO++; break;
                    case 'U': countU++; break;
                    default: break;
                }
            }
            Console.WriteLine(countALL);
            Console.WriteLine(str);
            Console.WriteLine("A:{0}", countA);
            Console.WriteLine("E:{0}", countE);
            Console.WriteLine("I:{0}", countI);
            Console.WriteLine("O:{0}", countO);
            Console.WriteLine("U:{0}", countU);
        }
    }
}
