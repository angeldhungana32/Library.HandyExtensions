using System;

namespace Library.HandyExtensions.Tests
{
    public class ListExtensionsTests
    {
        private readonly List<object?> _listInit;
        private readonly List<object>? _listNull;

        public ListExtensionsTests()
        {
            _listInit = new List<object?>();
        }

        [Fact]
        public void ShouldNotAddToList()
        {
            int count = _listInit.Count;
            _listInit.AddIfNotNull(null);
            Assert.Equal(_listInit.Count, count);
        }


        [Theory]
        [MemberData(nameof(ListTestData.ValidItems), MemberType = typeof(ListTestData))]
        public void ShouldAddToList(string item)
        {
            _listInit.AddIfNotNull(item);
            Assert.Contains(item, _listInit);
        }

        [Fact]
        public void AddIfNotNullShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => _listNull.AddIfNotNull(""));
        }
    }

    public class ListTestData
    {
        public static IEnumerable<object[]> ValidItems =>
        new List<object[]>
        {
            new object[] { "" },
            new object[] { "hello" }
        };
    }
}
