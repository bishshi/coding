using System;
namespace _5_2
{
    public class TemperatureCelius
    {
        private double degree;
        public TemperatureCelius(double degree)
        {
            this.degree = degree;
        }
        public double toFahrenheit()
        {
            return (degree * 9 / 5) + 32;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入摄氏温度：\n");
            double celsius = Convert.ToDouble(Console.ReadLine());
            TemperatureCelius tempCelius = new TemperatureCelius(celsius);
            double fahrenheit = tempCelius.toFahrenheit();
            Console.WriteLine("对应的华氏温度是：{0}\n", fahrenheit);
            Console.ReadKey();
        }
    }
}
