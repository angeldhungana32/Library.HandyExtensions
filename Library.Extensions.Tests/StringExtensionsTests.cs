namespace Library.HandyExtensions.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [MemberData(nameof(StringTestData.ReverseItems), MemberType = typeof(StringTestData))]
        public void Reverse_ShouldEqual(string value, string expected)
        {
            Assert.Equal(expected, value.Reverse());
        }

        [Theory]
        [MemberData(nameof(StringTestData.NumericItems), MemberType = typeof(StringTestData))]
        public void IsNumeric_NumericValue_ReturnsTrue(string item)
        {
            Assert.True(item.IsNumeric());
        }

        [Theory]
        [MemberData(nameof(StringTestData.NonNumericItems), MemberType = typeof(StringTestData))]
        public void IsNumeric_NonNumericValue_ReturnsFalse(string item)
        {
            Assert.False(item.IsNumeric());
        }

        [Theory]
        [MemberData(nameof(StringTestData.ValidEmails), MemberType = typeof(StringTestData))]
        public void IsEmail_ValidEmails_ReturnsTrue(string item)
        {
            Assert.True(item.IsEmail());
        }

        [Theory]
        [MemberData(nameof(StringTestData.InvalidEmails), MemberType = typeof(StringTestData))]
        public void IsEmail_InValidEmails_ReturnsFalse(string item)
        {
            Assert.False(item.IsEmail());
        }

        [Theory]
        [MemberData(nameof(StringTestData.ValidUrls), MemberType = typeof(StringTestData))]
        public void IsUrl_ValidUrls_ReturnsTrue(string url)
        {
            Assert.True(url.IsUrl());
        }

        [Theory]
        [MemberData(nameof(StringTestData.InvalidUrls), MemberType = typeof(StringTestData))]
        public void IsUrl_InvalidUrls_ReturnsFalse(string url)
        {
            Assert.False(url.IsUrl());
        }

        [Theory]
        [MemberData(nameof(StringTestData.ToTitleCaseItems), MemberType = typeof(StringTestData))]
        public void ToTitleCase_ReturnsExpectedString(string input, string expected)
        {
            Assert.Equal(expected, input.ToTitleCase());
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

        public static IEnumerable<object[]> ValidEmails => new List<object[]>
        {
            new object[] { "test@example.com" },
            new object[] { "test+123@example.com" },
            new object[] { "test@example.co.uk" },
            new object[] { "test+123@example.co.uk" },
            new object[] { "test@example.com.au" },
            new object[] { "test+123@example.com.au" },
        };

        public static IEnumerable<object[]> InvalidEmails => new List<object[]>
        {
            new object[] { "test.example.com" },
            new object[] { "test@.com" },
            new object[] { "@example.com" },
            new object[] { "test@.example.com" },
        };

        public static IEnumerable<object[]> ValidUrls => new List<object[]>
        {
            new object[] { "http://example.com" },
            new object[] { "https://example.com" },
            new object[] { "http://www.example.com" },
            new object[] { "https://www.example.com" },
            new object[] { "https://www.example.com/path/to/resource" },
        };

        public static IEnumerable<object[]> InvalidUrls => new List<object[]>
        {
            new object[] { "example.com" },
            new object[] { "ftp://example.com" },
            new object[] { "http:///example.com" },
            new object[] { "https:///example.com" }
        };

        public static IEnumerable<object[]> ToTitleCaseItems =>
           new List<object[]>
           {
                new object[] { "hello world", "Hello World" },
                new object[] { "Hello World", "Hello World" },
                new object[] { "hELLO wORLD", "Hello World" },
                new object[] { "hEllo wOrld", "Hello World" },
                new object[] { "1234", "1234" },
                new object[] { "", "" }
           };
    }
}
