using roadmap_dotnet.SOLID.Liskov;
using System;

namespace Test_RoadMap
{
    public class UT_SOLID
    {
        [Fact]
        public void testWithoutLiskov()
        {
            AppleWithoutLiskov apple = new OrangeWithoutLiskov();
            var actual = apple.GetColor();

            Assert.Equal("Orange" ,actual); 
        }


        [Fact]
        public void testWithLiskov()
        {
            IFruit fruit = new OrangeWithLiskov();           
            var actual = fruit.GetColor();

            Assert.Equal("Orange", actual);

            fruit = new AppleWithLiskov();
            actual = fruit.GetColor();

            Assert.Equal("Red", actual);
        }
    }
}