using System;
namespace CS4_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 80, 90, 67, 89, 78, 85, 45, 65, 77, 95 };
            // 统计分数段
            int a = 0, b = 0, c = 0, d = 0;
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] >= 90)
                {
                    a++;
                }
                else if (score[i] >= 80)
                {
                    b++;
                }
                else if (score[i] >= 60)
                {
                    c++;
                }
                else
                {
                    d++;
                }
            }
            Console.WriteLine("90分及以上人数：" + a);
            Console.WriteLine("80-89分人数：" + b);
            Console.WriteLine("60-79分人数：" + c);
            Console.WriteLine("60分以下人数：" + d);
        }
    }
}
