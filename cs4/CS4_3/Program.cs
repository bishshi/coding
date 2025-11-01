using System;
namespace CS4_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            Random rand = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rand.Next(1, 999); 
            }
            Console.WriteLine("原数组：");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            // 冒泡排序
            int temp;
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1 - i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n排序后数组：");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
        }
    }
}
