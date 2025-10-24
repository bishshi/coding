using System.Diagnostics;

namespace C_Sharp_1_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("请输入一个代表星期的数字");
            i = int.Parse(Console.ReadLine());
            switch (i)
                {
                case 1:
                        Console.WriteLine("星期一");
                        break;
                    case 2:
                        Console.WriteLine("星期二");
                        break;
                    case 3:
                        Console.WriteLine("星期三");
                        break;
                    case 4:
                        Console.WriteLine("星期四");
                        break;
                    case 5:
                        Console.WriteLine("星期五");
                        break;
                    case 6:
                        Console.WriteLine("星期六");
                        break;
                    case 7:
                        Console.WriteLine("星期日");
                        break;
                    default:
                        Console.WriteLine("输入错误");
                        break;
                }

        }
    }
}
