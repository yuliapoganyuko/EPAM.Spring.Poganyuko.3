using System;

namespace Task1Logic.ComparisonClasses
{
    /// <summary>
    /// Provides arrays comparison depending on the minimal elements.
    /// </summary>
    public class ComparisonByMinElement: IComparer
    {
        #region Public methods

        /// <summary>
        /// Compares arrays depending on the minimal elements.
        /// </summary>
        /// <param name="firstArray"> First array</param>
        /// <param name="secondArray"> Second array</param>
        /// <returns> -1 if first array's min element is less than second, 
        /// 0 if first and second array's min elements are equal, 
        /// 1 if first array's min element is bigger than second</returns>
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (firstArray == null || secondArray == null)
                throw new ArgumentNullException();

            int firstMinElement = GetMinElement(firstArray);
            int secondMinElement = GetMinElement(secondArray);
            if (firstMinElement < secondMinElement)
                return -1;
            else if (firstMinElement > secondMinElement)
                return 1;
            return 0;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Gets min element of array.
        /// </summary>
        /// <param name="array"> Array</param>
        /// <returns> Min element of array</returns>
        private int GetMinElement(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            int min = Int32.MaxValue;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < min)
                    min = array[i];
            return min;
        }

        #endregion
    }
}
