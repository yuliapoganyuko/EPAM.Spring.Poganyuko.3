using System;

namespace Task1Logic.ComparisonClasses
{
    /// <summary>
    /// Provides arrays comparing depending on array's elements sum.
    /// </summary>
    public class ComparisonBySum : IComparer
    {
        #region Public methods

        /// <summary>
        /// Compares arrays depending on the elements sum.
        /// </summary>
        /// <param name="firstArray"> First array</param>
        /// <param name="secondArray"> Second array</param>
        /// <returns> -1 if first array's elements sum is less than second, 
        /// 0 if first and second array's sums are equal, 
        /// 1 if first array's elements sum is bigger than second</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null || secondArray == null)
                throw new ArgumentNullException();

            int firstSum = GetElementsSum(firstArray);
            int secondSum = GetElementsSum(secondArray);
            if (firstSum < secondSum)
                return -1;
            else if (firstSum > secondSum)
                return 1;
            return 0;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Gets sum of array's elements.
        /// </summary>
        /// <param name="array"> Array</param>
        /// <returns> Sum of array's elements</returns>
        private int GetElementsSum(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }

        #endregion
    }
}
