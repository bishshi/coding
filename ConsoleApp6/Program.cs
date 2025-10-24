using System;
namespace c.pc
{
    public class TemperatureConvertor
    {
        public static double CtoF(string c)
        {
            double cl = Double.Parse(c);
            double fl = (cl * 9 / 5) + 32;
            return fl;
        }
        public double FtoC(string f)
        {
            double fl = Double.Parse(f);
            double cl = (fl - 32) * 5 / 9;
            return cl;
        }
    }
    class Test
    {
        static void Main()
        {
            string selection = Console.ReadLine();
            double F, C = 0;
            TemperatureConvertor tc = new TemperatureConvertor();
            switch (selection)
            {
                case "1":
                    F = TemperatureConvertor.CtoF(Console.ReadLine()); break;
                case "2":
                    C = tc.FtoC(Console.ReadLine());break;
                default:
                    Console.WriteLine("ERROR");break;
            }
            Console.WriteLine();
        }
    }
}