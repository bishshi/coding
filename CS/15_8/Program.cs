using System;
using System.Text.RegularExpressions;

namespace _15_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strIn = @"~@ How are you doing? Fine，thanks！";
            string result = Regex.Replace(strIn, @"[^\w\. ?,]", "");
            Console.WriteLine(strIn);
            Console.WriteLine(result);
        }
    }
}
