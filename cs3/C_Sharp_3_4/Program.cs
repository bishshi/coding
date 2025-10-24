using System;
namespace C_Sharp_3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n = 1, t = 1, pi = 0, s = 1;
            while (Math.Abs(t) >= Math.Pow(10,-6))
            {
                pi += t;
                n += 2;
                s = -s;
                t = s / n;
            }
            pi *= 4;
            Console.WriteLine("pi={0}" ,pi);
        }
    }
}
