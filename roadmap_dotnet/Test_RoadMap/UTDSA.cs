using roadmap_dotnet.DataStructures.SlidingWindow;

namespace Test_RoadMap
{
    public class UTDSA
    {
        [Fact]
        public void abordagemIngenua()
        {
            var precosDeLivros = new int[] { 100, 67, 300, 30, 50, 25 };
            var expectedResult = new int[] { 67, 30, 50, 25 };

            var actualResult = SlidingWindow.abordagemIngenua(precosDeLivros);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void abordagemComSlidingWindow()
        {
            var precosDeLivros = new int[] { 100, 67, 300, 30, 50, 25 };
            var expectedResult = new int[] { 67, 30, 50, 25 };

            var actualResult = SlidingWindow.abordagemSlidingWindow(precosDeLivros);
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void abordagemComSlidingWindowOrdenado()
        {
            var precosDeLivros = new int[] { 25, 30, 50, 67, 100, 300 };
            var expectedResult = new int[] { 25, 30, 50, 67 };

            var actualResult = SlidingWindow.abordagemSlidingWindow(precosDeLivros);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
