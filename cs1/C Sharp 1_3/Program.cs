using System;
using static System.Math;
namespace C_Sharp_1_3
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("请输入变量x的值：");
            double x = double.Parse(Console.ReadLine());
            double y;
            // 单句单分支方法
            y = Log(-5 * x) + 6 * Sqrt(Abs(x) + Exp(4)) - Pow((x + 1), 3);
            if (x>=0)
            {
                y = (Pow(x, 2) - 3 * x) / (Pow(x, 2) + 1) + 2 * PI + Sin(x);
            }
            Console.WriteLine("方法一，x={0},y={1}",x,y);

            // 两句单分支方法
            if (x >= 0)
            {
                y = (Pow(x, 2) - 3 * x) / (Pow(x, 2) + 1) + 2 * PI + Sin(x);
            }
            if(x < 0)
            {
                y = Log(-5 * x) + 6 * Sqrt(Abs(x) + Exp(4)) - Pow((x + 1), 3);
            }
            Console.WriteLine("方法二，x={0},y={1}", x,y);

            // 双分支方法
            if (x >= 0)
            {
                y = (Pow(x, 2) - 3 * x) / (Pow(x, 2) + 1) + 2 * PI + Sin(x);
            }
            else
            {
                y = Log(-5 * x) + 6 * Sqrt(Abs(x) + Exp(4)) - Pow((x + 1), 3);
            }
            Console.WriteLine("方法三，x={0},y={1}",x,y);

            // 条件运算符方法
            y = (x >= 0) ? (Pow(x, 2) - 3 * x) / (Pow(x, 2) + 1) + 2 * PI + Sin(x) : Log(-5 * x) + 6 * Sqrt(Abs(x) + Exp(4)) - Pow((x + 1), 3);
            Console.WriteLine("方法四，x={0},y={1}",x,y);
        }
    }
}
