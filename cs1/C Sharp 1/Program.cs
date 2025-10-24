using System;
using static System.Math;
namespace C_Sharp_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double r, c, s, v;
            Console.WriteLine("请输入半径：");
            r = double.Parse(Console.ReadLine());
            c = 2 * PI * r;
            s = PI * Pow(r, 2);
            v = (4 / 3.0) * PI * Pow(r, 3);
            Console.WriteLine("圆周长为{0}，面积为{1}",c,s);
            Console.WriteLine("球体积为{0}", v);
        }
    }
}
