
using CSharpFoundation.DSA;
using System.Collections;

namespace TestsCSharpFoundation.DSA
{
    public class UTQueueExercises
    {
        [Fact]
        public void testReversingTheFirstKElements()
        {
            // Given
            var queue = new Queue();
            for (int i = 1; i <= 10; i++)
                queue.Enqueue(i * 10);

            var expectedResult = new int[] { 50, 40, 30, 20, 10, 60, 70, 80, 90, 100 };
            int k = 5;
            // Then
            var actualResult = QueueExercises.reversingTheFirstKElements(queue, k);
            // When
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
