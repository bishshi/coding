using System.Text.RegularExpressions;

namespace _15_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatchCollection mc;
            string[] result = new string[20]; int[] matchposition = new int[20];
            Regex r = new Regex("abc");
            mc = r.Matches("123abc4abcd");
            Console.WriteLine("源字符串123abc4abcd");
            Console.WriteLine("匹配字符串abc");
            for (int i = 0; i < mc.Count; i++)
            {
                result[i] = mc[i].Value;
                matchposition[i] = mc[i].Index;
                Console.WriteLine("索引位置{0}；结果{1}；", mc[i].Index, mc[i].Value);
            }
        }
    }
}
