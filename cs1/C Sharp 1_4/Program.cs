using System;
using static System.Math;

namespace C_Sharp_1_4
{
    public class Program
    {
        static void Main()
        {
            int a, b, c, a1, b1, c1, temp, max, min, medium;
            Random rNumber = new Random();
            a = rNumber.Next(101);
            b = rNumber.Next(101);
            c = rNumber.Next(101);
            a1 = a; b1 = b; c1 = c;
            Console.WriteLine("原始值: a={0}, b={1}, c={2}");
            // 方法一
            if (a > b)
            {
                temp = a; a = b; b = temp;
            }
            if (a > c)
            {
                temp = a; a = c; c = temp;
            }
            if (b > c)
            {
                temp = b; b = c; c = temp;
            }
            Console.WriteLine("第一种方法排序: a={0}, b={1}, c={2}", a, b, c);
            // 方法二
            a = a1; b = b1; c = c1;
            max = Max(a, Max(b, c));
            min = Min(a, Min(b, c));
            medium = a + b + c - max - min;
            Console.WriteLine("第二种方法排序: a={0}, b={1}, c={2}", min, medium, max);
        }
    }
}
