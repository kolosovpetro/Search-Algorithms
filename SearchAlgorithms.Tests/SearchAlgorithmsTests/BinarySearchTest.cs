using FluentAssertions;
using NUnit.Framework;
using SearchAlgorithms.Interfaces;

namespace SearchAlgorithms.Tests.SearchAlgorithmsTests
{
    [TestFixture]
    public class BinarySearchTest
    {
        [Test]
        public void Binary_Search_Test()
        {
            var collection = new[] {1, 6, 7, 4, 9, 23, 77, 13, 24, 16, 22, 35};
            ISearchAlgorithm searchAlgorithm = null;
            searchAlgorithm.ElementIndex(collection, 21).Should().Be(-1);
            searchAlgorithm.ElementIndex(collection, 35).Should().Be(11);
        }
    }
}