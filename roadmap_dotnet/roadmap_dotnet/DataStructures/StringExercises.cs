using System.Collections;

namespace CSharpFoundation.DSA
{
    public static class StringExercises
    {
        public static string ReverseWordsInAGivenString(string input)
        {
            var arr = input.Split(' ');
            var aux = "";
            var result = "";
            var cont = 0;
            do
            {
                aux = arr[cont];
                arr[cont] = arr[(arr.Length - 1) - cont];
                arr[(arr.Length - 1) - cont] = aux;
                cont++;
            } while (cont < Math.Floor((decimal)arr.Length) / 2);

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                if (i < arr.Length - 1)
                    result += " ";
            }

            return result;
        }
        private static int encontreOMenorTamanho(String[] arr)
        {
            int min = arr[0].Length;
            // Pega a primeira palavra.
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Length < min)
                {
                    min = arr[i].Length;
                }
            }
            return (min);
        }
        public static string LongestCommonPrefixUsingSorting(string[] arr)
        {
            int menorTamanhoPalavra = encontreOMenorTamanho(arr);
            String result = "";
            char charCorrente;
            for (int i = 0; i < menorTamanhoPalavra; i++)
            {
                charCorrente = arr[0][i];
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j][i] != charCorrente)
                        return result;
                }
                result += charCorrente;
            }
            return result;
        }

        private static int RomanToIntegerFacade(char symbol)
        {
            if (symbol == 'I') return 1;
            if (symbol == 'V') return 5;
            if (symbol == 'X') return 10;
            if (symbol == 'L') return 50;
            if (symbol == 'C') return 100;
            if (symbol == 'D') return 500;
            if (symbol == 'M') return 1000;

            return -1;
        }

        public static int ConvertingRomanNumeralsToDecimal(string romanNumber)
        {
            var finalResult = 0;
            var currentValue = 0;
            var nextValue = 0;
            for (int i = 0; i < romanNumber.Length; i++)
            {
                currentValue = RomanToIntegerFacade(romanNumber[i]);
                if ((i + 1) < romanNumber.Length)
                {
                    nextValue = RomanToIntegerFacade(romanNumber[i + 1]);

                    if (currentValue >= nextValue)
                    {
                        finalResult += currentValue;
                    }
                    else
                    {
                        finalResult = finalResult + nextValue - currentValue;
                        i++;
                    }
                }
                else
                {
                    finalResult += currentValue;
                }
            }
            return finalResult;
        }

        public static string ConvertNumberToRoman(int number)
        {
            string[] vetThous = { "", "M", "MM", "MMM" };
            string[] vetHund = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }; ;
            string[] vetTens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] vetOnes = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string thousands = vetThous[number / 1000];
            string hundreds = vetHund[(number % 1000) / 100];
            string tens = vetTens[(number % 100) / 10];
            string ones = vetOnes[number % 10];

            return thousands + hundreds + tens + ones;
        }

        public static int MinimumDistanceBetweenWordsOfAString(string phase, string[] tokens)
        {
            var words = phase.Split(" ");
            var count = 0;
            var encontrado = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == tokens[0])
                {
                    encontrado = true;
                    count = 0;
                }
                else
                {
                    if (encontrado && (words[i] != tokens[1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        /**************************************************************************************/
        private static char? valueInHashTable(Hashtable mapWords, char chave)
        {
            foreach (DictionaryEntry item in mapWords)
            {
                if (item.Key.Equals(chave))
                    return (char)item.Value;
            }
            return null;
        }

        public static bool StringsAreIsomorphic(string first, string secound)
        {
            var mapWords = new Hashtable();
            for (int i = 0; i < first.Length; i++)
            {
                char caracterBase = first[i];
                char equivalentCaracter = secound[i];
                if (mapWords.ContainsKey(caracterBase))
                {
                    if (valueInHashTable(mapWords, caracterBase) != equivalentCaracter)
                    {
                        return false;
                    }
                }
                else
                {
                    mapWords.Add(caracterBase, equivalentCaracter);
                }
            }
            return true;
        }
    }
}
