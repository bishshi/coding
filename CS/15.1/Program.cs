using System;
using System.Drawing;
namespace _15._1
{
    class MathTriangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public MathTriangle(double a, double b, double c)
        {
            sideA = Math.Abs(a);
            sideB = Math.Abs(b);
            sideC = Math.Abs(c);
        }
        public double GetArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }
        public double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }
        public double GetHeight()
        {
            double area = GetArea();
            return (2 * area) / sideA;
        }
        public double GetMaxSide()
        {
            return Math.Max(sideA, Math.Max(sideB, sideC));
        }
        public double GetMinSide()
        {
            return Math.Min(sideA, Math.Min(sideB, sideC));
        }
        private double GetPartSideA()
        {
            return Math.Sqrt((Math.Pow(sideB, 2.0) - Math.Pow(GetHeight(), 2.0)));

        }
        static void Main()
        {
            MathTriangle triangle = new MathTriangle(16.0, 10.0, 8.0);
            Console.WriteLine("三角形三边长分别为: {0}, {1}, {2}", triangle.sideA, triangle.sideB, triangle.sideC);
            Console.WriteLine("三角形的面积为: {0:#.00}", triangle.GetArea());
            Console.WriteLine("三角形的周长为: {0}", triangle.GetPerimeter());
            Console.WriteLine("三角形的A边高为: {0:#.00}", triangle.GetHeight());
            Console.WriteLine("三角形的最大边为: {0}", triangle.GetMaxSide());
            Console.WriteLine("三角形的最小边为: {0}", triangle.GetMinSide());
        }
    }
}
