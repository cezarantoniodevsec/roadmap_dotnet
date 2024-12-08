using CSharpFoundation.DSA;

namespace TestsCSharpFoundation.DSA
{
    public class UTArrayExercises
    {
        [Fact]
        public void testReverseArray()
        {
            var actual = ArrayExercises.reverseArray(new int[] { 1, 2, 5, 8, 7 });
            var expected = new int[] { 7, 8, 5, 2, 1 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testMinimumMaximum()
        {
            var actual = ArrayExercises.findMinimumMaximum(new int[] { 5, 3, 4, 0, 40, 50, 61, -7 });
            var expected = new int[] { -7, 61 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testPeekElement()
        {
            var actual = ArrayExercises.findPeekElement(new int[] { 5, 10, 20, 15 });
            var expected = new int[] { 20 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testMorePeekElement()
        {
            var actual = ArrayExercises.findPeekElement(new int[] { 10, 20, 15, 2, 23, 90, 67 });
            var expected = new int[] { 20, 90 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testeMoveAllNegatives()
        {
            var actual = ArrayExercises.moveAllNegatives(new int[] { -1, 2, -3, 4, 5, 6, -7, 8, 9 });
            var expected = new int[] { -7, -3, -1, 2, 4, 5, 6, 8, 9 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testeFindkthLargestElementInUnsortedArray()
        {
            var actual = ArrayExercises.findkthLargestElement(new int[] { 7, 10, 4, 3, 20, 15 }, 3);
            var expected = 7;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testeFindkthLargestElementInUnsortedArraySegundoCaso()
        {
            var actual = ArrayExercises.findkthLargestElement(new int[] { 7, 10, 4, 3, 20, 15 }, 4);
            var expected = 10;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testUnionOfTwoSortedArrays()
        {
            var actual = ArrayExercises.UnionOfTwoSortedArrays(new int[] { 1, 3, 4, 5, 7 }, new int[] { 2, 3, 5, 6 });
            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testInterceptOfTwoSortedArrays()
        {
            var actual = ArrayExercises.InterceptOfTwoSortedArrays(new int[] { 1, 3, 4, 5, 7 }, new int[] { 2, 3, 5, 6 });
            var expected = new int[] { 3, 5 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testDutchNationalFlagProblem()
        {

            var actual = ArrayExercises.DutchNationalFlagProblem(new int[] { 0, 1, 2, 0, 1, 2 });
            var expected = new int[] { 0, 0, 1, 1, 2, 2 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testIntervalWithGivenSum()
        {
            // Given
            var sampleArr = new int[] { 1, 4, 20, 3, 10, 5 };
            var sumToBeFind = 33;
            var expectedIntervalOfSum = new int[2] { 2, 4 };
            // When
            var actualIntervalOfSum = ArrayExercises.IntervalWithGivenSum(sampleArr, sumToBeFind);
            // Then
            Assert.Equal(expectedIntervalOfSum, actualIntervalOfSum);
        }
    }
}
