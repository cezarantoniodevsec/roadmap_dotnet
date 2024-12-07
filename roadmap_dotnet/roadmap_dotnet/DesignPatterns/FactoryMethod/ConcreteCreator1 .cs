using roadmap_dotnet.DesignPatterns.Factory;

namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    class ConcreteCreator1 : Creator
    {        
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
