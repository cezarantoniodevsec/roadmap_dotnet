namespace roadmap_dotnet.DesignPatterns.SingleTon
{
    public sealed class Singleton
    {        
        private Singleton() { }
        
        private static Singleton _instance;
                
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        
        public void facaAConexaoComAlgumaInterface()
        {
            
        }
    }
}
