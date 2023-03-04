namespace Library.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Reverses the order of the characters in a string
        /// </summary>
        /// <param name="value">The string to be reversed</param>
        /// <returns>The reversed form of the value string</returns>
        public static string Reverse(this string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Checks if a string contains only numeric characters
        /// </summary>
        /// <param name="value"></param>
        /// <returns>true if value contains only numeric characters</returns>
        public static bool IsNumeric(this string value)
        {
            foreach (char c in value)
            {
                if (c < '0' || c > '9') { return false; }
            }

            return true;
        }
    }
}
