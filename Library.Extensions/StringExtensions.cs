using System.Globalization;
using System.Text;

namespace Library.HandyExtensions
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

        /// <summary>
        /// Returns true if the string is a valid email address.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEmail(this string value)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(value);
                return address.Address == value;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Returns true if the string is a valid URL.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsUrl(this string value)
        {
            return Uri.TryCreate(value, UriKind.Absolute, out Uri? uri)
                && (uri != null)
                && (uri.Scheme == Uri.UriSchemeHttp ||  uri.Scheme == Uri.UriSchemeHttps);  
        }
    }
}
