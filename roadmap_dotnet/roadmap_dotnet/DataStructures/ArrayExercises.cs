namespace CSharpFoundation.DSA
{
    public class ArrayExercises
    {
        public static int[] reverseArray(int[] arr)
        {
            var cont = 0;
            var aux = 0;
            do
            {
                aux = arr[cont];
                arr[cont] = arr[(arr.Length - 1) - cont];
                arr[(arr.Length - 1) - cont] = aux;
                cont++;
            } while (cont < Math.Floor((decimal)arr.Length) / 2);
            return arr;
        }

        public static int[] findMinimumMaximum(int[] arr)
        {
            var min = 0; var max = 0; var cont = 0;
            do
            {
                if (arr[cont] < min)
                    min = arr[cont];
                else if (arr[cont] > min && arr[cont] > max)
                    max = arr[cont];

                cont++;
            } while (cont < arr.Length);
            return new int[2] { min, max };
        }
        // TODO: Alterar para buscar pares e impares 
        public static int[] findPeekElement(int[] arr)
        {
            var cont = 0;
            List<int> lstPeek = new List<int>();
            do
            {
                if (((cont - 1) >= 0) && ((cont + 1) < arr.Length))
                {
                    if ((arr[cont] > arr[cont - 1]) && (arr[cont] > arr[cont + 1]))
                    {
                        lstPeek.Add(arr[cont]);
                    }
                }
                cont++;
            } while (cont < arr.Length);
            return lstPeek.ToArray();
        }

        public static int[] moveAllNegatives(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public static int findkthLargestElement(int[] arr, int kthElement)
        {
            Array.Sort(arr);
            return arr[kthElement - 1];
        }

        public static int[] UnionOfTwoSortedArrays(int[] arr1, int[] arr2)
        {
            var stUnion = new SortedSet<int>();
            foreach (var item in arr1)
                stUnion.Add(item);

            foreach (var item2 in arr2)
                stUnion.Add(item2);

            return stUnion.ToArray();
        }

        public static int[] InterceptOfTwoSortedArrays(int[] arr1, int[] arr2)
        {
            var stIntercept = new HashSet<int>(arr1);
            var lstRetorno = new List<int>();
            foreach (var item in arr2)
            {
                if (stIntercept.Contains(item))
                {
                    lstRetorno.Add(item);
                }
            }
            return lstRetorno.ToArray();
        }

        public static int[] DutchNationalFlagProblem(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public static int[] IntervalWithGivenSum(int[] arr, int target)
        {
            int[] retorno = new int[2];
            int currentSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentSum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum == target)
                    {
                        retorno[0] = i;
                        retorno[1] = j;
                    }
                }
            }
            return retorno;
        }
    }
}
