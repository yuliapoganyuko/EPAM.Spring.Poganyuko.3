﻿using System;

namespace Task1Logic
{
    /// <summary>
    /// Provides jagged array sorting.
    /// </summary>
    public static class JaggedArraySort
    {
        #region Public methods

        /// <summary>
        /// Sorts arrays in jagged array in ascending order.
        /// </summary>
        /// <param name="jaggedArray"> Jaggged array</param>
        /// <param name="comparer"> Object with comparison method</param>
        /// <param name="isAscendingOrder"> Flag showing the order (ascendind or descendind)</param>
        /// <remarks> Sorting depends on conditions defined in realization of comparer.</remarks>
        public static void Sort(int[][] jaggedArray, IComparer comparer, bool isAscendingOrder = true)
        {
            if (jaggedArray == null)
                throw new ArgumentNullException();
            foreach (int[] array in jaggedArray)
                if (array == null)
                    throw new ArgumentNullException();

            int flagOfOrder;
            if (isAscendingOrder)
                flagOfOrder = 1;
            else
                flagOfOrder = -1;

            for (int i = 0; i <= jaggedArray.Length - 2; i++)
            for (int j = 0; j <= jaggedArray.Length - 2 - i; j++)
            {
                if (comparer.Compare(jaggedArray[j], jaggedArray[j + 1]) == flagOfOrder)
                    SwapArrays(jaggedArray, j);
            }
        }

        #endregion


        #region Private methods

        /// <summary>
        /// Swaps successive arrays in jagged array.
        /// </summary>
        /// <param name="jaggedArray"> Jagged array</param>
        /// <param name="indexOfFirstArray"> Index of first array to swap</param>
        private static void SwapArrays(int[][] jaggedArray, int indexOfFirstArray)
        {
            if (jaggedArray == null)
                throw new ArgumentNullException();
            if (indexOfFirstArray > jaggedArray.Length - 2)
                throw new ArgumentOutOfRangeException();

            int[] temporaryArray = jaggedArray[indexOfFirstArray];
            jaggedArray[indexOfFirstArray] = jaggedArray[indexOfFirstArray + 1];
            jaggedArray[indexOfFirstArray + 1] = temporaryArray;
        }


        #endregion
    }
}
