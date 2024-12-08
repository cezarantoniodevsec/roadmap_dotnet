namespace CSharpFoundation.DSA
{
    public static class MatrixExercises
    {
        // https://www.geeksforgeeks.org/search-element-sorted-matrix/
        // Given a matrix mat[][] of size N x M, where every row and column is sorted in increasing order, and a number X is given. 
        // The task is to find whether element X is present in the matrix or not.
        public static bool searchInMatrix(int[,] mat, int x)
        {
            int m = mat.GetLength(0), n = mat.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                        return true;
                }
            }
            return false;
        }
        // https://www.geeksforgeeks.org/program-to-print-the-diagonals-of-a-matrix/
        // Given a 2D square matrix, print the Principal and Secondary diagonals
        public static int[,] diagonalMatrix(int[,] mat)
        {
            int m = mat.GetLength(0), n = mat.GetLength(1);
            if (m != n)
                return new int[,] { };

            var diagonalsMat = new int[2, m];
            var cont = 0; var aux = 0;
            // First Diagonal 
            do
            {
                diagonalsMat[0, cont] = mat[cont, cont];
                cont++;
            } while (cont < m);
            // 2tdh Diagonal
            cont = m - 1;
            do
            {
                diagonalsMat[1, aux] = mat[aux, cont];
                cont--;
                aux++;
            } while (aux < m);
            return diagonalsMat;
        }
        // Given a n x n matrix. The problem is to sort the given matrix in strict order
        // Here strict order means that the matrix is sorted in a way such that all elements in a row
        // are sorted in increasing order and for row ‘i’,
        // where 1 <= i <= n-1, the first element of row ‘i’ is greater than or equal to the last element of row ‘i-1’
        // https://www.geeksforgeeks.org/sort-given-matrix/
        public static int[,] sortTheGivenMatrix(int[,] mat)
        {
            int m = mat.GetLength(0), n = mat.GetLength(1);
            var vetAux = new int[m * n];
            var aux = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vetAux[aux++] = mat[i, j];
                }
            }

            Array.Sort(vetAux);
            aux = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = vetAux[aux++];
                }
            }
            return mat;
        }
    }
}
