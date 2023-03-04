namespace Library.HandyExtensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Checks if 'date' falls between 'start' and 'end' datetime
        /// </summary>
        /// <param name="date">The date to be checked</param>
        /// <param name="start">The start date</param>
        /// <param name="end">The end date</param>
        /// <returns>true if date falls between otherwise false</returns>
        public static bool IsBetween(this DateTime date, DateTime start, DateTime end)
        {
            return date >= start && date <= end;
        }

        /// <summary>
        /// Calculates the age of the object based on their birth date in accordance to current date
        /// </summary>
        /// <param name="dateOfBirth">Date Of Birth </param>
        /// <param name="currentDate"> Today's Date </param>
        /// <returns>The age, based on dateOfBirth with currentDate</returns>
        public static int GetAge(this DateTime dateOfBirth, DateTime currentDate)
        {
            var age = currentDate.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}