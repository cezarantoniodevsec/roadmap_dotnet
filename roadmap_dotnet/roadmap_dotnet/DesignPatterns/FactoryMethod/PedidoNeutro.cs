namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    class PedidoNeutro : PedidoMusica
    {
        public override IJukeBox TocarMusica()
        {
            return new JukeboxNeutro();
        }
    }
}
