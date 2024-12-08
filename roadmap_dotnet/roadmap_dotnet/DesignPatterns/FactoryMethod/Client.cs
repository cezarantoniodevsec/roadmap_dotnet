namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Publico pediu pro DeeJay tocar Pablo");
            ClientCode(new PedidoPolemico());

            Console.WriteLine("");

            Console.WriteLine("Publico pediu pro Deejay tocar Jeff Berlin");
            ClientCode(new PedidoNeutro());
        }

        public void ClientCode(PedidoMusica PlayerDeMusica)
        {
            Console.WriteLine($"Sou um deejay mal pago e vou mandar pra Jukebox" +
                $"{PlayerDeMusica.tocaMusica()} ");
        }
    }
}
