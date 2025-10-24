using System;

namespace ConsoleApp4
{
    public class p2
    {
        public static void Displaymatrix(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0,6}", A[i, j]);
                }
                Console.WriteLine();
            }
        }
    static void Main()
        {
            int i, j, sum = 0, t;
            int[,] A = new int[4, 4];
            for (i = 0; i < 4; i++) {
                for (j = 0; j < 4; j++)
                {
                    A[i, j] = i * 4 + j + 1;
                }
            }
            Console.WriteLine("原始矩阵："); Displaymatrix(A);
            Console.WriteLine("上三角矩阵：");
            for (i = 0; i < 4; i++)
            {
                for (int k = 0; k < i * 7; k++) Console.Write(" ");
                for (j = i; j < 4; j++) Console.Write("{0,6} ", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("下三角矩阵");
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < i+1; j++) Console.Write("{0,6}", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("两条对角线之和");
            for (i = 0; i < 4; i++) sum += A[i, i] + A[i, 3 - i];
            Console.WriteLine("{0,6}", sum);
            Console.WriteLine("矩阵A转置：");
            for (i = 0; i < 4; i++)
            {
                for (j = i; j < 4; j++)
                {
                    t = A[i, j];
                    A[i, j] = A[j, i];
                    A[j, i] = t;
                }
            }
            Displaymatrix(A);
            Console.ReadLine();
        }
    } 
}

