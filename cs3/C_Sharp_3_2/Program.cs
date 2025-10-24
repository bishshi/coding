using System;
namespace C_Sharp_3_2
{
    public class Program
    {
        static void Main()
        {
            int f1=1, f2=1, f3, n=2;
            Console.Write("{0,5}\t{0,5}\t", f1, f2);
            f3 = f1 + f2;
            while (f3<=1000)
            {
                Console.Write("{0,5}\t", f3);
                n++;
                if (n % 5 == 0) Console.WriteLine("\n");
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
        }
    }
}
