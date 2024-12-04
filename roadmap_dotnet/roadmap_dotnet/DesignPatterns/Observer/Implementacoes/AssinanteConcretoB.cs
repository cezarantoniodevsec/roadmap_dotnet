using roadmap_dotnet.DesignPatterns.Observer.Interfaces;

namespace roadmap_dotnet.DesignPatterns.Observer.Implementacoes
{
    public class AssinanteConcretoB : IObservador
    {
        public void Update(IPublicacao notificacao)
        {
            if ((notificacao as Publicacao).Status < 3)
            {
                Console.WriteLine("Sou o Assinante B: Recebi a notificação, porque o status é menor que 3");
            }
        }
    }
}
