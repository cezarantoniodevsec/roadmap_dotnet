using roadmap_dotnet.SOLID.Liskov;

namespace Test_RoadMap
{
    public class UT_SOLID
    {
        [Fact]
        public void testLiskov()
        {
            AppleWithoutLiskov apple = new OrangeWithoutLiskov();
            var actual = apple.GetColor();

            Assert.Equal("Orange" ,actual); 
        }
    }
}