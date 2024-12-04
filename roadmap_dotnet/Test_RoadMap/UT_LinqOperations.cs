using roadmap_dotnet.Linq;
using roadmap_dotnet.Linq.Models;

namespace Test_RoadMap
{
    public class UT_LinqOperations
    {
        [Fact]
        public void testAggregate()
        {
            var actual = LinqOperations.makeAggregate();
            Assert.Equal("PASSIONFRUIT", actual);
        }

        [Fact]
        public void testAll()
        {
            var actual = LinqOperations.makeALL();
            Assert.False(actual);
        }

        [Fact]
        public void testAny()
        {
            var actual = LinqOperations.makeAny();
            Assert.Equal("Haas", actual);
        }

        [Fact]
        public void testAppend()
        {
            var actual = LinqOperations.makeAppend();
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            Assert.Equal(numbers, actual);
        }

        [Fact]
        public void testEnumberableSemOveride()
        {
            var actual = LinqOperations.makeEnumerable(false);
            var lista = new List<string> { "passionfruit", "mango", "orange" };
            Assert.Equal(lista.ToList(), actual.ToList());
        }

        [Fact]
        public void testEnumberableComOveride()
        {
            var actual = LinqOperations.makeEnumerable(true);
            var lista = new List<string> { "passionfruit" };
            Assert.Equal(lista.ToList(), actual.ToList());
        }


        [Fact]
        public void testAvearege()
        {
            var actual = LinqOperations.makeAverage();
            var result = 133282081426.33333;
            Assert.Equal(result, actual);
        }

        [Fact]
        public void testCast()
        {
            var actual = LinqOperations.makeCast();
            var lista = new List<string>() { "apple", "lemon", "mango" };
            Assert.Equal(lista, actual);
        }

        [Fact]
        public void testChunk()
        {
            var actual = LinqOperations.makeChunk(1);
            var lista = new List<int>() { 3, 4, 5 };
            Assert.Equal(lista, actual);
        }

        [Fact]
        public void testConcat()
        {
            var actual = LinqOperations.makeConcat();
            var lista = new List<string>()
            {
                "Barley","Boots","Whiskers","Bounder","Snoopy","Fido"
            };
            Assert.Equal(lista, actual);
        }

        [Fact]
        public void testDistinct()
        {
            var actual = LinqOperations.makeDistinct();
            var lista = new List<string>()
            {
                "apple-9","orange-4","lemon-12"
            };
                        
            Assert.Equal(lista, actual);
        }


        [Fact]
        public void testExcept()
        {
            var actual = LinqOperations.makeExcept();
            var lista = new List<double>()
            {
                2, 2.1, 2.3, 2.4,2.5 
            };

            Assert.Equal(lista, actual);
        }

        [Fact]
        public void testGroupJoin()
        {
            var actual = LinqOperations.makeGroupJoin();
            var lista = "Hedlund, MagnusxDaisy";

            Assert.Equal(lista, actual.First());
        }

        [Fact]
        public void testInterSect()
        {
            var actual = LinqOperations.makeIntersect();
            var lista = "apple - 9";

            Assert.Equal(lista, actual);
        }
    }
}
