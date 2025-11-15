using System;
using System.Text;

namespace _15_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("ABC", 50);
            sb.Append(new char[] { 'D', 'F', 'E' });
            sb.AppendFormat("GHI{0}{1}", 'J', 'k');
            Console.WriteLine("{0} chars,内容为{1}", sb.Length, sb.ToString());
            sb.Insert(0, "Alphabet---");
            sb.Replace('k', 'K');
            Console.WriteLine("{0} chars,内容为{1}", sb.Length, sb.ToString());
        }
    }
}
