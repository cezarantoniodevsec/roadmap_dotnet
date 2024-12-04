using roadmap_dotnet.DesignPatterns.Strategy.Implementacoes;
using roadmap_dotnet.DesignPatterns.Strategy.Interfaces;

namespace Test_RoadMap
{
    public class UT_DesignPattern
    {
        private ISortingAlgorithm sortingAlgorithm;

        [Fact]
        public void testStrategy()
        {
            sortingAlgorithm = new BubbleSort();

            // Given
            var input = TestUtils.DISORDERED_ARRAY;
            var expectedResult = TestUtils.ORDERED_ARRAY;
            // When
            var actualResult = sortingAlgorithm.sort(input);
            // Then            
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
