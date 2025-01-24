namespace roadmap_dotnet.DataStructures.SlidingWindow
{
    public static class SlidingWindow
    {
        public static int[] abordagemSlidingWindow(int[] livros)
        {
            var listaTemporaria = new List<int>();
            var listaDefinitiva = new List<int>();
            var left = 0;
            var right = left + 1;

            var somaDosPrecos = 0;
            int valorDisponivel = 195;
            var tamanhoMaiorListaAteAgora = 0;

            listaTemporaria.Add(livros[left]);

            somaDosPrecos = livros[left];

            while ((left + 1) < livros.Length)
            {
                if ((somaDosPrecos + livros[right] < valorDisponivel))
                {
                    listaTemporaria.Add(livros[right]);
                    somaDosPrecos += livros[right];
                }

                if (listaTemporaria.Count > tamanhoMaiorListaAteAgora)
                {
                    listaDefinitiva.Clear();
                    listaDefinitiva.InsertRange(0, listaTemporaria.ToArray());
                    tamanhoMaiorListaAteAgora = listaTemporaria.Count;
                }

                if ((right + 1) >= livros.Length)
                {
                    listaTemporaria.Clear();
                    left++;
                    right = left + 1;
                    somaDosPrecos = livros[left];
                    listaTemporaria.Add(livros[left]);
                }
                else
                {
                    right++;
                }
            }

            return listaDefinitiva.ToArray();
        }

        public static int[] abordagemIngenua(int[] livros)
        {
            var listaTemporaria = new List<int>();
            var listaDefinitiva = new List<int>();
            int valorDisponivel = 195;
            var tamanhoMaiorListaAteAgora = 0;

            for (int i = 0; i < livros.Length; i++)
            {
                listaTemporaria.Add(livros[i]);
                int somaDosPrecos = livros[i];

                for (int j = (i + 1); j < livros.Length; j++)
                {
                    if ((somaDosPrecos + livros[j]) < valorDisponivel)
                    {
                        listaTemporaria.Add(livros[j]);
                        somaDosPrecos += livros[j];
                    }
                }

                if (listaTemporaria.Count > tamanhoMaiorListaAteAgora)
                {
                    listaDefinitiva.Clear();
                    listaDefinitiva.InsertRange(0, listaTemporaria.ToArray());
                    tamanhoMaiorListaAteAgora = listaTemporaria.Count;
                }

                listaTemporaria.Clear();
            }

            return listaDefinitiva.ToArray();
        }
    }
}
