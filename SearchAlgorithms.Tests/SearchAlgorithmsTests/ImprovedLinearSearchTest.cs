using FluentAssertions;
using NUnit.Framework;
using SearchAlgorithms.Interfaces;
using SearchAlgorithms.SearchAlgorithms;

namespace SearchAlgorithms.Tests.SearchAlgorithmsTests
{
    [TestFixture]
    public class ImprovedLinearSearchTest
    {
        [Test]
        public void Improved_Linear_Search_Test()
        {
            var collection = new[] {1, 6, 7, 4, 9, 23, 77, 13, 24, 16, 22, 35};
            ISearchAlgorithm searchAlgorithm = new ImprovedLinearSearch();
            searchAlgorithm.Contains(collection, 21).Should().BeFalse();
            searchAlgorithm.Contains(collection, 35).Should().BeTrue();
        }
    }
}