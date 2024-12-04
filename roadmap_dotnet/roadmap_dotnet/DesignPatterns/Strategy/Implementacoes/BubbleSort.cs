using roadmap_dotnet.DesignPatterns.Strategy.Interfaces;

namespace roadmap_dotnet.DesignPatterns.Strategy.Implementacoes
{
    public class BubbleSort : ISortingAlgorithm
    {
        public int[] sort(int[] vet)
        {
            int aux;
            for (int i = vet.Length - 1; i > 0; i--)
            {
                var swap = 0;
                for (int j = 0; j < i; j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        aux = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aux;
                        swap++;
                    }
                }
                if (swap == 0)
                    break;
            }
            return vet;
        }
    }
}
