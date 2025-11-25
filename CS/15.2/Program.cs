using System;
using System.Threading;

namespace _15._2
{
    public class RandomObjectDemo
    {
        static void RunIntRan(Random randObj)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("{0,10}", randObj.Next());
            }
            for (int i = 0;i < 6; i++)
            {
                Console.Write('{1,10}',randObj.NextDouble());
            }
        }
        static void Fixseed(Random randObj)
        {
            Random fixseed = new Random();
            fixseed.Next();
        }
        static void autoseed()
        {
            Thread.Sleep(1);
            Console.WriteLine("时间");
        }
    }
}
