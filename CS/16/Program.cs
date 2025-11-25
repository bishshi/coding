namespace _16
{
    internal class Program
    {
        private const string FILE_NAME = @"c:\temp\TestFile.txt";
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                try
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
    }
}
