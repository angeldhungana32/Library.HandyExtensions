namespace Library.HandyExtensions.Tests
{
    public class DateTimeExtensionsTests
    {
        private readonly DateTime _dateTime;

        public DateTimeExtensionsTests()
        {
            _dateTime = new DateTime(1998, 06, 01);
        }

        [Theory]
        [MemberData(nameof(DateTimeTestData.IsBetweenData), MemberType = typeof(DateTimeTestData))]
        public void ShouldBeBetweenDates(DateTime start, DateTime end)
        {
            Assert.True(_dateTime.IsBetween(start, end));
        }

        [Theory]
        [MemberData(nameof(DateTimeTestData.IsNotBetweenData), MemberType = typeof(DateTimeTestData))]
        public void ShouldNotBeBetweenDates(DateTime start, DateTime end)
        {
            Assert.False(_dateTime.IsBetween(start, end));
        }

        [Theory]
        [MemberData(nameof(DateTimeTestData.AgeData), MemberType = typeof(DateTimeTestData))]
        public void ShouldBeOfAge(DateTime currentDate, int age)
        {
            Assert.Equal(_dateTime.GetAge(currentDate), age);
        }
    }

    public class DateTimeTestData
    {
        public static IEnumerable<object[]> IsBetweenData =>
        new List<object[]>
        {
            new object[] { new DateTime(1998,05,30), new DateTime(1998,06,30) },
            new object[] { new DateTime(1997,05,30), new DateTime(2000,06,30) },
            new object[] { new DateTime(1998,05,30), new DateTime(1998,06,02) }
        };

        public static IEnumerable<object[]> IsNotBetweenData =>
        new List<object[]>
        {
            new object[] { new DateTime(2000,05,30), new DateTime(2002,06,30) },
            new object[] { new DateTime(1997,05,30), new DateTime(1998,05,30) },
            new object[] { new DateTime(1998,05,30), new DateTime(1998,05,30) }
        };

        public static IEnumerable<object[]> AgeData =>
        new List<object[]>
        {
            new object[] { new DateTime(1998,06,30), 0 },
            new object[] { new DateTime(2000,12,30), 2 },
            new object[] { new DateTime(2005,05,30), 6 },
            new object[] { new DateTime(2010,07,30), 12}
        };
    }
}