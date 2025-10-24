using System;
namespace d.d
{
    class A2
{    static void Main()
        {
            bool b1 = true;
            //bool b2 = false;
            char c = '0';
            bool b3 = (c > 64 && c < 123);
            Console.WriteLine("{0}\t{1}", b1, b3);
        }
    }
}