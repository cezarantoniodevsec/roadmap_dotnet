namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    class PedidoBom : PedidoMusica
    {
        public override IJukeBox TocarMusica()
        {
            return new JukeboxBoa();
        }
    }
}
