using CSharpFoundation.DSA;
using CSharpFoundation.DSA.MyCollections;

namespace TestsCSharpFoundation.DSA
{
    public class UTLinkedListExercises
    {
        [Fact]
        public void testLinkedListAreIdentical()
        {
            // Given
            var first = new MyLinkedList();
            var second = new MyLinkedList();
            var expectedResult = true;

            for (int i = 1; i <= 5; i++)
            {
                first.Add(i);
                second.Add(i);
            }
            // When
            var actualResult = LinkedListExercises.AreIdentical(first, second);
            // Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
