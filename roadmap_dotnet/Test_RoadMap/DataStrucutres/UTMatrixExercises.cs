using CSharpFoundation.DSA;

namespace TestsCSharpFoundation.DSA
{
    public class UTMatrixExercises
    {
        [Fact]
        public void testSearchInMatrix()
        {
            // Given
            var mat = new int[,]{
                {1, 5, 9},
                {14, 20, 21},
                {30, 34, 43}
            };
            var x = 14;
            var expectedResult = true;
            // When
            var actualResult = MatrixExercises.searchInMatrix(mat, x);
            // Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testDiagonalMatrixFirstScenario()
        {
            // Given
            var mat = new int[,]{
                {1 ,2 ,3 ,4},
                {4, 3, 2, 1},
                {7, 8, 9, 6},
                {6, 5, 4, 3}
            };

            var expectedResult = new int[,]{
                {1, 3, 9, 3},
                {4, 2, 8, 6}
            };
            // When
            var actualResult = MatrixExercises.diagonalMatrix(mat);
            // Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testDiagonalMatrixSecoundScenario()
        {
            // Given
            var mat = new int[,]{
                {1 ,1 ,1},
                {1, 1, 1},
                {1, 1, 1}
            };
            var expectedResult = new int[,]{
                {1, 1, 1},
                {1, 1, 1}
            };

            // When
            var actualResult = MatrixExercises.diagonalMatrix(mat);
            // Then
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void testSortTheGivenMatrix()
        {
            // Given
            var mat = new int[,]{
                {5, 4, 7},
                {1, 3, 8},
                {2, 9, 6}
            };
            var expectedResult = new int[,]{
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };
            // When
            var actualResult = MatrixExercises.sortTheGivenMatrix(mat);
            // Then
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
