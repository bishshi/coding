using System;
namespace C_Sharp_1_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入三角形的边长a：");
            double a = double.Parse(Console.ReadLine());
            Console.Write("请输入三角形的边长b：");
            double b = double.Parse(Console.ReadLine());
            Console.Write("请输入三角形的边长c：");
            double c = double.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                double perimeter = a + b + c;
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("三角形的三边长为：a={0}，b={1}，c={2}", a, b, c);
                Console.WriteLine("三角形的周长为{0}，面积为：{1}",perimeter,area);
            }
            else
            {
                Console.WriteLine("输入的边长不能构成三角形。");
            }
            Console.ReadLine();
        }
    }
}
