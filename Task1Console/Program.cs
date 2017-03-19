using System;
using Task1Logic;
using Task1Logic.ComparisonClasses;

namespace Task1Console
{
    public class Program
    {
        #region Public methods

        static void Main(string[] args)
        {
            int[][] jaggedArray = InitializeJaggedArray();

            JaggedArraySort.Sort(jaggedArray, new ComparisonBySum());
            PrintJaggedArray(jaggedArray, "Comparison by sum in ascending order: ");

            JaggedArraySort.Sort(jaggedArray, new ComparisonByMaxElement());
            PrintJaggedArray(jaggedArray, "Comparison by maximal element in ascending order: ");

            JaggedArraySort.Sort(jaggedArray, new ComparisonByMinElement());
            PrintJaggedArray(jaggedArray, "Comparison by minimal element in ascending order: ");

            Console.ReadKey();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Initializes jagged array.
        /// </summary>
        /// <returns> Jagged array</returns>
        private static int[][] InitializeJaggedArray()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new[] { 5, 0, 2, 1, 3 };
            jaggedArray[1] = new[] { 2, 8 };
            jaggedArray[2] = new[] { 9, 4, 1, 4 };
            return jaggedArray;
        }

        /// <summary>
        /// Prints jagged array.
        /// </summary>
        /// <param name="jaggedArray"> Jagged array</param>
        /// <param name="message"> Message to print</param>
        private static void PrintJaggedArray(int[][] jaggedArray, string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write($"{jaggedArray[i][j].ToString()} ");
                Console.WriteLine();
            }
        }

        #endregion
    }
}
