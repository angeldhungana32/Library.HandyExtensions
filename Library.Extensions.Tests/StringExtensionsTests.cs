namespace Library.HandyExtensions.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [MemberData(nameof(StringTestData.ReverseItems), MemberType = typeof(StringTestData))]
        public void ReverseShouldEqual(string value, string expected)
        {
            var result = value.Reverse();
            Assert.Equal(result, expected);
        }

        [Theory]
        [MemberData(nameof(StringTestData.NumericItems), MemberType = typeof(StringTestData))]
        public void ShouldBeNumeric(string item)
        {
            Assert.True(item.IsNumeric());
        }

        [Theory]
        [MemberData(nameof(StringTestData.NonNumericItems), MemberType = typeof(StringTestData))]
        public void ShouldNotBeNumeric(string item)
        {
            Assert.False(item.IsNumeric());
        }
    }

    public class StringTestData
    {
        public static IEnumerable<object[]> ReverseItems =>
        new List<object[]>
        {
            new object[] { "" , ""},
            new object[] { "hello", "olleh" },
            new object[] { "This is a Test", "tseT a si sihT" }
        };

        public static IEnumerable<object[]> NumericItems =>
        new List<object[]>
        {
            new object[] { "123"},
            new object[] { "0000101010"}
        };

        public static IEnumerable<object[]> NonNumericItems =>
        new List<object[]>
        {
            new object[] { "hello"},
            new object[] { "123test"}
        };
    }
}
