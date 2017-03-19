using System;

namespace Task1Logic
{
    /// <summary>
    /// 
    /// </summary>
    public interface IComparer
    {
        /// <summary>
        /// Compares arrays depending on conditions defined in realization.
        /// </summary>
        /// <param name="firstArray"> First array</param>
        /// <param name="secondArray"> Second array</param>
        /// <returns> -1 if first array is less than second, 0 if first and second arrays are equal, 1 if first array is bigger than second</returns>
        int Compare(int[] firstArray, int[] secondArray);
    }
}
