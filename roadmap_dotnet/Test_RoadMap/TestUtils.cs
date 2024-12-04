namespace Test_RoadMap
{
    internal class TestUtils
    {
        public static int[] DISORDERED_ARRAY = { 3, 2, 5 };
        public static int[] ORDERED_ARRAY = { 2, 3, 5 };

        public static int[] NEGATIVE_DISORDERED_ARRAY = { 3, 2, -5 };
        public static int[] NEGATIVE_ORDERED_ARRAY = { -5, 2, 3 };

        public static int[] WORST_CASE = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        public static int[] WORST_CASE_ORDERED = { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        public static int[] BEST_CASE = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static int[] BEST_CASE_ORDERED = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public const string CPF_INVALIDO = "123A";
        public const string CPF_ERRO_COMUNICACAO = "76217486300";
        public const string CPF_SEM_PENDENCIAS = "60487583752";
        public const string CPF_INADIMPLENTE = "82226651209";
    }
}
