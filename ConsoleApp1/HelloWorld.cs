using System;
namespace ConsoleApp1
{
    class HelloWorld
    {
        static void Main()
        {
            char ch=Console.ReadKey();
            if (Char.ToUpper(ch)<= 'A' && Char.ToUpper(ch)<='Z')
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    Console.WriteLine("{0}是大写字母", ch);
                }
                else
                {
                    Console.WriteLine("{0}是小写字母", ch);
                }
            }
            else if ()
        }
    }
}