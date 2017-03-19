using System;

namespace Task1Logic.ComparisonClasses
{
    /// <summary>
    /// Provides arrays comparison depending on the maximal elements.
    /// </summary>
    public class ComparisonByMaxElement: IComparer
    {
        #region Public methods

        /// <summary>
        /// Compares arrays depending on the maximal elements.
        /// </summary>
        /// <param name="firstArray"> First array</param>
        /// <param name="secondArray"> Second array</param>
        /// <returns> -1 if first array's max element is less than second, 
        /// 0 if first and second array's max elements are equal, 
        /// 1 if first array's max element is bigger than second</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null || secondArray == null)
                throw new ArgumentNullException();

            int firstMaxElement = GetMaxElement(firstArray);
            int secondMaxElement = GetMaxElement(secondArray);
            if (firstMaxElement < secondMaxElement)
                return -1;
            else if (firstMaxElement > secondMaxElement)
                return 1;
            return 0;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Gets max element of array.
        /// </summary>
        /// <param name="array"> Array</param>
        /// <returns> Max element of array</returns>
        private int GetMaxElement(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            int max = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }

        #endregion
    }
}
