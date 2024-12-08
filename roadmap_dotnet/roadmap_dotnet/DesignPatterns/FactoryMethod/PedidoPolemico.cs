namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    class PedidoPolemico : PedidoMusica
    {
        public override IJukeBox TocarMusica()
        {
            return new JukeBoxPolemica();
        }
    }
}
