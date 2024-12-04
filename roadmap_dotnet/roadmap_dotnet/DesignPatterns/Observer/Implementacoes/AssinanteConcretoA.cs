using roadmap_dotnet.DesignPatterns.Observer.Interfaces;

namespace roadmap_dotnet.DesignPatterns.Observer.Implementacoes
{
    public class AssinanteConcretoA : IObservador
    {
        public void Update(IPublicacao notificacao)
        {
            if ((notificacao as Publicacao).Status < 3)
            {
                Console.WriteLine("Sou o Assinante A: Recebi a notificação, porque o status é menor que 3");
            }
        }
    }
}
