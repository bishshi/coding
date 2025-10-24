using System;
namespace program.p
{
    class DoWhileLoopGCF
    {
        static void Main()
        {
            int m, n, r, m1, n1;
            Console.WriteLine("Please write the first number m");
            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the number n");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number  m = {0},n = {1}", m1, n1);
            if (m1 > n1) 
            { 
                m = m1; 
                n = n1; 
            }
            else 
            { 
                m = n1; 
                n = m1; 
            }
            do 
            {
                r = m % n; m = n; n = r;
            } while (r != 0);
            Console.WriteLine("最大公约数{0}，最小公倍数{1}", m, m1 * n1 / m);
            Console.ReadLine();
        }
    }
}