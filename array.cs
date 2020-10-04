using System;
using System.Linq;
using System.Collections.Generic;
namespace arrays
{
    class array
    {
        static void Main(string[] args)
        {

            int[] S;
            Console.WriteLine("Введіть к-ть елементів в одномірному масиві С");
            int n = int.Parse(Console.ReadLine());
            S = new int[n];

            Random rand = new Random();
            for (int i = 0; i < S.Length; i++)
            {
                S[i] = rand.Next(1, 10);
            }
            Console.WriteLine("Вміст масиву С:");
            for (int i = 0; i < S.Length; i++)
            {
                Console.Write(S[i] + " ");
            }

            int maxValue = S.Max();    //найти макс значение
            int maxIndex = S.ToList().IndexOf(maxValue); //найти макс индекс
            Console.WriteLine("Ваш максимум {0}, місцезнаходження {1}", maxValue, maxIndex);
            int[,] E;
            E = new int[maxValue, maxValue];
            for (int i = 0; i < maxValue; i++)
            {
                for (int j = 0; j < maxValue; j++)
                {
                    E[i, j] = rand.Next(1, 10);
                }
            }
            Console.WriteLine("Вміст E:");
            for (int i = 0; i < maxValue; i++)
            {
                for (int j = 0; j < maxValue; j++)
                {
                    Console.Write(E[i, j] + " ");
                }
                Console.WriteLine();
            }


            int[][] M = new int[n][];

            for (int i = 0; i < n; i++)
            {
                M[i] = new int[S[i]];
            }

            Console.WriteLine("Ваша матриця М+Е:");
            for (int i = 0; i < maxValue; i++)
            {
                for (int j = 0; j < M[i].Length; j++)
                {
                    M[i][j] = E[i, j];
                    Console.Write(M[i][j] + " ");
                }
                Console.WriteLine();
            }

            List<int> list_indexes_to_zero = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (maxValue == S[i])
                {
                    list_indexes_to_zero.Add(i);
                }
            }

            Console.WriteLine("Iндекси для обнулення:");
            int[] indexes_to_zero = list_indexes_to_zero.ToArray();

            for (int j = 0; j < indexes_to_zero.Length; j++)
            {
                Console.WriteLine(indexes_to_zero[j]);
                for (int i = 0; i < M[indexes_to_zero[j]].Length; i++)
                {

                    M[indexes_to_zero[j]][i] = 0;
                }
            }
            Console.WriteLine("Ваша матриця М+Е пiсля обнулення:");
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < M[i].Length; j++)
                {

                    Console.Write(M[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
