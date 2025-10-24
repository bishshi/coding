namespace C_Sharp_3_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int c, r;
            Console.Write("请输入总只数");
            int h = int.Parse(Console.ReadLine());
            int f = 1;
            while (f % 2 != 0)
            {
                Console.Write("请输入总脚数（必须是偶数）");
                f = int.Parse(Console.ReadLine());
            }
            // 循环
            bool solution = false;
            for (c = 0; c <= h; c++)
            {
                r = h - c;
                if (2 * c + 4 * r == f)
                {
                    Console.WriteLine("方法一：鸡有{0}只，兔有{1}只", c, r);
                    solution = true;
                }
            }
            if (!solution)
            {
                Console.WriteLine("方法一无解");
            }
            // 解方程
            r = f / 2 - h;
            c = h - r;
            solution = false;
            if (c >= 0 && r >= 0)
            {
                Console.WriteLine("方法二：鸡有{0}只，兔有{1}只", c, r);
                solution = true;
            }
            if (!solution)
            {
                Console.WriteLine("方法二无解");
            }
        }
    }
}
