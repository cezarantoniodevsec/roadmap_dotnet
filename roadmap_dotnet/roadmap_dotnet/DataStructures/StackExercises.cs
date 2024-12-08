namespace CSharpFoundation.DSA
{
    public static class StackExercises
    {
        public static bool checkBalancedBracked(string brackeds)
        {
            var dicPares = new Dictionary<char, char>();
            var arrCaracteres = brackeds.ToCharArray();
            var stackCaracter = new Stack<char>();

            dicPares.Add('{', '}');
            dicPares.Add('[', ']');
            dicPares.Add('(', ')');

            foreach (var caractere in arrCaracteres)
            {

                if (dicPares.ContainsKey(caractere))
                {
                    stackCaracter.Push(caractere);
                }
                else if (dicPares.ContainsValue(caractere))
                {
                    if (stackCaracter.ToArray().Length == 0)
                        return false;

                    if (dicPares[stackCaracter.Pop()] != caractere)
                        return false;
                }
            }
            return stackCaracter.ToArray().Length == 0;
        }
    }
}
