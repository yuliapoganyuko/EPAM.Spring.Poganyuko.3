using System;
using Task1Logic;
using Task1Logic.ComparisonClasses;

namespace Task1Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new[] {5, 7, 2, 4};
            jaggedArray[1] = new[] {5, 8};
            jaggedArray[2] = new[] { 5, 1, 2 };

            JaggedArraySort.Sort(jaggedArray, new ComparisonBySum());
            Console.WriteLine("Comparison by sum: ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write($"{jaggedArray[i][j].ToString()} ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
