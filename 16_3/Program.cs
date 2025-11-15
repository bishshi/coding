using System;
using System.IO;

namespace _16_3
{
    class Program
    {
        private const string FILE_NAME = @"c:\temp\TestFile.txt";
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(FILE_NAME))
            {
                sw.Write("文本文件");
                sw.Write("的写入/读取");
                sw.WriteLine("-----------------------");
                sw.WriteLine("写入整数{0}，或浮点数{1}", 1, 4.2);
                bool b = false; char grade ='A'; string s = "Multiple Data Type!";
                sw.WriteLine("写入布尔值、字符、字符串、日期：");
                sw.WriteLine(b);
                sw.WriteLine(grade);
                sw.WriteLine(s);
                sw.Write("当前日期：");sw.WriteLine(DateTime.Now);
            }
        }
    }
}
