namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    abstract class PedidoMusica
    {
        
        public abstract IJukeBox TocarMusica();

        public string tocaMusica()
        {
            
            var product = TocarMusica();
            
            var result = $" {Environment.NewLine}Sou só uma jukebox, vou tocar  { product.TocaMusica() } e NÃO TENHO NADA A VER COM ISSO";

            return result;
        }
    }
}
