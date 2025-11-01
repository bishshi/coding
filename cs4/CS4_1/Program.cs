using System;
namespace CS4_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int min, max, sum = 0, average;
            int[] A = new int[10];
            Random rand = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(1, 101);
            }
            Console.WriteLine("原始数组为：");
            foreach (var item in A)
            {
                Console.Write("{0,4}", item);
            }
            min = max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < min) min = A[i];
                if (A[i] > max) max = A[i];
                sum += A[i];
            }
            average = sum / A.Length;
            Console.WriteLine("\n数组的最小值为：{0}", min);
            Console.WriteLine("数组的最大值为：{0}", max);
            Console.WriteLine("数组的平均值为：{0}", average);
            // 元素降序排序
            int n = A.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("数组元素降序排序后为：");
            foreach (var item in A)
            {
                Console.Write("{0,4}", item);
            }
        }
    }
}
