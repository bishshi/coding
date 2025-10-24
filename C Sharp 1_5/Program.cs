using System;
using static System.Math;

namespace C_Sharp_1_5
{
    public class Program
    {
        static void Main()
        {
            double a, b, c, delta, real, imag;
            Console.Write("请输入系数a");
            a = double.Parse(Console.ReadLine());
            Console.Write("请输入系数b");
            b = double.Parse(Console.ReadLine());
            Console.Write("请输入系数c");
            c = double.Parse(Console.ReadLine());
            if (a == 0 && b == 0)
            {
                Console.WriteLine("该方程无解");
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Sqrt(delta)) / (2 * a);
                    Console.WriteLine("该方程有两个不等实根，分别为：x1={0},x2={1}", x1, x2);
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("该方程有两个相等实根，均为：x={0}", x);
                }
                else
                {
                    real = -b / (2 * a);
                    imag = Sqrt(-delta) / (2 * a);
                    Console.WriteLine("该方程有两个共轭复根，分别为：x1={0}+{1}i,x2={0}-{1}i", real, imag);
                }
            }
        }
    }
}
