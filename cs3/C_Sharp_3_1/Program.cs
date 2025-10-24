using System;
namespace C_Sharp_3_1
{
    public class Program
    {
        static void Main()
        {
            int n = -1, result = 1, i = 1;
            Console.WriteLine("请输入一个正整数n");
            while (n < 0)
            {
                n = int.Parse(Console.ReadLine());
            }
            // For循环实现阶乘
            for (i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("for 循环 {0}！={1}", n, result);
            // while循环实现阶乘
            while (n > 1)
            {
                result *= n;
                n--;
            }
            Console.WriteLine("while 循环 {0}！={1}", n, result);
            //do...while循环实现阶乘
            do
            {
                result *= i;
                i ++;
            } while (i<=n);
            Console.WriteLine("do...while 循环 {0}！={1}", n, result);
        }
    }
}
