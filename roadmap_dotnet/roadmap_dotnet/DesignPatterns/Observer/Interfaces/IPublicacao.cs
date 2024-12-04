namespace roadmap_dotnet.DesignPatterns.Observer.Interfaces
{
    public interface IPublicacao
    {
        void adicionaAssinatura(IObservador observador);

        void removeDaAssintura(IObservador observador);

        void Notifica();
    }
}
