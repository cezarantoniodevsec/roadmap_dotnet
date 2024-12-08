using CSharpFoundation.DSA;

namespace TestsCSharpFoundation.DSA
{

    public class UTStackExercises
    {
        [Fact]
        public void numeroImparCaracteres()
        {
            var correctBalancedBracket = "[({})";
            var actual = StackExercises.checkBalancedBracked(correctBalancedBracket);
            var expected = false;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void parentesCorretos()
        {
            var correctBalancedBracket = "{[()]}";
            var actual = StackExercises.checkBalancedBracked(correctBalancedBracket);
            var expected = true;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void parentesesNaoBalanceados()
        {
            var correctBalancedBracket = "[(])";
            var actual = StackExercises.checkBalancedBracked(correctBalancedBracket);
            var expected = false;
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void parentesesComExpessao()
        {
            var correctBalancedBracket = "[(A + B)]";
            var actual = StackExercises.checkBalancedBracked(correctBalancedBracket);
            var expected = true;
            Assert.Equal(actual, expected);
        }
    }
}