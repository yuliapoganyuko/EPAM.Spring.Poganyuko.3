using System;

namespace Task2Logic
{
    /// <summary>
    /// Provides formatting to hexadecimal value.
    /// </summary>
    public class HexFormatter : ICustomFormatter, IFormatProvider
    {
        #region Public methods

        /// <summary> Converts a value into equal string using hexadecimal formatting.</summary>
        /// <param name="format"> Format string</param>
        /// <param name="arg"> Object to format</param>
        /// <param name="formatProvider"> Object of format provider</param>
        /// <returns> String format of value</returns>
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (!formatProvider.Equals(this))
                throw new ArgumentException();

            if (string.IsNullOrEmpty(format))
                format = "hex";

            if (!(arg is int))
                throw new FormatException();

            if (format == "hex")
            {
                return IntToHexString((int) arg);
            }
            return String.Empty;
        }

        /// <summary>
        /// Gets object for type object formatting.
        /// </summary>
        /// <param name="formatType"> Type</param>
        /// <returns> Object instanse of <paramref name="formatType" /> or null</returns>
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            return null;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Converts an integer value to a hexadecimal value in string format.
        /// </summary>
        /// <param name="n"> Integer value</param>
        /// <returns> Hexadecimal value in string format</returns>
        private string IntToHexString(int n)
        {
            string result = String.Empty;

            for (int i = 7; i >= 0; i--)
                result = String.Concat(result, ByteToHexChar((byte)((n >> 4 * i) & 15)).ToString());

            return result;
        }

        /// <summary>
        /// Converts a byte value to a hexadecimal char.
        /// </summary>
        /// <param name="byteValue"> Byte value</param>
        /// <returns> Hexadecimal char</returns>
        private char ByteToHexChar(byte byteValue)
        {
            if (byteValue > 15)
                throw new ArgumentOutOfRangeException();

            if (byteValue < 10)
                return (char)(byteValue + 48);
            return (char)(byteValue + 87);
        }

        #endregion
    }
}
