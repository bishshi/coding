using System;
namespace C_Sharp_1_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            double salary, fees;
            Console.WriteLine("请输入工资");
            salary = double.Parse(Console.ReadLine());
            if (salary > 0 && salary <= 3000)
                fees = salary * 0.0005;
            else if (salary > 3000 && salary <= 5000)
                fees = salary * 0.0010;
            else if (salary > 5000 && salary <= 10000)
                fees = salary * 0.0015;
            else if (salary > 10000)
                fees = salary * 0.0020;
            else
                Console.WriteLine("工资输入有误");
            Console.WriteLine("应缴纳的费用是：" + fees);
        }
    }
}
