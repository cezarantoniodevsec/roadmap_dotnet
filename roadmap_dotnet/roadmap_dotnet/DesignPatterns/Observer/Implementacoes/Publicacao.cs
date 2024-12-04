using roadmap_dotnet.DesignPatterns.Observer.Interfaces;

namespace roadmap_dotnet.DesignPatterns.Observer.Implementacoes
{
    public class Publicacao : IPublicacao
    {
        public int Status { get; set; } = -0;

        private List<IObservador> _observadores = new List<IObservador>();

        public void adicionaAssinatura(IObservador observador)
        {
            _observadores.Add(observador);
        }

        public void removeDaAssintura(IObservador observador)
        {
            _observadores.Remove(observador);
        }

        public void Notifica()
        {
            foreach (var observador in _observadores)
            {
                observador.Update(this);
            }
        }

        public void geraNotificacao()
        {
            Console.WriteLine("\nProcessando o novo status.");
            Status = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Notificação: O status mudou para : " + Status);
            Notifica();
        }
    }
}
