using System;
using Task2Logic;

namespace Task2Console
{
    class Program
    {
        #region Public methods

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value:");
            int i = GetInt();
            Console.WriteLine("Hexadecimal value:");
            Console.WriteLine(String.Format(new HexFormatter(), "{0:hex}", i));
            Console.ReadKey();
        }

        #endregion

        #region Private methods
        
        /// <summary>
        /// Gets the integer value.
        /// </summary>
        /// <returns>The integer value</returns>
        private static int GetInt()
        {
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Check your input");
            }
            return number;
        }

        #endregion
    }
}
