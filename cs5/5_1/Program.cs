using System;
namespace _5_1
{
    class MyMath
    {
        public const double PI = 3.1415926;
        public static double perimeter(double r)
        {
            double p = 2 * PI * r;
            return p;
        }
        public static double area(double r)
        {
            double a = PI * r * r;
            return a;
        }
        public static double volume(double r)
        {
            double v = (4.0 / 3) * PI * r * r * r;
            return v;
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("请输入半径：\n");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("圆的周长为：{0}\n", MyMath.perimeter(r));
                Console.WriteLine("圆的面积为：{0}\n", MyMath.area(r));
                Console.WriteLine("球的体积为：{0}\n", MyMath.volume(r));
            }
        }
    }
}
